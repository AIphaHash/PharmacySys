namespace PharmacySys
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            AdminLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            PharmLabel = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            gradiant_class1 = new Gradiant_class();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 52);
            label1.Name = "label1";
            label1.Size = new Size(257, 65);
            label1.TabIndex = 0;
            label1.Text = "Dashbord";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(43, 47);
            button1.Name = "button1";
            button1.Size = new Size(92, 98);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(AdminLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(199, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 655);
            panel1.TabIndex = 2;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.BackColor = Color.DarkGray;
            AdminLabel.BorderStyle = BorderStyle.Fixed3D;
            AdminLabel.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            AdminLabel.Location = new Point(174, 558);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(2, 57);
            AdminLabel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 495);
            label4.Name = "label4";
            label4.Size = new Size(313, 37);
            label4.TabIndex = 2;
            label4.Text = "Total Num of Admin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 170);
            label3.Name = "label3";
            label3.Size = new Size(323, 185);
            label3.TabIndex = 1;
            label3.Text = "Task Performed \r\n\r\n* Add User\r\n* View User\r\n* Profile Management\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 59);
            label2.Name = "label2";
            label2.Size = new Size(224, 37);
            label2.TabIndex = 0;
            label2.Text = "Administrators";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(PharmLabel);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(776, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 655);
            panel2.TabIndex = 0;
            // 
            // PharmLabel
            // 
            PharmLabel.AutoSize = true;
            PharmLabel.BackColor = Color.DarkGray;
            PharmLabel.BorderStyle = BorderStyle.Fixed3D;
            PharmLabel.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            PharmLabel.Location = new Point(172, 558);
            PharmLabel.Name = "PharmLabel";
            PharmLabel.Size = new Size(2, 57);
            PharmLabel.TabIndex = 4;
            PharmLabel.Click += PharmLabel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 495);
            label10.Name = "label10";
            label10.Size = new Size(382, 37);
            label10.TabIndex = 3;
            label10.Text = "Total Num of Pharmacist:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(34, 170);
            label8.Name = "label8";
            label8.Size = new Size(359, 222);
            label8.TabIndex = 2;
            label8.Text = "Task Performed \r\n\r\n* Add Medcines\r\n* View Medicines\r\n* Medicine Management\r\n* Sell Medicine\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 59);
            label6.Name = "label6";
            label6.Size = new Size(194, 37);
            label6.TabIndex = 1;
            label6.Text = "Pharmacists";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(1352, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 655);
            panel3.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGray;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(182, 558);
            label13.Name = "label13";
            label13.Size = new Size(2, 57);
            label13.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(10, 495);
            label11.Name = "label11";
            label11.Size = new Size(391, 37);
            label11.TabIndex = 3;
            label11.Text = "Total Num of Accountent :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(44, 170);
            label9.Name = "label9";
            label9.Size = new Size(332, 222);
            label9.TabIndex = 2;
            label9.Text = "Task Performed \r\n\r\n\r\n* Calculate Budget\r\n* Recomend Solutions\r\n* Profits and Loses\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(112, 59);
            label7.Name = "label7";
            label7.Size = new Size(178, 37);
            label7.TabIndex = 1;
            label7.Text = "Accountent";
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 90F;
            gradiant_class1.BottomColor = Color.Beige;
            gradiant_class1.Controls.Add(panel1);
            gradiant_class1.Controls.Add(label5);
            gradiant_class1.Controls.Add(panel2);
            gradiant_class1.Controls.Add(pictureBox2);
            gradiant_class1.Controls.Add(panel3);
            gradiant_class1.Controls.Add(pictureBox1);
            gradiant_class1.Controls.Add(label1);
            gradiant_class1.Controls.Add(button1);
            gradiant_class1.Location = new Point(-7, -7);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1937, 1092);
            gradiant_class1.TabIndex = 4;
            gradiant_class1.TopColor = Color.SteelBlue;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1419, 120);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 6;
            label5.Text = "Refresh";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1387, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources._93634;
            pictureBox1.Location = new Point(19, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gradiant_class1.ResumeLayout(false);
            gradiant_class1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label AdminLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label PharmLabel;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label9;
        private Label label7;
        private Gradiant_class gradiant_class1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label13;
        private Label label11;
    }
}