using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FDB
{
    public partial class addActor : Form
    {
        private string img_path = String.Empty;
        private int selectedActorId;
        private DataTable actorsList = new DataTable();

        public addActor()
        {
            InitializeComponent();
        }

        private void addActor_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            btnActorRemove.Hide();
            btnActorUpdate.Location = btnAddActor.Location;
            btnActorUpdate.Hide();
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            string act_dob = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string act_fname = txtActFname.Text.Trim();
            string act_lname = txtActLname.Text.Trim();

            bool onlyLetters = (act_fname + act_lname).All(Char.IsLetter);
            if (onlyLetters && (act_fname != string.Empty && act_lname != string.Empty))
            {
                bool result = Database.InsertActorToDatabase(act_fname, act_lname, img_path);
                if (result)
                {
                    UpdateDataGrid();
                    ShowBtnAddActor();
                }
            }
            else
            {
                MessageBox.Show(
                    "You must enter a firstname and lastname, which does not containt numbers"
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                selectedActorId = (int)actorsList.Rows[index]["act_id"];

                string[] actFullName = actorsList.Rows[index]["Actor"].ToString().Split(' ');
                txtActFname.Text = actFullName[0];
                txtActLname.Text = actFullName[1];
                img_path = actorsList.Rows[index]["act_img_path"].ToString();
                if (img_path != String.Empty)
                {
                    pbPreview.Load(img_path);
                }
                else
                {
                    pbPreview.Image = null;
                }
                btnActorRemove.Show();
                btnActorUpdate.Show();
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
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

        private void UpdateDataGrid()
        {
            // Ensure the grid is empty when there are no assigned actors
            dataGridView1.DataSource = null;

            actorsList = Database.GetActorsFromDatabase();
            DataTable dt = actorsList.Copy();

            int count = dt.Columns.Count - 1;

            for (int i = 0; i < count; i++)
            {
                dt.Columns.RemoveAt(0);
            }

            // removes the act_id column from the datatable

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();
        }

        private void btnActorRemove_Click(object sender, EventArgs e)
        {
            bool result = Database.DeleteActorFromDatabase(selectedActorId);
            if (result)
            {
                UpdateDataGrid();
                ShowBtnAddActor();
            }
        }

        private void btnActorUpdate_Click(object sender, EventArgs e)
        {
            bool onlyLetters = (txtActFname.Text + txtActLname.Text).All(Char.IsLetter);
            if (
                onlyLetters
                && (txtActFname.Text != string.Empty && txtActLname.Text != string.Empty)
            )
            {
                bool result = Database.UpdateActor(
                    selectedActorId,
                    txtActFname.Text.Trim(),
                    txtActLname.Text.Trim(),
                    img_path
                );
                if (result)
                {
                    UpdateDataGrid();
                    ShowBtnAddActor();
                }
            }
        }

        private void ShowBtnAddActor()
        {
            txtActFname.Clear();
            txtActLname.Clear();
            pbPreview.Image = null;
            dataGridView1.ClearSelection();
            btnActorRemove.Hide();
            btnActorUpdate.Hide();
            btnAddActor.Show();
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            ShowBtnAddActor();
        }
    }
}
