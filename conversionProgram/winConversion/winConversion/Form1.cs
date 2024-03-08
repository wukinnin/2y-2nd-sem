using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winConversion
{
    public partial class formConversion : Form
    {
        public formConversion()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double lengthInCentimeters;
            bool parseSuccess = double.TryParse(textboxLengthInCentimeters.Text, out lengthInCentimeters);

            const double centimetersPerInch = 2.54;
            const double inchesPerFoot = 12;
            const double feetPerYard = 3;

            // Convert length to inches
            double lengthInInches = lengthInCentimeters / centimetersPerInch;

            // Convert inches to yards, feet, and remaining inches
            double totalInches = (int)(lengthInInches); // Rounding to the nearest inch
            double yards = (int)(totalInches / (inchesPerFoot * feetPerYard));
            double remainingFeet = (int)((totalInches % (inchesPerFoot * feetPerYard)) / inchesPerFoot);
            double remainingInches = totalInches % inchesPerFoot;

            // update labels
            labelYard.Text = yards.ToString();
            labelFoot.Text = remainingFeet.ToString();
            labelInch.Text = remainingInches.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
