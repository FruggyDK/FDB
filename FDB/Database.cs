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

        // Generel methods for communicating with database, which the methods builds upon
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

        public static DataTable GetAllEntititesFromTable(Table table)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select * from "
                    + tables[(int)table]
                    + " order by "
                    + tables[(int)table].Substring(0, 3)
                    + "_id desc;"
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

        public static DataTable GetCertainRowsFromTable(Table table, string rows)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "select " + rows + " from " + tables[(int)table] + ";"
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

        // Methods for communicating with movies table
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
                    "insert into movie(title, year, runtime, resume, img_path) values(@1, @2, @3, @4, @5) returning mov_id;"
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

        public static DataTable GetMoviesFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Movie, "title", query);
        }

        public static bool DeleteMovieFromDatabase(int mov_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "delete from movie where mov_id = $1"
            };
            cmd.Parameters.AddWithValue(mov_id);
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

        public static bool UpdateMovie(
            int mov_id,
            string title,
            int year,
            int runtime,
            string resume,
            string img_path
        )
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            //TODO: add dob parameter
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "update movie set title = @1, year = @2, runtime = @3, resume = @4, img_path = @5 where mov_id = @6"
            };
            cmd.Parameters.AddWithValue("@1", title);
            cmd.Parameters.AddWithValue("@2", year);
            cmd.Parameters.AddWithValue("@3", runtime);
            cmd.Parameters.AddWithValue("@4", resume);

            if (img_path != string.Empty)
            {
                cmd.Parameters.AddWithValue("@5", img_path);
            }
            else
            {
                cmd.Parameters.AddWithValue("@5", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@6", mov_id);

            // TODO: add constraint to name
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
            cmd.Dispose();
            connection.Close();
            return true;
        }

        // Methods for communicating with actors table
        public static DataTable GetActorsFromQuery(string query)
        {
            return GetEntitiesFromQuery(
                Table.Actor,
                "act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, act_dob, act_img_path",
                "concat(trim(actor.act_fname), ' ', trim(actor.act_lname))",
                query
            );
        }

        public static DataTable GetActorsFromDatabase()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select *, concat(trim(act_fname), ' ', trim(act_lname)) as Actor from actor order by act_id desc;"
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

        public static bool DeleteActorFromDatabase(int gen_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "delete from actor where act_id = $1"
            };
            cmd.Parameters.AddWithValue(gen_id);
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

        public static bool InsertActorToDatabase(
            string act_fname,
            string act_lname,
            string img_path
        )
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            //TODO: add dob parameter
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "insert into actor(act_fname, act_lname, act_img_path) values(@1, @2, @3) returning act_id"
            };
            cmd.Parameters.AddWithValue("@1", act_fname);
            cmd.Parameters.AddWithValue("@2", act_lname);
            if (img_path != string.Empty)
            {
                cmd.Parameters.AddWithValue("@3", img_path);
            }
            else
            {
                cmd.Parameters.AddWithValue("@3", DBNull.Value);
            }

            cmd.Parameters.Add(
                new NpgsqlParameter("act_id", DbType.Int32)
                {
                    Direction = ParameterDirection.Output
                }
            );

            try
            {
                cmd.ExecuteNonQuery();
                int act_id = (int)cmd.Parameters[cmd.Parameters.Count - 1].Value;
                MessageBox.Show("Succesfully added actor with id: " + act_id.ToString());
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);

                return false;
            }
            cmd.Dispose();
            connection.Close();
            return true;
        }

        public static bool UpdateActor(
            int act_id,
            string act_fname,
            string act_lname,
            string img_path
        )
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            //TODO: add dob parameter
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "update actor set act_fname = @1, act_lname = @2, act_img_path = @3 where act_id = @4"
            };
            cmd.Parameters.AddWithValue("@1", act_fname);
            cmd.Parameters.AddWithValue("@2", act_lname);
            if (img_path != string.Empty)
            {
                cmd.Parameters.AddWithValue("@3", img_path);
            }
            else
            {
                cmd.Parameters.AddWithValue("@3", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@4", act_id);

            cmd.Parameters.Add(
                new NpgsqlParameter("act_id", DbType.Int32)
                {
                    Direction = ParameterDirection.Output
                }
            );

            // TODO: add constraint to name
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
            cmd.Dispose();
            connection.Close();
            return true;
        }

        // Methods for communicating with genres table
        public static DataTable GetGenresFromQuery(string query)
        {
            return GetEntitiesFromQuery(Table.Genre, "gen_title", query);
        }

        public static bool InsertGenreToDatabase(string gen_title)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "insert into genre(gen_title) values('" + gen_title + "');"
            };

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        public static bool UpdateGenreTitle(int gen_id, string newGenTitle)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "update genre set gen_title = $1 where gen_id = $2;"
            };

            cmd.Parameters.AddWithValue(newGenTitle);
            cmd.Parameters.AddWithValue(gen_id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.CommandText);
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }

        public static bool DeleteGenreFromDatabase(int gen_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "delete from genre where gen_id = $1"
            };
            cmd.Parameters.AddWithValue(gen_id);
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

        // Methods for communicating with movie_cast table
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
                    "select movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role, actor.act_img_path from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = "
                    + mov_id
                    + "order by act_id desc;"
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

        public static bool DeleteActorFromMovie(int mov_id, int act_id)
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

        public static DataTable GetActorsMovies(int act_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select movie.img_path, movie.title from movie_cast JOIN movie on movie_cast.mov_id = movie.mov_id and movie_cast.act_id = @1;"
            };
            cmd.Parameters.AddWithValue("@1", act_id);
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

        // Methods for communicating with movie_genres table
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

        public static bool DeleteGenreFromMovie(int mov_id, int gen_id)
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
