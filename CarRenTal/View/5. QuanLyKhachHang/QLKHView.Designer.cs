namespace CarRenTal.View._5._QuanLyKhachHang
{
    partial class QLKHView
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
            dgvQLKH = new DataGridView();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            groupBox1 = new GroupBox();
            txtSdtKH = new TextBox();
            label8 = new Label();
            cbbGioiTinhKH = new ComboBox();
            dtpNgaySinhKh = new DateTimePicker();
            label7 = new Label();
            txtDiaChiKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtCCCDKH = new TextBox();
            label4 = new Label();
            txtHoTenKH = new TextBox();
            label3 = new Label();
            btnCreate = new Button();
            groupBox2 = new GroupBox();
            textIDkh = new Label();
            btnClear = new Button();
            btnUpdate2 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnClearTTTN = new Button();
            txtIDNT = new Label();
            btnCreateTn = new Button();
            btnUpdateTn = new Button();
            txtDiaChiTn = new TextBox();
            txtCCCDTn = new TextBox();
            label12 = new Label();
            txtSDTTn = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cbbGioiTinhTN = new ComboBox();
            txtHoTenTn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbSoLuongXe = new Label();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            lbTongTienKhachThue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQLKH
            // 
            dgvQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKH.Location = new Point(12, 393);
            dgvQLKH.Name = "dgvQLKH";
            dgvQLKH.RowHeadersWidth = 62;
            dgvQLKH.RowTemplate.Height = 33;
            dgvQLKH.Size = new Size(997, 379);
            dgvQLKH.TabIndex = 31;
            dgvQLKH.CellClick += dgvQLKH_CellClick;
            dgvQLKH.CellContentClick += dgvQLKH_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(62, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(536, 27);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1018, 727);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 45);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Người thân";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSdtKH);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbbGioiTinhKH);
            groupBox1.Controls.Add(dtpNgaySinhKh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDiaChiKH);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCCCDKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoTenKH);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(30, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 217);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtSdtKH
            // 
            txtSdtKH.Location = new Point(676, 159);
            txtSdtKH.Name = "txtSdtKH";
            txtSdtKH.Size = new Size(276, 27);
            txtSdtKH.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(638, 119);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 78;
            label8.Text = "Số điện thoại";
            // 
            // cbbGioiTinhKH
            // 
            cbbGioiTinhKH.FormattingEnabled = true;
            cbbGioiTinhKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinhKH.Location = new Point(359, 70);
            cbbGioiTinhKH.Name = "cbbGioiTinhKH";
            cbbGioiTinhKH.Size = new Size(278, 28);
            cbbGioiTinhKH.TabIndex = 77;
            // 
            // dtpNgaySinhKh
            // 
            dtpNgaySinhKh.Format = DateTimePickerFormat.Short;
            dtpNgaySinhKh.Location = new Point(676, 68);
            dtpNgaySinhKh.Name = "dtpNgaySinhKh";
            dtpNgaySinhKh.Size = new Size(276, 27);
            dtpNgaySinhKh.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(638, 27);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 75;
            label7.Text = "Ngày sinh";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(354, 159);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(283, 27);
            txtDiaChiKH.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 119);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 73;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 27);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 49;
            label5.Text = "Giới tính";
            // 
            // txtCCCDKH
            // 
            txtCCCDKH.Location = new Point(18, 159);
            txtCCCDKH.Name = "txtCCCDKH";
            txtCCCDKH.Size = new Size(283, 27);
            txtCCCDKH.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 119);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 47;
            label4.Text = "Số CCCD";
            // 
            // txtHoTenKH
            // 
            txtHoTenKH.Location = new Point(18, 72);
            txtHoTenKH.Name = "txtHoTenKH";
            txtHoTenKH.Size = new Size(283, 27);
            txtHoTenKH.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 27);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 45;
            label3.Text = "Họ và tên";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(164, 95);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(147, 44);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Thêm";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Visible = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textIDkh);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Controls.Add(btnUpdate2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(31, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(978, 145);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // textIDkh
            // 
            textIDkh.AutoSize = true;
            textIDkh.Location = new Point(24, 108);
            textIDkh.Name = "textIDkh";
            textIDkh.Size = new Size(64, 20);
            textIDkh.TabIndex = 4;
            textIDkh.Text = "textIDkh";
            textIDkh.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(17, 46);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 44);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate2
            // 
            btnUpdate2.Location = new Point(164, 46);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(147, 44);
            btnUpdate2.TabIndex = 2;
            btnUpdate2.Text = "Cập nhật";
            btnUpdate2.UseVisualStyleBackColor = true;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(353, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(605, 70);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnClearTTTN);
            groupBox4.Controls.Add(txtIDNT);
            groupBox4.Controls.Add(btnCreateTn);
            groupBox4.Controls.Add(btnUpdateTn);
            groupBox4.Controls.Add(txtDiaChiTn);
            groupBox4.Controls.Add(txtCCCDTn);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtSDTTn);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cbbGioiTinhTN);
            groupBox4.Controls.Add(txtHoTenTn);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(1015, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(461, 375);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            groupBox4.Text = "Người thân";
            // 
            // btnClearTTTN
            // 
            btnClearTTTN.Location = new Point(52, 319);
            btnClearTTTN.Name = "btnClearTTTN";
            btnClearTTTN.Size = new Size(147, 44);
            btnClearTTTN.TabIndex = 5;
            btnClearTTTN.Text = "Clear";
            btnClearTTTN.UseVisualStyleBackColor = true;
            btnClearTTTN.Click += btnClearTTTN_Click;
            // 
            // txtIDNT
            // 
            txtIDNT.AutoSize = true;
            txtIDNT.Location = new Point(322, 27);
            txtIDNT.Name = "txtIDNT";
            txtIDNT.Size = new Size(68, 20);
            txtIDNT.TabIndex = 5;
            txtIDNT.Text = "textIDNT";
            txtIDNT.Visible = false;
            // 
            // btnCreateTn
            // 
            btnCreateTn.Location = new Point(88, 206);
            btnCreateTn.Name = "btnCreateTn";
            btnCreateTn.Size = new Size(157, 44);
            btnCreateTn.TabIndex = 80;
            btnCreateTn.Text = "Thêm";
            btnCreateTn.UseVisualStyleBackColor = true;
            btnCreateTn.Visible = false;
            btnCreateTn.Click += btnCreateTn_Click;
            // 
            // btnUpdateTn
            // 
            btnUpdateTn.Location = new Point(265, 319);
            btnUpdateTn.Name = "btnUpdateTn";
            btnUpdateTn.Size = new Size(147, 44);
            btnUpdateTn.TabIndex = 4;
            btnUpdateTn.Text = "Cập nhật";
            btnUpdateTn.UseVisualStyleBackColor = true;
            btnUpdateTn.Click += btnUpdateTn_Click;
            // 
            // txtDiaChiTn
            // 
            txtDiaChiTn.Location = new Point(25, 260);
            txtDiaChiTn.Name = "txtDiaChiTn";
            txtDiaChiTn.Size = new Size(420, 27);
            txtDiaChiTn.TabIndex = 81;
            txtDiaChiTn.TextChanged += textBox4_TextChanged;
            // 
            // txtCCCDTn
            // 
            txtCCCDTn.Location = new Point(17, 166);
            txtCCCDTn.Name = "txtCCCDTn";
            txtCCCDTn.Size = new Size(198, 27);
            txtCCCDTn.TabIndex = 81;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 216);
            label12.Name = "label12";
            label12.Size = new Size(55, 20);
            label12.TabIndex = 80;
            label12.Text = "Địa chỉ";
            label12.Click += label12_Click;
            // 
            // txtSDTTn
            // 
            txtSDTTn.Location = new Point(235, 166);
            txtSDTTn.Name = "txtSDTTn";
            txtSDTTn.Size = new Size(210, 27);
            txtSDTTn.TabIndex = 80;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 126);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 80;
            label11.Text = "Số CCCD";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(215, 126);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 80;
            label10.Text = "Số điện thoại";
            // 
            // cbbGioiTinhTN
            // 
            cbbGioiTinhTN.FormattingEnabled = true;
            cbbGioiTinhTN.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinhTN.Location = new Point(235, 77);
            cbbGioiTinhTN.Name = "cbbGioiTinhTN";
            cbbGioiTinhTN.Size = new Size(210, 28);
            cbbGioiTinhTN.TabIndex = 81;
            // 
            // txtHoTenTn
            // 
            txtHoTenTn.Location = new Point(20, 79);
            txtHoTenTn.Name = "txtHoTenTn";
            txtHoTenTn.Size = new Size(195, 27);
            txtHoTenTn.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 27);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 80;
            label2.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 80;
            label1.Text = "Họ và tên";
            // 
            // lbSoLuongXe
            // 
            lbSoLuongXe.AutoSize = true;
            lbSoLuongXe.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbSoLuongXe.Location = new Point(185, 42);
            lbSoLuongXe.Name = "lbSoLuongXe";
            lbSoLuongXe.Size = new Size(56, 18);
            lbSoLuongXe.TabIndex = 35;
            lbSoLuongXe.Text = "Loading";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lbSoLuongXe);
            groupBox5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(1018, 402);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(458, 96);
            groupBox5.TabIndex = 36;
            groupBox5.TabStop = false;
            groupBox5.Text = "Số lượng xe khách đã thuê";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lbTongTienKhachThue);
            groupBox6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(1018, 504);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(458, 96);
            groupBox6.TabIndex = 37;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tổng tiền xe khách đã thuê";
            // 
            // lbTongTienKhachThue
            // 
            lbTongTienKhachThue.AutoSize = true;
            lbTongTienKhachThue.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbTongTienKhachThue.Location = new Point(185, 42);
            lbTongTienKhachThue.Name = "lbTongTienKhachThue";
            lbTongTienKhachThue.Size = new Size(56, 18);
            lbTongTienKhachThue.TabIndex = 35;
            lbTongTienKhachThue.Text = "Loading";
            // 
            // QLKHView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1478, 784);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(dgvQLKH);
            Name = "QLKHView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += QLKHView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private Button btnUpdate;
        public DataGridView dgvQLKH;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtCCCDKH;
        private Label label4;
        private TextBox txtHoTenKH;
        private Label label3;
        private ComboBox cbbGioiTinhKH;
        private DateTimePicker dtpNgaySinhKh;
        private Label label7;
        private TextBox txtDiaChiKH;
        private Label label6;
        private TextBox txtSdtKH;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnUpdate2;
        private Button btnCreate;
        private GroupBox groupBox3;
        private Button btnClear;
        private GroupBox groupBox4;
        private TextBox txtDiaChiTn;
        private TextBox txtCCCDTn;
        private Label label12;
        private TextBox txtSDTTn;
        private Label label11;
        private Label label10;
        private ComboBox cbbGioiTinhTN;
        private TextBox txtHoTenTn;
        private Label label2;
        private Label label1;
        private Button btnCreateTn;
        private Button btnUpdateTn;
        private Label textIDkh;
        private Label lbSoLuongXe;
        private GroupBox groupBox5;
        private Label txtIDNT;
        private GroupBox groupBox6;
        private Label lbTongTienKhachThue;
        private Button btnClearTTTN;
    }
}