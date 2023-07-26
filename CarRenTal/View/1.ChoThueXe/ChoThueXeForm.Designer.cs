namespace CarRenTal.View._1.ChoThueXe
{
    partial class ChoThueXeForm
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
            cbb_hangXe = new ComboBox();
            cbb_nhienLieu = new ComboBox();
            cbb_soGhe = new ComboBox();
            groupBox2 = new GroupBox();
            bt_deleteAll = new Button();
            dt_delete = new Button();
            bt_add = new Button();
            bt_search = new Button();
            tx_search = new TextBox();
            dtgv_xeChon = new DataGridView();
            dtgv_xeSS = new DataGridView();
            label15 = new Label();
            label14 = new Label();
            nud_maxGia = new NumericUpDown();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            nud_minGia = new NumericUpDown();
            groupBox4 = new GroupBox();
            dtp_ngayTra = new DateTimePicker();
            dtp_ngayThue = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            groupBox5 = new GroupBox();
            button3 = new Button();
            label7 = new Label();
            lb_idKhach = new Label();
            label5 = new Label();
            tx_canCuoc = new TextBox();
            tx_nameKhach = new TextBox();
            groupBox6 = new GroupBox();
            button4 = new Button();
            button2 = new Button();
            cbb_trangThai = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tx_phiThanhToan = new TextBox();
            tx_coc = new TextBox();
            tx_phiThue = new TextBox();
            groupBox7 = new GroupBox();
            bt_taiSan = new ComboBox();
            cbb_typeGiayTo = new ComboBox();
            label6 = new Label();
            tx_maHopDong = new TextBox();
            label16 = new Label();
            tx_chiTiet = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_xeChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_xeSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_maxGia).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_minGia).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(cbb_hangXe);
            groupBox1.Controls.Add(cbb_nhienLieu);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(cbb_soGhe);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin xe";
            // 
            // cbb_hangXe
            // 
            cbb_hangXe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_hangXe.FormattingEnabled = true;
            cbb_hangXe.Location = new Point(368, 96);
            cbb_hangXe.Name = "cbb_hangXe";
            cbb_hangXe.Size = new Size(151, 28);
            cbb_hangXe.TabIndex = 0;
            // 
            // cbb_nhienLieu
            // 
            cbb_nhienLieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_nhienLieu.FormattingEnabled = true;
            cbb_nhienLieu.Items.AddRange(new object[] { "Xăng ", "Dầu", "Điện" });
            cbb_nhienLieu.Location = new Point(368, 44);
            cbb_nhienLieu.Name = "cbb_nhienLieu";
            cbb_nhienLieu.Size = new Size(151, 28);
            cbb_nhienLieu.TabIndex = 1;
            // 
            // cbb_soGhe
            // 
            cbb_soGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_soGhe.FormattingEnabled = true;
            cbb_soGhe.Items.AddRange(new object[] { "4", "7", "16" });
            cbb_soGhe.Location = new Point(93, 42);
            cbb_soGhe.Name = "cbb_soGhe";
            cbb_soGhe.Size = new Size(151, 28);
            cbb_soGhe.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_deleteAll);
            groupBox2.Controls.Add(dt_delete);
            groupBox2.Controls.Add(bt_add);
            groupBox2.Controls.Add(bt_search);
            groupBox2.Controls.Add(tx_search);
            groupBox2.Controls.Add(dtgv_xeChon);
            groupBox2.Controls.Add(dtgv_xeSS);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(21, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(974, 631);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin xe";
            // 
            // bt_deleteAll
            // 
            bt_deleteAll.Location = new Point(856, 352);
            bt_deleteAll.Name = "bt_deleteAll";
            bt_deleteAll.Size = new Size(100, 29);
            bt_deleteAll.TabIndex = 2;
            bt_deleteAll.Text = "Xóa hết";
            bt_deleteAll.UseVisualStyleBackColor = true;
            // 
            // dt_delete
            // 
            dt_delete.Location = new Point(676, 352);
            dt_delete.Name = "dt_delete";
            dt_delete.Size = new Size(100, 29);
            dt_delete.TabIndex = 2;
            dt_delete.Text = "Xóa";
            dt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(856, 40);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(100, 29);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(676, 40);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(94, 29);
            bt_search.TabIndex = 2;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            // 
            // tx_search
            // 
            tx_search.Location = new Point(197, 40);
            tx_search.Name = "tx_search";
            tx_search.Size = new Size(463, 27);
            tx_search.TabIndex = 1;
            // 
            // dtgv_xeChon
            // 
            dtgv_xeChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_xeChon.Location = new Point(13, 396);
            dtgv_xeChon.Name = "dtgv_xeChon";
            dtgv_xeChon.RowHeadersWidth = 51;
            dtgv_xeChon.RowTemplate.Height = 29;
            dtgv_xeChon.Size = new Size(964, 219);
            dtgv_xeChon.TabIndex = 0;
            // 
            // dtgv_xeSS
            // 
            dtgv_xeSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_xeSS.Location = new Point(13, 86);
            dtgv_xeSS.Name = "dtgv_xeSS";
            dtgv_xeSS.RowHeadersWidth = 51;
            dtgv_xeSS.RowTemplate.Height = 29;
            dtgv_xeSS.Size = new Size(964, 243);
            dtgv_xeSS.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(13, 40);
            label15.Name = "label15";
            label15.Size = new Size(166, 20);
            label15.TabIndex = 2;
            label15.Text = "Thông tin xe sẵn sàng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(13, 361);
            label14.Name = "label14";
            label14.Size = new Size(160, 20);
            label14.TabIndex = 2;
            label14.Text = "Thông tin xe đã chọn:";
            // 
            // nud_maxGia
            // 
            nud_maxGia.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_maxGia.Location = new Point(283, 26);
            nud_maxGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nud_maxGia.Name = "nud_maxGia";
            nud_maxGia.Size = new Size(150, 27);
            nud_maxGia.TabIndex = 1;
            nud_maxGia.Value = new decimal(new int[] { 100000000, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(nud_maxGia);
            groupBox3.Controls.Add(nud_minGia);
            groupBox3.Location = new Point(556, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(439, 70);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khoảng giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 33);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ:";
            // 
            // nud_minGia
            // 
            nud_minGia.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_minGia.Location = new Point(62, 26);
            nud_minGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nud_minGia.Name = "nud_minGia";
            nud_minGia.Size = new Size(141, 27);
            nud_minGia.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtp_ngayTra);
            groupBox4.Controls.Add(dtp_ngayThue);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(556, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 70);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ngày thuê";
            // 
            // dtp_ngayTra
            // 
            dtp_ngayTra.Format = DateTimePickerFormat.Short;
            dtp_ngayTra.Location = new Point(283, 28);
            dtp_ngayTra.Name = "dtp_ngayTra";
            dtp_ngayTra.Size = new Size(141, 27);
            dtp_ngayTra.TabIndex = 3;
            // 
            // dtp_ngayThue
            // 
            dtp_ngayThue.Format = DateTimePickerFormat.Short;
            dtp_ngayThue.Location = new Point(62, 29);
            dtp_ngayThue.Name = "dtp_ngayThue";
            dtp_ngayThue.Size = new Size(141, 27);
            dtp_ngayThue.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(227, 33);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Đến:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 2;
            label4.Text = "Từ:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button3);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(lb_idKhach);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(tx_canCuoc);
            groupBox5.Controls.Add(tx_nameKhach);
            groupBox5.Location = new Point(1001, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(453, 140);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin khách hàng";
            // 
            // button3
            // 
            button3.Location = new Point(18, 103);
            button3.Name = "button3";
            button3.Size = new Size(435, 37);
            button3.TabIndex = 2;
            button3.Text = "Chọn khách hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 73);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 2;
            label7.Text = "Số căn cước:";
            // 
            // lb_idKhach
            // 
            lb_idKhach.AutoSize = true;
            lb_idKhach.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_idKhach.Location = new Point(360, -3);
            lb_idKhach.Name = "lb_idKhach";
            lb_idKhach.Size = new Size(109, 20);
            lb_idKhach.TabIndex = 2;
            lb_idKhach.Text = "ID khách hàng";
            lb_idKhach.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 33);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 2;
            label5.Text = "Tên khách hàng:";
            // 
            // tx_canCuoc
            // 
            tx_canCuoc.Location = new Point(168, 70);
            tx_canCuoc.Name = "tx_canCuoc";
            tx_canCuoc.ReadOnly = true;
            tx_canCuoc.Size = new Size(285, 27);
            tx_canCuoc.TabIndex = 1;
            // 
            // tx_nameKhach
            // 
            tx_nameKhach.Location = new Point(168, 26);
            tx_nameKhach.Name = "tx_nameKhach";
            tx_nameKhach.ReadOnly = true;
            tx_nameKhach.Size = new Size(285, 27);
            tx_nameKhach.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button4);
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(cbb_trangThai);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(tx_phiThanhToan);
            groupBox6.Controls.Add(tx_coc);
            groupBox6.Controls.Add(tx_phiThue);
            groupBox6.Location = new Point(1001, 401);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(453, 388);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thanh toán hóa đơn";
            // 
            // button4
            // 
            button4.Location = new Point(249, 309);
            button4.Name = "button4";
            button4.Size = new Size(162, 51);
            button4.TabIndex = 3;
            button4.Text = "Hủy";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 309);
            button2.Name = "button2";
            button2.Size = new Size(162, 51);
            button2.TabIndex = 3;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbb_trangThai
            // 
            cbb_trangThai.FormattingEnabled = true;
            cbb_trangThai.Items.AddRange(new object[] { "Đã cọc", "Đã lấy xe" });
            cbb_trangThai.Location = new Point(188, 53);
            cbb_trangThai.Name = "cbb_trangThai";
            cbb_trangThai.Size = new Size(223, 28);
            cbb_trangThai.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(6, 233);
            label13.Name = "label13";
            label13.Size = new Size(149, 20);
            label13.TabIndex = 2;
            label13.Text = "Thanh toán hiện tại:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(9, 178);
            label12.Name = "label12";
            label12.Size = new Size(173, 20);
            label12.TabIndex = 2;
            label12.Text = "Phí Cọc( 10% phí thuê):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 111);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 2;
            label11.Text = "Phí Thuê:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 56);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 2;
            label10.Text = "Trạng thái hóa đơn:";
            // 
            // tx_phiThanhToan
            // 
            tx_phiThanhToan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tx_phiThanhToan.Location = new Point(188, 221);
            tx_phiThanhToan.Name = "tx_phiThanhToan";
            tx_phiThanhToan.ReadOnly = true;
            tx_phiThanhToan.Size = new Size(223, 38);
            tx_phiThanhToan.TabIndex = 1;
            // 
            // tx_coc
            // 
            tx_coc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tx_coc.Location = new Point(188, 166);
            tx_coc.Name = "tx_coc";
            tx_coc.ReadOnly = true;
            tx_coc.Size = new Size(223, 38);
            tx_coc.TabIndex = 1;
            // 
            // tx_phiThue
            // 
            tx_phiThue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tx_phiThue.Location = new Point(188, 108);
            tx_phiThue.Name = "tx_phiThue";
            tx_phiThue.ReadOnly = true;
            tx_phiThue.Size = new Size(223, 38);
            tx_phiThue.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(bt_taiSan);
            groupBox7.Controls.Add(cbb_typeGiayTo);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(tx_maHopDong);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(tx_chiTiet);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label9);
            groupBox7.Location = new Point(1001, 158);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(453, 237);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thế chấp và hợp đồng";
            groupBox7.Visible = false;
            // 
            // bt_taiSan
            // 
            bt_taiSan.FormattingEnabled = true;
            bt_taiSan.Location = new Point(188, 86);
            bt_taiSan.Name = "bt_taiSan";
            bt_taiSan.Size = new Size(223, 28);
            bt_taiSan.TabIndex = 4;
            // 
            // cbb_typeGiayTo
            // 
            cbb_typeGiayTo.FormattingEnabled = true;
            cbb_typeGiayTo.Location = new Point(188, 37);
            cbb_typeGiayTo.Name = "cbb_typeGiayTo";
            cbb_typeGiayTo.Size = new Size(223, 28);
            cbb_typeGiayTo.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 40);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 2;
            label6.Text = "Loại giấy tờ:";
            // 
            // tx_maHopDong
            // 
            tx_maHopDong.Location = new Point(188, 190);
            tx_maHopDong.Name = "tx_maHopDong";
            tx_maHopDong.ReadOnly = true;
            tx_maHopDong.Size = new Size(223, 27);
            tx_maHopDong.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(19, 197);
            label16.Name = "label16";
            label16.Size = new Size(106, 20);
            label16.TabIndex = 2;
            label16.Text = "Mã hợp đồng:";
            // 
            // tx_chiTiet
            // 
            tx_chiTiet.Location = new Point(188, 138);
            tx_chiTiet.Name = "tx_chiTiet";
            tx_chiTiet.Size = new Size(223, 27);
            tx_chiTiet.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 145);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 2;
            label8.Text = "Chi tiết:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(18, 89);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 2;
            label9.Text = "Loại tài sản:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(6, 50);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 2;
            label17.Text = "Số ghế:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(6, 104);
            label18.Name = "label18";
            label18.Size = new Size(62, 20);
            label18.TabIndex = 2;
            label18.Text = "Hộp số:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(278, 52);
            label19.Name = "label19";
            label19.Size = new Size(84, 20);
            label19.TabIndex = 2;
            label19.Text = "Nhiên liệu:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(278, 104);
            label20.Name = "label20";
            label20.Size = new Size(70, 20);
            label20.TabIndex = 2;
            label20.Text = "Hãng xe:";
            // 
            // ChoThueXeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 793);
            Controls.Add(groupBox6);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ChoThueXeForm";
            Load += ChoThueXeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_xeChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgv_xeSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_maxGia).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_minGia).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbb_nhienLieu;
        private ComboBox cbb_soGhe;
        private GroupBox groupBox2;
        private Button bt_search;
        private TextBox tx_search;
        private DataGridView dtgv_xeChon;
        private DataGridView dtgv_xeSS;
        private NumericUpDown nud_maxGia;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private NumericUpDown nud_minGia;
        private GroupBox groupBox4;
        private Label label3;
        private Label label4;
        private ComboBox cbb_hangXe;
        private DateTimePicker dtp_ngayTra;
        private DateTimePicker dtp_ngayThue;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button button3;
        private Label label7;
        private Label lb_idKhach;
        private Label label5;
        private TextBox tx_canCuoc;
        private TextBox tx_nameKhach;
        private ComboBox cbb_trangThai;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox tx_phiThanhToan;
        private TextBox tx_coc;
        private TextBox tx_phiThue;
        private GroupBox groupBox7;
        private ComboBox bt_taiSan;
        private ComboBox cbb_typeGiayTo;
        private Label label6;
        private TextBox tx_chiTiet;
        private Label label8;
        private Label label9;
        private Button bt_deleteAll;
        private Button dt_delete;
        private Button bt_add;
        private Label label15;
        private Label label14;
        private Button button4;
        private Button button2;
        private TextBox tx_maHopDong;
        private Label label16;
        private ComboBox comboBox1;
        private Label label18;
        private Label label20;
        private Label label19;
        private Label label17;
    }
}