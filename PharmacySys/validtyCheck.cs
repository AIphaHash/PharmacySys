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
    public partial class validtyCheck : Form
    {
        function fn = new function();
        string query;
        public validtyCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getdate()";//getdata() mean today date
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Valid Medicines";
                label3.ForeColor = Color.Green;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                query = "select * from medic where eDate < getdate()";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "Expired Medicines";
                label3.ForeColor = Color.Red;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                query = "select * from medic ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label3.Text = "All Medicines";
                label3.ForeColor = Color.Black;
            }

        }

        private void validtyCheck_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            if (pictureBox9.Location.X > width)
            {
                pictureBox9.Location = new Point(1, pictureBox9.Location.Y);
            }
            else
            {
                pictureBox9.Location = new Point(pictureBox9.Location.X + 4, pictureBox9.Location.Y);
            }
        }

        private void gradiant_class1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
