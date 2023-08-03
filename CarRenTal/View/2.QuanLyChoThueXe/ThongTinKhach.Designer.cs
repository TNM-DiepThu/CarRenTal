namespace CarRenTal.View._2.QuanLyChoThueXe
{
    partial class ThongTinKhach
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
            tx_sex = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tx_pNum = new TextBox();
            label4 = new Label();
            tx_vnID = new TextBox();
            label5 = new Label();
            tx_dob = new TextBox();
            label7 = new Label();
            tx_name = new TextBox();
            bt_ok = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 176);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Giới tính";
            // 
            // tx_sex
            // 
            tx_sex.Location = new Point(166, 176);
            tx_sex.Name = "tx_sex";
            tx_sex.ReadOnly = true;
            tx_sex.Size = new Size(273, 27);
            tx_sex.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 40);
            label2.Name = "label2";
            label2.Size = new Size(249, 31);
            label2.TabIndex = 0;
            label2.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 251);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại";
            // 
            // tx_pNum
            // 
            tx_pNum.Location = new Point(166, 251);
            tx_pNum.Name = "tx_pNum";
            tx_pNum.ReadOnly = true;
            tx_pNum.Size = new Size(273, 27);
            tx_pNum.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 326);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 0;
            label4.Text = "Số căn cước";
            // 
            // tx_vnID
            // 
            tx_vnID.Location = new Point(166, 326);
            tx_vnID.Name = "tx_vnID";
            tx_vnID.ReadOnly = true;
            tx_vnID.Size = new Size(273, 27);
            tx_vnID.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 401);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh";
            // 
            // tx_dob
            // 
            tx_dob.Location = new Point(166, 401);
            tx_dob.Name = "tx_dob";
            tx_dob.ReadOnly = true;
            tx_dob.Size = new Size(273, 27);
            tx_dob.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 101);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Họ và tên";
            // 
            // tx_name
            // 
            tx_name.Location = new Point(166, 101);
            tx_name.Name = "tx_name";
            tx_name.ReadOnly = true;
            tx_name.Size = new Size(273, 27);
            tx_name.TabIndex = 1;
            // 
            // bt_ok
            // 
            bt_ok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ok.Location = new Point(249, 484);
            bt_ok.Name = "bt_ok";
            bt_ok.Size = new Size(190, 67);
            bt_ok.TabIndex = 2;
            bt_ok.Text = "OK";
            bt_ok.UseVisualStyleBackColor = true;
            bt_ok.Click += bt_ok_Click;
            // 
            // ThongTinKhach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 572);
            Controls.Add(bt_ok);
            Controls.Add(tx_name);
            Controls.Add(label7);
            Controls.Add(tx_dob);
            Controls.Add(tx_vnID);
            Controls.Add(label5);
            Controls.Add(tx_pNum);
            Controls.Add(label4);
            Controls.Add(tx_sex);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongTinKhach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongTinKhach";
            Load += ThongTinKhach_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_sex;
        private Label label2;
        private Label label3;
        private TextBox tx_pNum;
        private Label label4;
        private TextBox tx_vnID;
        private Label label5;
        private TextBox tx_dob;
        private Label label7;
        private TextBox tx_name;
        private Button bt_ok;
    }
}