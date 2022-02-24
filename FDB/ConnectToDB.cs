using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FDB.Properties;

namespace FDB
{
    public partial class ConnectToDB : Form
    {
        public ConnectToDB()
        {
            InitializeComponent();
        }

        private void ConnectToDB_Load(object sender, EventArgs e)
        {
            txtServer.Text = Settings.Default.Server;
            txtDatabase.Text = Settings.Default.Database;
            txtPort.Text = Settings.Default.Port;
            txtUserId.Text = Settings.Default.UserId;
            txtPassword.Text = Settings.Default.Password;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = txtServer.Text;
            Settings.Default.Database = txtDatabase.Text;
            Settings.Default.Port = txtPort.Text;
            Settings.Default.UserId = txtUserId.Text;
            Settings.Default.Password = txtPassword.Text;
            Settings.Default.Save();

            // test if this new info works
            bool result = Database.TestConnection();
            if (result)
            {
                this.Close();
            } else
            {
                MessageBox.Show("The inputtet info doesn't work.\nPlease change and try again");
            }
        }
    }
}
