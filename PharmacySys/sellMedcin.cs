using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacySys
{

    public partial class sellMedcin : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public sellMedcin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pharmacist p = new pharmacist();
            p.Show();
            this.Hide();
        }


        private void sellMedcin_Load(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            query = "select sname from storage";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            listBox1.Items.Clear();
            query = "select sname from storage where sname like '" + textBox7.Text + "%'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellMedcin_Load(this, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname from medic where mname like '" + textBox1.Text + "%' and sname = '" + listBox3.SelectedItem.ToString() + "' and RIGHT(eDate,4) >= 2024 and quantity >'0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Clear();

            string name = listBox1.GetItemText(listBox1.SelectedItem);
            textBox3.Text = name;

            query = "select mname, eDate,perUnit,sname from medic where mname = '" + name + "'";
            ds = fn.getData(query);
            textBox3.Text = ds.Tables[0].Rows[0][0].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][2].ToString();
            listBox2.Items.Add(ds.Tables[0].Rows[0][3].ToString());

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                Int64 unitPrice = Int64.Parse(textBox4.Text);
                Int64 noOFUNit = Int64.Parse(textBox5.Text);
                Int64 totalAmount = unitPrice * noOFUNit;
                textBox6.Text = totalAmount.ToString();
            }
            else
            {
                textBox6.Clear();
            }
        }
         int n, totalAmount = 0;
         Int64 quantity, newQuantity;

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }
        private void clearall()
        {
           
            textBox3.Clear();
            dateTimePicker1.ResetText();
            textBox4.Clear();
            textBox5.Clear();
            

        }
        int valueAmount;
        string valueId;
         Int64 noOfunit;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                
            }
            catch (Exception)
            {

            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sellMedcin_Load(this, null);
        }
        Int64 currentsiz;
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            
            int price = int.Parse(label10.Text);
            string bDate = DateTime.Now.ToString("yyyyMMdd");
            string Too = textBox8.Text;
            int numOfmedic = dataGridView1.Rows.Count - 1;

            query = "insert into sellBill (from_,bDate,numOfmedic,price) values ('" + Too + "','" + bDate + "','" + numOfmedic + "','" + price + "')";
            fn.setData(query, "sellBill updated");

            DGVPrinter print = new DGVPrinter();
            print.Title = "medcine Bill";
            print.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + label10.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);

            totalAmount = 0;
            label10.Text = "";
            dataGridView1.DataSource = 0;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "select quantity, sname from medic where mname = '" + valueId + "'";
                ds = fn.getData(query);
                Int64 quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                string sname = ds.Tables[0].Rows[0][1].ToString();
                query = "select currentsiz from storage where sname = '" + sname + "'";
                ds = fn.getData(query);
                Int64 currentsiz = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                Int64 finalsiz = quantity + currentsiz;
                query = "update storage set currentsiz ='" + finalsiz + "' where sname = '" + sname + "'";
                fn.setData(query, "Storage Updated");

                newQuantity = quantity + noOfunit;
                query = "update medic set quantity ='" + newQuantity + "' where mname = '" + valueId + "'";
                fn.setData(query, "Medicn removed from cart.");


                Int64 fullPrice = valueAmount;
                Int64 totalPrice = Int64.Parse(label10.Text);

                label10.Text = (totalPrice - fullPrice).ToString();
                

                

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);

                
                sellMedcin_Load(this, null);

            }

            //if (valueId != "")
            //{
             //   try
             //   {
             //       dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
              //      query = "select quantity from medic where mname = '" + valueId + "'";
              //      ds = fn.getData(query);
              //      quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    
              //      totalAmount = totalAmount - valueAmount;
             //       label10.Text = totalAmount.ToString();
              //  }
             //   catch
             //   {
              //      MessageBox.Show("please select a medicn to delete","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  }
                
             //   sellMedcin_Load(this, null);
           // }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (textBox8.Text != "")
            {
                if (textBox3.Text != "")
                {
                    textBox8.Enabled = false;
                    query = "select quantity from medic where mname = '" + textBox3.Text + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity - Int64.Parse(textBox5.Text);
                    if (newQuantity >= 0)
                    {
                        n = dataGridView1.Rows.Add();
                        
                        dataGridView1.Rows[n].Cells[0].Value = textBox3.Text;
                        dataGridView1.Rows[n].Cells[1].Value = dateTimePicker1.Text;
                        dataGridView1.Rows[n].Cells[2].Value = textBox4.Text;
                        dataGridView1.Rows[n].Cells[3].Value = textBox5.Text;
                        dataGridView1.Rows[n].Cells[4].Value = textBox6.Text;
                        dataGridView1.Rows[n].Cells[5].Value = textBox8.Text;

                        totalAmount = totalAmount + int.Parse(textBox6.Text);
                        label10.Text = totalAmount.ToString();

                        query = "update medic set quantity = '" + newQuantity + "' where mname = '" + textBox3.Text + "'";
                        fn.setData(query, "Medicn Added.");
                        query = "select currentsiz from storage where sname = '" + listBox2.Items[0].ToString() + "'";
                        ds = fn.getData(query);
                        currentsiz = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        currentsiz += int.Parse(textBox5.Text);
                        query = "update storage set currentsiz = '" + currentsiz + "' where sname = '" + listBox2.Items[0].ToString() + "'";
                        fn.setData(query, "storage size updated");

                    }
                    else
                    {
                        MessageBox.Show("Medcine is out of stock \n Only " + quantity + "left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    clearall();
                    sellMedcin_Load(this, null);
                }
                else
                {
                    MessageBox.Show("select Medicine first", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Enter buyer name ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            query = "select sname from storage where sname like '" + textBox7.Text + "%' and  currentsiz > 0";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname from medic where sname like '" + listBox3.SelectedItem.ToString() + "%' and RIGHT(eDate,4) >= 2024 and quantity >'0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select mname from medic where RIGHT(eDate,4) >= 2024 and quantity >'0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
