using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySys
{
    public partial class expire_warning : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public expire_warning()
        {
            InitializeComponent();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }

        private void expire_warning_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //query = "select* from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and DATEPART(month,eDate) = DATEPART(MONTH,GETDATE())";
                query = "select* from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >=30  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <=60";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label1.Text = "Warning only 1 or 2 month left";
                label1.ForeColor = Color.Yellow;
                label2.Text = (dataGridView1.Rows.Count - 1).ToString();


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //query = "select* from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and DATEPART(month,eDate) = DATEPART(MONTH,GETDATE())";
                query = " select* from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <30  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >7";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label1.Text = "Warning less than month left";
                label1.ForeColor = Color.Orange;
                label2.Text = (dataGridView1.Rows.Count - 1).ToString();


            }
            else if (comboBox1.SelectedIndex == 2)
            {
                query = "select* from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <=7  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >0;";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                label1.Text = "Warning only 1 week or less left";
                label1.ForeColor = Color.Red;
                label2.Text = (dataGridView1.Rows.Count - 1).ToString();
            }


















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
    }
}
