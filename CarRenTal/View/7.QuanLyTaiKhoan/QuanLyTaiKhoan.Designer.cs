namespace CarRenTal.View._7.QuanLyTaiKhoan
{
    partial class QuanLyTaiKhoan
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
            groupBox1 = new GroupBox();
            groupBox11 = new GroupBox();
            tx_email = new TextBox();
            groupBox10 = new GroupBox();
            dtp_dob = new DateTimePicker();
            groupBox9 = new GroupBox();
            tx_sdt = new TextBox();
            groupBox8 = new GroupBox();
            tx_adress = new TextBox();
            groupBox7 = new GroupBox();
            cbb_gioiTinh = new ComboBox();
            groupBox5 = new GroupBox();
            tx_hoTen = new TextBox();
            groupBox2 = new GroupBox();
            bt_search = new Button();
            bt_clear = new Button();
            bt_delete = new Button();
            bt_update = new Button();
            bt_add = new Button();
            tx_search = new TextBox();
            groupBox3 = new GroupBox();
            groupBox6 = new GroupBox();
            tx_pass = new TextBox();
            groupBox4 = new GroupBox();
            tx_user = new TextBox();
            lb_id = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgv_data).BeginInit();
            groupBox1.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_data
            // 
            dtgv_data.AllowUserToAddRows = false;
            dtgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(39, 345);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(1385, 436);
            dtgv_data.TabIndex = 44;
            dtgv_data.CellClick += dtgv_data_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox11);
            groupBox1.Controls.Add(groupBox10);
            groupBox1.Controls.Add(groupBox9);
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1385, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(tx_email);
            groupBox11.Location = new Point(1151, 26);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(214, 82);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Email";
            // 
            // tx_email
            // 
            tx_email.Location = new Point(21, 47);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(184, 27);
            tx_email.TabIndex = 6;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dtp_dob);
            groupBox10.Location = new Point(922, 26);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(214, 82);
            groupBox10.TabIndex = 1;
            groupBox10.TabStop = false;
            groupBox10.Text = "Ngày sinh";
            // 
            // dtp_dob
            // 
            dtp_dob.Format = DateTimePickerFormat.Short;
            dtp_dob.Location = new Point(19, 49);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(180, 27);
            dtp_dob.TabIndex = 5;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tx_sdt);
            groupBox9.Location = new Point(693, 26);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(214, 82);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Số điện thoại";
            // 
            // tx_sdt
            // 
            tx_sdt.Location = new Point(21, 47);
            tx_sdt.Name = "tx_sdt";
            tx_sdt.Size = new Size(184, 27);
            tx_sdt.TabIndex = 4;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tx_adress);
            groupBox8.Location = new Point(464, 26);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(214, 82);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Địa chỉ";
            // 
            // tx_adress
            // 
            tx_adress.Location = new Point(15, 26);
            tx_adress.Multiline = true;
            tx_adress.Name = "tx_adress";
            tx_adress.Size = new Size(184, 48);
            tx_adress.TabIndex = 3;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbb_gioiTinh);
            groupBox7.Location = new Point(235, 26);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(214, 82);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Giới tính";
            // 
            // cbb_gioiTinh
            // 
            cbb_gioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_gioiTinh.FormattingEnabled = true;
            cbb_gioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbb_gioiTinh.Location = new Point(25, 46);
            cbb_gioiTinh.Name = "cbb_gioiTinh";
            cbb_gioiTinh.Size = new Size(183, 28);
            cbb_gioiTinh.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tx_hoTen);
            groupBox5.Location = new Point(6, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(214, 82);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Họ và tên";
            // 
            // tx_hoTen
            // 
            tx_hoTen.Location = new Point(21, 47);
            tx_hoTen.Name = "tx_hoTen";
            tx_hoTen.Size = new Size(184, 27);
            tx_hoTen.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_search);
            groupBox2.Controls.Add(bt_clear);
            groupBox2.Controls.Add(bt_delete);
            groupBox2.Controls.Add(bt_update);
            groupBox2.Controls.Add(bt_add);
            groupBox2.Controls.Add(tx_search);
            groupBox2.Location = new Point(39, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(702, 174);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bt_search
            // 
            bt_search.Location = new Point(575, 125);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(110, 34);
            bt_search.TabIndex = 6;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(553, 47);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(132, 55);
            bt_clear.TabIndex = 12;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(391, 47);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(132, 55);
            bt_delete.TabIndex = 11;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(203, 47);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(132, 55);
            bt_update.TabIndex = 10;
            bt_update.Text = "Sửa ";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(19, 47);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(132, 55);
            bt_add.TabIndex = 9;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // tx_search
            // 
            tx_search.Location = new Point(19, 129);
            tx_search.Name = "tx_search";
            tx_search.Size = new Size(504, 27);
            tx_search.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(747, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(677, 174);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin tài khoản";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tx_pass);
            groupBox6.Location = new Point(372, 60);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(221, 90);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mật khẩu";
            // 
            // tx_pass
            // 
            tx_pass.Location = new Point(15, 47);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(188, 27);
            tx_pass.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tx_user);
            groupBox4.Location = new Point(78, 60);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(238, 90);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên đăng nhập";
            // 
            // tx_user
            // 
            tx_user.Location = new Point(21, 47);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(184, 27);
            tx_user.TabIndex = 7;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(751, 11);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(50, 20);
            lb_id.TabIndex = 4;
            lb_id.Text = "label1";
            lb_id.Visible = false;
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1482, 793);
            Controls.Add(lb_id);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgv_data);
            Name = "QuanLyTaiKhoan";
            Text = "QuanLyTaiKhoan";
            Load += QuanLyTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_data;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button bt_search;
        private Button bt_clear;
        private Button bt_delete;
        private Button bt_update;
        private Button bt_add;
        private TextBox tx_search;
        private GroupBox groupBox3;
        private TextBox tx_pass;
        private TextBox tx_user;
        private GroupBox groupBox11;
        private TextBox tx_email;
        private GroupBox groupBox10;
        private DateTimePicker dtp_dob;
        private GroupBox groupBox9;
        private TextBox tx_sdt;
        private GroupBox groupBox8;
        private TextBox tx_adress;
        private GroupBox groupBox7;
        private ComboBox cbb_gioiTinh;
        private GroupBox groupBox5;
        private TextBox tx_hoTen;
        private GroupBox groupBox6;
        private GroupBox groupBox4;
        private Label lb_id;
    }
}