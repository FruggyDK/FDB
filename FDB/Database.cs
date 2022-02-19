using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    internal static class Database
    {
        private static string connectionString = "Server=localhost;Port=5432;Database=FDB;User Id=postgres;Password=Nta87pxm10;";
        public enum Table
        {
            Movie,
            Actor,
            Genre
        }

        private static readonly string[] tables =
        {
            "movie",
            "actor",
            "genre"
        };

        /// <summary>Gets the movies from search string.</summary>
        /// <param name="table">The table.</param>
        /// <param name="queryColumn">The query column.</param>
        /// <param name="query">The search query.</param>
        /// <returns>Returns a DataTable with the result from the DB; otherwise it will return an empty DataTable</returns>
        private static DataTable GetEntitiesFromQuery(Table table, string queryColumn, string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text
            };
            // TODO: add parameter
            if (query != String.Empty)
            {
                cmd.CommandText = "select * from " + tables[(int)table] + " where " + queryColumn +  " ilike '%" + query + "%';";
            }
            else if (query == String.Empty)
            {
                cmd.CommandText = "select * from " + table + ";";
            }

            try
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }


            cmd.Dispose();
            connection.Close();
            return new DataTable();
        }

        public static DataTable GetMoviesFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Movie, "title", query);
        }

        public static DataTable GetActorsFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Actor, "concat(trim(actor.act_fname),' ', trim(actor.act_lname))", query);
        }

        public static DataTable GetGenresFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Genre, "gen_title", query);
        }


        /// <summary>Loads the actors from movie.</summary>
        /// <param name="mov_id">The mov identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static DataTable GetActorsFromMovie(int mov_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            //TODO: consider changing the following expression to a postgresql function, to simplify call
            cmd.CommandText =
                "select movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = " + mov_id + ";";

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }

            cmd.Dispose();
            connection.Close();

            return new DataTable();
        }


        /// <summary>Gets all from table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static DataTable GetAllEntititesFromTable(Table table)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from " + tables[(int)table] + ";";


            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }


            cmd.Dispose();
            connection.Close();
            return new DataTable();
        }
    }

    // TODO: move all the database calls to this class and use these methods from within the other files

}
