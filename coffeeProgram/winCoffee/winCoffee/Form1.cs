using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCoffee
{
    public partial class coffeeForm : Form
    {
        public coffeeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void coffeeForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            int bagsOrdered;
            bool parseGood = int.TryParse(textBoxCoffee.Text, out bagsOrdered);

            double bagPrice = 5.50;
            double largeBoxPrice = 3.00;
            double mediumBoxPrice = 2.50;
            double smallBoxPrice = 2.00;
            int largeBoxCapacity = 20;
            int mediumBoxCapacity = 10;
            int smallBoxCapacity = 5;

            int largeBoxesUsed = bagsOrdered / largeBoxCapacity;
            int mediumBoxesUsed = (bagsOrdered % largeBoxCapacity) / mediumBoxCapacity;
            int smallBoxesUsed = ((bagsOrdered % largeBoxCapacity) % mediumBoxCapacity) / smallBoxCapacity;
            if (((bagsOrdered % largeBoxCapacity) % mediumBoxCapacity) % smallBoxCapacity != 0)
            {
                smallBoxesUsed += 1;
            }
            double totalCost = (largeBoxesUsed * largeBoxPrice) + (mediumBoxesUsed * mediumBoxPrice) + (smallBoxesUsed * smallBoxPrice) + (bagsOrdered * bagPrice);

            // label outputs
            labelBags.Text = bagsOrdered.ToString();
            labelLarge.Text = largeBoxesUsed.ToString();
            labelMedium.Text = mediumBoxesUsed.ToString();
            labelSmall.Text = smallBoxesUsed.ToString();
            labelTotalCost.Text = totalCost.ToString();
        }
    }
}
