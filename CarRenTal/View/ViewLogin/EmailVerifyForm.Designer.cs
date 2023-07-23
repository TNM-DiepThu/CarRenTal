namespace CarRenTal.View.ViewLogin
{
    partial class EmailVerifyForm
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
            pn_emailVerify = new Panel();
            lb_time = new Label();
            lb_sendOTP = new Label();
            bt_continue = new Button();
            bt_return = new Button();
            tx_emailOTP = new TextBox();
            tx_email = new TextBox();
            lb_pass = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pn_emailVerify.SuspendLayout();
            SuspendLayout();
            // 
            // pn_emailVerify
            // 
            pn_emailVerify.Controls.Add(lb_time);
            pn_emailVerify.Controls.Add(lb_sendOTP);
            pn_emailVerify.Controls.Add(bt_continue);
            pn_emailVerify.Controls.Add(bt_return);
            pn_emailVerify.Controls.Add(tx_emailOTP);
            pn_emailVerify.Controls.Add(tx_email);
            pn_emailVerify.Controls.Add(lb_pass);
            pn_emailVerify.Controls.Add(label2);
            pn_emailVerify.Controls.Add(label1);
            pn_emailVerify.Location = new Point(0, 0);
            pn_emailVerify.Name = "pn_emailVerify";
            pn_emailVerify.Size = new Size(571, 722);
            pn_emailVerify.TabIndex = 2;
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.ForeColor = SystemColors.MenuHighlight;
            lb_time.Location = new Point(422, 455);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(50, 20);
            lb_time.TabIndex = 7;
            lb_time.Text = "label3";
            lb_time.Visible = false;
            // 
            // lb_sendOTP
            // 
            lb_sendOTP.AutoSize = true;
            lb_sendOTP.Enabled = false;
            lb_sendOTP.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sendOTP.Location = new Point(330, 450);
            lb_sendOTP.Name = "lb_sendOTP";
            lb_sendOTP.Size = new Size(86, 25);
            lb_sendOTP.TabIndex = 7;
            lb_sendOTP.Text = "Nhận mã";
            lb_sendOTP.Click += lb_sendOTP_Click;
            // 
            // bt_continue
            // 
            bt_continue.BackColor = SystemColors.ScrollBar;
            bt_continue.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_continue.ForeColor = SystemColors.ControlText;
            bt_continue.Location = new Point(90, 489);
            bt_continue.Name = "bt_continue";
            bt_continue.Size = new Size(177, 64);
            bt_continue.TabIndex = 3;
            bt_continue.Text = "Tiếp tục";
            bt_continue.UseVisualStyleBackColor = false;
            bt_continue.Click += bt_continue_Click;
            // 
            // bt_return
            // 
            bt_return.BackColor = SystemColors.ScrollBar;
            bt_return.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_return.ForeColor = SystemColors.ControlText;
            bt_return.Location = new Point(295, 489);
            bt_return.Name = "bt_return";
            bt_return.Size = new Size(177, 64);
            bt_return.TabIndex = 4;
            bt_return.Text = "Trở lại";
            bt_return.UseVisualStyleBackColor = false;
            bt_return.Click += bt_return_Click;
            // 
            // tx_emailOTP
            // 
            tx_emailOTP.BackColor = SystemColors.ScrollBar;
            tx_emailOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_emailOTP.Location = new Point(122, 390);
            tx_emailOTP.Name = "tx_emailOTP";
            tx_emailOTP.Size = new Size(316, 34);
            tx_emailOTP.TabIndex = 2;
            // 
            // tx_email
            // 
            tx_email.BackColor = SystemColors.ScrollBar;
            tx_email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_email.Location = new Point(122, 251);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(316, 34);
            tx_email.TabIndex = 1;
            tx_email.TextChanged += tx_email_TextChanged;
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pass.Location = new Point(69, 328);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(139, 28);
            lb_pass.TabIndex = 3;
            lb_pass.Text = "Mã xác minh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 194);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 2;
            label2.Text = "Email của bạn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 78);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 1;
            label1.Text = "XÁC NHẬN EMAIL";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // EmailVerifyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 675);
            Controls.Add(pn_emailVerify);
            Name = "EmailVerifyForm";
            Text = "EmailVerifyForm";
            pn_emailVerify.ResumeLayout(false);
            pn_emailVerify.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_emailVerify;
        private Button bt_continue;
        private Button bt_return;
        private TextBox tx_emailOTP;
        private TextBox tx_email;
        private Label lb_pass;
        private Label label2;
        private Label label1;
        private Label lb_time;
        private Label lb_sendOTP;
        private System.Windows.Forms.Timer timer1;
    }
}