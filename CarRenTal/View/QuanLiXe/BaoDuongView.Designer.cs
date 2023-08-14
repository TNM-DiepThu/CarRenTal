namespace CarRenTal.View.QuanLiXe
{
    partial class BaoDuongView
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
            tb_ct = new TextBox();
            tb_cphi = new TextBox();
            dtp_bd = new DateTimePicker();
            dtp_kt = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_add = new Button();
            bt_edit = new Button();
            tb_chitiet = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(34, 34);
            dtg_show.MaximumSize = new Size(841, 385);
            dtg_show.MinimumSize = new Size(841, 385);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(841, 385);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_ct
            // 
            tb_ct.Location = new Point(893, 216);
            tb_ct.Name = "tb_ct";
            tb_ct.Size = new Size(360, 27);
            tb_ct.TabIndex = 1;
            // 
            // tb_cphi
            // 
            tb_cphi.Location = new Point(893, 163);
            tb_cphi.Name = "tb_cphi";
            tb_cphi.Size = new Size(360, 27);
            tb_cphi.TabIndex = 1;
            // 
            // dtp_bd
            // 
            dtp_bd.Location = new Point(893, 57);
            dtp_bd.Name = "dtp_bd";
            dtp_bd.Size = new Size(360, 27);
            dtp_bd.TabIndex = 2;
            // 
            // dtp_kt
            // 
            dtp_kt.Location = new Point(893, 110);
            dtp_kt.Name = "dtp_kt";
            dtp_kt.Size = new Size(360, 27);
            dtp_kt.TabIndex = 2;
            dtp_kt.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(893, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(893, 87);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Ngày kết thúc";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(893, 140);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Chi phí";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(893, 193);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Số công tơ";
            label4.Click += label2_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(893, 375);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(177, 44);
            bt_add.TabIndex = 4;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(1076, 375);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(177, 44);
            bt_edit.TabIndex = 4;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // tb_chitiet
            // 
            tb_chitiet.Location = new Point(893, 273);
            tb_chitiet.Multiline = true;
            tb_chitiet.Name = "tb_chitiet";
            tb_chitiet.Size = new Size(360, 96);
            tb_chitiet.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(893, 246);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "Chi tiết";
            label5.Click += label2_Click;
            // 
            // BaoDuongView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 460);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp_kt);
            Controls.Add(dtp_bd);
            Controls.Add(tb_cphi);
            Controls.Add(tb_chitiet);
            Controls.Add(tb_ct);
            Controls.Add(dtg_show);
            Name = "BaoDuongView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảo dưỡng";
            Load += BaoDuongView_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_ct;
        private TextBox tb_cphi;
        private DateTimePicker dtp_bd;
        private DateTimePicker dtp_kt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_add;
        private Button bt_edit;
        private TextBox tb_chitiet;
        private Label label5;
    }
}