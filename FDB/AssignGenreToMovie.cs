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
        int selectedGenId;

        public AssignGenreToMovie(int mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
        }

        private void AssignGenreToMovie_Load(object sender, EventArgs e)
        {
            btnAssignGenre.Hide();
            btnRemoveGenre.Location = btnAssignGenre.Location;
            btnRemoveGenre.Hide();
            lbSelectedGenres_Update();
        }

        private void txtGenSearch_TextChanged(object sender, EventArgs e)
        {
            lbSearchedGenres.Items.Clear();
            searchedGenres = Database.GetGenresFromQuery(txtGenSearch.Text);

            for (int i = 0; i < searchedGenres.Rows.Count; i++)
            {
                lbSearchedGenres.Items.Add(searchedGenres.Rows[i]["gen_title"].ToString());
            }
        }

        private void btnAssignGenre_Click(object sender, EventArgs e)
        {
            int index = lbSearchedGenres.SelectedIndex;

            if (index != -1)
            {
                bool result = Database.AddGenreToMovie(
                    this.mov_id,
                    (int)searchedGenres.Rows[index]["gen_id"]
                );
                if (result)
                {
                    lbSelectedGenres_Update();
                }
            }
        }

        private void btnRemoveGenre_Click(object sender, EventArgs e) 
        {
            bool result = Database.RemoveGenreFromMovie(mov_id, selectedGenId);
            if (result)
            {
                lbSelectedGenres_Update();
            }
        }

        private void lbSelectedGenres_Update()
        {
            // Ensure the grid is empty when there are no assigned actors
            lbSelectedGenres.Items.Clear();

            selectedGenres = Database.GetGenresFromMovie(mov_id);
            if (selectedGenres.Rows.Count > 0)
            {
                for (int i = 0; i < selectedGenres.Rows.Count; i++)
                {
                    lbSelectedGenres.Items.Add(selectedGenres.Rows[i]["gen_title"]);
                }
            }
            lbSelectedGenres.ClearSelected();
        }

        private void lbSearchedGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAssignGenre.Show();
            btnRemoveGenre.Hide();
        }

        private void lbSelectedGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSearchedGenres.ClearSelected();
            int index = lbSelectedGenres.SelectedIndex;
            if (index != -1)
            {
                selectedGenId = (int)selectedGenres.Rows[index]["gen_id"];
                btnRemoveGenre.Show();
                btnAssignGenre.Hide();
            }
        }
    }
}
