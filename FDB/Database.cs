using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    internal static class Database
    {
        private static string connectionString =
            "Server=localhost;Port=5432;Database=FDB;User Id=postgres;Password=Nta87pxm10;";

        public enum Table
        {
            Movie,
            Actor,
            Genre
        }

        private static readonly string[] tables = { "movie", "actor", "genre" };

        // TODO: add try-catchs to all functions to ensure visibility and stability of program

        // TODO: try to add parameters
        /// <summary>Gets the movies from search string.</summary>
        /// <param name="table">The table.</param>
        /// <param name="queryColumn">The query column.</param>
        /// <param name="query">The search query.</param>
        /// <returns>Returns a DataTable with the result from the DB; otherwise it will return an empty DataTable</returns>
        private static DataTable GetEntitiesFromQuery(
            Table table,
            string rows,
            string queryColumn,
            string query
        )
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
                cmd.CommandText =
                    "select "
                    + rows
                    + " from "
                    + tables[(int)table]
                    + " where "
                    + queryColumn
                    + " ilike '%"
                    + query
                    + "%';";
            }
            else if (query == String.Empty)
            {
                cmd.CommandText = "select " + rows + " from " + table + ";";
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
                cmd.CommandText =
                    "select * from "
                    + tables[(int)table]
                    + " where "
                    + queryColumn
                    + " ilike '%"
                    + query
                    + "%';";
            }
            else if (query == String.Empty)
            {
                cmd.CommandText = "select * from " + tables[(int)table] + ";";
            }

            DataTable dt = new DataTable();
            try
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
            return dt;
        }

        public static DataTable GetMoviesFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Movie, "title", query);
        }

        public static DataTable GetActorsFromQuery(string query)
        {
            return GetEntitiesFromQuery(
                Table.Actor,
                "act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor",
                "concat(trim(actor.act_fname), ' ', trim(actor.act_lname))",
                query
            );
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
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                //TODO: consider changing the following expression to a postgresql function, to simplify call
                CommandText =
                    "select movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = "
                    + mov_id
                    + ";"
            };

            DataTable dt = new DataTable();
            try
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
            return dt;
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
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "select * from $1;"
            };
            cmd.Parameters.AddWithValue(tables[(int)table]);
            DataTable dt = new DataTable();
            try
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
            return dt;
        }

        public static int InsertMovieToDatabase(
            string title,
            int year,
            int play_time,
            string resume,
            string img_path
        )
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "insert into movie(title, year, play_time, resume, img_path) values(@1, @2, @3, @4, @5) returning mov_id;"
            };
            cmd.Parameters.AddWithValue("@1", title);
            cmd.Parameters.AddWithValue("@2", year);
            cmd.Parameters.AddWithValue("@3", play_time);
            cmd.Parameters.AddWithValue("@4", resume);
            if (img_path != string.Empty)
            {
                cmd.Parameters.AddWithValue("@5", img_path);
            }
            else
            {
                cmd.Parameters.AddWithValue("@5", DBNull.Value);
            }
            cmd.Parameters.Add(
                new NpgsqlParameter("mov_id", DbType.Int32)
                {
                    Direction = ParameterDirection.Output
                }
            );

            int mov_id = -1;
            try
            {
                cmd.ExecuteNonQuery();
                mov_id = (int)cmd.Parameters[cmd.Parameters.Count - 1].Value;
                MessageBox.Show("Succesfully added movie with id: " + mov_id.ToString());
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
            }

            cmd.Dispose();
            connection.Close();
            return mov_id;
        }

        public static bool InsertActorToMovie(int mov_id, int act_id, string role)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "insert into movie_cast (mov_id, act_id, role) values($1, $2, $3);"
            };
            cmd.Parameters.AddWithValue(mov_id);
            cmd.Parameters.AddWithValue(act_id);

            if (role != string.Empty)
            {
                cmd.Parameters.AddWithValue(role);
            }
            else
            {
                cmd.Parameters.AddWithValue(DBNull.Value);
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        /// <summary>Removes the actor from movie.</summary>
        /// <param name="mov_id">The mov identifier.</param>
        /// <param name="act_id">The act identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static bool RemoveActorFromMovie(int mov_id, int act_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "delete from movie_cast where act_id = " + act_id + "and mov_id=" + mov_id + ";"
            };
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.CommandText);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        public static bool UpdateActorsRole(int mov_id, int act_id, string newRole)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "update movie_cast set role = $3 where mov_id = $1 and act_id = $2;"
            };
            cmd.Parameters.AddWithValue(mov_id);
            cmd.Parameters.AddWithValue(act_id);

            if (newRole != string.Empty)
            {
                cmd.Parameters.AddWithValue(newRole);
            }
            else
            {
                cmd.Parameters.AddWithValue(DBNull.Value);
            }

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        // TODO: add parameters
        public static bool AddGenreToMovie(int mov_id, int gen_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "insert into movie_genres (mov_id, gen_id) values($1, $2);"
            };
            cmd.Parameters.AddWithValue(mov_id);
            cmd.Parameters.AddWithValue(gen_id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.CommandText);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        public static DataTable GetGenresFromMovie(int mov_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select movie_genres.gen_id, genre.gen_title from movie_genres join genre on movie_genres.gen_id = genre.gen_id and movie_genres.mov_id=$1;"
            };
            cmd.Parameters.AddWithValue(mov_id);

            DataTable dt = new DataTable();
            try
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
            return dt;
        }

        public static bool RemoveGenreFromMovie(int mov_id, int gen_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "delete from movie_genres where gen_id = "
                    + gen_id
                    + "and mov_id="
                    + mov_id
                    + ";"
            };
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.CommandText);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }
    }
}

// TODO: move all the database calls to this class and use these methods from within the other files
