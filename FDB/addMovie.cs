using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

//TODO find a way to remove the need for a password
namespace FDB
{
    public partial class addMovie : Form
    {
        private String password = "Nta87pxm10";
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

            NpgsqlConnection connection = new NpgsqlConnection(
                        "Server=localhost;" +
                        "Port=5432;" +
                        "Database=FDB;" +
                        "User Id=postgres;" +
                        "Password=" + password + ";"
                        );
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
            cmd.Parameters.AddWithValue("@5", img_path);
            cmd.Parameters.Add(new NpgsqlParameter("mov_id", DbType.Int32) { Direction = ParameterDirection.Output });

            try
            {
                cmd.ExecuteNonQuery();
                this.mov_id = (int)cmd.Parameters[cmd.Parameters.Count - 1].Value;
                MessageBox.Show("Succesfully added movie with id: " + this.mov_id.ToString());
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
            }

            cmd.Dispose();
            connection.Close();
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
            AssignGenreToMovie assignGenreToMovie = new AssignGenreToMovie(this.mov_id);
            assignGenreToMovie.Show();
        }
    }
}