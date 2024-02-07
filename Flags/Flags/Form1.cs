using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Flags
{
    public partial class flagViewerForm : Form
    {
        public flagViewerForm()
        {
            InitializeComponent();
            CountryNameLabel.Visible = false;
            FlagViewerLabel.Visible = false;
            ProgrammerLabel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // PhilippinesRadioButton
        {
            PhilippinesPictureBox.Visible = true;
            ColombiaPictureBox.Visible = false;
            USAPictureBox.Visible = false;
            FrancePictureBox.Visible = false;

            CountryNameLabel.Text = "Philippines";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // USARadioButton
        {
            PhilippinesPictureBox.Visible = false;
            ColombiaPictureBox.Visible = false;
            USAPictureBox.Visible = true;
            FrancePictureBox.Visible = false;
            
            CountryNameLabel.Text = "USA";
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_2(object sender, EventArgs e)
        {   
            CountryNameLabel.Visible = CountryNameCheckBox.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ColombiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PhilippinesPictureBox.Visible = false;
            ColombiaPictureBox.Visible = true;
            USAPictureBox.Visible = false;
            FrancePictureBox.Visible = false;

            CountryNameLabel.Text = "Colombia";
        }

        private void FranceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PhilippinesPictureBox.Visible = false;
            ColombiaPictureBox.Visible = false;
            USAPictureBox.Visible = false;
            FrancePictureBox.Visible = true;

            CountryNameLabel.Text = "France";
        }

        private void CountryNameCheckBox_CheckedChanged(object sender, EventArgs e, bool v)
        {
            
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FlagViewerLabel.Visible = TitleCheckBox.Checked;
        }

        private void CountryNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CountryNameLabel.Visible = CountryNameCheckBox.Checked;
        }

        private void ProgrammerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ProgrammerLabel.Visible = ProgrammerCheckBox.Checked;
        }
    }
}
