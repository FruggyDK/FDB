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
        private String password = "Nta87pxm10";
        private string act_img_path = "";

        public addActor()
        {
            InitializeComponent();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            bool onlyLetters = (txtActFname.Text + txtActLname.Text).All(Char.IsLetter);
            if (onlyLetters)
            {
            }
            string act_dob = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string act_fname = txtActFname.Text.Trim();
            string act_lname = txtActLname.Text.Trim();

            NpgsqlConnection connection = new NpgsqlConnection(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=FDB;" +
                "User Id=postgres;" +
                "Password=" + password + ";"
                );
            connection.Open();

            //TODO: add dob parameter
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "insert into actor(act_fname, act_lname, act_img_path) values(@1, @2, @3) returning act_id"
            };
            cmd.Parameters.AddWithValue("@1", act_fname);
            cmd.Parameters.AddWithValue("@2", act_lname);
            if (this.act_img_path != "")
            {
                cmd.Parameters.AddWithValue("@3", openFileDialog1.FileName);
            }
            else
            {
                cmd.Parameters.AddWithValue("@3", DBNull.Value);
            }

            cmd.Parameters.Add(new NpgsqlParameter("act_id", DbType.Int32) { Direction = ParameterDirection.Output });

            // TODO: add constraint to name
            try
            {
                cmd.ExecuteNonQuery();
                int act_id = (int)cmd.Parameters[cmd.Parameters.Count - 1].Value;
                MessageBox.Show("Succesfully added actor with id: " + act_id.ToString());
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
            }
            cmd.Dispose();
            connection.Close();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Select an image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.act_img_path = openFileDialog1.FileName;
                Image img = Image.FromFile(act_img_path);
                pbPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPreview.Load(this.act_img_path);
                pbPreview.Show();
            }
            //TODO: add images to resources
        }
    }
}