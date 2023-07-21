namespace CarRenTal.View
{
    partial class Login
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
            pn_login = new Panel();
            bt_Login = new Button();
            tx_pass = new TextBox();
            tx_user = new TextBox();
            lb_forgotPass = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pn_login.SuspendLayout();
            SuspendLayout();
            // 
            // pn_login
            // 
            pn_login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pn_login.BackColor = Color.White;
            pn_login.Controls.Add(bt_Login);
            pn_login.Controls.Add(tx_pass);
            pn_login.Controls.Add(tx_user);
            pn_login.Controls.Add(lb_forgotPass);
            pn_login.Controls.Add(label3);
            pn_login.Controls.Add(label2);
            pn_login.Controls.Add(label1);
            pn_login.Location = new Point(1, 1);
            pn_login.Name = "pn_login";
            pn_login.Size = new Size(519, 600);
            pn_login.TabIndex = 4;
            // 
            // bt_Login
            // 
            bt_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Login.BackColor = Color.LightGray;
            bt_Login.ImageAlign = ContentAlignment.TopRight;
            bt_Login.Location = new Point(167, 467);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(179, 60);
            bt_Login.TabIndex = 10;
            bt_Login.Text = "Đăng nhập";
            bt_Login.UseVisualStyleBackColor = false;
            // 
            // tx_pass
            // 
            tx_pass.BackColor = Color.LightGray;
            tx_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_pass.Location = new Point(123, 366);
            tx_pass.Name = "tx_pass";
            tx_pass.PasswordChar = '*';
            tx_pass.Size = new Size(286, 34);
            tx_pass.TabIndex = 9;
            // 
            // tx_user
            // 
            tx_user.BackColor = Color.LightGray;
            tx_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_user.Location = new Point(123, 246);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(282, 34);
            tx_user.TabIndex = 8;
            // 
            // lb_forgotPass
            // 
            lb_forgotPass.AutoSize = true;
            lb_forgotPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_forgotPass.Location = new Point(296, 423);
            lb_forgotPass.Name = "lb_forgotPass";
            lb_forgotPass.Size = new Size(130, 20);
            lb_forgotPass.TabIndex = 4;
            lb_forgotPass.Text = "&Quên mật khẩu";
            lb_forgotPass.Click += lb_forgotPass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 321);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 191);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 60);
            label1.Name = "label1";
            label1.Size = new Size(287, 51);
            label1.TabIndex = 7;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 603);
            Controls.Add(pn_login);
            MaximizeBox = false;
            MaximumSize = new Size(537, 650);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(537, 650);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pn_login.ResumeLayout(false);
            pn_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_login;
        private Button bt_Login;
        private TextBox tx_pass;
        private TextBox tx_user;
        private Label lb_forgotPass;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}