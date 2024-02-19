using System;
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
    public partial class modifyMedicn : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public modifyMedicn()
        {
            InitializeComponent();
            query = "select sname from storage where currentsiz <= ssize";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void clearall()
        {

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            listBox1.Items.Clear();
            if (textBox6.Text != "0")
            {
                textBox6.Text = "0";

            }
            else
            {
                textBox6.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearall();
        }
        Int64 totalQuantity;
        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox11_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string mname = textBox2.Text;
            string mDose = textBox3.Text;
            string mdate = dateTimePicker1.Text;
            string edate = dateTimePicker2.Text;
            Int64 quantity = Int64.Parse(textBox4.Text);
            Int64 addQuantity = Int64.Parse(textBox6.Text);
            Int64 unitPrice = Int64.Parse(textBox5.Text);
            Int64 totalq = quantity + addQuantity;
            string sname = listBox2.GetItemText(listBox2.SelectedItem).ToString();

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname = '" + mname + "', mDose = '" + mDose + "',mDate ='" + mdate + "', eDate ='" + edate + "', quantity ='" + totalq + "', perUnit ='" + unitPrice + "', sname = '" + sname + "' where mname = '" + textBox2.Text + "'";
            fn.setData(query, "medicn updated");
        }

        private void modifyMedicn_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                query = "select * from medic where mname = '" + textBox2.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {

                    textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][3].ToString();
                    dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
                    dateTimePicker2.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0][6].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0][7].ToString();
                    listBox1.Items.Add(ds.Tables[0].Rows[0][8].ToString());
                }
                else
                {
                    MessageBox.Show("No medicn in that name : " + textBox2.Text + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                clearall();
            }
        }
    }
}
