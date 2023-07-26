namespace CarRenTal.View._5._QuanLyKhachHang
{
    partial class TTKHchiTiet
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
            btnCreate = new Button();
            textBox7 = new TextBox();
            cbbThietBi = new ComboBox();
            groupBox1 = new GroupBox();
            grbCam = new GroupBox();
            btnTurnOffCam = new Button();
            btnTurnOnCam = new Button();
            btnCheckQrNT = new Button();
            btnCheckQrKH = new Button();
            picBQuetMa = new PictureBox();
            label16 = new Label();
            btnExit = new Button();
            btnResetNT = new Button();
            btnResetKH = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox11 = new TextBox();
            label13 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtSdtKH = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtDiaChiKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCCCDKH = new TextBox();
            label4 = new Label();
            txtHoTenKH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpNgaySinhKh = new DateTimePicker();
            dtpNgaySinhNT = new DateTimePicker();
            cbbGioiTinhKH = new ComboBox();
            cbbGioiTinhNT = new ComboBox();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            grbCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBQuetMa).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(784, 895);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 67;
            btnCreate.Text = "Thêm";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(869, 765);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(283, 31);
            textBox7.TabIndex = 64;
            // 
            // cbbThietBi
            // 
            cbbThietBi.FormattingEnabled = true;
            cbbThietBi.Location = new Point(36, 85);
            cbbThietBi.Name = "cbbThietBi";
            cbbThietBi.Size = new Size(336, 33);
            cbbThietBi.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grbCam);
            groupBox1.Controls.Add(btnCheckQrNT);
            groupBox1.Controls.Add(btnCheckQrKH);
            groupBox1.Controls.Add(picBQuetMa);
            groupBox1.Controls.Add(cbbThietBi);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(26, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 578);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quét QR Code";
            // 
            // grbCam
            // 
            grbCam.Controls.Add(btnTurnOffCam);
            grbCam.Controls.Add(btnTurnOnCam);
            grbCam.Location = new Point(36, 143);
            grbCam.Name = "grbCam";
            grbCam.Size = new Size(330, 82);
            grbCam.TabIndex = 70;
            grbCam.TabStop = false;
            grbCam.Text = "Camera";
            // 
            // btnTurnOffCam
            // 
            btnTurnOffCam.Location = new Point(212, 30);
            btnTurnOffCam.Name = "btnTurnOffCam";
            btnTurnOffCam.Size = new Size(112, 34);
            btnTurnOffCam.TabIndex = 40;
            btnTurnOffCam.Text = "Tắt";
            btnTurnOffCam.UseVisualStyleBackColor = true;
            // 
            // btnTurnOnCam
            // 
            btnTurnOnCam.Location = new Point(78, 30);
            btnTurnOnCam.Name = "btnTurnOnCam";
            btnTurnOnCam.Size = new Size(112, 34);
            btnTurnOnCam.TabIndex = 39;
            btnTurnOnCam.Text = "Bật ";
            btnTurnOnCam.UseVisualStyleBackColor = true;
            // 
            // btnCheckQrNT
            // 
            btnCheckQrNT.Location = new Point(216, 527);
            btnCheckQrNT.Name = "btnCheckQrNT";
            btnCheckQrNT.Size = new Size(150, 33);
            btnCheckQrNT.TabIndex = 42;
            btnCheckQrNT.Text = "Người thân";
            btnCheckQrNT.UseVisualStyleBackColor = true;
            // 
            // btnCheckQrKH
            // 
            btnCheckQrKH.Location = new Point(46, 527);
            btnCheckQrKH.Name = "btnCheckQrKH";
            btnCheckQrKH.Size = new Size(150, 33);
            btnCheckQrKH.TabIndex = 41;
            btnCheckQrKH.Text = "Khách hàng";
            btnCheckQrKH.UseVisualStyleBackColor = true;
            // 
            // picBQuetMa
            // 
            picBQuetMa.Location = new Point(36, 247);
            picBQuetMa.Name = "picBQuetMa";
            picBQuetMa.Size = new Size(330, 249);
            picBQuetMa.TabIndex = 38;
            picBQuetMa.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(36, 38);
            label16.Name = "label16";
            label16.Size = new Size(114, 25);
            label16.TabIndex = 36;
            label16.Text = "Chọn thiết bị";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1040, 895);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 68;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnResetNT
            // 
            btnResetNT.Location = new Point(1040, 819);
            btnResetNT.Name = "btnResetNT";
            btnResetNT.Size = new Size(112, 34);
            btnResetNT.TabIndex = 66;
            btnResetNT.Text = "Nhập lại";
            btnResetNT.UseVisualStyleBackColor = true;
            // 
            // btnResetKH
            // 
            btnResetKH.Location = new Point(676, 819);
            btnResetKH.Name = "btnResetKH";
            btnResetKH.Size = new Size(112, 34);
            btnResetKH.TabIndex = 65;
            btnResetKH.Text = "Nhập lại";
            btnResetKH.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(869, 718);
            label9.Name = "label9";
            label9.Size = new Size(117, 25);
            label9.TabIndex = 63;
            label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(869, 618);
            label10.Name = "label10";
            label10.Size = new Size(91, 25);
            label10.TabIndex = 61;
            label10.Text = "Ngày sinh";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(869, 565);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(283, 31);
            textBox9.TabIndex = 60;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(869, 518);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 59;
            label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(869, 418);
            label12.Name = "label12";
            label12.Size = new Size(78, 25);
            label12.TabIndex = 57;
            label12.Text = "Giới tính";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(869, 365);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(283, 31);
            textBox11.TabIndex = 56;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(869, 318);
            label13.Name = "label13";
            label13.Size = new Size(166, 25);
            label13.TabIndex = 55;
            label13.Text = "Số CCCD/PassProst";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(869, 265);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(283, 31);
            textBox12.TabIndex = 54;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(869, 218);
            label14.Name = "label14";
            label14.Size = new Size(89, 25);
            label14.TabIndex = 53;
            label14.Text = "Họ và tên";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(869, 157);
            label15.Name = "label15";
            label15.Size = new Size(300, 38);
            label15.TabIndex = 52;
            label15.Text = "Thông tin người thân";
            // 
            // txtSdtKH
            // 
            txtSdtKH.Location = new Point(505, 765);
            txtSdtKH.Name = "txtSdtKH";
            txtSdtKH.Size = new Size(283, 31);
            txtSdtKH.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 718);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 50;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(505, 618);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 48;
            label7.Text = "Ngày sinh";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(505, 565);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(283, 31);
            txtDiaChiKH.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 518);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 46;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 418);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 44;
            label5.Text = "Giới tính";
            // 
            // txtCCCDKH
            // 
            txtCCCDKH.Location = new Point(505, 365);
            txtCCCDKH.Name = "txtCCCDKH";
            txtCCCDKH.Size = new Size(283, 31);
            txtCCCDKH.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 318);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 42;
            label4.Text = "Số CCCD/PassProst";
            // 
            // txtHoTenKH
            // 
            txtHoTenKH.Location = new Point(505, 265);
            txtHoTenKH.Name = "txtHoTenKH";
            txtHoTenKH.Size = new Size(283, 31);
            txtHoTenKH.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 218);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 40;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(505, 157);
            label2.Name = "label2";
            label2.Size = new Size(305, 38);
            label2.TabIndex = 39;
            label2.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(422, 39);
            label1.Name = "label1";
            label1.Size = new Size(496, 49);
            label1.TabIndex = 38;
            label1.Text = "Chi tiết thông tin khách hàng";
            // 
            // dtpNgaySinhKh
            // 
            dtpNgaySinhKh.Location = new Point(505, 664);
            dtpNgaySinhKh.Name = "dtpNgaySinhKh";
            dtpNgaySinhKh.Size = new Size(276, 31);
            dtpNgaySinhKh.TabIndex = 70;
            // 
            // dtpNgaySinhNT
            // 
            dtpNgaySinhNT.Location = new Point(876, 664);
            dtpNgaySinhNT.Name = "dtpNgaySinhNT";
            dtpNgaySinhNT.Size = new Size(276, 31);
            dtpNgaySinhNT.TabIndex = 71;
            // 
            // cbbGioiTinhKH
            // 
            cbbGioiTinhKH.FormattingEnabled = true;
            cbbGioiTinhKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinhKH.Location = new Point(510, 465);
            cbbGioiTinhKH.Name = "cbbGioiTinhKH";
            cbbGioiTinhKH.Size = new Size(278, 33);
            cbbGioiTinhKH.TabIndex = 72;
            cbbGioiTinhKH.SelectedIndexChanged += cbbGioiTinhKH_SelectedIndexChanged;
            // 
            // cbbGioiTinhNT
            // 
            cbbGioiTinhNT.FormattingEnabled = true;
            cbbGioiTinhNT.Location = new Point(869, 465);
            cbbGioiTinhNT.Name = "cbbGioiTinhNT";
            cbbGioiTinhNT.Size = new Size(278, 33);
            cbbGioiTinhNT.TabIndex = 73;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(913, 895);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 74;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // TTKHchiTiet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 968);
            Controls.Add(btnUpdate);
            Controls.Add(cbbGioiTinhNT);
            Controls.Add(cbbGioiTinhKH);
            Controls.Add(dtpNgaySinhNT);
            Controls.Add(dtpNgaySinhKh);
            Controls.Add(btnCreate);
            Controls.Add(textBox7);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnResetNT);
            Controls.Add(btnResetKH);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox11);
            Controls.Add(label13);
            Controls.Add(textBox12);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtSdtKH);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtDiaChiKH);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCCCDKH);
            Controls.Add(label4);
            Controls.Add(txtHoTenKH);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TTKHchiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin khách hàng chi tiết";
            Load += TTKHchiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbCam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBQuetMa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox textBox7;
        private ComboBox cbbThietBi;
        private GroupBox groupBox1;
        private GroupBox grbCam;
        private Button btnTurnOffCam;
        private Button btnTurnOnCam;
        private Button btnCheckQrNT;
        private Button btnCheckQrKH;
        private PictureBox picBQuetMa;
        private Label label16;
        private Button btnExit;
        private Button btnResetNT;
        private Button btnResetKH;
        private Label label9;
        private Label label10;
        private TextBox textBox9;
        private Label label11;
        private Label label12;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox12;
        private Label label14;
        private Label label15;
        private TextBox txtSdtKH;
        private Label label8;
        private Label label7;
        private TextBox txtDiaChiKH;
        private Label label6;
        private Label label5;
        private TextBox txtCCCDKH;
        private Label label4;
        private TextBox txtHoTenKH;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgaySinhKh;
        private DateTimePicker dtpNgaySinhNT;
        private ComboBox cbbGioiTinhKH;
        private ComboBox cbbGioiTinhNT;
        private Button btnUpdate;
    }
}