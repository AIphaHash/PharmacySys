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
    public partial class ViewUser : Form
    {
        function fn = new function();
        string query;
        string currentUser = "";

        public ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminstratro am = new adminstratro();
            am.Show();
            this.Hide();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + textBox1.Text + "%'";// % means any data start with a or any other bit will be loaded
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        string id;




        private void button2_Click(object sender, EventArgs e)
        {
            ViewUser_Load(this, null);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search..")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search..";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                query = "delete from users where id = '" + id + "'";
                fn.setData(query, "user record Deleted");
                ViewUser_Load(this, null);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewUser_Load(this, null);
        }


    }
}
