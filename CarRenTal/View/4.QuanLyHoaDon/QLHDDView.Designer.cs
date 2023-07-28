namespace CarRenTal.View._4._QuanLyHoaDon
{
    partial class QLHDDView
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
            groupBox1 = new GroupBox();
            bt_hoanThanh = new Button();
            bt_dangThue = new Button();
            bt_datCoc = new Button();
            pn_hoaDon = new Panel();
            groupBox2 = new GroupBox();
            dtp_endDate = new DateTimePicker();
            dtp_startDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            bt_clear = new Button();
            bt_chiTiet = new Button();
            label3 = new Label();
            label2 = new Label();
            tx_nguoiTao = new TextBox();
            tx_canCuoc = new TextBox();
            label1 = new Label();
            tx_ten = new TextBox();
            bt_search = new Button();
            tx_search = new TextBox();
            dtgv_data = new DataGridView();
            groupBox1.SuspendLayout();
            pn_hoaDon.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_hoanThanh);
            groupBox1.Controls.Add(bt_dangThue);
            groupBox1.Controls.Add(bt_datCoc);
            groupBox1.Location = new Point(18, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1452, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // bt_hoanThanh
            // 
            bt_hoanThanh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_hoanThanh.Location = new Point(969, 9);
            bt_hoanThanh.Name = "bt_hoanThanh";
            bt_hoanThanh.Size = new Size(483, 150);
            bt_hoanThanh.TabIndex = 0;
            bt_hoanThanh.Text = "Hóa đơn đã hoàn thành";
            bt_hoanThanh.UseVisualStyleBackColor = true;
            bt_hoanThanh.Click += bt_hoanThanh_Click;
            // 
            // bt_dangThue
            // 
            bt_dangThue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_dangThue.Location = new Point(497, 9);
            bt_dangThue.Name = "bt_dangThue";
            bt_dangThue.Size = new Size(475, 150);
            bt_dangThue.TabIndex = 0;
            bt_dangThue.Text = "Hóa đơn đang  cho thuê";
            bt_dangThue.UseVisualStyleBackColor = true;
            bt_dangThue.Click += bt_dangThue_Click;
            // 
            // bt_datCoc
            // 
            bt_datCoc.BackColor = Color.LightGray;
            bt_datCoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_datCoc.Location = new Point(0, 9);
            bt_datCoc.Name = "bt_datCoc";
            bt_datCoc.Size = new Size(502, 150);
            bt_datCoc.TabIndex = 0;
            bt_datCoc.Text = "Hóa đơn đã đặt cọc";
            bt_datCoc.UseVisualStyleBackColor = false;
            bt_datCoc.Click += bt_datCoc_Click;
            // 
            // pn_hoaDon
            // 
            pn_hoaDon.Controls.Add(groupBox2);
            pn_hoaDon.Controls.Add(groupBox3);
            pn_hoaDon.Controls.Add(bt_search);
            pn_hoaDon.Controls.Add(tx_search);
            pn_hoaDon.Controls.Add(dtgv_data);
            pn_hoaDon.Location = new Point(18, 179);
            pn_hoaDon.Name = "pn_hoaDon";
            pn_hoaDon.Size = new Size(1452, 602);
            pn_hoaDon.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtp_endDate);
            groupBox2.Controls.Add(dtp_startDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(996, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 101);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khoảng ngày";
            // 
            // dtp_endDate
            // 
            dtp_endDate.Format = DateTimePickerFormat.Short;
            dtp_endDate.Location = new Point(247, 59);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(167, 27);
            dtp_endDate.TabIndex = 0;
            // 
            // dtp_startDate
            // 
            dtp_startDate.Format = DateTimePickerFormat.Short;
            dtp_startDate.Location = new Point(25, 59);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(143, 27);
            dtp_startDate.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(247, 31);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 1;
            label6.Text = "Đến ngày:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 27);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 1;
            label5.Text = "Từ ngày:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_clear);
            groupBox3.Controls.Add(bt_chiTiet);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(tx_nguoiTao);
            groupBox3.Controls.Add(tx_canCuoc);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tx_ten);
            groupBox3.Location = new Point(989, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 399);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hóa đơn";
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(243, 305);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(118, 62);
            bt_clear.TabIndex = 2;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_chiTiet
            // 
            bt_chiTiet.Location = new Point(59, 305);
            bt_chiTiet.Name = "bt_chiTiet";
            bt_chiTiet.Size = new Size(118, 62);
            bt_chiTiet.TabIndex = 2;
            bt_chiTiet.Text = "Chi tiết hóa đơn";
            bt_chiTiet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 206);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Người tạo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 117);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Số căn cước";
            // 
            // tx_nguoiTao
            // 
            tx_nguoiTao.Location = new Point(59, 243);
            tx_nguoiTao.Name = "tx_nguoiTao";
            tx_nguoiTao.Size = new Size(343, 27);
            tx_nguoiTao.TabIndex = 0;
            // 
            // tx_canCuoc
            // 
            tx_canCuoc.Location = new Point(59, 160);
            tx_canCuoc.Name = "tx_canCuoc";
            tx_canCuoc.Size = new Size(343, 27);
            tx_canCuoc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng:";
            // 
            // tx_ten
            // 
            tx_ten.Location = new Point(59, 71);
            tx_ten.Name = "tx_ten";
            tx_ten.Size = new Size(343, 27);
            tx_ten.TabIndex = 0;
            // 
            // bt_search
            // 
            bt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_search.Location = new Point(745, 81);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(125, 34);
            bt_search.TabIndex = 11;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            // 
            // tx_search
            // 
            tx_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tx_search.Location = new Point(38, 81);
            tx_search.Name = "tx_search";
            tx_search.PlaceholderText = "Nhập tên khách hàng hoặc căn cước";
            tx_search.Size = new Size(620, 34);
            tx_search.TabIndex = 10;
            // 
            // dtgv_data
            // 
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(16, 174);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(967, 391);
            dtgv_data.TabIndex = 9;
            // 
            // QLHDDView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 793);
            Controls.Add(pn_hoaDon);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "QLHDDView";
            Text = "QLHDDView";
            Load += QLHDDView_Load;
            groupBox1.ResumeLayout(false);
            pn_hoaDon.ResumeLayout(false);
            pn_hoaDon.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button bt_hoanThanh;
        private Button bt_dangThue;
        private Button bt_datCoc;
        private Panel pn_hoaDon;
        private GroupBox groupBox2;
        private DateTimePicker dtp_endDate;
        private DateTimePicker dtp_startDate;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button bt_clear;
        private Button bt_chiTiet;
        private Label label3;
        private Label label2;
        private TextBox tx_nguoiTao;
        private TextBox tx_canCuoc;
        private Label label1;
        private TextBox tx_ten;
        private Button bt_search;
        private TextBox tx_search;
        private DataGridView dtgv_data;
    }
}