using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FDB
{
    public partial class Form1 : Form
    {
        private String password = "Nta87pxm10";
        private SearchType currentSearchType = SearchType.Movies;
        private Scene currentScene = Scene.frontPage;

        private enum Scene
        {
            frontPage,
            resultPage,
            moviePage,
            actorPage
        }

        private enum SearchType
        {
            Movies,
            Actors,
            Genres
        }

        public Form1()
        {
            InitializeComponent();
            LoadActorsFromMovie(47);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // quick and dirty fix for hiding headers for each tabpage
            SceneControl.Appearance = TabAppearance.FlatButtons;
            SceneControl.ItemSize = new Size(0, 1);
            SceneControl.SizeMode = TabSizeMode.Fixed;
            foreach (TabPage tab in SceneControl.TabPages)
            {
                tab.Text = string.Empty;
            }


            menuStrip1.BringToFront();
            txtSøg.Focus();
            Database.GetActorsFromMovie(47);


            //TODO: fix xD
            cbSearchType.SelectedItem = cbSearchType.Items[0];
            currentSearchType = SearchType.Movies;

        }



        //TODO: fix spawning position of child forms after moving parent form
        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMovie addMovie = new addMovie();
            addMovie.StartPosition = FormStartPosition.CenterParent;
            addMovie.Show();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addActor addActor = new addActor();
            addActor.StartPosition = FormStartPosition.CenterParent;
            addActor.Show();
        }

        // TODO: add checks
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = (currentScene == Scene.frontPage) ? txtSøg.Text : textBox1.Text;

            switch(currentSearchType)
            {
                case SearchType.Movies:
                    dgMovieResults.DataSource = Database.GetMoviesFromQuery(searchQuery);
                    break;
                case SearchType.Actors:
                    dgMovieResults.DataSource = Database.GetActorsFromQuery(searchQuery);
                    break;
                case SearchType.Genres:
                    dgMovieResults.DataSource = Database.GetGenresFromQuery(searchQuery);
                    break;
            }

            if (currentScene!= Scene.resultPage)
            {
                TransitionTo(Scene.resultPage);
            }
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: figure out how to spawn new windows inside parent window;
            addGenre addGenre = new addGenre();
            addGenre.StartPosition = FormStartPosition.CenterParent;
            addGenre.Show();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToDB connectToDB = new ConnectToDB();
            connectToDB.StartPosition = FormStartPosition.CenterParent;
            connectToDB.Show();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            TransitionTo(Scene.frontPage);
        }

        private void TransitionTo(Scene newScene)
        {
            switch (newScene)
            {
                case Scene.frontPage:
                    SceneControl.SelectTab(0);
                    break;

                case Scene.resultPage:
                    //txtSøg.Clear();
                    //tbMoviePage.SelectTab(1);
                    comboBox2.SelectedIndex = cbSearchType.SelectedIndex;
                    SceneControl.SelectTab(1);
                    break;

                case Scene.moviePage:
                    SceneControl.SelectTab(2);
                    break;

                case Scene.actorPage:
                    break;

                default:
                    break;
            }
            currentScene = newScene;
        }


        //TODO: add dynamic movie loading from DB
        private void tbMoviePage_Selected(object sender, TabControlEventArgs e)
        {
            lblResume.Text = "sdahduashdhauhsduashdua";
            lblTitle.Text = "HEJ MED DIG";
            lblScore.Text = 10.ToString();
            pictureBox1.Load("C:\\Users\\chris\\OneDrive\\Billeder\\Udklip.PNG");
        }

        //TODO: fix
        private DataTable LoadActorsFromMovie(int mov_id)
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
            //TODO: consider changing the following expression to a postgresql function, to simplify call
            cmd.CommandText = "select movie.img_path from movie;";
            //"select movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = " + mov_id + ";";
            //cmd.CommandText = "select movie.img_path, movie_cast.act_id, concat(trim(actor.act_fname), ' ', trim(actor.act_lname)) as Actor, movie_cast.role from movie_cast JOIN actor on movie_cast.act_id = actor.act_id and movie_cast.mov_id = " + mov_id + ";";

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                lvActors.Columns.Add("Image", 200);
                ImageList imgs = new ImageList();
                imgs.ImageSize = new Size(50, 50);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["img_path"].ToString().StartsWith("C:"))
                    {
                        try
                        {
                            //listView1.Items.Add(dt.Rows[i][])
                            imgs.Images.Add(Image.FromFile(dt.Rows[i]["img_path"].ToString()));
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

                //TODO: dynamically add images and actors according to movie from DB
                MessageBox.Show(imgs.Images.Count.ToString());
                lvActors.LargeImageList = imgs;
                lvActors.Items.Add("Michael Carrick \nas Spiderman", 0);
                lvActors.Items.Add("Diego Costa", 1);
                lvActors.Items.Add("David De Gea", 2);
                lvActors.Items.Add("Eden Hazard", 3);
                lvActors.Items.Add("Anders Herera", 4);
                lvActors.Items.Add("Oscar", 5);
                lvActors.Items.Add("Aaron Ramsey", 6);
                return dt;
            }

            cmd.Dispose();
            connection.Close();

            return new DataTable();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = (currentScene == Scene.frontPage) ? cbSearchType.SelectedIndex : comboBox2.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    currentSearchType = SearchType.Movies;
                    break;
                case 1:
                    currentSearchType = SearchType.Actors;
                    break;
                case 2:
                    currentSearchType = SearchType.Genres;
                    break;
            }

            MessageBox.Show(currentSearchType.ToString());
        }

        private void lvActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lvActors.SelectedItems.ToString());
        }

        //TODO: implement actors gallery for movie page. CHECK this: http://csharphelper.com/blog/2018/04/display-database-pictures-in-a-listview-control-in-c/
    }
}