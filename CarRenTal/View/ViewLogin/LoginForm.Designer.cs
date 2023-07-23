namespace CarRenTal.View.ViewLogin
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            lb_pass = new Label();
            lb_forgotPass = new Label();
            tx_user = new TextBox();
            tx_pass = new TextBox();
            bt_login = new Button();
            pn_login = new Panel();
            pn_login.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(235, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pass.Location = new Point(111, 410);
            lb_pass.Margin = new Padding(4, 0, 4, 0);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(128, 32);
            lb_pass.TabIndex = 3;
            lb_pass.Text = "Mật khẩu:";
            // 
            // lb_forgotPass
            // 
            lb_forgotPass.AutoSize = true;
            lb_forgotPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_forgotPass.Location = new Point(395, 596);
            lb_forgotPass.Margin = new Padding(4, 0, 4, 0);
            lb_forgotPass.Name = "lb_forgotPass";
            lb_forgotPass.Size = new Size(188, 32);
            lb_forgotPass.TabIndex = 4;
            lb_forgotPass.Text = "Quên mật khẩu";
            lb_forgotPass.Click += lb_forgotPass_Click;
            // 
            // tx_user
            // 
            tx_user.BackColor = SystemColors.ScrollBar;
            tx_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_user.Location = new Point(142, 251);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(316, 34);
            tx_user.TabIndex = 1;
            // 
            // tx_pass
            // 
            tx_pass.BackColor = SystemColors.ScrollBar;
            tx_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_pass.Location = new Point(142, 379);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(316, 34);
            tx_pass.TabIndex = 2;
            tx_pass.UseSystemPasswordChar = true;
            // 
            // bt_login
            // 
            bt_login.BackColor = SystemColors.ScrollBar;
            bt_login.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_login.ForeColor = SystemColors.ControlText;
            bt_login.Location = new Point(188, 536);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(190, 71);
            bt_login.TabIndex = 3;
            bt_login.Text = "Đăng nhập";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // pn_login
            // 
            pn_login.Controls.Add(bt_login);
            pn_login.Controls.Add(tx_pass);
            pn_login.Controls.Add(tx_user);
            pn_login.Controls.Add(lb_forgotPass);
            pn_login.Controls.Add(lb_pass);
            pn_login.Controls.Add(label2);
            pn_login.Controls.Add(label1);
            pn_login.Location = new Point(2, 1);
            pn_login.Name = "pn_login";
            pn_login.Size = new Size(571, 722);
            pn_login.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 675);
            Controls.Add(pn_login);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            pn_login.ResumeLayout(false);
            pn_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_pass;
        private Label lb_forgotPass;
        private TextBox tx_user;
        private TextBox tx_pass;
        private Button bt_login;
        private Panel pn_login;
    }
}