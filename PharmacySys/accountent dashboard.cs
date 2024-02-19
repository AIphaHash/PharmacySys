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
    public partial class accountent_dashboard : Form
    {
        public accountent_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void accountent_dashboard_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.accountentName;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();
            b.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            buyRecipt br = new buyRecipt();
            br.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sellRecipt sr = new sellRecipt();
            sr.Show();
            this.Hide();
        }
    }
}
