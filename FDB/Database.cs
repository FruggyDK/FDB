using Npgsql;
using System;
using System.Data;

namespace FDB
{ 
    internal static class Database
    {
        private static string connectionString = "Server=localhost;Port=5432;Database=FDB;User Id=postgres;Password=Nta87pxm10;";

        /// <summary>Gets the movies from search string.</summary>
        /// <param name="searchQuery">The search query.</param>
        /// <returns>Returns a DataTable with the result from the DB; otherwise it will return an empty DataTable</returns>
        public static DataTable GetMoviesFromSearchString(string searchQuery)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            String searchString = searchQuery;
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from movie where title ilike '%" + searchQuery + "%';";

            if (searchString != string.Empty)
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;
                }
            }

            cmd.Dispose();
            connection.Close();
            return new DataTable();
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
        public static DataTable GetAllFromTable(string table)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from " + table + ";";


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

}
