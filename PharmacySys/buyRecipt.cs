﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySys
{

    public partial class buyRecipt : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public buyRecipt()
        {
            InitializeComponent();
        }


        private void buyRecipt_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            accountent_dashboard ad = new accountent_dashboard();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            accountent_dashboard ad = new accountent_dashboard();
            ad.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            label4.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}
