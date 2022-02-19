using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    public partial class addGenre : Form
    {
        private String password = "Nta87pxm10";
        private bool updateGenre = false;
        private String selectedDbGenre = "";

        public addGenre()
        {
            InitializeComponent();
            updateDataGrid();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string gen_title = txtGenreTitle.Text.Trim();

            if (txtGenreTitle.Text != "")
            {
                NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=" + password + ";"
                );
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                if (updateGenre)
                {
                    cmd.CommandText = "update genre set gen_title = '" + gen_title + "' where gen_title ='" + selectedDbGenre + "';";
                }
                else
                {
                    cmd.CommandText = "insert into genre(gen_title) values('" + gen_title + "');";
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (NpgsqlException E)
                {
                    MessageBox.Show(E.Message);
                }
                cmd.Dispose();
                connection.Close();
                updateDataGrid();
                updateGenre = false;
                btnAddGenre.Text = "Add";
                txtGenreTitle.Clear();
            }
        }

        private void updateDataGrid()
        {
            NpgsqlConnection connection = new NpgsqlConnection(
               "Server=localhost;" +
               "Port=5432;" +
               "Database=FDB;" +
               "User Id=postgres;" +
               "Password=" + password + ";"
               );
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select genre.gen_title as Genre from genre;";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String selectedGenre = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            txtGenreTitle.Text = selectedGenre;
            selectedDbGenre = selectedGenre;
            updateGenre = true;
            btnAddGenre.Text = "Update";
        }
    }
}