namespace PharmacySys
{
    partial class validtyCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(validtyCheck));
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            gradiant_class1 = new Gradiant_class();
            pictureBox9 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(55, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 77);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(336, 223);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Validty check";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Valid Medicines", "Expired Medicines", "View All Medicines" });
            comboBox1.Location = new Point(897, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(215, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1509, 462);
            dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources._936344;
            pictureBox1.Location = new Point(39, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 60F;
            gradiant_class1.BottomColor = Color.White;
            gradiant_class1.Controls.Add(pictureBox9);
            gradiant_class1.Controls.Add(label3);
            gradiant_class1.Controls.Add(label2);
            gradiant_class1.Controls.Add(comboBox1);
            gradiant_class1.Controls.Add(pictureBox1);
            gradiant_class1.Controls.Add(dataGridView1);
            gradiant_class1.Controls.Add(button1);
            gradiant_class1.Controls.Add(label1);
            gradiant_class1.Controls.Add(pictureBox2);
            gradiant_class1.Location = new Point(-9, -4);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1940, 1090);
            gradiant_class1.TabIndex = 7;
            gradiant_class1.TopColor = Color.FromArgb(255, 192, 128);
            gradiant_class1.Paint += gradiant_class1_Paint;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(-172, 897);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(237, 175);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(764, 769);
            label3.Name = "label3";
            label3.Size = new Size(465, 47);
            label3.TabIndex = 9;
            label3.Text = "Too Check Medcine Validty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(694, 136);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 8;
            label2.Text = "Chosse Search Filter :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(215, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 237);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // validtyCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "validtyCheck";
            Text = "validtyCheck";
            WindowState = FormWindowState.Maximized;
            Load += validtyCheck_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradiant_class1.ResumeLayout(false);
            gradiant_class1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Gradiant_class gradiant_class1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer1;
    }
}