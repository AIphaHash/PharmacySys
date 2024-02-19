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
    public partial class Dashboard : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminstratro am = new adminstratro();
            am.Show();
            this.Hide();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Adminstratro'";
            ds = fn.getData(query);//here to count the adminstartaro number in the database
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);//here to count the phramacist number in the database
            setLabel(ds, PharmLabel);//calling a function

            query = "select count(userRole) from users where userRole = 'Accountent'";
            ds = fn.getData(query);
            setLabel(ds, label13);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();// here to set the value of the textbox to the number that we get from the databse

            }
            else
            {
                lbl.Text = "0";//if there is nothing
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard_Load(this, null);//to reset the page to reset the database
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard_Load(this, null);//same
        }

        private void PharmLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
