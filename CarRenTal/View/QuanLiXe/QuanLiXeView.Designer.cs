namespace CarRenTal
{
    partial class QuanLiXeView
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
            dtg_show = new DataGridView();
            tb_seach = new TextBox();
            bt_dhdk = new Button();
            bt_hhdk = new Button();
            bt_add = new Button();
            bt_bd = new Button();
            cb_lsg = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            bt_edit = new Button();
            bt_bh = new Button();
            bt_dk = new Button();
            bt_hx = new Button();
            bt_qllx = new Button();
            label3 = new Label();
            label4 = new Label();
            cb_seachms = new ComboBox();
            bt_lbh = new Button();
            cb_seachhx = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.AllowUserToAddRows = false;
            dtg_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(42, 106);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(1428, 543);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_seach
            // 
            tb_seach.Location = new Point(42, 43);
            tb_seach.Name = "tb_seach";
            tb_seach.Size = new Size(293, 27);
            tb_seach.TabIndex = 1;
            tb_seach.TextChanged += tb_seach_TextChanged;
            // 
            // bt_dhdk
            // 
            bt_dhdk.Location = new Point(1199, 27);
            bt_dhdk.Name = "bt_dhdk";
            bt_dhdk.Size = new Size(204, 58);
            bt_dhdk.TabIndex = 2;
            bt_dhdk.Text = "Hết hạn đăng kiểm";
            bt_dhdk.UseVisualStyleBackColor = true;
            bt_dhdk.Click += bt_dhdk_Click;
            // 
            // bt_hhdk
            // 
            bt_hhdk.Location = new Point(974, 27);
            bt_hhdk.Name = "bt_hhdk";
            bt_hhdk.Size = new Size(204, 58);
            bt_hhdk.TabIndex = 2;
            bt_hhdk.Text = "Còn hạn đăng kiểm";
            bt_hhdk.UseVisualStyleBackColor = true;
            bt_hhdk.Click += bt_hhdk_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(1283, 699);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(187, 58);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm xe";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_bd
            // 
            bt_bd.Location = new Point(42, 699);
            bt_bd.Name = "bt_bd";
            bt_bd.Size = new Size(154, 58);
            bt_bd.TabIndex = 2;
            bt_bd.Text = "Xem bảo dưỡng Xe";
            bt_bd.UseVisualStyleBackColor = true;
            bt_bd.Click += bt_dk_Click;
            // 
            // cb_lsg
            // 
            cb_lsg.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lsg.FormattingEnabled = true;
            cb_lsg.Items.AddRange(new object[] { "", "4", "7", "16" });
            cb_lsg.Location = new Point(379, 41);
            cb_lsg.Name = "cb_lsg";
            cb_lsg.Size = new Size(151, 28);
            cb_lsg.TabIndex = 3;
            cb_lsg.SelectedIndexChanged += cb_lsg_SelectedIndexChanged;
            cb_lsg.TextChanged += comboBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm theo số ghế";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 9);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 4;
            label2.Text = "Tìm kiếm theo tên hoặc biển số";
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(1090, 699);
            bt_edit.Margin = new Padding(3, 4, 3, 4);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(187, 58);
            bt_edit.TabIndex = 5;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_bh
            // 
            bt_bh.Location = new Point(202, 699);
            bt_bh.Margin = new Padding(3, 4, 3, 4);
            bt_bh.Name = "bt_bh";
            bt_bh.Size = new Size(154, 58);
            bt_bh.TabIndex = 6;
            bt_bh.Text = "Xem bảo hiểm xe";
            bt_bh.UseVisualStyleBackColor = true;
            bt_bh.Click += bt_bh_Click;
            // 
            // bt_dk
            // 
            bt_dk.Location = new Point(363, 699);
            bt_dk.Margin = new Padding(3, 4, 3, 4);
            bt_dk.Name = "bt_dk";
            bt_dk.Size = new Size(154, 58);
            bt_dk.TabIndex = 7;
            bt_dk.Text = "Xem đăng kiểm xe";
            bt_dk.UseVisualStyleBackColor = true;
            bt_dk.Click += bt_dk_Click_1;
            // 
            // bt_hx
            // 
            bt_hx.Location = new Point(523, 699);
            bt_hx.Name = "bt_hx";
            bt_hx.Size = new Size(154, 58);
            bt_hx.TabIndex = 8;
            bt_hx.Text = "Quản lí hãng xe";
            bt_hx.UseVisualStyleBackColor = true;
            bt_hx.Click += bt_hx_Click;
            // 
            // bt_qllx
            // 
            bt_qllx.Location = new Point(683, 699);
            bt_qllx.Name = "bt_qllx";
            bt_qllx.Size = new Size(154, 58);
            bt_qllx.TabIndex = 8;
            bt_qllx.Text = "Quản lí loại xe";
            bt_qllx.UseVisualStyleBackColor = true;
            bt_qllx.Click += bt_qllx_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 9);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 4;
            label3.Text = "Tìm kiếm theo hãng xe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(552, 9);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 4;
            label4.Text = "Tìm kiếm theo màu sắc";
            // 
            // cb_seachms
            // 
            cb_seachms.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_seachms.FormattingEnabled = true;
            cb_seachms.Location = new Point(552, 42);
            cb_seachms.Name = "cb_seachms";
            cb_seachms.Size = new Size(151, 28);
            cb_seachms.TabIndex = 9;
            cb_seachms.SelectedIndexChanged += cb_seachms_SelectedIndexChanged;
            cb_seachms.TextChanged += cb_seachms_TextChanged;
            // 
            // bt_lbh
            // 
            bt_lbh.Location = new Point(843, 699);
            bt_lbh.Name = "bt_lbh";
            bt_lbh.Size = new Size(154, 58);
            bt_lbh.TabIndex = 10;
            bt_lbh.Text = "Quản lý loại bảo hiểm";
            bt_lbh.UseVisualStyleBackColor = true;
            bt_lbh.Click += bt_lbh_Click;
            // 
            // cb_seachhx
            // 
            cb_seachhx.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_seachhx.FormattingEnabled = true;
            cb_seachhx.Location = new Point(720, 43);
            cb_seachhx.Name = "cb_seachhx";
            cb_seachhx.Size = new Size(151, 28);
            cb_seachhx.TabIndex = 11;
            cb_seachhx.SelectedIndexChanged += cb_seachhx_SelectedIndexChanged;
            cb_seachhx.TextChanged += cb_seachhx_TextChanged_1;
            // 
            // QuanLiXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 793);
            Controls.Add(cb_seachhx);
            Controls.Add(bt_lbh);
            Controls.Add(cb_seachms);
            Controls.Add(bt_qllx);
            Controls.Add(bt_hx);
            Controls.Add(bt_dk);
            Controls.Add(bt_bh);
            Controls.Add(bt_edit);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cb_lsg);
            Controls.Add(bt_hhdk);
            Controls.Add(bt_dhdk);
            Controls.Add(bt_bd);
            Controls.Add(bt_add);
            Controls.Add(tb_seach);
            Controls.Add(dtg_show);
            MaximumSize = new Size(1500, 840);
            MinimumSize = new Size(1500, 840);
            Name = "QuanLiXeView";
            Text = "Quản lý xe";
            Load += QuanLiXe_Load;
            Click += QuanLiXeView_Click;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_seach;
        private Button bt_dhdk;
        private Button bt_hhdk;
        private Button bt_add;
        private Button bt_bd;
        private ComboBox cb_lsg;
        private Label label1;
        private Label label2;
        private Button bt_edit;
        private Button bt_bh;
        private Button bt_dk;
        private Button bt_hx;
        private Button bt_qllx;
        private Label label3;
        private Label label4;
        private ComboBox cb_seachms;
        private Button bt_lbh;
        private ComboBox cb_seachhx;
    }
}