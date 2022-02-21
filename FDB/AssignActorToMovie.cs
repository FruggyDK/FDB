using System;
using System.Data;
using System.Windows.Forms;

namespace FDB
{
    public partial class AssignActorToMovie : Form
    {
        private int mov_id;
        private DataTable searchedActors = new DataTable();
        private DataTable selectedActors = new DataTable();
        private int selectedRowIndex;
        private int selectedActId;

        // TODO: add checker for role changing before showing update button

        public AssignActorToMovie(int mov_id)
        {
            InitializeComponent();
            this.mov_id = mov_id;
        }

        private void AssignActorToMovie_Load(object sender, EventArgs e)
        {
            label1.Text = "Adding actors to movie with id: " + mov_id.ToString();
            selectedActors = Database.GetActorsFromMovie(mov_id);
            btnRemoveActor.Hide();
            btnAssignActor.Hide();
            btnUpdateActor.Hide();
            UpdateDataGrid();
        }

        private void txtActSearch_TextChanged(object sender, EventArgs e)
        {
            lbSearchedActors.Items.Clear();

            searchedActors = Database.GetActorsFromQuery(txtActSearch.Text);

            for (int i = 0; i < searchedActors.Rows.Count; i++)
            {
                lbSearchedActors.Items.Add(searchedActors.Rows[i]["Actor"].ToString());
            }
        }

        private void UpdateDataGrid()
        {
            // Ensure the grid is empty when there are no assigned actors
            dataGridView1.DataSource = null;

            selectedActors = Database.GetActorsFromMovie(mov_id);
            DataTable dt = selectedActors.Copy();
            if (selectedActors.Columns.Count != 0)
            {
                // removes the act_id column from the datatable
                dt.Columns.RemoveAt(0);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.ClearSelection();
        }

        private void btnAssignActor_Click(object sender, EventArgs e)
        {
            int index = lbSearchedActors.SelectedIndex;
            string role = txtRole.Text.Trim();

            if (index != -1)
            {
                bool result = Database.InsertActorToMovie(
                    mov_id,
                    (int)searchedActors.Rows[index]["act_id"],
                    role
                );
                if (result)
                {
                    UpdateDataGrid();
                    txtRole.Clear();
                    btnAssignActor.Hide();
                }
            }
        }

        private void btnRemoveActor_Click(object sender, EventArgs e)
        {
            bool result = Database.DeleteActorFromMovie(mov_id, selectedActId);
            if (result)
            {
                txtRole.Clear();
                UpdateDataGrid();
            }
        }

        // TODO: fix dobbel blue higlight flash in datagridview1
        private void lbSearchedActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRole.Clear();
            dataGridView1.ClearSelection();
            btnAssignActor.Show();
            btnRemoveActor.Hide();
            btnUpdateActor.Hide();
        }

        // TODO: fix delete when there is only one selected actor
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSearchedActors.ClearSelected();
            selectedRowIndex = e.RowIndex;
            if (selectedRowIndex != -1)
            {
                selectedActId = (int)selectedActors.Rows[selectedRowIndex]["act_id"];
                txtRole.Text = selectedActors.Rows[selectedRowIndex]["role"].ToString();
                btnRemoveActor.Show();
                btnUpdateActor.Location = btnAssignActor.Location;
                btnUpdateActor.Show(); // TODO: fix
                btnAssignActor.Hide();
            }
        }

        private void btnUpdateActor_Click(object sender, EventArgs e)
        {
            bool result = Database.UpdateActorsRole(mov_id, selectedActId, txtRole.Text);
            if (result)
            {
                txtRole.Clear();
                UpdateDataGrid();
            }
        }

        private void txtActSearch_Click(object sender, EventArgs e)
        {
            txtRole.Clear();
        }
    }
}
