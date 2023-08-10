namespace CarRenTal.View.QuanLiXe
{
    partial class MauSacView
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
            bt_dell = new Button();
            bt_edit = new Button();
            bt_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(290, 81);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(361, 357);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(33, 119);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(197, 27);
            tb_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 81);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên màu sắc";
            // 
            // bt_dell
            // 
            bt_dell.Location = new Point(33, 351);
            bt_dell.Name = "bt_dell";
            bt_dell.Size = new Size(197, 54);
            bt_dell.TabIndex = 3;
            bt_dell.Text = "Xoá";
            bt_dell.UseVisualStyleBackColor = true;
            bt_dell.Click += bt_dell_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(33, 267);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(197, 54);
            bt_edit.TabIndex = 3;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(33, 183);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(197, 54);
            bt_add.TabIndex = 3;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // MauSacView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(bt_add);
            Controls.Add(bt_edit);
            Controls.Add(bt_dell);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Controls.Add(dtg_show);
            MaximumSize = new Size(688, 497);
            MinimumSize = new Size(688, 497);
            Name = "MauSacView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MauSac";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_name;
        private Label label1;
        private Button bt_dell;
        private Button bt_edit;
        private Button bt_add;
    }
}