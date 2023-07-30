namespace CarRenTal.View.QuanLiXe
{
    partial class EditXeView
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
            rd_0 = new RadioButton();
            rd_1 = new RadioButton();
            tb_sct = new TextBox();
            tb_dongia = new TextBox();
            tb_somay = new TextBox();
            label7 = new Label();
            lb = new Label();
            label5 = new Label();
            label4 = new Label();
            tb_sokhung = new TextBox();
            label3 = new Label();
            tb_bienso = new TextBox();
            label2 = new Label();
            bt_edit = new Button();
            SuspendLayout();
            // 
            // rd_0
            // 
            rd_0.AutoSize = true;
            rd_0.Location = new Point(57, 292);
            rd_0.Margin = new Padding(3, 2, 3, 2);
            rd_0.Name = "rd_0";
            rd_0.Size = new Size(144, 19);
            rd_0.TabIndex = 21;
            rd_0.TabStop = true;
            rd_0.Text = "Tạm ngừng hoạt động";
            rd_0.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Location = new Point(57, 276);
            rd_1.Margin = new Padding(3, 2, 3, 2);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(82, 19);
            rd_1.TabIndex = 20;
            rd_1.TabStop = true;
            rd_1.Text = "Hoạt động";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // tb_sct
            // 
            tb_sct.Location = new Point(57, 236);
            tb_sct.Margin = new Padding(3, 2, 3, 2);
            tb_sct.Name = "tb_sct";
            tb_sct.Size = new Size(220, 23);
            tb_sct.TabIndex = 14;
            // 
            // tb_dongia
            // 
            tb_dongia.Location = new Point(57, 189);
            tb_dongia.Margin = new Padding(3, 2, 3, 2);
            tb_dongia.Name = "tb_dongia";
            tb_dongia.Size = new Size(220, 23);
            tb_dongia.TabIndex = 13;
            // 
            // tb_somay
            // 
            tb_somay.Location = new Point(57, 150);
            tb_somay.Margin = new Padding(3, 2, 3, 2);
            tb_somay.Name = "tb_somay";
            tb_somay.Size = new Size(220, 23);
            tb_somay.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 258);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 11;
            label7.Text = "Trạng thái";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(57, 219);
            lb.Name = "lb";
            lb.Size = new Size(64, 15);
            lb.TabIndex = 9;
            lb.Text = "Số công tơ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 172);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 133);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Số máy";
            // 
            // tb_sokhung
            // 
            tb_sokhung.Location = new Point(57, 110);
            tb_sokhung.Margin = new Padding(3, 2, 3, 2);
            tb_sokhung.Name = "tb_sokhung";
            tb_sokhung.Size = new Size(220, 23);
            tb_sokhung.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 93);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Số khung";
            // 
            // tb_bienso
            // 
            tb_bienso.Location = new Point(57, 70);
            tb_bienso.Margin = new Padding(3, 2, 3, 2);
            tb_bienso.Name = "tb_bienso";
            tb_bienso.Size = new Size(220, 23);
            tb_bienso.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 53);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Biển số";
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(74, 330);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(149, 58);
            bt_edit.TabIndex = 22;
            bt_edit.Text = "Sửa Xe";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // EditXeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 403);
            Controls.Add(bt_edit);
            Controls.Add(rd_0);
            Controls.Add(rd_1);
            Controls.Add(tb_sct);
            Controls.Add(tb_dongia);
            Controls.Add(tb_somay);
            Controls.Add(label7);
            Controls.Add(lb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_sokhung);
            Controls.Add(label3);
            Controls.Add(tb_bienso);
            Controls.Add(label2);
            Name = "EditXeView";
            Text = "EditXeView";
            Load += EditXeView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rd_0;
        private RadioButton rd_1;
        private TextBox tb_sct;
        private TextBox tb_dongia;
        private TextBox tb_somay;
        private Label label7;
        private Label lb;
        private Label label5;
        private Label label4;
        private TextBox tb_sokhung;
        private Label label3;
        private TextBox tb_bienso;
        private Label label2;
        private Button bt_edit;
    }
}