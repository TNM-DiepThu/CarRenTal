namespace CarRenTal
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
            pn_verify = new Panel();
            lb_timeDown = new Label();
            bt_continue = new Button();
            bt_back = new Button();
            tx_emaiOTP = new TextBox();
            tx_email = new TextBox();
            lb_forgotPass = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timerDown = new System.Windows.Forms.Timer(components);
            pn_verify.SuspendLayout();
            SuspendLayout();
            // 
            // pn_verify
            // 
            pn_verify.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pn_verify.BackColor = Color.White;
            pn_verify.Controls.Add(lb_timeDown);
            pn_verify.Controls.Add(bt_continue);
            pn_verify.Controls.Add(bt_back);
            pn_verify.Controls.Add(tx_emaiOTP);
            pn_verify.Controls.Add(tx_email);
            pn_verify.Controls.Add(lb_forgotPass);
            pn_verify.Controls.Add(label3);
            pn_verify.Controls.Add(label2);
            pn_verify.Controls.Add(label1);
            pn_verify.Location = new Point(0, 1);
            pn_verify.Name = "pn_verify";
            pn_verify.Size = new Size(519, 600);
            pn_verify.TabIndex = 5;
            // 
            // lb_timeDown
            // 
            lb_timeDown.AutoSize = true;
            lb_timeDown.ForeColor = SystemColors.HotTrack;
            lb_timeDown.Location = new Point(422, 423);
            lb_timeDown.Name = "lb_timeDown";
            lb_timeDown.Size = new Size(50, 20);
            lb_timeDown.TabIndex = 11;
            lb_timeDown.Text = "label4";
            lb_timeDown.Visible = false;
            // 
            // bt_continue
            // 
            bt_continue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_continue.BackColor = Color.LightGray;
            bt_continue.ImageAlign = ContentAlignment.TopRight;
            bt_continue.Location = new Point(44, 467);
            bt_continue.Name = "bt_continue";
            bt_continue.Size = new Size(179, 60);
            bt_continue.TabIndex = 10;
            bt_continue.Text = "Tiếp tục";
            bt_continue.UseVisualStyleBackColor = false;
            bt_continue.Click += bt_continue_Click;
            // 
            // bt_back
            // 
            bt_back.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_back.BackColor = Color.LightGray;
            bt_back.ImageAlign = ContentAlignment.TopRight;
            bt_back.Location = new Point(274, 467);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(179, 60);
            bt_back.TabIndex = 10;
            bt_back.Text = "Quay lại";
            bt_back.UseVisualStyleBackColor = false;
            bt_back.Click += bt_back_Click;
            // 
            // tx_emaiOTP
            // 
            tx_emaiOTP.BackColor = Color.LightGray;
            tx_emaiOTP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_emaiOTP.Location = new Point(123, 366);
            tx_emaiOTP.Name = "tx_emaiOTP";
            tx_emaiOTP.Size = new Size(286, 34);
            tx_emaiOTP.TabIndex = 9;
            // 
            // tx_email
            // 
            tx_email.BackColor = Color.LightGray;
            tx_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_email.Location = new Point(123, 246);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(282, 34);
            tx_email.TabIndex = 8;
            // 
            // lb_forgotPass
            // 
            lb_forgotPass.AutoSize = true;
            lb_forgotPass.Enabled = false;
            lb_forgotPass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_forgotPass.Location = new Point(325, 423);
            lb_forgotPass.Name = "lb_forgotPass";
            lb_forgotPass.Size = new Size(75, 20);
            lb_forgotPass.TabIndex = 4;
            lb_forgotPass.Text = "Nhận mã";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 321);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã xác minh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 191);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 6;
            label2.Text = "Email của bạn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 60);
            label1.Name = "label1";
            label1.Size = new Size(419, 51);
            label1.TabIndex = 7;
            label1.Text = "XÁC NHẬN EMAIL";
            // 
            // timerDown
            // 
            timerDown.Interval = 1000;
            // 
            // EmailVerifyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 603);
            Controls.Add(pn_verify);
            Name = "EmailVerifyForm";
            Text = "EmailVerifyForm";
            pn_verify.ResumeLayout(false);
            pn_verify.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_verify;
        private Label lb_timeDown;
        private Button bt_continue;
        private Button bt_back;
        private TextBox tx_emaiOTP;
        private TextBox tx_email;
        private Label lb_forgotPass;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timerDown;
    }
}