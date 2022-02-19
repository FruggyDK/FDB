using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    public partial class AssignGenreToMovie : Form
    {
        private DataTable searchedGenres = new DataTable();
        private DataTable selectedGenres = new DataTable();
        private int mov_id;

        public AssignGenreToMovie(int mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
        }

        private void txtGenSearch_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=Nta87pxm10;");
            searchedGenres.Clear();
            lbSearchedGenres.Items.Clear();
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select genre.gen_id, genre.gen_title as Genre from genre where genre.gen_title ilike '%" + txtGenSearch.Text + "%';";
            if (txtGenSearch.Text != "")
            {
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    searchedGenres.Load(dr);
                    for (int i = 0; i < searchedGenres.Rows.Count; i++)
                    {
                        lbSearchedGenres.Items.Add(searchedGenres.Rows[i]["Genre"].ToString());
                    }
                }
            }

            cmd.Dispose();
            connection.Close();
        }

        private void lbSearchedGenres_DoubleClick(object sender, EventArgs e)
        {
            int index = lbSearchedGenres.SelectedIndex;

            if (index != -1)
            {
                if (selectedGenres.Columns.Count != 2)
                {
                    selectedGenres = searchedGenres.Copy();
                    selectedGenres.Rows.Clear();
                }
                selectedGenres.ImportRow(searchedGenres.Rows[index]);
                bool result = AddGenreToMovie(this.mov_id, (int)selectedGenres.Rows[selectedGenres.Rows.Count - 1]["gen_id"]);
                if (result)
                {
                    lbSelectedGenres.Items.Add(lbSearchedGenres.SelectedItem);
                }
            }
        }

        private bool AddGenreToMovie(int mov_id, int gen_id)
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
            cmd.CommandText = "insert into movie_genres (mov_id, gen_id) values(" + mov_id + ", " + gen_id + ");";
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