using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BookMonitoringSystem
{
    public partial class frmBook : Form
    {

        OleDbConnection con;

        public frmBook()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Gonz\\Project\\BookMonitoringSystem.mdb");

        }

        private void loadDatagrid()
        {

            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Book", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com); 
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            con.Close();


        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            con.Open();

            OleDbCommand com = new OleDbCommand("Insert into book values (" + txtTitle.Text + "' , '" + txtAuthor.Text + "')",con);
            com.ExecuteNonQuery();

            MessageBox.Show("Successfully SAVED!", "New Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            loadDatagrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            con.Open();

            OleDbCommand com = new OleDbCommand("Select * from Book where title like '%" + txtSearch.Text + "%'", con);
            com.ExecuteNonQuery();

            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dgvBookRecords.DataSource = tab;

            con.Close();

        }

        //
        
        private void dgvBookRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookID.Text = dataGridView1.Rows[e.RowIndex].Cells["bookID"].Value.ToString();
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells["Author"].Value.ToString();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            int no;
            no = int.Parse(txtBookID.Text);

            OleDbCommand com = new OleDbCommand("Update book SET TITLE=" + txtTitle.Text + "', author=" + txtAuthor.Text + "' where bookID= " + no + "", con);
            com.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY UPDATED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

            loadDatagrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            int num = (int.Parse(txtBookID.Text));
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
            }
            else
            {
                OleDbCommand com = new OleDbCommand("Delete from book where bookID=" + num + "", con); com.ExecuteNonQuery();
                MessageBox.Show("Succesfully DELETED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("CANCELLED!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            loadDatagrid();
        }

        private void dgvBookRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
