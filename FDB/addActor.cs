using Npgsql;
using System;
using System.Data;
using System.Drawing;
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
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            bool onlyLetters = (txtActFname.Text + txtActLname.Text).All(Char.IsLetter);
            if (onlyLetters && (txtActFname.Text != string.Empty && txtActLname.Text != string.Empty))
            {
                string act_dob = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string act_fname = txtActFname.Text.Trim();
                string act_lname = txtActLname.Text.Trim();

                Database.InsertActorToDatabase(act_fname, act_lname, img_path);
            } else
            {
                MessageBox.Show("You must enter a firstname and lastname, which does not containt numbers");
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
                Image img = Image.FromFile(img_path);
                pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
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
           
            // removes the act_id column from the datatable
            dt.Columns.RemoveAt(0);
            dataGridView1.DataSource = dt;
           
            dataGridView1.ClearSelection();
        }

        private void btnActorRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnActorUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
