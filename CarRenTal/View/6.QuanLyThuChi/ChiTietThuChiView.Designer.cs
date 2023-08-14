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
            button1 = new Button();
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
            dgvDoanhThu.Location = new Point(11, 113);
            dgvDoanhThu.Margin = new Padding(2);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 62;
            dgvDoanhThu.RowTemplate.Height = 33;
            dgvDoanhThu.Size = new Size(1104, 248);
            dgvDoanhThu.TabIndex = 31;
            dgvDoanhThu.CellContentClick += dgvDoanhThu_CellContentClick;
            // 
            // btnXuatDL
            // 
            btnXuatDL.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatDL.Location = new Point(1167, 474);
            btnXuatDL.Margin = new Padding(2);
            btnXuatDL.Name = "btnXuatDL";
            btnXuatDL.Size = new Size(123, 68);
            btnXuatDL.TabIndex = 30;
            btnXuatDL.Text = "Xuất dữ liệu doanh thu";
            btnXuatDL.UseVisualStyleBackColor = true;
            btnXuatDL.Click += btnXuatDL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 34;
            label1.Text = "Doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 35;
            label2.Text = "Doanh thu";
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 376);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 34);
            label3.TabIndex = 36;
            label3.Text = "Khoản tiền chi";
            // 
            // dgvKhoanChi
            // 
            dgvKhoanChi.AllowUserToAddRows = false;
            dgvKhoanChi.AllowUserToDeleteRows = false;
            dgvKhoanChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoanChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoanChi.Location = new Point(10, 412);
            dgvKhoanChi.Margin = new Padding(2);
            dgvKhoanChi.Name = "dgvKhoanChi";
            dgvKhoanChi.ReadOnly = true;
            dgvKhoanChi.RowHeadersWidth = 62;
            dgvKhoanChi.RowTemplate.Height = 33;
            dgvKhoanChi.Size = new Size(1105, 268);
            dgvKhoanChi.TabIndex = 38;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbLoiNhuan);
            groupBox1.Controls.Add(lbChi);
            groupBox1.Controls.Add(lbDoanhThu);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1129, 101);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(342, 337);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lợi nhuận";
            // 
            // lbLoiNhuan
            // 
            lbLoiNhuan.AutoSize = true;
            lbLoiNhuan.Location = new Point(154, 130);
            lbLoiNhuan.Margin = new Padding(2, 0, 2, 0);
            lbLoiNhuan.Name = "lbLoiNhuan";
            lbLoiNhuan.Size = new Size(17, 20);
            lbLoiNhuan.TabIndex = 40;
            lbLoiNhuan.Text = "0";
            // 
            // lbChi
            // 
            lbChi.AutoSize = true;
            lbChi.Location = new Point(154, 94);
            lbChi.Margin = new Padding(2, 0, 2, 0);
            lbChi.Name = "lbChi";
            lbChi.Size = new Size(17, 20);
            lbChi.TabIndex = 39;
            lbChi.Text = "0";
            lbChi.TextChanged += lbDoanhThu_TextChanged;
            // 
            // lbDoanhThu
            // 
            lbDoanhThu.AutoSize = true;
            lbDoanhThu.Location = new Point(154, 44);
            lbDoanhThu.Margin = new Padding(2, 0, 2, 0);
            lbDoanhThu.Name = "lbDoanhThu";
            lbDoanhThu.Size = new Size(17, 20);
            lbDoanhThu.TabIndex = 38;
            lbDoanhThu.Text = "0";
            lbDoanhThu.TextChanged += lbDoanhThu_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 130);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 37;
            label8.Text = "Lợi nhuận";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 86);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(30, 20);
            label7.TabIndex = 36;
            label7.Text = "Chi";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(387, 23);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 27);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.TextChanged += lbDoanhThu_TextChanged;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 25);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(354, 27);
            txtSearch.TabIndex = 28;
            // 
            // dtTimeSearch
            // 
            dtTimeSearch.Format = DateTimePickerFormat.Short;
            dtTimeSearch.Location = new Point(14, 31);
            dtTimeSearch.Margin = new Padding(2);
            dtTimeSearch.Name = "dtTimeSearch";
            dtTimeSearch.Size = new Size(190, 27);
            dtTimeSearch.TabIndex = 32;
            dtTimeSearch.Value = new DateTime(2023, 8, 14, 0, 0, 0, 0);
            dtTimeSearch.ValueChanged += dtTimeSearch_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtTimeSearch);
            groupBox2.Location = new Point(1129, 30);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(225, 67);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm theo ngày";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(575, 34);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(550, 58);
            groupBox3.TabIndex = 45;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1312, 474);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(123, 68);
            button1.TabIndex = 46;
            button1.Text = "Xuất dữ liệu khoản chi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChiTietThuChiView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 793);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvKhoanChi);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvDoanhThu);
            Controls.Add(btnXuatDL);
            Margin = new Padding(2);
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
        private Button button1;
    }
}