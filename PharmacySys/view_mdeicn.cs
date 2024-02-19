using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacySys
{
    public partial class view_mdeicn : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public view_mdeicn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();

        }

        private void view_mdeicn_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select * from medic";
            setDataGridView(query);
            query = "select sname from storage";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sname = listBox1.GetItemText(listBox1.SelectedItem);
            query = "select * from medic where mname like '" + textBox1.Text + "%' and sname = '" + sname + "'";
            setDataGridView(query);
        }

        private void setDataGridView(string query)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        string medicineid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_mdeicn_Load(this, null);
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "select quantity, sname from medic where mname = '" + medicineid + "'";
                ds = fn.getData(query);
                Int64 quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                string sname = ds.Tables[0].Rows[0][1].ToString();
                query = "select currentsiz from storage where sname = '" + sname + "'";
                ds = fn.getData(query);
                Int64 currentsiz = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                Int64 finalsiz = quantity + currentsiz;
                query = "update storage set currentsiz ='" + finalsiz + "' where sname = '"+sname+"'";
                fn.setData(query, "Storage Updated");

                query = "delete from medic where mname = '" + medicineid + "'";
                fn.setData(query, "medcin Deleted");
                view_mdeicn_Load(this, null);


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            view_mdeicn_Load(this, null);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select sname from storage where sname like '" + textBox2.Text + "%'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sname = listBox1.GetItemText(listBox1.SelectedItem);
            query = "select * from medic where sname = '" + sname + "'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            query = "select * from medic";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
