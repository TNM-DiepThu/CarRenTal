namespace CarRenTal.View.ViewLogin
{
    partial class ResetPassForm
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
            pn_resetPass = new Panel();
            cb_showPass = new CheckBox();
            bt_submit = new Button();
            bt_back = new Button();
            tx_rePass = new TextBox();
            tx_newPass = new TextBox();
            lb_pass = new Label();
            label2 = new Label();
            label1 = new Label();
            pn_resetPass.SuspendLayout();
            SuspendLayout();
            // 
            // pn_resetPass
            // 
            pn_resetPass.Controls.Add(cb_showPass);
            pn_resetPass.Controls.Add(bt_submit);
            pn_resetPass.Controls.Add(bt_back);
            pn_resetPass.Controls.Add(tx_rePass);
            pn_resetPass.Controls.Add(tx_newPass);
            pn_resetPass.Controls.Add(lb_pass);
            pn_resetPass.Controls.Add(label2);
            pn_resetPass.Controls.Add(label1);
            pn_resetPass.Location = new Point(0, 0);
            pn_resetPass.Name = "pn_resetPass";
            pn_resetPass.Size = new Size(571, 722);
            pn_resetPass.TabIndex = 3;
            // 
            // cb_showPass
            // 
            cb_showPass.AutoSize = true;
            cb_showPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cb_showPass.Location = new Point(71, 456);
            cb_showPass.Name = "cb_showPass";
            cb_showPass.Size = new Size(205, 32);
            cb_showPass.TabIndex = 3;
            cb_showPass.Text = "Hiển thị mật khẩu";
            cb_showPass.UseVisualStyleBackColor = true;
            cb_showPass.CheckedChanged += cb_showPass_CheckedChanged;
            // 
            // bt_submit
            // 
            bt_submit.BackColor = SystemColors.ScrollBar;
            bt_submit.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_submit.ForeColor = SystemColors.ControlText;
            bt_submit.Location = new Point(97, 517);
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(156, 58);
            bt_submit.TabIndex = 4;
            bt_submit.Text = "Cập nhật";
            bt_submit.UseVisualStyleBackColor = false;
            bt_submit.Click += bt_submit_Click;
            // 
            // bt_back
            // 
            bt_back.BackColor = SystemColors.ScrollBar;
            bt_back.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_back.ForeColor = SystemColors.ControlText;
            bt_back.Location = new Point(310, 517);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(156, 58);
            bt_back.TabIndex = 5;
            bt_back.Text = "Trở lại";
            bt_back.UseVisualStyleBackColor = false;
            bt_back.Click += bt_back_Click;
            // 
            // tx_rePass
            // 
            tx_rePass.BackColor = SystemColors.ScrollBar;
            tx_rePass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_rePass.Location = new Point(150, 395);
            tx_rePass.Name = "tx_rePass";
            tx_rePass.Size = new Size(316, 34);
            tx_rePass.TabIndex = 2;
            tx_rePass.UseSystemPasswordChar = true;
            // 
            // tx_newPass
            // 
            tx_newPass.BackColor = SystemColors.ScrollBar;
            tx_newPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_newPass.Location = new Point(150, 256);
            tx_newPass.Name = "tx_newPass";
            tx_newPass.Size = new Size(316, 34);
            tx_newPass.TabIndex = 1;
            tx_newPass.UseSystemPasswordChar = true;
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pass.Location = new Point(97, 333);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(199, 28);
            lb_pass.TabIndex = 3;
            lb_pass.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 199);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 2;
            label2.Text = "Nhập mật khẩu mới:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 72);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT MẬT KHẨU";
            // 
            // ResetPassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 675);
            Controls.Add(pn_resetPass);
            Name = "ResetPassForm";
            Text = "ResetPassForm";
            pn_resetPass.ResumeLayout(false);
            pn_resetPass.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_resetPass;
        private Button bt_submit;
        private Button bt_back;
        private TextBox tx_rePass;
        private TextBox tx_newPass;
        private Label lb_pass;
        private Label label2;
        private Label label1;
        private CheckBox cb_showPass;
    }
}