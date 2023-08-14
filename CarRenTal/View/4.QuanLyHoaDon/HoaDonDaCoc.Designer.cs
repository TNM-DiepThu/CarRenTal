namespace CarRenTal.View._4.QuanLyHoaDon
{
    partial class HoaDonDaCoc
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
            dtgv_data = new DataGridView();
            groupBox2 = new GroupBox();
            tx_ngayThue = new TextBox();
            label5 = new Label();
            cbb_trangThai = new ComboBox();
            tx_ngayTra = new TextBox();
            label3 = new Label();
            tx_tienCoc = new TextBox();
            label4 = new Label();
            label11 = new Label();
            tx_LoaiXe = new TextBox();
            tx_bienSo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            cbb_taiSan = new ComboBox();
            cbb_giayTo = new ComboBox();
            tx_chiTiet = new TextBox();
            tx_soTien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            bt_exit = new Button();
            lb_id = new Label();
            bt_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_data
            // 
            dtgv_data.AllowUserToAddRows = false;
            dtgv_data.AllowUserToDeleteRows = false;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(40, 373);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.ReadOnly = true;
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(1049, 253);
            dtgv_data.TabIndex = 3;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tx_ngayThue);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbb_trangThai);
            groupBox2.Controls.Add(tx_ngayTra);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tx_tienCoc);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tx_LoaiXe);
            groupBox2.Controls.Add(tx_bienSo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(40, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1049, 161);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin hóa đơn chi tiết";
            // 
            // tx_ngayThue
            // 
            tx_ngayThue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_ngayThue.Location = new Point(118, 110);
            tx_ngayThue.Name = "tx_ngayThue";
            tx_ngayThue.ReadOnly = true;
            tx_ngayThue.Size = new Size(220, 27);
            tx_ngayThue.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày thuê:";
            // 
            // cbb_trangThai
            // 
            cbb_trangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_trangThai.FormattingEnabled = true;
            cbb_trangThai.Items.AddRange(new object[] { "Đã hủy", "Đã cọc", "Đang thực hiện", "Đã Hoàn thành", "Không nhận xe", "Bồi thường cọc" });
            cbb_trangThai.Location = new Point(823, 106);
            cbb_trangThai.Name = "cbb_trangThai";
            cbb_trangThai.Size = new Size(220, 28);
            cbb_trangThai.TabIndex = 6;
            cbb_trangThai.SelectedIndexChanged += cbb_trangThai_SelectedIndexChanged;
            // 
            // tx_ngayTra
            // 
            tx_ngayTra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_ngayTra.Location = new Point(462, 110);
            tx_ngayTra.Name = "tx_ngayTra";
            tx_ngayTra.ReadOnly = true;
            tx_ngayTra.Size = new Size(220, 27);
            tx_ngayTra.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Ngày trả:";
            // 
            // tx_tienCoc
            // 
            tx_tienCoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_tienCoc.Location = new Point(829, 39);
            tx_tienCoc.Name = "tx_tienCoc";
            tx_tienCoc.ReadOnly = true;
            tx_tienCoc.Size = new Size(220, 27);
            tx_tienCoc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(706, 42);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Số tiền cọc:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(706, 110);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 5;
            label11.Text = "Trạng thái:";
            // 
            // tx_LoaiXe
            // 
            tx_LoaiXe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_LoaiXe.Location = new Point(118, 39);
            tx_LoaiXe.Name = "tx_LoaiXe";
            tx_LoaiXe.ReadOnly = true;
            tx_LoaiXe.Size = new Size(220, 27);
            tx_LoaiXe.TabIndex = 4;
            // 
            // tx_bienSo
            // 
            tx_bienSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_bienSo.Location = new Point(471, 39);
            tx_bienSo.Name = "tx_bienSo";
            tx_bienSo.ReadOnly = true;
            tx_bienSo.Size = new Size(220, 27);
            tx_bienSo.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 42);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 5;
            label9.Text = "Tên xe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(358, 42);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 5;
            label10.Text = "Biển số";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_taiSan);
            groupBox1.Controls.Add(cbb_giayTo);
            groupBox1.Controls.Add(tx_chiTiet);
            groupBox1.Controls.Add(tx_soTien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(374, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 172);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thế chấp";
            // 
            // cbb_taiSan
            // 
            cbb_taiSan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_taiSan.FormattingEnabled = true;
            cbb_taiSan.Items.AddRange(new object[] { "Đã cọc", "Đã nhận xe", "Đã hủy" });
            cbb_taiSan.Location = new Point(489, 51);
            cbb_taiSan.Name = "cbb_taiSan";
            cbb_taiSan.Size = new Size(220, 28);
            cbb_taiSan.TabIndex = 13;
            // 
            // cbb_giayTo
            // 
            cbb_giayTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbb_giayTo.FormattingEnabled = true;
            cbb_giayTo.Items.AddRange(new object[] { "Đã cọc", "Đã nhận xe", "Đã hủy" });
            cbb_giayTo.Location = new Point(118, 51);
            cbb_giayTo.Name = "cbb_giayTo";
            cbb_giayTo.Size = new Size(220, 28);
            cbb_giayTo.TabIndex = 14;
            // 
            // tx_chiTiet
            // 
            tx_chiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_chiTiet.Location = new Point(118, 109);
            tx_chiTiet.Name = "tx_chiTiet";
            tx_chiTiet.Size = new Size(220, 27);
            tx_chiTiet.TabIndex = 7;
            // 
            // tx_soTien
            // 
            tx_soTien.Enabled = false;
            tx_soTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tx_soTien.Location = new Point(489, 112);
            tx_soTien.Name = "tx_soTien";
            tx_soTien.Size = new Size(220, 27);
            tx_soTien.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 112);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 9;
            label7.Text = "Chi tiết:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(379, 112);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Số tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 11;
            label2.Text = "Tài sản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Giấy tờ :";
            // 
            // bt_exit
            // 
            bt_exit.Location = new Point(40, 216);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(124, 120);
            bt_exit.TabIndex = 10;
            bt_exit.Text = "Thoát";
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(46, 165);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(41, 20);
            lb_id.TabIndex = 8;
            lb_id.Text = "lb_id";
            lb_id.Visible = false;
            // 
            // bt_save
            // 
            bt_save.Location = new Point(208, 216);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(124, 120);
            bt_save.TabIndex = 10;
            bt_save.Text = "Lưu lại";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // HoaDonDaCoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 662);
            Controls.Add(lb_id);
            Controls.Add(bt_save);
            Controls.Add(bt_exit);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(dtgv_data);
            MaximizeBox = false;
            MaximumSize = new Size(1137, 709);
            MinimizeBox = false;
            MinimumSize = new Size(1137, 709);
            Name = "HoaDonDaCoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += HoaDonDaCoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_data;
        private GroupBox groupBox2;
        private ComboBox cbb_trangThai;
        private TextBox tx_ngayTra;
        private Label label3;
        private TextBox tx_tienCoc;
        private Label label4;
        private TextBox tx_LoaiXe;
        private TextBox tx_bienSo;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tx_ngayThue;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox cbb_taiSan;
        private ComboBox cbb_giayTo;
        private TextBox tx_chiTiet;
        private TextBox tx_soTien;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label1;
        private Button bt_exit;
        private Label lb_id;
        private Button bt_save;
    }
}