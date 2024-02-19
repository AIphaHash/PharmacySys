using DGVPrinterHelper;
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
    public partial class addMedicine : Form
    {
        function fn = new function();//here i use the oop to get function from a class /btw it's made manually it contain the set data and get data code for the database
        string query;// a var to save the query inside it
        DataSet ds;
        public addMedicine()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();// oop for another class
            p.Show();//to show main dashbaord for the pharmacist
            this.Hide();//to hide this screen
        }
        protected int n, totalamount = 0;
        private void button2_Click(object sender, EventArgs e)
        {

        }


        public void clearall()//function to clear all the textbox from any data
        {
           
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            textBox6.Clear();


        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            clearall();// to clear the textboxs
        }

        private void addMedicine_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select * from storage where currentsiz >0";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            if ( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != "" && textBox5.Text != "" && listBox1.SelectedIndex != -1)
            {
                Int64 quan = Int64.Parse(textBox4.Text);
                Int64 price = Int64.Parse(textBox5.Text);
                Int64 final = quan * price;
                //label13.Text = final.ToString();
                string sname = listBox1.SelectedItem.ToString();


                query = "select currentsiz from storage where sname = '" + sname + "'";
                ds = fn.getData(query);
                Int64 currentsiz = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                try
                {
                    if (quan > currentsiz)
                    {
                        MessageBox.Show("the storage is full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        n = dataGridView1.Rows.Add();

                        dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
                        dataGridView1.Rows[n].Cells[1].Value = textBox3.Text;
                        dataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;
                        dataGridView1.Rows[n].Cells[3].Value = dateTimePicker2.Text;
                        dataGridView1.Rows[n].Cells[4].Value = textBox4.Text;
                        dataGridView1.Rows[n].Cells[5].Value = textBox5.Text;
                        dataGridView1.Rows[n].Cells[6].Value = listBox1.SelectedItem.ToString();
                        dataGridView1.Rows[n].Cells[7].Value = textBox6.Text;


                        currentsiz -= quan;
                        query = " update storage set currentsiz ='" + currentsiz + "'where sname = '" + sname + "'";
                        fn.setData(query, "The avaliable storage for '" + sname + "'is '" + currentsiz + "'");

                        totalamount += int.Parse(label13.Text);
                        label15.Text = totalamount.ToString();
                        MessageBox.Show("Add to list", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        string mname = textBox2.Text;
                        string mDose = textBox3.Text;
                        string mdate = dateTimePicker1.Text;
                        string edate = dateTimePicker2.Text;
                        Int64 quantity = Int64.Parse(textBox4.Text);
                        Int64 perunit = Int64.Parse(textBox5.Text);
                        string from_ = textBox6.Text;

                        query = "insert into medic (mname,mDose,mDate,eDate,quantity,perUnit,sname,from_) values ('" + mname + "','" + mDose + "','" + mdate + "','" + edate + "','" + quantity + "','" + perunit + "','" + sname + "','" + from_ + "')";
                        fn.setData(query, "The medicn added to the bill");//here i type the sql query and save it inside query var then use the funcotion to set the data inside the database

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("manme Already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//here to catch an error that will accroured if the user typed a username that already exists

                }


                textBox2.Clear();

            }





            else if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a storage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Enter all data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//here it shows to the user that he missed a textbox
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public Int64 datarows;
        public void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            int p = int.Parse(label15.Text);
            int price = p;
            string bDate = DateTime.Now.ToString("yyyyMMdd");
            string from_ = textBox6.Text;
            int numOfmedic = dataGridView1.Rows.Count - 1;

            query = "insert into buyBill (from_,numOfmedic,bDate,cost) values ('" + from_ + "','" + numOfmedic + "','" + bDate + "','" + price + "')";
            fn.setData(query, "buyBill updated");

            DGVPrinter print = new DGVPrinter();
            print.Title = "Buying Bill";
            print.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + label15.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);

            totalamount = 0;
            label15.Text = "";
            dataGridView1.DataSource = 0;
        }


        private void pictureBox15_Click(object sender, EventArgs e)
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

                Int64 perUnit = Int64.Parse(textBox5.Text);
                Int64 fullPrice = perUnit * quantity;
                Int64 totalPrice = Int64.Parse(label15.Text);

                label15.Text = (totalPrice - fullPrice).ToString();
                query = "update storage set currentsiz ='" + finalsiz + "' where sname = '" + sname + "'";
                fn.setData(query, "Storage Updated");

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);

                query = "delete from medic where mname = '" + medicineid + "'";
                fn.setData(query, "medcin Deleted");
                addMedicine_Load(this, null);

            }
        }
        string medicineid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch { }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox5.Text);
            int b = int.Parse(textBox4.Text);
            int c = a * b;
            label13.Text = c.ToString();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname = '" + textBox2.Text + "'";//type the sql query
            DataSet ds = fn.getData(query);//get the data from the database

            if (ds.Tables[0].Rows.Count == 0)//here if the return form the query was no value then we can use the username
            {
                pictureBox17.Image = PharmacySys.Properties.Resources.praxis_checkmark_icon_circle;
                pictureBox11.Enabled = true;
                label1.ForeColor = Color.Black;
                label1.Text = "Add";
            }
            else
            {
                pictureBox17.Image = PharmacySys.Properties.Resources.icn_error;
                pictureBox11.Enabled = false;
                label1.ForeColor = Color.Red;
                label1.Text = "Change mname";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
