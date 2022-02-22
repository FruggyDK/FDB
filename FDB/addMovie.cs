using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

//TODO find a way to remove the need for a password
namespace FDB
{
    public partial class addMovie : Form
    {
        string img_path = string.Empty;
        private DataTable moviesList;
        private int selectedMovieId;

        public addMovie()
        {
            InitializeComponent();
        }

        private void addMovie_Load(object sender, EventArgs e)
        {
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMovieUpdate.Location = btnAddMovie.Location;
            btnMovieUpdate.Hide();
            btnMovieRemove.Hide();
            UpdateDataGrid();
        }

        private void BtnaddMovie_Click(object sender, EventArgs e)
        {
            //TODO: add check for empty input
            string title = txtTitle.Text;
            int year = Int32.Parse(txtYear.Text);
            int play_time = Int32.Parse(txtRuntime.Text);
            string resume = txtResume.Text;

            selectedMovieId = Database.InsertMovieToDatabase(
                title,
                year,
                play_time,
                resume,
                img_path
            );
            UpdateDataGrid();
        }

        private void btnAssignActors_Click(object sender, EventArgs e)
        {
            if (selectedMovieId != 0)
            {
                AssignActorToMovie assignActorToMovie = new AssignActorToMovie(selectedMovieId);
                assignActorToMovie.ShowInTaskbar = false;
                assignActorToMovie.Show();
            }
            else
            {
                MessageBox.Show("You must add or select a movie before adding actors");
            }
        }

        //TODO: copy local image to resources withing project folder
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an image";

            openFileDialog1.Title = "Select an image";
            openFileDialog1.FileName = String.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_path = openFileDialog1.FileName;
                pbPreview.Load(img_path);
                pbPreview.Show();
            }
            //TODO: add images to resources
        }

        private void btnAssignGenres_Click(object sender, EventArgs e)
        {
            if (selectedMovieId != 0)
            {
                AssignGenreToMovie assignGenreToMovie = new AssignGenreToMovie(selectedMovieId);
                assignGenreToMovie.ShowInTaskbar = false;
                assignGenreToMovie.Show();
            }
            else
            {
                MessageBox.Show("You must add or select a movie before adding genres");
            }
        }

        private void btnMovieRemove_Click(object sender, EventArgs e)
        {
            bool result = Database.DeleteMovieFromDatabase(selectedMovieId);
            if (result)
            {
                UpdateDataGrid();
                ShowBtnAddMovie();
            }
        }

        private void btnMovieUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            int year = Int32.Parse(txtYear.Text);
            int play_time = Int32.Parse(txtRuntime.Text);
            string resume = txtResume.Text.Trim();

            bool result = Database.UpdateMovie(
                selectedMovieId,
                title,
                year,
                play_time,
                resume,
                img_path
            );

            if (result)
            {
                UpdateDataGrid();
                ShowBtnAddMovie();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                selectedMovieId = (int)moviesList.Rows[index]["mov_id"];

                txtTitle.Text = moviesList.Rows[index]["title"].ToString();
                txtYear.Text = moviesList.Rows[index]["year"].ToString();
                txtRuntime.Text = moviesList.Rows[index]["runtime"].ToString();
                txtResume.Text = moviesList.Rows[index]["resume"].ToString();

                img_path = moviesList.Rows[index]["img_path"].ToString();
                if (img_path != String.Empty)
                {
                    pbPreview.Load(img_path);
                }
                else
                {
                    pbPreview.Image = null;
                }
                btnMovieRemove.Show();
                btnMovieUpdate.Show();
            }
        }

        private void UpdateDataGrid()
        {
            // Ensure the grid is empty when there are no assigned actors
            dataGridView1.DataSource = null;

            moviesList = Database.GetAllEntititesFromTable(Database.Table.Movie);
            DataTable dt = moviesList.Copy();

            dt.Columns.RemoveAt(0);

            for (int i = 0; i < 4; i++)
            {
                dt.Columns.RemoveAt(1);
            }

            // removes the act_id column from the datatable

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();
        }

        private void ShowBtnAddMovie()
        {
            selectedMovieId = 0;
            txtTitle.Clear();
            txtRuntime.Clear();
            txtResume.Clear();
            txtYear.Clear();
            dataGridView1.ClearSelection();
            pbPreview.Image = null;
            btnMovieUpdate.Hide();
            btnMovieRemove.Hide();
            btnAddMovie.Show();
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            ShowBtnAddMovie();
        }
    }
}
