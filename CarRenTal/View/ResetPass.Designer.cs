namespace CarRenTal.View
{
    partial class ResetPass
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
            pn_rePass = new Panel();
            cb_showPas = new CheckBox();
            bt_save = new Button();
            bt_cancel = new Button();
            tx_rePass = new TextBox();
            tx_newPass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pn_rePass.SuspendLayout();
            SuspendLayout();
            // 
            // pn_rePass
            // 
            pn_rePass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pn_rePass.BackColor = Color.White;
            pn_rePass.Controls.Add(cb_showPas);
            pn_rePass.Controls.Add(bt_save);
            pn_rePass.Controls.Add(bt_cancel);
            pn_rePass.Controls.Add(tx_rePass);
            pn_rePass.Controls.Add(tx_newPass);
            pn_rePass.Controls.Add(label3);
            pn_rePass.Controls.Add(label2);
            pn_rePass.Controls.Add(label1);
            pn_rePass.Location = new Point(1, 1);
            pn_rePass.Name = "pn_rePass";
            pn_rePass.Size = new Size(519, 600);
            pn_rePass.TabIndex = 5;
            // 
            // cb_showPas
            // 
            cb_showPas.AutoSize = true;
            cb_showPas.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cb_showPas.Location = new Point(72, 421);
            cb_showPas.Name = "cb_showPas";
            cb_showPas.Size = new Size(173, 24);
            cb_showPas.TabIndex = 12;
            cb_showPas.Text = "Hiển thị mật khẩu";
            cb_showPas.UseVisualStyleBackColor = true;
            cb_showPas.CheckedChanged += cb_showPas_CheckedChanged;
            // 
            // bt_save
            // 
            bt_save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_save.BackColor = Color.LightGray;
            bt_save.ImageAlign = ContentAlignment.TopRight;
            bt_save.Location = new Point(49, 467);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(179, 60);
            bt_save.TabIndex = 10;
            bt_save.Text = "Xác nhận";
            bt_save.UseVisualStyleBackColor = false;
            bt_save.Click += bt_save_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_cancel.BackColor = Color.LightGray;
            bt_cancel.ImageAlign = ContentAlignment.TopRight;
            bt_cancel.Location = new Point(279, 467);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(179, 60);
            bt_cancel.TabIndex = 10;
            bt_cancel.Text = "Hủy";
            bt_cancel.UseVisualStyleBackColor = false;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // tx_rePass
            // 
            tx_rePass.BackColor = Color.LightGray;
            tx_rePass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_rePass.Location = new Point(123, 366);
            tx_rePass.Name = "tx_rePass";
            tx_rePass.Size = new Size(286, 34);
            tx_rePass.TabIndex = 9;
            tx_rePass.UseSystemPasswordChar = true;
            // 
            // tx_newPass
            // 
            tx_newPass.BackColor = Color.LightGray;
            tx_newPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_newPass.Location = new Point(123, 246);
            tx_newPass.Name = "tx_newPass";
            tx_newPass.Size = new Size(282, 34);
            tx_newPass.TabIndex = 8;
            tx_newPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 321);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 191);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 63);
            label1.Name = "label1";
            label1.Size = new Size(362, 51);
            label1.TabIndex = 7;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 553);
            Controls.Add(pn_rePass);
            Name = "ResetPass";
            Text = "ResetPass";
            pn_rePass.ResumeLayout(false);
            pn_rePass.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_rePass;
        private Button bt_cancel;
        private TextBox tx_rePass;
        private TextBox tx_newPass;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_save;
        private CheckBox cb_showPas;
    }
}