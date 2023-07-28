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
            dtgv = new DataGridView();
            textBox1 = new TextBox();
            label4 = new Label();
            bt_search = new Button();
            tx_ten = new TextBox();
            label1 = new Label();
            tx_canCuoc = new TextBox();
            tx_nguoiTao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            bt_chiTiet = new Button();
            bt_clear = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            dtp_startDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv
            // 
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Location = new Point(12, 152);
            dtgv.Name = "dtgv";
            dtgv.RowHeadersWidth = 51;
            dtgv.RowTemplate.Height = 29;
            dtgv.Size = new Size(967, 391);
            dtgv.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(86, 91);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên khách hàng hoặc căn cước";
            textBox1.Size = new Size(620, 34);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 37);
            label4.Name = "label4";
            label4.Size = new Size(294, 28);
            label4.TabIndex = 1;
            label4.Text = "Thông tin các hóa đơn đã cọc";
            // 
            // bt_search
            // 
            bt_search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bt_search.Location = new Point(793, 91);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(125, 34);
            bt_search.TabIndex = 5;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            // 
            // tx_ten
            // 
            tx_ten.Location = new Point(59, 71);
            tx_ten.Name = "tx_ten";
            tx_ten.Size = new Size(343, 27);
            tx_ten.TabIndex = 0;
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
            // tx_canCuoc
            // 
            tx_canCuoc.Location = new Point(59, 160);
            tx_canCuoc.Name = "tx_canCuoc";
            tx_canCuoc.Size = new Size(343, 27);
            tx_canCuoc.TabIndex = 0;
            // 
            // tx_nguoiTao
            // 
            tx_nguoiTao.Location = new Point(59, 243);
            tx_nguoiTao.Name = "tx_nguoiTao";
            tx_nguoiTao.Size = new Size(343, 27);
            tx_nguoiTao.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 206);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Người tạo";
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
            // bt_clear
            // 
            bt_clear.Location = new Point(243, 305);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(118, 62);
            bt_clear.TabIndex = 2;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bt_clear);
            groupBox1.Controls.Add(bt_chiTiet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tx_nguoiTao);
            groupBox1.Controls.Add(tx_canCuoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tx_ten);
            groupBox1.Location = new Point(985, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 399);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 36);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 1;
            label5.Text = "Từ ngày:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(228, 40);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 1;
            label6.Text = "Đến ngày:";
            // 
            // dtp_startDate
            // 
            dtp_startDate.Format = DateTimePickerFormat.Short;
            dtp_startDate.Location = new Point(6, 68);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(143, 27);
            dtp_startDate.TabIndex = 0;
            // 
            // dtp_endDate
            // 
            dtp_endDate.Format = DateTimePickerFormat.Short;
            dtp_endDate.Location = new Point(228, 68);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(167, 27);
            dtp_endDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtp_endDate);
            groupBox2.Controls.Add(dtp_startDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(992, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 101);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khoảng ngày";
            // 
            // HoaDonDaCoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 555);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bt_search);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dtgv);
            Name = "HoaDonDaCoc";
            Text = "HoaDonDaCoc";
            Load += HoaDonDaCoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv;
        private TextBox textBox1;
        private Label label4;
        private Button bt_search;
        private TextBox tx_ten;
        private Label label1;
        private TextBox tx_canCuoc;
        private TextBox tx_nguoiTao;
        private Label label2;
        private Label label3;
        private Button bt_chiTiet;
        private Button bt_clear;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private DateTimePicker dtp_startDate;
        private DateTimePicker dtp_endDate;
        private GroupBox groupBox2;
    }
}