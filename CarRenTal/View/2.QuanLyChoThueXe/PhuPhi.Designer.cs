namespace CarRenTal.View._2.QuanLyChoThueXe
{
    partial class PhuPhi
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
            tx_tongTien = new TextBox();
            label1 = new Label();
            cbb_loaiPP = new ComboBox();
            tx_giaTri = new TextBox();
            tx_moTa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_them = new Button();
            bt_huy = new Button();
            bt_ok = new Button();
            groupBox1 = new GroupBox();
            lb_khach = new Label();
            lb_bienSo = new Label();
            lb_xe = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_data
            // 
            dtgv_data.AllowUserToAddRows = false;
            dtgv_data.AllowUserToDeleteRows = false;
            dtgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(432, 135);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.ReadOnly = true;
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(610, 280);
            dtgv_data.TabIndex = 0;
            dtgv_data.RowsAdded += dtgv_data_RowsAdded;
            dtgv_data.RowsRemoved += dtgv_data_RowsRemoved;
            // 
            // tx_tongTien
            // 
            tx_tongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tx_tongTien.Location = new Point(565, 454);
            tx_tongTien.Name = "tx_tongTien";
            tx_tongTien.Size = new Size(268, 34);
            tx_tongTien.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(440, 457);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền:";
            // 
            // cbb_loaiPP
            // 
            cbb_loaiPP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_loaiPP.FormattingEnabled = true;
            cbb_loaiPP.Location = new Point(138, 140);
            cbb_loaiPP.Name = "cbb_loaiPP";
            cbb_loaiPP.Size = new Size(264, 28);
            cbb_loaiPP.TabIndex = 3;
            // 
            // tx_giaTri
            // 
            tx_giaTri.Location = new Point(138, 211);
            tx_giaTri.Name = "tx_giaTri";
            tx_giaTri.Size = new Size(264, 27);
            tx_giaTri.TabIndex = 4;
            // 
            // tx_moTa
            // 
            tx_moTa.Location = new Point(138, 281);
            tx_moTa.Name = "tx_moTa";
            tx_moTa.Size = new Size(264, 27);
            tx_moTa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 135);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Loại phụ phí";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 211);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Giá trị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 288);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // bt_them
            // 
            bt_them.Location = new Point(48, 395);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(119, 55);
            bt_them.TabIndex = 6;
            bt_them.Text = "Thêm phụ phí";
            bt_them.UseVisualStyleBackColor = true;
            bt_them.Click += bt_them_Click;
            // 
            // bt_huy
            // 
            bt_huy.Location = new Point(239, 395);
            bt_huy.Name = "bt_huy";
            bt_huy.Size = new Size(119, 55);
            bt_huy.TabIndex = 6;
            bt_huy.Text = "Xóa";
            bt_huy.UseVisualStyleBackColor = true;
            bt_huy.Click += bt_huy_Click;
            // 
            // bt_ok
            // 
            bt_ok.Location = new Point(923, 447);
            bt_ok.Name = "bt_ok";
            bt_ok.Size = new Size(119, 55);
            bt_ok.TabIndex = 6;
            bt_ok.Text = "Hoàn thành";
            bt_ok.UseVisualStyleBackColor = true;
            bt_ok.Click += bt_ok_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_khach);
            groupBox1.Controls.Add(lb_bienSo);
            groupBox1.Controls.Add(lb_xe);
            groupBox1.Location = new Point(12, 12);
            groupBox1.MaximumSize = new Size(1030, 101);
            groupBox1.MinimumSize = new Size(1030, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 101);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm phụ phí cho";
            // 
            // lb_khach
            // 
            lb_khach.AutoSize = true;
            lb_khach.Location = new Point(36, 60);
            lb_khach.Name = "lb_khach";
            lb_khach.Size = new Size(74, 20);
            lb_khach.TabIndex = 5;
            lb_khach.Text = "Tên khách";
            // 
            // lb_bienSo
            // 
            lb_bienSo.AutoSize = true;
            lb_bienSo.Location = new Point(710, 60);
            lb_bienSo.Name = "lb_bienSo";
            lb_bienSo.Size = new Size(57, 20);
            lb_bienSo.TabIndex = 5;
            lb_bienSo.Text = "biển số";
            // 
            // lb_xe
            // 
            lb_xe.AutoSize = true;
            lb_xe.Location = new Point(460, 60);
            lb_xe.Name = "lb_xe";
            lb_xe.Size = new Size(49, 20);
            lb_xe.TabIndex = 5;
            lb_xe.Text = "tên xe";
            // 
            // PhuPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 514);
            Controls.Add(groupBox1);
            Controls.Add(bt_ok);
            Controls.Add(bt_huy);
            Controls.Add(bt_them);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tx_moTa);
            Controls.Add(tx_giaTri);
            Controls.Add(cbb_loaiPP);
            Controls.Add(label1);
            Controls.Add(tx_tongTien);
            Controls.Add(dtgv_data);
            MaximumSize = new Size(1091, 561);
            MinimumSize = new Size(1091, 561);
            Name = "PhuPhi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phụ phí thuê xe";
            Load += PhuPhi_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_data;
        private TextBox tx_tongTien;
        private Label label1;
        private ComboBox cbb_loaiPP;
        private TextBox tx_giaTri;
        private TextBox tx_moTa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_them;
        private Button bt_huy;
        private Button bt_ok;
        private GroupBox groupBox1;
        private Label lb_khach;
        private Label lb_bienSo;
        private Label lb_xe;
    }
}