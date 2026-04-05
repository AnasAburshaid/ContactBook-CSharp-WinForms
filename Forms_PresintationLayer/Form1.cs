using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleBusinessLayer;
namespace Forms_PresintationLayer
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void _LoadAllData()
        {
           dataGridView1.DataSource = clsContacts.ListContacts();
           lblTotalCount.Text = dataGridView1.RowCount.ToString();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadAllData();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2(-1);
            frm2.ShowDialog();
            _LoadAllData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm2.ShowDialog();
            _LoadAllData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete contact " +
                "with id = [" + dataGridView1.CurrentRow.Cells[0].Value + "] ?","Delete Contact",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(clsContacts.DeleteContact((int)dataGridView1.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Contact deleted successfuly");
                _LoadAllData();

            }
        }

      
    }
}
