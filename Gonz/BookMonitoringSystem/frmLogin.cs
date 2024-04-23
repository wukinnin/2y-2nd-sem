using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMonitoringSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "Nimu" && txtPassword.Text == "password")
            {

                frmMain m = new frmMain();
                m.ShowDialog();

            }

            else
            {

                lblError.Text = "Invalid username and password";

            }



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            lblError.Text = "";
            txtPassword.Text = "";

        }
    }
}
