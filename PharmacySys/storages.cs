using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacySys
{
    public partial class storages : Form
    {
        Int64 currentsize;
        function fn = new function();//here i use the oop to get function from a class /btw it's made manually it contain the set data and get data code for the database
        string query;// a var to save the query inside it
        DataSet ds;
        public storages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            query = "select * from storage where sname = '" + textBox3.Text + "'";//type the sql query
            DataSet ds = fn.getData(query);//get the data from the database

            if (ds.Tables[0].Rows.Count == 0)//here if the return form the query was no value then we can use the username
            {
                pictureBox1.ImageLocation = @"C:\Users\ameer\Pictures\software_project\true.jpg";
                pictureBox6.Enabled = true;
                label1.Text = "";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\ameer\Pictures\software_project\false.jpg";//we can't cause it already exists
                pictureBox6.Enabled = false;
                label1.Text = "Please change username";
            }
        }

        private void storages_Load(object sender, EventArgs e)
        {
            query = "select * from storage";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from storage where sname like '" + textBox1.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            storages_Load(this, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from storage where sname = '" + sname + "'";
                fn.setData(query, "storage Deleted");
                storages_Load(this, null);
            }
        }
        string sname;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sname = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch { }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            storages_Load(this, null);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from storage where sname = '" + sname + "'";
                fn.setData(query, "storage Deleted");
                storages_Load(this, null);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")//to make sure all the textbox have values
            {
                if (textBox5.Text == textBox4.Text)
                {
                    string sname = textBox3.Text;
                    string slocation = textBox2.Text;
                    Int64 ssize = Int64.Parse(textBox4.Text);
                    Int64 currentsize = Int64.Parse(textBox5.Text);


                    query = "insert into storage (sname,slocation,ssize,currentsiz) values ('" + sname + "','" + slocation + "','" + ssize + "','" + currentsize + "')";
                    fn.setData(query, "The storage have been created");//here i type the sql query and save it inside query var then use the funcotion to set the data inside the database

                }
                else
                {
                    MessageBox.Show("correct the size ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//here it shows to the user that he missed a textbox

                }


            }
            else
            {
                MessageBox.Show("Enter all data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//here it shows to the user that he missed a textbox
            }
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
