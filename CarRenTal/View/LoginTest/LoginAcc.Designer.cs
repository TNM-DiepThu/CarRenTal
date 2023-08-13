namespace CarRenTal.View.LoginTest
{
    partial class LoginAcc
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_png_car_front_png_image_32725_17001;
            pictureBox1.Location = new Point(131, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(190, 212);
            label1.Name = "label1";
            label1.Size = new Size(156, 54);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(54, 360);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Location = new Point(54, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Location = new Point(54, 515);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.synchronize;
            pictureBox3.Location = new Point(54, 459);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(54, 612);
            button1.Name = "button1";
            button1.Size = new Size(410, 58);
            button1.TabIndex = 6;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(178, 699);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 7;
            label2.Text = "Create an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(331, 553);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 8;
            label3.Text = "Reset PassWord";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.AutoCompleteCustomSource.AddRange(new string[] { "Enter PassWord" });
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(110, 377);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 33);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.AutoCompleteCustomSource.AddRange(new string[] { "Enter PassWord" });
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(110, 477);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 32);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // LoginAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 747);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAcc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginAcc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}