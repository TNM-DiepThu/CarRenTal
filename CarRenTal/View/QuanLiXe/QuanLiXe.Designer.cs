namespace CarRenTal
{
    partial class QuanLiXe
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
            dtg_qlx = new DataGridView();
            tb_seach = new TextBox();
            bt_4cho = new Button();
            bt_loaihopso = new Button();
            bt_dhdk = new Button();
            bt_hhdk = new Button();
            bt_addxe = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_qlx).BeginInit();
            SuspendLayout();
            // 
            // dtg_qlx
            // 
            dtg_qlx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_qlx.Location = new Point(42, 105);
            dtg_qlx.Name = "dtg_qlx";
            dtg_qlx.RowHeadersWidth = 51;
            dtg_qlx.RowTemplate.Height = 29;
            dtg_qlx.Size = new Size(976, 301);
            dtg_qlx.TabIndex = 0;
            // 
            // tb_seach
            // 
            tb_seach.Location = new Point(42, 40);
            tb_seach.Name = "tb_seach";
            tb_seach.Size = new Size(293, 27);
            tb_seach.TabIndex = 1;
            // 
            // bt_4cho
            // 
            bt_4cho.Location = new Point(400, 38);
            bt_4cho.Name = "bt_4cho";
            bt_4cho.Size = new Size(94, 29);
            bt_4cho.TabIndex = 2;
            bt_4cho.Text = "4 Chỗ";
            bt_4cho.UseVisualStyleBackColor = true;
            // 
            // bt_loaihopso
            // 
            bt_loaihopso.Location = new Point(567, 38);
            bt_loaihopso.Name = "bt_loaihopso";
            bt_loaihopso.Size = new Size(94, 29);
            bt_loaihopso.TabIndex = 2;
            bt_loaihopso.Text = "Loại hộp số";
            bt_loaihopso.UseVisualStyleBackColor = true;
            // 
            // bt_dhdk
            // 
            bt_dhdk.Location = new Point(667, 38);
            bt_dhdk.Name = "bt_dhdk";
            bt_dhdk.Size = new Size(165, 29);
            bt_dhdk.TabIndex = 2;
            bt_dhdk.Text = "Đến hạn đăng kiểm";
            bt_dhdk.UseVisualStyleBackColor = true;
            // 
            // bt_hhdk
            // 
            bt_hhdk.Location = new Point(838, 38);
            bt_hhdk.Name = "bt_hhdk";
            bt_hhdk.Size = new Size(165, 29);
            bt_hhdk.TabIndex = 2;
            bt_hhdk.Text = "Hết hạn đăng kiểm";
            bt_hhdk.UseVisualStyleBackColor = true;
            // 
            // bt_addxe
            // 
            bt_addxe.Location = new Point(831, 426);
            bt_addxe.Name = "bt_addxe";
            bt_addxe.Size = new Size(187, 39);
            bt_addxe.TabIndex = 2;
            bt_addxe.Text = "Thêm xe";
            bt_addxe.UseVisualStyleBackColor = true;
            // 
            // QuanLiXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 477);
            Controls.Add(bt_hhdk);
            Controls.Add(bt_dhdk);
            Controls.Add(bt_loaihopso);
            Controls.Add(bt_addxe);
            Controls.Add(bt_4cho);
            Controls.Add(tb_seach);
            Controls.Add(dtg_qlx);
            Name = "QuanLiXe";
            Text = "QuanLiXe";
            Load += QuanLiXe_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_qlx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_qlx;
        private TextBox tb_seach;
        private Button bt_4cho;
        private Button bt_loaihopso;
        private Button bt_dhdk;
        private Button bt_hhdk;
        private Button bt_addxe;
    }
}