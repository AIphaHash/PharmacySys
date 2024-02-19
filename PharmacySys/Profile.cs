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
    public partial class Profile : Form
    {

        function fn = new function();
        string query;
        adminstratro am = new adminstratro();

        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            am.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label2.Text = adminstratro.po;
        }

        private void Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + label2.Text + "'";
            DataSet ds = fn.getData(query);
            comboBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox1.Text = ds.Tables[0].Rows[0][2].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox2.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][6].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile_Enter(this, null);
        }



        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string role = comboBox1.Text;
            string name = textBox1.Text;
            string dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox2.Text);
            string email = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox5.Text;

            query = "update users set userRole = '" + role + "' ,name= '" + name + "', dob = '" + dob + "', mobile = '" + mobile + "', email = '" + email + "',pass = '" + password + "' where username = '" + username + "'";
            fn.setData(query, "Profile Udated succesfuly");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Profile_Enter(this, null);
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
            if (textBox2.Text == "781......")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "781......";
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
            if (textBox4.Text == "")
            {
                textBox4.Text = "Username.";
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
    }
}
