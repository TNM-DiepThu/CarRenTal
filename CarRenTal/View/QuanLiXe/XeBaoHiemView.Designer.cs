namespace CarRenTal.View.QuanLiXe
{
    partial class XeBaoHiemView
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
            dtp_bd = new DateTimePicker();
            dtp_kt = new DateTimePicker();
            cb_lbh = new ComboBox();
            tb_cp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LB1 = new Label();
            bt_add = new Button();
            bt_edit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(329, 61);
            dtg_show.Margin = new Padding(3, 4, 3, 4);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 25;
            dtg_show.Size = new Size(573, 436);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // dtp_bd
            // 
            dtp_bd.Location = new Point(54, 61);
            dtp_bd.Margin = new Padding(3, 4, 3, 4);
            dtp_bd.Name = "dtp_bd";
            dtp_bd.Size = new Size(228, 27);
            dtp_bd.TabIndex = 1;
            // 
            // dtp_kt
            // 
            dtp_kt.Location = new Point(54, 120);
            dtp_kt.Margin = new Padding(3, 4, 3, 4);
            dtp_kt.Name = "dtp_kt";
            dtp_kt.Size = new Size(228, 27);
            dtp_kt.TabIndex = 1;
            // 
            // cb_lbh
            // 
            cb_lbh.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_lbh.FormattingEnabled = true;
            cb_lbh.Location = new Point(54, 179);
            cb_lbh.Margin = new Padding(3, 4, 3, 4);
            cb_lbh.Name = "cb_lbh";
            cb_lbh.Size = new Size(228, 28);
            cb_lbh.TabIndex = 2;
            // 
            // tb_cp
            // 
            tb_cp.Location = new Point(54, 237);
            tb_cp.Margin = new Padding(3, 4, 3, 4);
            tb_cp.Name = "tb_cp";
            tb_cp.Size = new Size(228, 27);
            tb_cp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 155);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "Loại bảo hiểm";
            label3.Click += label3_Click;
            // 
            // LB1
            // 
            LB1.AutoSize = true;
            LB1.Location = new Point(54, 213);
            LB1.Name = "LB1";
            LB1.Size = new Size(55, 20);
            LB1.TabIndex = 4;
            LB1.Text = "Chi phí";
            LB1.Click += label3_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(54, 305);
            bt_add.Margin = new Padding(3, 4, 3, 4);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(225, 60);
            bt_add.TabIndex = 5;
            bt_add.Text = "Thêm bảo hiểm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(54, 373);
            bt_edit.Margin = new Padding(3, 4, 3, 4);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(225, 60);
            bt_edit.TabIndex = 5;
            bt_edit.Text = "Sửa bảo hiểm";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // XeBaoHiemView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 509);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(LB1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_cp);
            Controls.Add(cb_lbh);
            Controls.Add(dtp_kt);
            Controls.Add(dtp_bd);
            Controls.Add(dtg_show);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(935, 556);
            MinimumSize = new Size(935, 556);
            Name = "XeBaoHiemView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XeBaoHiemView";
            FormClosed += XeBaoHiemView_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private DateTimePicker dtp_bd;
        private DateTimePicker dtp_kt;
        private ComboBox cb_lbh;
        private TextBox tb_cp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LB1;
        private Button bt_add;
        private Button bt_edit;
    }
}