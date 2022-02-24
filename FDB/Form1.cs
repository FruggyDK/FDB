using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FDB
{
    public partial class Form1 : Form
    {
        private SearchType currentSearchType = SearchType.Movies;
        private Scene currentScene = Scene.frontPage;
        private int selectedResultId = 0;
        private int selectedResultIndex = 0;
        private DataTable results = new DataTable();

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

            pbCoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeadshot.SizeMode = PictureBoxSizeMode.StretchImage;

            menuStrip1.BringToFront();
            txtSearch.Focus();
            currentSearchType = SearchType.Movies;
            cbSearchType.SelectedItem = cbSearchType.Items[(int)currentSearchType];
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = string.Empty;

            switch (currentScene)
            {
                case Scene.frontPage:
                    searchQuery = txtSearch.Text.Trim();
                    break;
                case Scene.resultPage:
                    searchQuery = txtSeach1.Text.Trim();
                    break;
                case Scene.moviePage:
                    searchQuery = txtSearch2.Text.Trim();
                    break;
                case Scene.actorPage:
                    searchQuery = txtSearch3.Text.Trim();
                    break;
                default:
                    break;
            }

            lblSearchQuery.Text = "Showing results for '" + searchQuery + "'";

            switch (currentSearchType)
            {
                case SearchType.Movies:
                    results = Database.GetMoviesFromQuery(searchQuery);
                    break;
                case SearchType.Actors:
                    results = Database.GetActorsFromQuery(searchQuery);
                    break;
                case SearchType.Genres:
                    results = Database.GetGenresFromQuery(searchQuery);
                    break;
            }

            dgResults.DataSource = results;
            dgResults.ClearSelection();

            if (currentScene != Scene.resultPage)
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

            /*
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name == addGenre.Name)
                {
                    
                } else
                {
                    
                }
            }

            */


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
                    txtSearch.Clear();
                    cbSearchType.SelectedItem = cbSearchType.Items[(int)currentSearchType];
                    SceneControl.SelectTab(0);
                    break;

                case Scene.resultPage:
                    txtSeach1.Clear();
                    cbSearchType1.SelectedItem = cbSearchType.Items[(int)currentSearchType];
                    SceneControl.SelectTab(1);
                    break;

                case Scene.moviePage:
                    txtSearch2.Clear();
                    cbSearchType2.SelectedItem = cbSearchType.Items[(int)currentSearchType];
                    SceneControl.SelectTab(2);
                    break;

                case Scene.actorPage:
                    txtSearch3.Clear();
                    cbSearchType3.SelectedItem = cbSearchType.Items[(int)currentSearchType];
                    SceneControl.SelectTab(3);
                    break;

                default:
                    break;
            }
            currentScene = newScene;
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = 0;

            switch (currentScene)
            {
                case Scene.frontPage:
                    selectedIndex = cbSearchType.SelectedIndex;
                    break;
                case Scene.resultPage:
                    selectedIndex = cbSearchType1.SelectedIndex;
                    break;
                case Scene.moviePage:
                    selectedIndex = cbSearchType2.SelectedIndex;
                    break;
                case Scene.actorPage:
                    selectedIndex = cbSearchType3.SelectedIndex;
                    break;
                default:
                    break;
            }

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
        }

        private void dgResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                selectedResultId = (int)results.Rows[index][0];
                selectedResultIndex = index;

                switch (currentSearchType)
                {
                    case SearchType.Movies:
                        TransitionTo(Scene.moviePage);
                        break;
                    case SearchType.Actors:
                        TransitionTo(Scene.actorPage);
                        break;
                    default:
                        break;
                }
            }
        }

        // Function called when entering the MoviePage scene
        private void tpMoviePage_Enter(object sender, EventArgs e)
        {
            string title = results.Rows[selectedResultIndex]["title"].ToString().Trim();
            string year = results.Rows[selectedResultIndex]["year"].ToString();
            string runtime = results.Rows[selectedResultIndex]["runtime"].ToString();

            lblResume.Text = results.Rows[selectedResultIndex]["resume"].ToString().Trim();
            lblTitle.Text = title + " (" + year + ")";
            lblRuntime.Text = "Duration: " + runtime + " minutes";

            string img_path = results.Rows[selectedResultIndex]["img_path"].ToString();
            if (img_path != String.Empty)
            {
                pbCoverImage.Load(img_path);
            }
            else
            {
                pbCoverImage.Image = null;
            }

            ShowActors();
            ShowGenres();
        }

        private void tpActorPage_Enter(object sender, EventArgs e)
        {
            string name = results.Rows[selectedResultIndex]["Actor"].ToString().Trim();
            string dob = results.Rows[selectedResultIndex]["act_dob"].ToString();

            lblName.Text = name;
            lblDob.Text = "Date of birth: " + dob;

            string img_path = results.Rows[selectedResultIndex]["act_img_path"].ToString();
            if (img_path != String.Empty)
            {
                pbHeadshot.Load(img_path);
            }
            else
            {
                pbHeadshot.Image = null;
            }

            ShowMovies();
        }

        private void ShowActors()
        {
            lvActors.Items.Clear();
            ImageList imgs = new ImageList { ImageSize = new Size(50, 50) };

            lvActors.Columns.Add("Actor", 250);
            lvActors.LargeImageList = imgs;

            DataTable actors = Database.GetActorsFromMovie(selectedResultId);
            for (int i = 0; i < actors.Rows.Count; i++)
            {
                string act_img_path = actors.Rows[i]["act_img_path"].ToString();
                string actor = actors.Rows[i]["Actor"].ToString().Trim();
                string role = actors.Rows[i]["role"].ToString().Trim();
                if (act_img_path != string.Empty)
                {
                    try
                    {
                        imgs.Images.Add(Image.FromFile(act_img_path));
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                }

                // check and add empty actor image.
                lvActors.Items.Add(actor + "\nas\n" + role, i);
            }
        }

        private void ShowGenres()
        {
            lvGenres.Items.Clear();
            DataTable genres = Database.GetGenresFromMovie(selectedResultId);
            for (int i = 0; i < genres.Rows.Count; i++)
            {
                lvGenres.Items.Add(genres.Rows[i]["gen_title"].ToString().Trim());
            }
        }

        private void ShowMovies()
        {
            lvMovies.Items.Clear();
            ImageList imgs = new ImageList { ImageSize = new Size(50, 50) };

            lvMovies.Columns.Add("Movies", 250);
            lvMovies.LargeImageList = imgs;

            DataTable movies = Database.GetActorsMovies(selectedResultId);
            for (int i = 0; i < movies.Rows.Count; i++)
            {
                string img_path = movies.Rows[i]["img_path"].ToString();
                string title = movies.Rows[i]["title"].ToString().Trim();
                if (img_path != string.Empty)
                {
                    try
                    {
                        imgs.Images.Add(Image.FromFile(img_path));
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                }

                // check and add empty actor image.
                lvMovies.Items.Add(title, i);
            }
        }
    }
}
