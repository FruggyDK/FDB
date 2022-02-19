using System;
using System.Windows.Forms;

namespace FDB
{
    public partial class ConnectToDB : Form
    {
        public ConnectToDB()
        {
            InitializeComponent();
        }

        private void cBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}