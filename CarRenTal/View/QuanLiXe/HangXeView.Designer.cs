namespace CarRenTal.View
{
    partial class HangXeView
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
            components = new System.ComponentModel.Container();
            ShowHangXe = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            rd_hd = new RadioButton();
            rd_khd = new RadioButton();
            errorProvider1 = new ErrorProvider(components);
            bt_add = new Button();
            bt_edit = new Button();
            bt_del = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowHangXe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ShowHangXe
            // 
            ShowHangXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowHangXe.Location = new Point(275, 12);
            ShowHangXe.Name = "ShowHangXe";
            ShowHangXe.RowHeadersWidth = 51;
            ShowHangXe.RowTemplate.Height = 29;
            ShowHangXe.Size = new Size(513, 362);
            ShowHangXe.TabIndex = 0;
            ShowHangXe.CellClick += ShowHangXe_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên hãng xe";
            label1.Click += label1_Click;
            // 
            // rd_hd
            // 
            rd_hd.AutoSize = true;
            rd_hd.Location = new Point(12, 136);
            rd_hd.Name = "rd_hd";
            rd_hd.Size = new Size(102, 24);
            rd_hd.TabIndex = 3;
            rd_hd.TabStop = true;
            rd_hd.Text = "Hoạt động";
            rd_hd.UseVisualStyleBackColor = true;
            // 
            // rd_khd
            // 
            rd_khd.AutoSize = true;
            rd_khd.Location = new Point(12, 166);
            rd_khd.Name = "rd_khd";
            rd_khd.Size = new Size(146, 24);
            rd_khd.TabIndex = 3;
            rd_khd.TabStop = true;
            rd_khd.Text = "Không hoạt động";
            rd_khd.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(12, 214);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(159, 38);
            bt_add.TabIndex = 4;
            bt_add.Text = "Thêm hãng xe";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(12, 258);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(159, 38);
            bt_edit.TabIndex = 4;
            bt_edit.Text = "Sửa hãng xe";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(12, 302);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(159, 38);
            bt_del.TabIndex = 4;
            bt_del.Text = "Xoá hãng xe";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += bt_del_Click;
            // 
            // HangXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 381);
            Controls.Add(bt_del);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(rd_khd);
            Controls.Add(rd_hd);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ShowHangXe);
            MaximumSize = new Size(818, 428);
            MinimumSize = new Size(818, 428);
            Name = "HangXeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HangXeView";
            ((System.ComponentModel.ISupportInitialize)ShowHangXe).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ShowHangXe;
        private TextBox textBox1;
        private Label label1;
        private RadioButton rd_hd;
        private RadioButton rd_khd;
        private ErrorProvider errorProvider1;
        private Button bt_del;
        private Button bt_edit;
        private Button bt_add;
    }
}