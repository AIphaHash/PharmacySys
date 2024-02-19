namespace PharmacySys
{
    partial class ViewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            gradiant_class1 = new Gradiant_class();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            gradiant_class2 = new Gradiant_class();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gradiant_class2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 326);
            label1.Name = "label1";
            label1.Size = new Size(222, 50);
            label1.TabIndex = 0;
            label1.Text = "View Users ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(759, 188);
            label2.Name = "label2";
            label2.Size = new Size(189, 30);
            label2.TabIndex = 1;
            label2.Text = "Type a username :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SlateGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(954, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search..";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(532, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1170, 656);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(20, 28);
            button3.Name = "button3";
            button3.Size = new Size(75, 79);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 60F;
            gradiant_class1.BottomColor = Color.SteelBlue;
            gradiant_class1.Controls.Add(label3);
            gradiant_class1.Controls.Add(pictureBox4);
            gradiant_class1.Controls.Add(pictureBox3);
            gradiant_class1.Controls.Add(textBox1);
            gradiant_class1.Controls.Add(label2);
            gradiant_class1.Controls.Add(dataGridView1);
            gradiant_class1.Controls.Add(gradiant_class2);
            gradiant_class1.Location = new Point(-8, -4);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1938, 1096);
            gradiant_class1.TabIndex = 7;
            gradiant_class1.TopColor = Color.Khaki;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(1077, 955);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 11;
            label3.Text = "Delete Selected";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources._8ff9f9b0e469f751f47fc0a995a172ad;
            pictureBox4.Location = new Point(1077, 888);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1520, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // gradiant_class2
            // 
            gradiant_class2.Angel = 0F;
            gradiant_class2.BottomColor = Color.FromArgb(194, 186, 75);
            gradiant_class2.Controls.Add(label5);
            gradiant_class2.Controls.Add(label4);
            gradiant_class2.Controls.Add(panel1);
            gradiant_class2.Controls.Add(label1);
            gradiant_class2.Controls.Add(pictureBox2);
            gradiant_class2.Controls.Add(pictureBox1);
            gradiant_class2.Controls.Add(button3);
            gradiant_class2.Location = new Point(0, 0);
            gradiant_class2.Name = "gradiant_class2";
            gradiant_class2.Size = new Size(256, 1096);
            gradiant_class2.TabIndex = 12;
            gradiant_class2.TopColor = Color.FromArgb(82, 136, 146);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(4, 426);
            label5.Name = "label5";
            label5.Size = new Size(238, 50);
            label5.TabIndex = 15;
            label5.Text = "Delete Users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 376);
            label4.Name = "label4";
            label4.Size = new Size(63, 50);
            label4.TabIndex = 14;
            label4.Text = "&& ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(79, 79, 79);
            panel1.Location = new Point(241, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1093);
            panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(39, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources._936341;
            pictureBox1.Location = new Point(3, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewUser";
            Text = "ViewUser";
            WindowState = FormWindowState.Maximized;
            Load += ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gradiant_class1.ResumeLayout(false);
            gradiant_class1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gradiant_class2.ResumeLayout(false);
            gradiant_class2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Gradiant_class gradiant_class1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label3;
        private Gradiant_class gradiant_class2;
        private Label label5;
        private Label label4;
        private Panel panel1;
    }
}