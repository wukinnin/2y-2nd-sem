using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trbCelcius_Scroll(object sender, EventArgs e)
        {
            lblCelVal.Text = trbCelsius.Value.ToString();

            lblFarVal.Text = ((double.Parse(lblCelVal.Text) * 9 / 5) + 32).ToString();
            lblKelVal.Text = (double.Parse(lblCelVal.Text) + 273.15).ToString();
        }
    }
}
