using PharmacySys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacySys
{
    public partial class Balance : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Balance()
        {
            InitializeComponent();
        }

        private void butRecipt_Load(object sender, EventArgs e)
        {
            query = "select from_ from buyBill";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }


            query = "select * from buyBill";

            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pharmacist ad = new pharmacist();
            ad.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select from_ from buyBill where from_ like '" + textBox1.Text + "%'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from buyBill where from_ like '" + listBox1.SelectedItem.ToString() + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGridView1.SelectedCells[3].Value.ToString();

        }
    }

}

   

        
    