using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    public partial class addGenre : Form
    {
        private int selectedGenreId;
        private DataTable genreList;
        private bool selectedGenre = true;

        public addGenre()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void addGenre_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            btnGenreUpdate.Hide();
            btnGenreUpdate.Location = btnAddGenre.Location;
            btnGenreRemove.Hide();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string gen_title = txtGenreTitle.Text.Trim();

            if (txtGenreTitle.Text != string.Empty)
            {
                bool result = Database.InsertGenreToDatabase(gen_title);
                if (result)
                {
                    txtGenreTitle.Clear();
                    UpdateDataGrid();
                }
            }
        }

        private void UpdateDataGrid()
        {
            genreList = Database.GetAllEntititesFromTable(Database.Table.Genre);

            DataTable dt = genreList.Copy();
            dt.Columns.RemoveAt(0);
            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void btnGenreUpdate_Click(object sender, EventArgs e)
        {
            string gen_title = txtGenreTitle.Text.Trim();

            if (gen_title != string.Empty)
            {
                bool result = Database.UpdateGenreTitle(selectedGenreId, gen_title);
                UpdateDataGrid();
                txtGenreTitle.Clear();
                ShowBtnAddGenre();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                selectedGenreId = (int)genreList.Rows[index]["gen_id"];
                txtGenreTitle.Text = genreList.Rows[index]["gen_title"].ToString();
                btnGenreRemove.Show();
                btnGenreUpdate.Show();
            }
        }

        private void btnGenreRemove_Click(object sender, EventArgs e)
        {
            bool result = Database.DeleteGenreFromDatabase(selectedGenreId);
            if (result)
            {
                UpdateDataGrid();
                txtGenreTitle.Clear();
                ShowBtnAddGenre();
            }
        }

        private void txtGenreTitle_Click(object sender, EventArgs e)
        {
            if (selectedGenre == false)
            {
                btnAddGenre.Show();
                btnGenreRemove.Hide();
                btnGenreUpdate.Hide();
            }

            selectedGenre = true;
        }

        private void ShowBtnAddGenre()
        {
            btnAddGenre.Show();
            dataGridView1.ClearSelection();
            txtGenreTitle.Clear();
            btnGenreRemove.Hide();
            btnGenreUpdate.Hide();
        }

        private void addGenre_Click(object sender, EventArgs e)
        {
            ShowBtnAddGenre();
        }
    }
}
