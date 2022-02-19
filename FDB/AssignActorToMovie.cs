using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    //TODO: consider making a class for the handling the database, and adding methods there for adding
    // each type of data. Which return type of enum Result; Result.OK, Result.Error
    //TODO: RETHINK DESIGN OG THIS PAGE
    public partial class AssignActorToMovie : Form
    {
        //TODO: check if there already exists actors in movie; if so display them in listBox2

        private int mov_id;
        private DataTable searchedActors = new DataTable();
        private DataTable selectedActors = new DataTable();

        public AssignActorToMovie(int mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
        }

        private void AssignActorToMovie_Load(object sender, EventArgs e)
        {
            label1.Text = "Adding actors to movie with id: " + this.mov_id.ToString();
            selectedActors = LoadActorsFromMovie(this.mov_id);
            updateDataGrid();
        }

        private void txtActSearch_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=Nta87pxm10;");
            searchedActors.Clear();
            lbSearchedActors.Items.Clear();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
                "select  actor.act_id, concat(trim(actor.act_fname),' ', trim(actor.act_lname)) as Actor from actor where concat(trim(actor.act_fname),' ', trim(actor.act_lname)) ilike '%" + txtActSearch.Text + "%';";

            if (txtActSearch.Text != "")
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    searchedActors.Load(dr);
                    for (int i = 0; i < searchedActors.Rows.Count; i++)
                    {
                        lbSearchedActors.Items.Add(searchedActors.Rows[i]["Actor"].ToString());
                    }
                }
            }

            cmd.Dispose();
            connection.Close();
        }

        //TODO: consider using datagrids instead of listboxs

        private void lbSearchedActors_DoubleClick(object sender, EventArgs e)
        {
            int index = lbSearchedActors.SelectedIndex;
            string role = txtRole.Text.Trim();

            if (index != -1)
            {
                if (selectedActors.Columns.Count != 2)
                {
                    selectedActors = searchedActors.Copy();
                    selectedActors.Rows.Clear();
                }
                selectedActors.ImportRow(searchedActors.Rows[index]);
                bool result = InsertActorToMovie(this.mov_id, (int)selectedActors.Rows[selectedActors.Rows.Count - 1]["act_id"], role);
                if (result)
                {
                    lbSelectedActors.Items.Add(lbSearchedActors.SelectedItem);
                }
            }
        }

        private bool InsertActorToMovie(int mov_id, int act_id, string role)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=Nta87pxm10;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into movie_cast (mov_id, act_id, role) values($1, $2, $3);";
            cmd.Parameters.AddWithValue(mov_id);
            cmd.Parameters.AddWithValue(act_id);
            if (role != "")
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

        //TODO: consider add a return type of datatype, with a return clause in the commandtext
        private bool RemoveActorFromMovie(int mov_id, int act_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=Nta87pxm10;");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "delete from movie_cast where act_id = " + act_id + "and mov_id=" + mov_id + ";"
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
            lbSelectedActors.Items.Clear();

            this.selectedActors = LoadActorsFromMovie(this.mov_id);
            return true;
        }

        private DataTable LoadActorsFromMovie(int mov_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=Nta87pxm10;");
            lbSelectedActors.Items.Clear();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            //TODO: consider changing the following expression to a postgresql function, to simplify call
            cmd.CommandText =
                "select movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = " + this.mov_id + ";";

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lbSelectedActors.Items.Add(dt.Rows[i]["Actor"].ToString());
                    lbRole.Items.Add(dt.Rows[i]["role"].ToString());
                }
                return dt;
            }

            cmd.Dispose();
            connection.Close();

            return new DataTable();
        }

        private void lbSelectedActors_DoubleClick(object sender, EventArgs e)
        {
            int index = lbSelectedActors.SelectedIndex;

            if (index != -1)
            {
                MessageBox.Show(this.selectedActors.Rows[index]["Actor"].ToString());
                RemoveActorFromMovie(this.mov_id, (int)this.selectedActors.Rows[index]["act_id"]);
            }
        }

        private void updateDataGrid()
        {
            NpgsqlConnection connection = new NpgsqlConnection(
               "Server=localhost;" +
               "Port=5432;" +
               "Database=FDB;" +
               "User Id=postgres;" +
               "Password=Nta87pxm10;"
               );
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select actor.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast join actor on actor.act_id = movie_cast.act_id;";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            cmd.Dispose();
            connection.Close();
        }


    }
}