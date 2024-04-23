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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBook b = new frmBook();
            b.ShowDialog();


        }

        private void masterFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
