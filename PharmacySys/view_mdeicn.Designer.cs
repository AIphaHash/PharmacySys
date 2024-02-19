namespace PharmacySys
{
    partial class view_mdeicn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_mdeicn));
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            gradiant_class1 = new Gradiant_class();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            gradiant_class2 = new Gradiant_class();
            label5 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox5 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gradiant_class2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(683, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 26);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(538, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1341, 479);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 100F;
            gradiant_class1.BottomColor = Color.White;
            gradiant_class1.Controls.Add(label2);
            gradiant_class1.Controls.Add(pictureBox3);
            gradiant_class1.Controls.Add(label1);
            gradiant_class1.Controls.Add(label3);
            gradiant_class1.Controls.Add(textBox1);
            gradiant_class1.Controls.Add(pictureBox2);
            gradiant_class1.Controls.Add(dataGridView1);
            gradiant_class1.Controls.Add(gradiant_class2);
            gradiant_class1.Controls.Add(pictureBox9);
            gradiant_class1.Cursor = Cursors.Hand;
            gradiant_class1.Location = new Point(-8, -4);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1937, 1088);
            gradiant_class1.TabIndex = 7;
            gradiant_class1.TopColor = Color.SkyBlue;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(1094, 789);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 13;
            label2.Text = "Delete Selected Medcine";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1141, 709);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(461, 138);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 11;
            label1.Text = "Search Medicne name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1595, 143);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 10;
            label3.Text = "Refresh";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1571, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // gradiant_class2
            // 
            gradiant_class2.Angel = 100F;
            gradiant_class2.BottomColor = Color.FromArgb(104, 190, 227);
            gradiant_class2.Controls.Add(label6);
            gradiant_class2.Controls.Add(label5);
            gradiant_class2.Controls.Add(textBox2);
            gradiant_class2.Controls.Add(listBox1);
            gradiant_class2.Controls.Add(label4);
            gradiant_class2.Controls.Add(pictureBox4);
            gradiant_class2.Controls.Add(panel1);
            gradiant_class2.Controls.Add(pictureBox1);
            gradiant_class2.Controls.Add(pictureBox5);
            gradiant_class2.Location = new Point(3, 0);
            gradiant_class2.Name = "gradiant_class2";
            gradiant_class2.Size = new Size(384, 1088);
            gradiant_class2.TabIndex = 23;
            gradiant_class2.TopColor = Color.Empty;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 343);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 28;
            label5.Text = "Search Storages";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(163, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 26);
            textBox2.TabIndex = 27;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gray;
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(63, 392);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 404);
            listBox1.TabIndex = 26;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(136, 143);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 25;
            label4.Text = "Storages";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.warehouse_storage_icon_22;
            pictureBox4.Location = new Point(103, 171);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 112);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(367, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(17, 1085);
            panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._936343;
            pictureBox1.Location = new Point(33, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(167, 913);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(237, 175);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.pngtree_age_old_pattern_icon_animal_illustration_hawaiian_vector_png_image_21145522;
            pictureBox5.Location = new Point(27, 766);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(199, 141);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(186, 824);
            label6.Name = "label6";
            label6.Size = new Size(113, 32);
            label6.TabIndex = 29;
            label6.Text = "Show All";
            // 
            // view_mdeicn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_mdeicn";
            Text = "view_mdeicn";
            WindowState = FormWindowState.Maximized;
            Load += view_mdeicn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gradiant_class1.ResumeLayout(false);
            gradiant_class1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gradiant_class2.ResumeLayout(false);
            gradiant_class2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Gradiant_class gradiant_class1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer1;
        private Gradiant_class gradiant_class2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Label label5;
        private TextBox textBox2;
        private ListBox listBox1;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox5;
    }
}