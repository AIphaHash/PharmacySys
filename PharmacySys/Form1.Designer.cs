namespace PharmacySys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gradiant_class1 = new Gradiant_class();
            gradiant_class3 = new Gradiant_class();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            gradiant_class2 = new Gradiant_class();
            gradiant_class1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            gradiant_class2.SuspendLayout();
            SuspendLayout();
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 60F;
            gradiant_class1.BackColor = Color.OliveDrab;
            gradiant_class1.BottomColor = Color.Black;
            gradiant_class1.Controls.Add(gradiant_class3);
            gradiant_class1.Controls.Add(pictureBox2);
            gradiant_class1.Controls.Add(pictureBox1);
            gradiant_class1.Location = new Point(-10, -8);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(557, 1093);
            gradiant_class1.TabIndex = 0;
            gradiant_class1.TopColor = Color.Green;
            // 
            // gradiant_class3
            // 
            gradiant_class3.Angel = 360F;
            gradiant_class3.BackColor = Color.OliveDrab;
            gradiant_class3.BottomColor = Color.FromArgb(44, 44, 44);
            gradiant_class3.ForeColor = SystemColors.ControlLightLight;
            gradiant_class3.Location = new Point(535, 6);
            gradiant_class3.Name = "gradiant_class3";
            gradiant_class3.Size = new Size(22, 1093);
            gradiant_class3.TabIndex = 12;
            gradiant_class3.TopColor = Color.FromArgb(27, 60, 82);
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._7TapAz6Lc;
            pictureBox2.Location = new Point(51, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 685);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._24_7_Pharmacy;
            pictureBox1.Location = new Point(3, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(551, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._7TapAz6Lc;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(1351, 38);
            button1.Name = "button1";
            button1.Size = new Size(82, 110);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(532, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 50);
            textBox1.TabIndex = 2;
            textBox1.Text = "UserName.";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(532, 468);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(467, 50);
            textBox2.TabIndex = 3;
            textBox2.Text = "Password.";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(367, 793);
            button2.Name = "button2";
            button2.Size = new Size(216, 78);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(351, 330);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 53);
            label1.Name = "label1";
            label1.Size = new Size(1058, 108);
            label1.TabIndex = 7;
            label1.Text = "Welcome To Pharmacy";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(351, 433);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(158, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Enabled = false;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(351, 793);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(233, 78);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(918, 767);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(129, 114);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Enabled = false;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1307, 35);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(158, 135);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // gradiant_class2
            // 
            gradiant_class2.Angel = 60F;
            gradiant_class2.AutoSize = true;
            gradiant_class2.BackColor = Color.Transparent;
            gradiant_class2.BottomColor = Color.Black;
            gradiant_class2.Controls.Add(textBox2);
            gradiant_class2.Controls.Add(pictureBox6);
            gradiant_class2.Controls.Add(textBox1);
            gradiant_class2.Controls.Add(pictureBox7);
            gradiant_class2.Controls.Add(pictureBox5);
            gradiant_class2.Controls.Add(button2);
            gradiant_class2.Controls.Add(label1);
            gradiant_class2.Controls.Add(pictureBox4);
            gradiant_class2.Controls.Add(button1);
            gradiant_class2.Controls.Add(pictureBox3);
            gradiant_class2.Location = new Point(421, -5);
            gradiant_class2.Name = "gradiant_class2";
            gradiant_class2.Size = new Size(1511, 1090);
            gradiant_class2.TabIndex = 12;
            gradiant_class2.TopColor = Color.SteelBlue;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1920, 1057);
            Controls.Add(gradiant_class1);
            Controls.Add(gradiant_class2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            gradiant_class1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            gradiant_class2.ResumeLayout(false);
            gradiant_class2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Gradiant_class gradiant_class1;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Gradiant_class gradiant_class2;
        private Gradiant_class gradiant_class3;
    }
}