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
    public partial class adminstratro : Form
    {
        string user = "";
        ViewUser vu = new ViewUser();
        public static string po;//to save the username value that have been entered by the user into a var then use it into a label

        public adminstratro()
        {
            InitializeComponent();
            label2.Text = Form1.adminName;

        }

        public adminstratro(string username)
        {
            InitializeComponent();
            label2.Text = Form1.adminName;
            po = label2.Text;
            user = username;
            vu.ID = ID;//to get the id from the Viewuser class useing the oop

        }
        public string ID
        {
            get { return user.ToString(); }//not used
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewUser vu = new ViewUser();
            vu.Show();
            this.Hide();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile();
            pr.Show();
            this.Hide();
        }


    }
}
