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
            btnTrangThai = new Button();
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
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnUpdate2 = new Button();
            btnCreate = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQLKH
            // 
            dgvQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKH.Location = new Point(12, 406);
            dgvQLKH.Name = "dgvQLKH";
            dgvQLKH.RowHeadersWidth = 62;
            dgvQLKH.RowTemplate.Height = 33;
            dgvQLKH.Size = new Size(1454, 366);
            dgvQLKH.TabIndex = 31;
            dgvQLKH.CellClick += dgvQLKH_CellClick;
            dgvQLKH.CellContentClick += dgvQLKH_CellContentClick;
            // 
            // btnTrangThai
            // 
            btnTrangThai.Location = new Point(1163, 19);
            btnTrangThai.Name = "btnTrangThai";
            btnTrangThai.Size = new Size(112, 34);
            btnTrangThai.TabIndex = 27;
            btnTrangThai.Text = "Trạng thái";
            btnTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(62, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(483, 31);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1163, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 45);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
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
            groupBox1.Size = new Size(979, 245);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtSdtKH
            // 
            txtSdtKH.Location = new Point(676, 188);
            txtSdtKH.Name = "txtSdtKH";
            txtSdtKH.Size = new Size(283, 31);
            txtSdtKH.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(669, 141);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 78;
            label8.Text = "Số điện thoại";
            // 
            // cbbGioiTinhKH
            // 
            cbbGioiTinhKH.FormattingEnabled = true;
            cbbGioiTinhKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinhKH.Location = new Point(359, 84);
            cbbGioiTinhKH.Name = "cbbGioiTinhKH";
            cbbGioiTinhKH.Size = new Size(278, 33);
            cbbGioiTinhKH.TabIndex = 77;
            // 
            // dtpNgaySinhKh
            // 
            dtpNgaySinhKh.Format = DateTimePickerFormat.Short;
            dtpNgaySinhKh.Location = new Point(676, 82);
            dtpNgaySinhKh.Name = "dtpNgaySinhKh";
            dtpNgaySinhKh.Size = new Size(276, 31);
            dtpNgaySinhKh.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(669, 41);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 75;
            label7.Text = "Ngày sinh";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(354, 188);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(283, 31);
            txtDiaChiKH.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 141);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 73;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 41);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 49;
            label5.Text = "Giới tính";
            // 
            // txtCCCDKH
            // 
            txtCCCDKH.Location = new Point(18, 188);
            txtCCCDKH.Name = "txtCCCDKH";
            txtCCCDKH.Size = new Size(283, 31);
            txtCCCDKH.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 141);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 47;
            label4.Text = "Số CCCD/PassProst";
            // 
            // txtHoTenKH
            // 
            txtHoTenKH.Location = new Point(18, 86);
            txtHoTenKH.Name = "txtHoTenKH";
            txtHoTenKH.Size = new Size(283, 31);
            txtHoTenKH.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 41);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 45;
            label3.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnUpdate2);
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(31, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1435, 114);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(335, 46);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 44);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate2
            // 
            btnUpdate2.Location = new Point(684, 46);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(147, 44);
            btnUpdate2.TabIndex = 2;
            btnUpdate2.Text = "Cập nhật";
            btnUpdate2.UseVisualStyleBackColor = true;
            btnUpdate2.Click += btnUpdate2_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(489, 46);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(147, 44);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Thêm";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(858, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 70);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // QLKHView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1478, 784);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdate);
            Controls.Add(dgvQLKH);
            Controls.Add(btnTrangThai);
            Name = "QLKHView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            Load += QLKHView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTrangThai;
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
    }
}