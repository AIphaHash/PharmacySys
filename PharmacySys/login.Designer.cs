namespace PharmacySys
{
    partial class login
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
            gradiant_class1 = new Gradiant_class();
            SuspendLayout();
            // 
            // gradiant_class1
            // 
            gradiant_class1.Angel = 0F;
            gradiant_class1.BottomColor = Color.Black;
            gradiant_class1.Location = new Point(-6, -6);
            gradiant_class1.Name = "gradiant_class1";
            gradiant_class1.Size = new Size(1919, 1054);
            gradiant_class1.TabIndex = 0;
            gradiant_class1.TopColor = Color.Gray;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(gradiant_class1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Gradiant_class gradiant_class1;
    }
}