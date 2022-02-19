using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

//TODO find a way to remove the need for a password
namespace FDB
{
    public partial class addMovie : Form
    {
        private int mov_id;

        public addMovie()
        {
            InitializeComponent();
        }

        private void BtnaddMovie_Click(object sender, EventArgs e)
        {
            //TODO: add check for empty input
            string title = txtTitle.Text;
            int year = Int32.Parse(txtYear.Text);
            int play_time = Int32.Parse(txtPlay_time.Text);
            string resume = txtResume.Text;
            string img_path = openFileDialog1.FileName;

            this.mov_id = Database.InsertMovieToDatabase(title, year, play_time, resume, img_path);
        }

        private void btnAssignActors_Click(object sender, EventArgs e)
        {
            if (this.mov_id != 0)
            {
                AssignActorToMovie assignActorToMovie = new AssignActorToMovie(this.mov_id);
                assignActorToMovie.ShowInTaskbar = false;
                assignActorToMovie.Show();
            }
            else
            {
                MessageBox.Show("You must add a movie before adding actors");
            }
        }
         
        //TODO: copy local image to resources withing project folder
        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Select an image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog1.FileName;
                pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPreview.Load(filePath);
                pbPreview.Show();
            }
        }

        private void btnAssignGenres_Click(object sender, EventArgs e)
        {
            if (this.mov_id != 0)
            {
                AssignGenreToMovie assignGenreToMovie = new AssignGenreToMovie(this.mov_id);
                assignGenreToMovie.ShowInTaskbar = false;
                assignGenreToMovie.Show();
            } else
            {
                MessageBox.Show("You must add a movie before adding genres");
            }
            
        }
    }
}