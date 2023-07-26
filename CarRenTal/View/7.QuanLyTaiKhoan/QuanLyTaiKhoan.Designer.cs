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
            dateTimePicker1 = new DateTimePicker();
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
            dtgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_data.Location = new Point(49, 431);
            dtgv_data.Margin = new Padding(4);
            dtgv_data.Name = "dtgv_data";
            dtgv_data.RowHeadersWidth = 51;
            dtgv_data.RowTemplate.Height = 29;
            dtgv_data.Size = new Size(1731, 545);
            dtgv_data.TabIndex = 0;
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
            groupBox1.Location = new Point(49, 42);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1731, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(tx_email);
            groupBox11.Location = new Point(1442, 32);
            groupBox11.Margin = new Padding(4);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(4);
            groupBox11.Size = new Size(268, 102);
            groupBox11.TabIndex = 1;
            groupBox11.TabStop = false;
            groupBox11.Text = "Email";
            // 
            // tx_email
            // 
            tx_email.Location = new Point(26, 59);
            tx_email.Margin = new Padding(4);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(229, 31);
            tx_email.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dateTimePicker1);
            groupBox10.Location = new Point(1108, 32);
            groupBox10.Margin = new Padding(4);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(4);
            groupBox10.Size = new Size(268, 102);
            groupBox10.TabIndex = 1;
            groupBox10.TabStop = false;
            groupBox10.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 61);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(tx_sdt);
            groupBox9.Location = new Point(832, 32);
            groupBox9.Margin = new Padding(4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4);
            groupBox9.Size = new Size(268, 102);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Số điện thoại";
            // 
            // tx_sdt
            // 
            tx_sdt.Location = new Point(26, 59);
            tx_sdt.Margin = new Padding(4);
            tx_sdt.Name = "tx_sdt";
            tx_sdt.Size = new Size(229, 31);
            tx_sdt.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tx_adress);
            groupBox8.Location = new Point(558, 32);
            groupBox8.Margin = new Padding(4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4);
            groupBox8.Size = new Size(268, 102);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Địa chỉ";
            // 
            // tx_adress
            // 
            tx_adress.Location = new Point(19, 32);
            tx_adress.Margin = new Padding(4);
            tx_adress.Multiline = true;
            tx_adress.Name = "tx_adress";
            tx_adress.Size = new Size(229, 59);
            tx_adress.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbb_gioiTinh);
            groupBox7.Location = new Point(282, 32);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(268, 102);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Giới tính";
            // 
            // cbb_gioiTinh
            // 
            cbb_gioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_gioiTinh.FormattingEnabled = true;
            cbb_gioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbb_gioiTinh.Location = new Point(31, 58);
            cbb_gioiTinh.Margin = new Padding(4);
            cbb_gioiTinh.Name = "cbb_gioiTinh";
            cbb_gioiTinh.Size = new Size(228, 33);
            cbb_gioiTinh.TabIndex = 0;
            cbb_gioiTinh.SelectedIndexChanged += cbb_gioiTinh_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tx_hoTen);
            groupBox5.Location = new Point(8, 32);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(268, 102);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Họ và tên";
            // 
            // tx_hoTen
            // 
            tx_hoTen.Location = new Point(26, 59);
            tx_hoTen.Margin = new Padding(4);
            tx_hoTen.Name = "tx_hoTen";
            tx_hoTen.Size = new Size(229, 31);
            tx_hoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_search);
            groupBox2.Controls.Add(bt_clear);
            groupBox2.Controls.Add(bt_delete);
            groupBox2.Controls.Add(bt_update);
            groupBox2.Controls.Add(bt_add);
            groupBox2.Controls.Add(tx_search);
            groupBox2.Location = new Point(49, 206);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(878, 218);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bt_search
            // 
            bt_search.Location = new Point(719, 156);
            bt_search.Margin = new Padding(4);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(138, 42);
            bt_search.TabIndex = 6;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            bt_clear.Location = new Point(691, 59);
            bt_clear.Margin = new Padding(4);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(165, 69);
            bt_clear.TabIndex = 7;
            bt_clear.Text = "Clear";
            bt_clear.UseVisualStyleBackColor = true;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(489, 59);
            bt_delete.Margin = new Padding(4);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(165, 69);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(254, 59);
            bt_update.Margin = new Padding(4);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(165, 69);
            bt_update.TabIndex = 9;
            bt_update.Text = "Sửa ";
            bt_update.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(24, 59);
            bt_add.Margin = new Padding(4);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(165, 69);
            bt_add.TabIndex = 10;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            // 
            // tx_search
            // 
            tx_search.Location = new Point(24, 161);
            tx_search.Margin = new Padding(4);
            tx_search.Name = "tx_search";
            tx_search.Size = new Size(629, 31);
            tx_search.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(934, 206);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(846, 218);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin tài khoản";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tx_pass);
            groupBox6.Location = new Point(465, 75);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(276, 112);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mật khẩu";
            // 
            // tx_pass
            // 
            tx_pass.Location = new Point(19, 59);
            tx_pass.Margin = new Padding(4);
            tx_pass.Name = "tx_pass";
            tx_pass.Size = new Size(234, 31);
            tx_pass.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tx_user);
            groupBox4.Location = new Point(98, 75);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(298, 112);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên đăng nhập";
            // 
            // tx_user
            // 
            tx_user.Location = new Point(26, 59);
            tx_user.Margin = new Padding(4);
            tx_user.Name = "tx_user";
            tx_user.Size = new Size(229, 31);
            tx_user.TabIndex = 0;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(939, 14);
            lb_id.Margin = new Padding(4, 0, 4, 0);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(59, 25);
            lb_id.TabIndex = 4;
            lb_id.Text = "label1";
            lb_id.Visible = false;
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 991);
            Controls.Add(lb_id);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtgv_data);
            Margin = new Padding(4);
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
        private DateTimePicker dateTimePicker1;
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