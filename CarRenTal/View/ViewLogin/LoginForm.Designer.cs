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
            label1.Location = new Point(180, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 46);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pass.Location = new Point(111, 325);
            lb_pass.Margin = new Padding(4, 0, 4, 0);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(107, 28);
            lb_pass.TabIndex = 3;
            lb_pass.Text = "Mật khẩu:";
            // 
            // lb_forgotPass
            // 
            lb_forgotPass.AutoSize = true;
            lb_forgotPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_forgotPass.Location = new Point(292, 467);
            lb_forgotPass.Margin = new Padding(4, 0, 4, 0);
            lb_forgotPass.Name = "lb_forgotPass";
            lb_forgotPass.Size = new Size(157, 28);
            lb_forgotPass.TabIndex = 4;
            lb_forgotPass.Text = "Quên mật khẩu";
            lb_forgotPass.Click += lb_forgotPass_Click;
            // 
            // tx_user
            // 
            tx_user.BackColor = SystemColors.ScrollBar;
            tx_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_user.Location = new Point(111, 243);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(348, 34);
            tx_user.TabIndex = 1;
            // 
            // tx_pass
            // 
            tx_pass.BackColor = SystemColors.ScrollBar;
            tx_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_pass.Location = new Point(111, 373);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(348, 34);
            tx_pass.TabIndex = 2;
            tx_pass.UseSystemPasswordChar = true;
            // 
            // bt_login
            // 
            bt_login.BackColor = SystemColors.ScrollBar;
            bt_login.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_login.ForeColor = SystemColors.ControlText;
            bt_login.Location = new Point(180, 538);
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
            pn_login.Paint += pn_login_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 722);
            Controls.Add(pn_login);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            pn_login.ResumeLayout(false);
            pn_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label lb_pass;
        public Label lb_forgotPass;
        public TextBox tx_user;
        public TextBox tx_pass;
        public Button bt_login;
        public Panel pn_login;
    }
}