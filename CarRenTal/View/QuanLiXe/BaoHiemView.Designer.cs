namespace CarRenTal.View.QuanLiXe
{
    partial class BaoHiemView
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
            bt_add = new Button();
            bt_edit = new Button();
            bt_dell = new Button();
            rd_0 = new RadioButton();
            rd_1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(273, 23);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 51;
            dtg_show.RowTemplate.Height = 29;
            dtg_show.Size = new Size(446, 415);
            dtg_show.TabIndex = 0;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(28, 76);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(201, 27);
            tb_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên bảo hiểm";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(28, 233);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(201, 44);
            bt_add.TabIndex = 3;
            bt_add.Text = "Thêm ";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(28, 283);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(201, 44);
            bt_edit.TabIndex = 3;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_dell
            // 
            bt_dell.Location = new Point(28, 333);
            bt_dell.Name = "bt_dell";
            bt_dell.Size = new Size(201, 44);
            bt_dell.TabIndex = 3;
            bt_dell.Text = "Xoá";
            bt_dell.UseVisualStyleBackColor = true;
            bt_dell.Click += bt_dell_Click;
            // 
            // rd_0
            // 
            rd_0.AutoSize = true;
            rd_0.Location = new Point(28, 128);
            rd_0.Name = "rd_0";
            rd_0.Size = new Size(102, 24);
            rd_0.TabIndex = 4;
            rd_0.TabStop = true;
            rd_0.Text = "Hoạt động";
            rd_0.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Location = new Point(28, 158);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(146, 24);
            rd_1.TabIndex = 4;
            rd_1.TabStop = true;
            rd_1.Text = "Không hoạt động";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // BaoHiemView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(rd_1);
            Controls.Add(rd_0);
            Controls.Add(bt_dell);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Controls.Add(dtg_show);
            MaximumSize = new Size(743, 497);
            MinimumSize = new Size(743, 497);
            Name = "BaoHiemView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaoHiemView";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_show;
        private TextBox tb_name;
        private Label label1;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_dell;
        private RadioButton rd_0;
        private RadioButton rd_1;
    }
}