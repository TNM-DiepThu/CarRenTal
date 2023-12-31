﻿namespace CarRenTal.View.QuanLiXe
{
    partial class LoaiXeView
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
            tb_lnl = new ComboBox();
            dtg_show = new DataGridView();
            tb_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            bt_add = new Button();
            cbb_hangxe = new ComboBox();
            bt_edit = new Button();
            bt_del = new Button();
            rd_0 = new RadioButton();
            rd_1 = new RadioButton();
            colorDialog1 = new ColorDialog();
            tb_soghe = new ComboBox();
            tb_loaisoxe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // tb_lnl
            // 
            tb_lnl.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_lnl.FormattingEnabled = true;
            tb_lnl.Items.AddRange(new object[] { "Xăng", "Dầu", "Điện" });
            tb_lnl.Location = new Point(26, 105);
            tb_lnl.Name = "tb_lnl";
            tb_lnl.Size = new Size(246, 28);
            tb_lnl.TabIndex = 5;
            tb_lnl.SelectedIndexChanged += cbb_hangxe_SelectedIndexChanged;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(303, 12);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(843, 455);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(26, 48);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(246, 27);
            tb_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên loại xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Loại nhiên liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 139);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Số ghế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Loại số xe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 273);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Hãng xe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 327);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 2;
            label7.Text = "Trạng thái";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(11, 504);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(112, 44);
            bt_add.TabIndex = 4;
            bt_add.Text = "Thêm ";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // cbb_hangxe
            // 
            cbb_hangxe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_hangxe.FormattingEnabled = true;
            cbb_hangxe.Location = new Point(26, 296);
            cbb_hangxe.Name = "cbb_hangxe";
            cbb_hangxe.Size = new Size(246, 28);
            cbb_hangxe.TabIndex = 5;
            cbb_hangxe.SelectedIndexChanged += cbb_hangxe_SelectedIndexChanged;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(139, 504);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(112, 44);
            bt_edit.TabIndex = 4;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(258, 504);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(112, 44);
            bt_del.TabIndex = 4;
            bt_del.Text = "Xoá";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // rd_0
            // 
            rd_0.AutoSize = true;
            rd_0.Location = new Point(39, 363);
            rd_0.Name = "rd_0";
            rd_0.Size = new Size(102, 24);
            rd_0.TabIndex = 6;
            rd_0.TabStop = true;
            rd_0.Text = "Hoạt động";
            rd_0.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Location = new Point(39, 393);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(146, 24);
            rd_1.TabIndex = 6;
            rd_1.TabStop = true;
            rd_1.Text = "Không hoạt động";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // tb_soghe
            // 
            tb_soghe.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_soghe.FormattingEnabled = true;
            tb_soghe.Items.AddRange(new object[] { "4", "7", "16" });
            tb_soghe.Location = new Point(26, 165);
            tb_soghe.Name = "tb_soghe";
            tb_soghe.Size = new Size(246, 28);
            tb_soghe.TabIndex = 5;
            tb_soghe.SelectedIndexChanged += cbb_hangxe_SelectedIndexChanged;
            // 
            // tb_loaisoxe
            // 
            tb_loaisoxe.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_loaisoxe.FormattingEnabled = true;
            tb_loaisoxe.Items.AddRange(new object[] { "Số sàn", "Số tự động" });
            tb_loaisoxe.Location = new Point(26, 229);
            tb_loaisoxe.Name = "tb_loaisoxe";
            tb_loaisoxe.Size = new Size(246, 28);
            tb_loaisoxe.TabIndex = 5;
            tb_loaisoxe.SelectedIndexChanged += cbb_hangxe_SelectedIndexChanged;
            // 
            // LoaiXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 560);
            Controls.Add(rd_1);
            Controls.Add(rd_0);
            Controls.Add(tb_lnl);
            Controls.Add(tb_soghe);
            Controls.Add(tb_loaisoxe);
            Controls.Add(cbb_hangxe);
            Controls.Add(bt_del);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Controls.Add(dtg_show);
            MaximumSize = new Size(1176, 607);
            MinimumSize = new Size(1176, 607);
            Name = "LoaiXeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại xe";
            Load += LoaiXeView_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button bt_add;
        private ComboBox cbb_hangxe;
        private Button bt_edit;
        private Button bt_del;
        private RadioButton rd_0;
        private RadioButton rd_1;
        private ColorDialog colorDialog1;
        private ComboBox tb_soghe;
        private ComboBox tb_loaisoxe;
        private ComboBox tb_lnl;
    }
}