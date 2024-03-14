using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShapeGonzaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectCalculateButton_Click(object sender, EventArgs e)
        {
            double length = double.Parse(rectLengthTextBox.Text);
            double width = double.Parse(rectWidthTextBox.Text);

            double area = length * width;
            rectResultLabel.Text = (Math.Round(area, 2)).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void circleCalculateButton_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(circleRadiusTextBox.Text);

            double area = Math.PI * radius * radius;
            circleResultLabel.Text = (Math.Round(area, 2)).ToString();
        }

        private void triCalculateButton_Click(object sender, EventArgs e)
        {
            double baseLength = double.Parse(triBaseLengthTextBox.Text);
            double height = double.Parse(triHeightTextBox.Text);

            double area = 0.5 * baseLength * height;
            triResultLabel.Text = (Math.Round(area, 2)).ToString();
        }
    }
}
