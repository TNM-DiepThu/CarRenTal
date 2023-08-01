namespace CarRenTal.View._6.QuanLyThuChi
{
    partial class ChiTietThuChiView
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
            dgvDoanhThu = new DataGridView();
            btnXuatDL = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvKhoanChi = new DataGridView();
            groupBox1 = new GroupBox();
            lbLoiNhuan = new Label();
            lbChi = new Label();
            lbDoanhThu = new Label();
            label8 = new Label();
            label7 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dtTimeSearch = new DateTimePicker();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoanChi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToDeleteRows = false;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(12, 126);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 62;
            dgvDoanhThu.RowTemplate.Height = 33;
            dgvDoanhThu.Size = new Size(1000, 260);
            dgvDoanhThu.TabIndex = 31;
            dgvDoanhThu.CellContentClick += dgvDoanhThu_CellContentClick;
            // 
            // btnXuatDL
            // 
            btnXuatDL.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatDL.Location = new Point(1280, 711);
            btnXuatDL.Name = "btnXuatDL";
            btnXuatDL.Size = new Size(155, 49);
            btnXuatDL.TabIndex = 30;
            btnXuatDL.Text = "Xuất dữ liệu";
            btnXuatDL.UseVisualStyleBackColor = true;
            btnXuatDL.Click += btnXuatDL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(118, 29);
            label1.TabIndex = 34;
            label1.Text = "Doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 35;
            label2.Text = "Doanh thu";
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 404);
            label3.Name = "label3";
            label3.Size = new Size(193, 42);
            label3.TabIndex = 36;
            label3.Text = "Khoản tiền chi";
            // 
            // dgvKhoanChi
            // 
            dgvKhoanChi.AllowUserToAddRows = false;
            dgvKhoanChi.AllowUserToDeleteRows = false;
            dgvKhoanChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoanChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoanChi.Location = new Point(12, 437);
            dgvKhoanChi.Name = "dgvKhoanChi";
            dgvKhoanChi.ReadOnly = true;
            dgvKhoanChi.RowHeadersWidth = 62;
            dgvKhoanChi.RowTemplate.Height = 33;
            dgvKhoanChi.Size = new Size(1000, 335);
            dgvKhoanChi.TabIndex = 38;
            dgvKhoanChi.CellContentClick += dgvBaoHiem_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbLoiNhuan);
            groupBox1.Controls.Add(lbChi);
            groupBox1.Controls.Add(lbDoanhThu);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1039, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 421);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lợi nhuận";
            // 
            // lbLoiNhuan
            // 
            lbLoiNhuan.AutoSize = true;
            lbLoiNhuan.Location = new Point(193, 163);
            lbLoiNhuan.Name = "lbLoiNhuan";
            lbLoiNhuan.Size = new Size(22, 25);
            lbLoiNhuan.TabIndex = 40;
            lbLoiNhuan.Text = "0";
            // 
            // lbChi
            // 
            lbChi.AutoSize = true;
            lbChi.Location = new Point(193, 118);
            lbChi.Name = "lbChi";
            lbChi.Size = new Size(22, 25);
            lbChi.TabIndex = 39;
            lbChi.Text = "0";
            lbChi.TextChanged += lbDoanhThu_TextChanged;
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Location = new Point(193, 55);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(22, 25);
            lbDoanhThu.TabIndex = 38;
            lbDoanhThu.Text = "0";
            lbDoanhThu.TextChanged += lbDoanhThu_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 163);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 37;
            label8.Text = "Lợi nhuận";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 107);
            label7.Name = "label7";
            label7.Size = new Size(37, 25);
            label7.TabIndex = 36;
            label7.Text = "Chi";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(484, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 34);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.TextChanged += lbDoanhThu_TextChanged;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(441, 31);
            txtSearch.TabIndex = 28;
            // 
            // dtTimeSearch
            // 
            dtTimeSearch.Format = DateTimePickerFormat.Short;
            dtTimeSearch.Location = new Point(18, 39);
            dtTimeSearch.Name = "dtTimeSearch";
            dtTimeSearch.Size = new Size(236, 31);
            dtTimeSearch.TabIndex = 32;
            dtTimeSearch.ValueChanged += dtTimeSearch_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtTimeSearch);
            groupBox2.Location = new Point(1039, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 84);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm theo ngày";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(325, 37);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(687, 73);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // ChiTietThuChiView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 784);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvKhoanChi);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvDoanhThu);
            Controls.Add(btnXuatDL);
            Name = "ChiTietThuChiView";
            Text = "Quản lý thu chi";
            Load += lbDoanhThu_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhoanChi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDoanhThu;
        private Button btnXuatDL;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvKhoanChi;
        private Label label5;
        private DataGridView dgvDangKiem;
        private Label label6;
        private DataGridView dgvBaoDuong;
        private GroupBox groupBox1;
        private Label lbLoiNhuan;
        private Label lbChi;
        private Label lbDoanhThu;
        private Label label8;
        private Label label7;
        private Button btnSearch;
        private TextBox txtSearch;
        private DateTimePicker dtTimeSearch;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}