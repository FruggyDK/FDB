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
            selectedActors = Database.GetActorsFromMovie(this.mov_id); 
            updateDataGrid();
        }

        private void txtActSearch_TextChanged(object sender, EventArgs e)
        {
            searchedActors.Rows.Clear();
            searchedActors = Database.GetActorsFromQuery(txtActSearch.Text);

            for (int i = 0; i < searchedActors.Rows.Count; i++)
            {
                lbSearchedActors.Items.Add(searchedActors.Rows[i]["Actor"].ToString());
            }
        }

        //TODO: consider using datagrids instead of listboxs

        /*private void lbSearchedActors_DoubleClick(object sender, EventArgs e)
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
        }*/


        /*private void lbSelectedActors_DoubleClick(object sender, EventArgs e)
        {
            int index = lbSelectedActors.SelectedIndex;

            if (index != -1)
            {
                MessageBox.Show(this.selectedActors.Rows[index]["Actor"].ToString());
                RemoveActorFromMovie(this.mov_id, (int)this.selectedActors.Rows[index]["act_id"]);
            }
        }*/

        private void updateDataGrid()
        {
            dataGridView1.DataSource = Database.GetActorsFromMovie(mov_id);
        }


    }
}