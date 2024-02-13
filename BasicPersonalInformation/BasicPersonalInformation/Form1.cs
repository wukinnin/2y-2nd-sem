using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayTxt_Click(object sender, EventArgs e)
        {

           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BPI_Click(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string det = "First Name: " + fNameTxt.Text + "\nMiddle Name: " + mNameTxt.Text + "\nLast Name: " + lNameTxt.Text + "\nBirth Date: " + Date.Text + "\nCivil Status : " + comboBox.SelectedItem;

            if (Male.Checked)
                det = det + " \nGender: Male";
            else
                det = det + "\nGender: Female";

            det = det + " \nSports: ";

            if (Basketball.Checked)
                det = det + "\nBasketball";
            if (Volleyball.Checked)
                det = det + "\nVolleyball";
            if (Tennis.Checked)
                det = det + "\nTennis";
            if (Soccer.Checked)
                det = det + "\nSoccer";

            MessageBox.Show(det, "Personal Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
