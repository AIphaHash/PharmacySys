namespace PharmacySys
{
    partial class expire_warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expire_warning));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            gradiant_class1 = new Gradiant_class();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            gradiant_class2 = new Gradiant_class();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            gradiant_class2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(501, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1357, 494);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightPink;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "YellowWarning", "OrangeWarning", "RedWarning" });
            comboBox1.Location = new Point(885, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(588, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._936348;
            pictureBox1.Location = new Point(34, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(820, 702);
            label1.Name = "label1";
            label1.Size = new Size(96, 37);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 388);
            label2.Name = "label2";
            label2.Size = new Size(2, 39);
            label2.TabIndex = 6;
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 60F;
            gradiant_class1.BottomColor = Color.FromArgb(128, 208, 242);
            gradiant_class1.Controls.Add(pictureBox3);
            gradiant_class1.Controls.Add(comboBox1);
            gradiant_class1.Controls.Add(dataGridView1);
            gradiant_class1.Controls.Add(label3);
            gradiant_class1.Controls.Add(label1);
            gradiant_class1.Controls.Add(gradiant_class2);
            gradiant_class1.Controls.Add(pictureBox9);
            gradiant_class1.Location = new Point(-10, -2);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1926, 1088);
            gradiant_class1.TabIndex = 7;
            gradiant_class1.TopColor = Color.Empty;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(948, 741);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(652, 113);
            label3.Name = "label3";
            label3.Size = new Size(227, 30);
            label3.TabIndex = 8;
            label3.Text = "Choose Edate period :";
            // 
            // gradiant_class2
            // 
            gradiant_class2.Angel = 180F;
            gradiant_class2.BottomColor = Color.FromArgb(255, 192, 255);
            gradiant_class2.Controls.Add(pictureBox2);
            gradiant_class2.Controls.Add(panel1);
            gradiant_class2.Controls.Add(label4);
            gradiant_class2.Controls.Add(label2);
            gradiant_class2.Controls.Add(pictureBox1);
            gradiant_class2.Location = new Point(0, 3);
            gradiant_class2.Name = "gradiant_class2";
            gradiant_class2.Size = new Size(340, 1085);
            gradiant_class2.TabIndex = 10;
            gradiant_class2.TopColor = Color.Empty;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.expired_131964752748201554;
            pictureBox2.Location = new Point(54, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 183);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(322, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 1082);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 358);
            label4.Name = "label4";
            label4.Size = new Size(229, 30);
            label4.TabIndex = 9;
            label4.Text = "Number of warnings :";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(165, 913);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(237, 175);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // expire_warning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "expire_warning";
            Text = "expire_warning";
            WindowState = FormWindowState.Maximized;
            Load += expire_warning_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradiant_class1.ResumeLayout(false);
            gradiant_class1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            gradiant_class2.ResumeLayout(false);
            gradiant_class2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Gradiant_class gradiant_class1;
        private Label label3;
        private Label label4;
        private Gradiant_class gradiant_class2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
    }
}