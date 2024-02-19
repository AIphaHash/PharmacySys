using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySys
{
    public partial class AddUser : Form
    {
        function fn = new function();//here i use the oop to get function from a class /btw it's made manually it contain the set data and get data code for the database
        string query;// a var to save the query inside it
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminstratro ad = new adminstratro();// oop for a class that contain all adminstartor screen
            ad.Show();//to show it
            this.Hide();// to hide this screen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text;//to save all the values that enterd by the user inside a variables
            string name = textBox1.Text;
            string dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox2.Text);
            string email = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;

            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "' ,'" + name + "' ,'" + dob + "' ,'" + mobile + "' ,'" + email + "' ,'" + username + "' ,'" + password + "') ";
                fn.setData(query, "Sign Up Successfuly");//here to use the values that enterd by the user and add it into the database

            }

            catch (Exception)
            {
                MessageBox.Show("Username Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//here to catch an error that will accroured if the user typed a username that already exists
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();//call a function to clear all the textboxs
        }
        public void clearAll()
        {
            textBox1.Clear();//to clear all the textboxs
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.ResetText();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + textBox4.Text + "'";//type the sql query
            DataSet ds = fn.getData(query);//get the data from the database

            if (ds.Tables[0].Rows.Count == 0)//here if the return form the query was no value then we can use the username
            {
                pictureBox1.ImageLocation = @"C:\Users\ameer\Pictures\software_project\true.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\ameer\Pictures\software_project\false.jpg";//we can't cause it already exists
            }
        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Name.";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "781........")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "781........";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "example@gmail.com")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "example@gmail.com";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Username.")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "Username.")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password.")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Password.";
                textBox5.ForeColor = Color.Silver;
            }
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {
            clearAll();//to clear all the textboxs
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            adminstratro ad = new adminstratro();
            ad.Show();
            this.Hide();
        }

        private void gradiant_class1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
