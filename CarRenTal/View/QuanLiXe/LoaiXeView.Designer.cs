namespace CarRenTal.View.QuanLiXe
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
            dtg_show = new DataGridView();
            tb_name = new TextBox();
            label1 = new Label();
            tb_lnl = new TextBox();
            label2 = new Label();
            tb_soghe = new TextBox();
            label3 = new Label();
            tb_loaisoxe = new TextBox();
            label4 = new Label();
            tb_nltt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            bt_add = new Button();
            cbb_hangxe = new ComboBox();
            bt_edit = new Button();
            bt_del = new Button();
            rd_0 = new RadioButton();
            rd_1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
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
            // tb_lnl
            // 
            tb_lnl.Location = new Point(26, 105);
            tb_lnl.Name = "tb_lnl";
            tb_lnl.Size = new Size(246, 27);
            tb_lnl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Loại nhiên liệu";
            // 
            // tb_soghe
            // 
            tb_soghe.Location = new Point(26, 161);
            tb_soghe.Name = "tb_soghe";
            tb_soghe.Size = new Size(246, 27);
            tb_soghe.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 138);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Số ghế";
            // 
            // tb_loaisoxe
            // 
            tb_loaisoxe.Location = new Point(26, 220);
            tb_loaisoxe.Name = "tb_loaisoxe";
            tb_loaisoxe.Size = new Size(246, 27);
            tb_loaisoxe.TabIndex = 1;
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
            // tb_nltt
            // 
            tb_nltt.Location = new Point(26, 284);
            tb_nltt.Name = "tb_nltt";
            tb_nltt.Size = new Size(246, 27);
            tb_nltt.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 261);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 2;
            label5.Text = "Nhiên liệu tiêu thụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 317);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Hãng xe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 377);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 2;
            label7.Text = "Trạng thái";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(12, 504);
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
            cbb_hangxe.Location = new Point(26, 349);
            cbb_hangxe.Name = "cbb_hangxe";
            cbb_hangxe.Size = new Size(246, 28);
            cbb_hangxe.TabIndex = 5;
            cbb_hangxe.SelectedIndexChanged += cbb_hangxe_SelectedIndexChanged;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(140, 504);
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
            rd_0.Location = new Point(53, 413);
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
            rd_1.Location = new Point(53, 455);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(146, 24);
            rd_1.TabIndex = 6;
            rd_1.TabStop = true;
            rd_1.Text = "Không hoạt động";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // LoaiXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 560);
            Controls.Add(rd_1);
            Controls.Add(rd_0);
            Controls.Add(cbb_hangxe);
            Controls.Add(bt_del);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_nltt);
            Controls.Add(tb_loaisoxe);
            Controls.Add(tb_soghe);
            Controls.Add(tb_lnl);
            Controls.Add(tb_name);
            Controls.Add(dtg_show);
            Name = "LoaiXeView";
            Text = "LoaiXeView";
            Load += LoaiXeView_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_name;
        private Label label1;
        private TextBox tb_lnl;
        private Label label2;
        private TextBox tb_soghe;
        private Label label3;
        private TextBox tb_loaisoxe;
        private Label label4;
        private TextBox tb_nltt;
        private Label label5;
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
    }
}