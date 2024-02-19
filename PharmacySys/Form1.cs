using System.Data;

namespace PharmacySys
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public static string pharmName;//to get the username 
        public static string adminName;
        public static string accountentName;


        public Form1()
        {
            InitializeComponent();

        }





        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)//here where all the magic happen
        {
            adminName = textBox1.Text;
            pharmName = textBox1.Text;
            accountentName = textBox1.Text;
            query = "select * from users where userRole = 'Adminstratro'";//to check if there is an adminstarot with the enttered username
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (textBox1.Text == "root" && textBox2.Text == "root")
                {
                    adminstratro admin = new adminstratro();
                    admin.Show();
                    this.Hide();
                }
                else if (textBox1.Text != "root" && textBox2.Text != "root")
                {
                    query = "select * from users where username = '" + textBox1.Text + "' and pass= '" + textBox2.Text + "'";
                    ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        string role = ds.Tables[0].Rows[0][1].ToString();
                        if (role == "Pharmacist")
                        {
                            pharmacist pharm = new pharmacist();
                            pharm.Show();
                            this.Hide();
                        }
                        if (role == "Accountent")
                        {
                            accountent_dashboard ad = new accountent_dashboard();
                            ad.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong username OR password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            else 
            {
                query = "select * from users where username = '" + textBox1.Text + "' and pass= '" + textBox2.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Adminstratro")
                    {
                        adminstratro admin = new adminstratro(textBox1.Text);
                        admin.Show();
                        this.Hide();

                    }
                    else if (role == "Pharmacist")
                    {
                        pharmacist pharm = new pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                    if (role == "Accountent")
                    {
                        accountent_dashboard ad = new accountent_dashboard();
                        ad.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username OR password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "UserName.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "UserName.";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password.")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password.";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }


    }
}