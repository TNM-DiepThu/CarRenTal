namespace CarRenTal.View.QuanLiXe
{
    partial class DangKiemView
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
            bt_edit = new Button();
            dtp_bd = new DateTimePicker();
            dtp_kt = new DateTimePicker();
            tb_cp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.AllowDrop = true;
            dtg_show.AllowUserToAddRows = false;
            dtg_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg_show.ColumnHeadersHeight = 30;
            dtg_show.Location = new Point(72, 12);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 100;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(624, 93);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            dtg_show.MouseClick += dtg_show_MouseClick;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(527, 148);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(159, 93);
            bt_edit.TabIndex = 1;
            bt_edit.Text = "Sửa thông tin";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // dtp_bd
            // 
            dtp_bd.Location = new Point(185, 148);
            dtp_bd.Name = "dtp_bd";
            dtp_bd.Size = new Size(300, 27);
            dtp_bd.TabIndex = 2;
            // 
            // dtp_kt
            // 
            dtp_kt.Location = new Point(185, 181);
            dtp_kt.Name = "dtp_kt";
            dtp_kt.Size = new Size(300, 27);
            dtp_kt.TabIndex = 2;
            // 
            // tb_cp
            // 
            tb_cp.Location = new Point(185, 213);
            tb_cp.Name = "tb_cp";
            tb_cp.Size = new Size(300, 27);
            tb_cp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 155);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 188);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 221);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Chi phí";
            // 
            // DangKiemView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 280);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_cp);
            Controls.Add(dtp_kt);
            Controls.Add(dtp_bd);
            Controls.Add(bt_edit);
            Controls.Add(dtg_show);
            MaximumSize = new Size(877, 327);
            MinimumSize = new Size(877, 327);
            Name = "DangKiemView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKiemView";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private Button bt_edit;
        private DateTimePicker dtp_bd;
        private DateTimePicker dtp_kt;
        private TextBox tb_cp;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}