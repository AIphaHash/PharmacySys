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

    public partial class pharmacist : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        int speed = 5;
        public pharmacist()
        {
            InitializeComponent();

            query = "select count(*) from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >=30  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <=60";
            ds = fn.getData(query);
            label10.Text = ds.Tables[0].Rows[0][0].ToString();

            query = " select count(*) from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <30  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >7";
            ds = fn.getData(query);
            label9.Text = ds.Tables[0].Rows[0][0].ToString();

            query = "select count(*) from medic where DATEPART(yy,eDate) = DATEPART(yy,getdate()) and  ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) <=7  and ((DATEPART(month,eDate) *30)+ DATEPART(day,eDate)) - ((DATEPART(MONTH,GETDATE()) * 30)+DATEPART(day,getdate())) >0;";
            ds = fn.getData(query);
            label11.Text = ds.Tables[0].Rows[0][0].ToString();
            Int64 numOfnote1 = Int64.Parse(label10.Text);
            Int64 numOfnote2 = Int64.Parse(label11.Text);
            Int64 numOfnote3 = Int64.Parse(label9.Text);
            Int64 numOfnote4 = numOfnote3 + numOfnote1 + numOfnote2;
            label12.Text = "You Have'" + numOfnote4.ToString() + "' Notefication";
            if (numOfnote4 > 0)
            {
                pictureBox11.Enabled = true;
            }
            else { pictureBox11.Enabled = false; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addMedicine adm = new addMedicine();
            adm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_mdeicn vm = new view_mdeicn();
            vm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modifyMedicn mm = new modifyMedicn();
            mm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            validtyCheck vc = new validtyCheck();
            vc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sellMedcin sm = new sellMedcin();
            sm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            addMedicine adm = new addMedicine();
            adm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            view_mdeicn vm = new view_mdeicn();
            vm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            modifyMedicn mm = new modifyMedicn();
            mm.Show();
            this.Hide();
        }


        private void pharmacist_Load(object sender, EventArgs e)
        {


            label2.Text = Form1.pharmName;

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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            storages ss = new storages();
            ss.Show();
            this.Hide();
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            expire_warning ew = new expire_warning();
            ew.Show();
            this.Hide();

        }
    }
}
