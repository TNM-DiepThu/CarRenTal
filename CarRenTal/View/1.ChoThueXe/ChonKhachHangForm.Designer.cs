namespace CarRenTal.View._1.ChoThueXe
{
    partial class ChonKhachHangForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            bt_stop = new Button();
            bt_start = new Button();
            bt_nguoiThan = new Button();
            bt_khach = new Button();
            pic_Cam = new PictureBox();
            cbb_chooseDrives = new ComboBox();
            label16 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tx_sdtNT = new TextBox();
            label9 = new Label();
            tx_diaChiNT = new TextBox();
            label11 = new Label();
            label12 = new Label();
            tx_cccdNT = new TextBox();
            label13 = new Label();
            tx_nameNT = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tx_sdtKH = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tx_diaChiKH = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tx_cccdKH = new TextBox();
            label4 = new Label();
            tx_nameKH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            lb_idKH = new Label();
            dtgv_data = new DataGridView();
            tx_search = new TextBox();
            bt_search = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dtp_ngaySinhKH = new DateTimePicker();
            cbb_gtinhKH = new ComboBox();
            cbb_gtinhNT = new ComboBox();
            bt_exit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Cam).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(bt_nguoiThan);
            groupBox1.Controls.Add(bt_khach);
            groupBox1.Controls.Add(pic_Cam);
            groupBox1.Controls.Add(cbb_chooseDrives);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(932, 311);
            groupBox1.TabIndex = 102;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quét QR Code";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_stop);
            groupBox2.Controls.Add(bt_start);
            groupBox2.Location = new Point(36, 142);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(330, 82);
            groupBox2.TabIndex = 70;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camera";
            // 
            // bt_stop
            // 
            bt_stop.Enabled = false;
            bt_stop.Location = new Point(194, 36);
            bt_stop.Margin = new Padding(2);
            bt_stop.Name = "bt_stop";
            bt_stop.Size = new Size(112, 34);
            bt_stop.TabIndex = 40;
            bt_stop.Text = "Tắt";
            bt_stop.UseVisualStyleBackColor = true;
            bt_stop.Click += bt_stop_Click;
            // 
            // bt_start
            // 
            bt_start.Enabled = false;
            bt_start.Location = new Point(38, 36);
            bt_start.Margin = new Padding(2);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(112, 34);
            bt_start.TabIndex = 39;
            bt_start.Text = "Bật ";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += bt_start_Click;
            // 
            // bt_nguoiThan
            // 
            bt_nguoiThan.Location = new Point(216, 246);
            bt_nguoiThan.Margin = new Padding(2);
            bt_nguoiThan.Name = "bt_nguoiThan";
            bt_nguoiThan.Size = new Size(150, 32);
            bt_nguoiThan.TabIndex = 42;
            bt_nguoiThan.Text = "Người thân";
            bt_nguoiThan.UseVisualStyleBackColor = true;
            bt_nguoiThan.Click += bt_nguoiThan_Click;
            // 
            // bt_khach
            // 
            bt_khach.Location = new Point(36, 246);
            bt_khach.Margin = new Padding(2);
            bt_khach.Name = "bt_khach";
            bt_khach.Size = new Size(150, 32);
            bt_khach.TabIndex = 41;
            bt_khach.Text = "Khách hàng";
            bt_khach.UseVisualStyleBackColor = true;
            bt_khach.Click += bt_khach_Click;
            // 
            // pic_Cam
            // 
            pic_Cam.BorderStyle = BorderStyle.Fixed3D;
            pic_Cam.Location = new Point(486, 30);
            pic_Cam.Margin = new Padding(2);
            pic_Cam.Name = "pic_Cam";
            pic_Cam.Size = new Size(395, 275);
            pic_Cam.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Cam.TabIndex = 38;
            pic_Cam.TabStop = false;
            // 
            // cbb_chooseDrives
            // 
            cbb_chooseDrives.FormattingEnabled = true;
            cbb_chooseDrives.Location = new Point(36, 85);
            cbb_chooseDrives.Margin = new Padding(2);
            cbb_chooseDrives.Name = "cbb_chooseDrives";
            cbb_chooseDrives.Size = new Size(336, 33);
            cbb_chooseDrives.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 36);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(114, 25);
            label16.TabIndex = 36;
            label16.Text = "Chọn thiết bị";
            // 
            // button4
            // 
            button4.Location = new Point(1439, 882);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 101;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1284, 882);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 100;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1358, 644);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(284, 39);
            button2.TabIndex = 99;
            button2.Text = "Nhập lại";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(1044, 762);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(195, 94);
            button1.TabIndex = 98;
            button1.Text = "Lưu lại và thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tx_sdtNT
            // 
            tx_sdtNT.Location = new Point(1358, 562);
            tx_sdtNT.Margin = new Padding(2);
            tx_sdtNT.Name = "tx_sdtNT";
            tx_sdtNT.Size = new Size(283, 31);
            tx_sdtNT.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1358, 515);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 96;
            label9.Text = "Số điện thoại";
            // 
            // tx_diaChiNT
            // 
            tx_diaChiNT.Location = new Point(1358, 444);
            tx_diaChiNT.Margin = new Padding(2);
            tx_diaChiNT.Name = "tx_diaChiNT";
            tx_diaChiNT.Size = new Size(283, 31);
            tx_diaChiNT.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1358, 396);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 92;
            label11.Text = "Địa chỉ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1358, 296);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 25);
            label12.TabIndex = 90;
            label12.Text = "Giới tính";
            // 
            // tx_cccdNT
            // 
            tx_cccdNT.Location = new Point(1358, 244);
            tx_cccdNT.Margin = new Padding(2);
            tx_cccdNT.Name = "tx_cccdNT";
            tx_cccdNT.Size = new Size(283, 31);
            tx_cccdNT.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1358, 196);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(171, 25);
            label13.TabIndex = 88;
            label13.Text = "Số CCCD/PassProst";
            // 
            // tx_nameNT
            // 
            tx_nameNT.Location = new Point(1358, 144);
            tx_nameNT.Margin = new Padding(2);
            tx_nameNT.Name = "tx_nameNT";
            tx_nameNT.Size = new Size(283, 31);
            tx_nameNT.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1358, 96);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(95, 25);
            label14.TabIndex = 86;
            label14.Text = "Họ và tên";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(1358, 35);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(300, 38);
            label15.TabIndex = 85;
            label15.Text = "Thông tin người thân";
            // 
            // tx_sdtKH
            // 
            tx_sdtKH.Location = new Point(994, 644);
            tx_sdtKH.Margin = new Padding(2);
            tx_sdtKH.Name = "tx_sdtKH";
            tx_sdtKH.Size = new Size(283, 31);
            tx_sdtKH.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(994, 596);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 83;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(994, 496);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 81;
            label7.Text = "Ngày sinh";
            // 
            // tx_diaChiKH
            // 
            tx_diaChiKH.Location = new Point(994, 444);
            tx_diaChiKH.Margin = new Padding(2);
            tx_diaChiKH.Name = "tx_diaChiKH";
            tx_diaChiKH.Size = new Size(283, 31);
            tx_diaChiKH.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(994, 396);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 79;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(994, 296);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 77;
            label5.Text = "Giới tính";
            // 
            // tx_cccdKH
            // 
            tx_cccdKH.Location = new Point(994, 244);
            tx_cccdKH.Margin = new Padding(2);
            tx_cccdKH.Name = "tx_cccdKH";
            tx_cccdKH.Size = new Size(283, 31);
            tx_cccdKH.TabIndex = 2;
            tx_cccdKH.TextChanged += tx_cccdKH_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(994, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 75;
            label4.Text = "Số CCCD/PassProst";
            // 
            // tx_nameKH
            // 
            tx_nameKH.Location = new Point(994, 144);
            tx_nameKH.Margin = new Padding(2);
            tx_nameKH.Name = "tx_nameKH";
            tx_nameKH.Size = new Size(283, 31);
            tx_nameKH.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(994, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 73;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(994, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(305, 38);
            label2.TabIndex = 72;
            label2.Text = "Thông tin khách hàng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lb_idKH);
            groupBox3.Controls.Add(dtgv_data);
            groupBox3.Controls.Add(tx_search);
            groupBox3.Controls.Add(bt_search);
            groupBox3.Location = new Point(15, 352);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(931, 531);
            groupBox3.TabIndex = 103;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng từng thuê";
            // 
            // lb_idKH
            // 
            lb_idKH.AutoSize = true;
            lb_idKH.Location = new Point(21, 55);
            lb_idKH.Margin = new Padding(4, 0, 4, 0);
            lb_idKH.Name = "lb_idKH";
            lb_idKH.Size = new Size(59, 25);
            lb_idKH.TabIndex = 100;
            lb_idKH.Text = "label1";
            lb_idKH.Visible = false;
            // 
            // dtgv_data
            // 
            dtgv_data.AllowUserToAddRows = false;
            dtgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(8, 109);
            dtgv_data.Margin = new Padding(4);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(906, 415);
            dtgv_data.TabIndex = 0;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // tx_search
            // 
            tx_search.Location = new Point(126, 56);
            tx_search.Margin = new Padding(2);
            tx_search.Name = "tx_search";
            tx_search.Size = new Size(463, 31);
            tx_search.TabIndex = 78;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(676, 56);
            bt_search.Margin = new Padding(2);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(112, 34);
            bt_search.TabIndex = 99;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // dtp_ngaySinhKH
            // 
            dtp_ngaySinhKH.Format = DateTimePickerFormat.Short;
            dtp_ngaySinhKH.Location = new Point(994, 548);
            dtp_ngaySinhKH.Margin = new Padding(4);
            dtp_ngaySinhKH.Name = "dtp_ngaySinhKH";
            dtp_ngaySinhKH.Size = new Size(283, 31);
            dtp_ngaySinhKH.TabIndex = 104;
            // 
            // cbb_gtinhKH
            // 
            cbb_gtinhKH.FormattingEnabled = true;
            cbb_gtinhKH.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbb_gtinhKH.Location = new Point(994, 352);
            cbb_gtinhKH.Margin = new Padding(4);
            cbb_gtinhKH.Name = "cbb_gtinhKH";
            cbb_gtinhKH.Size = new Size(283, 33);
            cbb_gtinhKH.TabIndex = 105;
            // 
            // cbb_gtinhNT
            // 
            cbb_gtinhNT.FormattingEnabled = true;
            cbb_gtinhNT.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbb_gtinhNT.Location = new Point(1358, 352);
            cbb_gtinhNT.Margin = new Padding(4);
            cbb_gtinhNT.Name = "cbb_gtinhNT";
            cbb_gtinhNT.Size = new Size(283, 33);
            cbb_gtinhNT.TabIndex = 105;
            // 
            // bt_exit
            // 
            bt_exit.Location = new Point(1358, 762);
            bt_exit.Margin = new Padding(2);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(195, 94);
            bt_exit.TabIndex = 98;
            bt_exit.Text = "Thoát";
            bt_exit.UseVisualStyleBackColor = true;
            bt_exit.Click += bt_exit_Click;
            // 
            // ChonKhachHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 886);
            Controls.Add(cbb_gtinhNT);
            Controls.Add(cbb_gtinhKH);
            Controls.Add(dtp_ngaySinhKH);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(bt_exit);
            Controls.Add(button1);
            Controls.Add(tx_sdtNT);
            Controls.Add(label9);
            Controls.Add(tx_diaChiNT);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(tx_cccdNT);
            Controls.Add(label13);
            Controls.Add(tx_nameNT);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(tx_sdtKH);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tx_diaChiKH);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tx_cccdKH);
            Controls.Add(label4);
            Controls.Add(tx_nameKH);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4);
            Name = "ChonKhachHangForm";
            Text = "ChonKhachHangForm";
            FormClosing += ChonKhachHangForm_FormClosing;
            Load += ChonKhachHangForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Cam).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button bt_stop;
        private Button bt_start;
        private Button bt_nguoiThan;
        private Button bt_khach;
        private PictureBox pic_Cam;
        private ComboBox cbb_chooseDrives;
        private Label label16;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox tx_sdtNT;
        private Label label9;
        private TextBox tx_diaChiNT;
        private Label label11;
        private Label label12;
        private TextBox tx_cccdNT;
        private Label label13;
        private TextBox tx_nameNT;
        private Label label14;
        private Label label15;
        private TextBox tx_sdtKH;
        private Label label8;
        private Label label7;
        private TextBox tx_diaChiKH;
        private Label label6;
        private Label label5;
        private TextBox tx_cccdKH;
        private Label label4;
        private TextBox tx_nameKH;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private DataGridView dtgv_data;
        private System.Windows.Forms.Timer timer1;
        private TextBox tx_search;
        private Button bt_search;
        private DateTimePicker dtp_ngaySinhKH;
        private ComboBox cbb_gtinhKH;
        private ComboBox cbb_gtinhNT;
        private Label lb_idKH;
        private Button bt_exit;
    }
}