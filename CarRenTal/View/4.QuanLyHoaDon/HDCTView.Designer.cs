namespace CarRenTal.View.QuanLyChoThueXe
{
    partial class HDCTView
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
            lbTTCty = new Label();
            lbTTCustomer = new Label();
            dgvHoaDon = new DataGridView();
            label4 = new Label();
            cbbHinhThucTT = new ComboBox();
            btnPrint = new Button();
            btnXacNhan = new Button();
            btnExit = new Button();
            lbTimeHD = new Label();
            lbMaGD = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 49);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn cho thuê xe";
            // 
            // lbTTCty
            // 
            lbTTCty.AutoSize = true;
            lbTTCty.Location = new Point(26, 145);
            lbTTCty.Name = "lbTTCty";
            lbTTCty.Size = new Size(353, 100);
            lbTTCty.TabIndex = 1;
            lbTTCty.Text = "Lucky Việt Đài - Cho thuê xe tự lái\nsố 68 Mễ Trì Thượng, Nam Từ Liêm, Hà Nội\nSố điện thoại: 0986888688\nluckyVietDai.ctxtl.vn\n";
            // 
            // lbTTCustomer
            // 
            lbTTCustomer.AutoSize = true;
            lbTTCustomer.Location = new Point(436, 272);
            lbTTCustomer.Name = "lbTTCustomer";
            lbTTCustomer.Size = new Size(284, 75);
            lbTTCustomer.TabIndex = 2;
            lbTTCustomer.Text = "Họ tên khách hàng: Nguyễn Văn A\nĐịa chỉ: số abc, đường xyz\nsố điện thoại: 0366666666";
            lbTTCustomer.Click += label3_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(12, 375);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.RowTemplate.Height = 33;
            dgvHoaDon.Size = new Size(799, 426);
            dgvHoaDon.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 829);
            label4.Name = "label4";
            label4.Size = new Size(266, 32);
            label4.TabIndex = 4;
            label4.Text = "Hình thức thanh toán";
            // 
            // cbbHinhThucTT
            // 
            cbbHinhThucTT.FormattingEnabled = true;
            cbbHinhThucTT.Location = new Point(597, 832);
            cbbHinhThucTT.Name = "cbbHinhThucTT";
            cbbHinhThucTT.Size = new Size(182, 33);
            cbbHinhThucTT.TabIndex = 5;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(415, 911);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "In hóa đơn";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += button1_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(559, 911);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 34);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(699, 911);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lbTimeHD
            // 
            lbTimeHD.AutoSize = true;
            lbTimeHD.Location = new Point(519, 95);
            lbTimeHD.Name = "lbTimeHD";
            lbTimeHD.Size = new Size(260, 25);
            lbTimeHD.TabIndex = 9;
            lbTimeHD.Text = "23:22 Hà nội, ngày 18/07/2023";
            // 
            // lbMaGD
            // 
            lbMaGD.AutoSize = true;
            lbMaGD.Location = new Point(609, 130);
            lbMaGD.Name = "lbMaGD";
            lbMaGD.Size = new Size(170, 25);
            lbMaGD.TabIndex = 10;
            lbMaGD.Text = "Mã dao dịch: TX001";
            // 
            // HDCTView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 968);
            Controls.Add(lbMaGD);
            Controls.Add(lbTimeHD);
            Controls.Add(btnExit);
            Controls.Add(btnXacNhan);
            Controls.Add(btnPrint);
            Controls.Add(cbbHinhThucTT);
            Controls.Add(label4);
            Controls.Add(dgvHoaDon);
            Controls.Add(lbTTCustomer);
            Controls.Add(lbTTCty);
            Controls.Add(label1);
            Name = "HDCTView";
            Text = "Hóa đơn chi tiết";
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbTTCty;
        private Label lbTTCustomer;
        private DataGridView dgvHoaDon;
        private Label label4;
        private ComboBox cbbHinhThucTT;
        private Button btnPrint;
        private Button btnXacNhan;
        private Button btnExit;
        private Label lbTimeHD;
        private Label lbMaGD;
    }
}