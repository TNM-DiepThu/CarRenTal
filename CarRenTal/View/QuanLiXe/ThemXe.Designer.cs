namespace CarRenTal.View.QuanLiXe
{
    partial class ThemXe
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
            tx_bienSo = new TextBox();
            label3 = new Label();
            tx_soKhung = new TextBox();
            label5 = new Label();
            tx_soMay = new TextBox();
            tx_donGia = new TextBox();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            bt_nhaplai = new Button();
            bt_add = new Button();
            bt_esc = new Button();
            cbb_loaiXe = new ComboBox();
            cbb_mau = new ComboBox();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            tx_congTo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 10);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Loại xe";
            // 
            // tx_bienSo
            // 
            tx_bienSo.Location = new Point(44, 87);
            tx_bienSo.Name = "tx_bienSo";
            tx_bienSo.Size = new Size(230, 27);
            tx_bienSo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 64);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Biển số";
            // 
            // tx_soKhung
            // 
            tx_soKhung.Location = new Point(44, 149);
            tx_soKhung.Name = "tx_soKhung";
            tx_soKhung.Size = new Size(230, 27);
            tx_soKhung.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 126);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 1;
            label5.Text = "Số khung";
            // 
            // tx_soMay
            // 
            tx_soMay.Location = new Point(44, 202);
            tx_soMay.Name = "tx_soMay";
            tx_soMay.Size = new Size(230, 27);
            tx_soMay.TabIndex = 0;
            // 
            // tx_donGia
            // 
            tx_donGia.Location = new Point(44, 384);
            tx_donGia.Name = "tx_donGia";
            tx_donGia.Size = new Size(230, 27);
            tx_donGia.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 179);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 1;
            label7.Text = "Số máy";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 360);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 1;
            label10.Text = "Gía cho thuê";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 306);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 1;
            label11.Text = "Màu sắc";
            // 
            // bt_nhaplai
            // 
            bt_nhaplai.Location = new Point(529, 507);
            bt_nhaplai.Name = "bt_nhaplai";
            bt_nhaplai.Size = new Size(148, 29);
            bt_nhaplai.TabIndex = 2;
            bt_nhaplai.Text = "Nhập lại";
            bt_nhaplai.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(708, 507);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(148, 29);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm xe";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_esc
            // 
            bt_esc.Location = new Point(886, 507);
            bt_esc.Name = "bt_esc";
            bt_esc.Size = new Size(94, 29);
            bt_esc.TabIndex = 2;
            bt_esc.Text = "Thoát";
            bt_esc.UseVisualStyleBackColor = true;
            // 
            // cbb_loaiXe
            // 
            cbb_loaiXe.FormattingEnabled = true;
            cbb_loaiXe.Location = new Point(44, 33);
            cbb_loaiXe.Name = "cbb_loaiXe";
            cbb_loaiXe.Size = new Size(230, 28);
            cbb_loaiXe.TabIndex = 3;
            // 
            // cbb_mau
            // 
            cbb_mau.FormattingEnabled = true;
            cbb_mau.Location = new Point(42, 329);
            cbb_mau.Name = "cbb_mau";
            cbb_mau.Size = new Size(230, 28);
            cbb_mau.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 232);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 1;
            label9.Text = "Số công tơ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(618, 303);
            dataGridView1.TabIndex = 4;
            // 
            // tx_congTo
            // 
            tx_congTo.Location = new Point(42, 255);
            tx_congTo.Name = "tx_congTo";
            tx_congTo.Size = new Size(230, 27);
            tx_congTo.TabIndex = 0;
            // 
            // ThemXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 586);
            Controls.Add(dataGridView1);
            Controls.Add(cbb_mau);
            Controls.Add(cbb_loaiXe);
            Controls.Add(bt_esc);
            Controls.Add(bt_add);
            Controls.Add(bt_nhaplai);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tx_donGia);
            Controls.Add(tx_congTo);
            Controls.Add(tx_soMay);
            Controls.Add(tx_soKhung);
            Controls.Add(tx_bienSo);
            Name = "ThemXe";
            Text = "Thêm Xe";
            Load += ThemXe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox tx_bienSo;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TextBox tx_soKhung;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox tx_soMay;
        private TextBox tx_donGia;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
        private Button bt_nhaplai;
        private Button bt_add;
        private Button bt_esc;
        private ComboBox cbb_loaiXe;
        private ComboBox cbb_mau;
        private Label label9;
        private DataGridView dataGridView1;
        private TextBox tb_nsx;
        private TextBox tx_congTo;
    }
}