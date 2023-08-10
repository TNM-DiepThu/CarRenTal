namespace CarRenTal.View.QuanLiXe
{
    partial class ThemXe
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
            label1 = new Label();
            label2 = new Label();
            tb_bienso = new TextBox();
            label3 = new Label();
            tb_sokhung = new TextBox();
            label4 = new Label();
            tb_somay = new TextBox();
            label5 = new Label();
            tb_dongia = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tb_chiphi = new TextBox();
            button1 = new Button();
            cb_mausac = new ComboBox();
            cb_name = new ComboBox();
            rd_1 = new RadioButton();
            rd_0 = new RadioButton();
            dtp_ndk = new DateTimePicker();
            dtp_nhh = new DateTimePicker();
            lb = new Label();
            tb_sct = new TextBox();
            cb_hangxe = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên xe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 0;
            label2.Text = "Biển số";
            // 
            // tb_bienso
            // 
            tb_bienso.Location = new Point(25, 146);
            tb_bienso.Name = "tb_bienso";
            tb_bienso.Size = new Size(251, 27);
            tb_bienso.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 176);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Số khung";
            // 
            // tb_sokhung
            // 
            tb_sokhung.Location = new Point(25, 199);
            tb_sokhung.Name = "tb_sokhung";
            tb_sokhung.Size = new Size(251, 27);
            tb_sokhung.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 230);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Số máy";
            // 
            // tb_somay
            // 
            tb_somay.Location = new Point(25, 252);
            tb_somay.Name = "tb_somay";
            tb_somay.Size = new Size(251, 27);
            tb_somay.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 282);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 0;
            label5.Text = "Đơn giá";
            // 
            // tb_dongia
            // 
            tb_dongia.Location = new Point(25, 304);
            tb_dongia.Name = "tb_dongia";
            tb_dongia.Size = new Size(251, 27);
            tb_dongia.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 335);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 0;
            label6.Text = "Màu sắc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 440);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 0;
            label7.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 19);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 0;
            label8.Text = "Ngày đăng kiểm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 72);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 0;
            label9.Text = "Ngày hết hạn";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 125);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 0;
            label10.Text = "Chi phí";
            label10.Click += label10_Click;
            // 
            // tb_chiphi
            // 
            tb_chiphi.Location = new Point(299, 148);
            tb_chiphi.Name = "tb_chiphi";
            tb_chiphi.Size = new Size(251, 27);
            tb_chiphi.TabIndex = 1;
            tb_chiphi.TextChanged += tb_chiphi_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(383, 435);
            button1.Name = "button1";
            button1.Size = new Size(138, 77);
            button1.TabIndex = 2;
            button1.Text = "Thêm Xe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_mausac
            // 
            cb_mausac.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mausac.FormattingEnabled = true;
            cb_mausac.Location = new Point(25, 358);
            cb_mausac.Name = "cb_mausac";
            cb_mausac.Size = new Size(251, 28);
            cb_mausac.TabIndex = 3;
            // 
            // cb_name
            // 
            cb_name.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_name.FormattingEnabled = true;
            cb_name.Location = new Point(25, 97);
            cb_name.Name = "cb_name";
            cb_name.Size = new Size(251, 28);
            cb_name.TabIndex = 3;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Location = new Point(25, 461);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(102, 24);
            rd_1.TabIndex = 4;
            rd_1.TabStop = true;
            rd_1.Text = "Hoạt động";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // rd_0
            // 
            rd_0.AutoSize = true;
            rd_0.Location = new Point(25, 483);
            rd_0.Name = "rd_0";
            rd_0.Size = new Size(179, 24);
            rd_0.TabIndex = 4;
            rd_0.TabStop = true;
            rd_0.Text = "Tạm ngừng hoạt động";
            rd_0.UseVisualStyleBackColor = true;
            // 
            // dtp_ndk
            // 
            dtp_ndk.Location = new Point(299, 43);
            dtp_ndk.Name = "dtp_ndk";
            dtp_ndk.Size = new Size(250, 27);
            dtp_ndk.TabIndex = 5;
            // 
            // dtp_nhh
            // 
            dtp_nhh.Location = new Point(299, 95);
            dtp_nhh.Name = "dtp_nhh";
            dtp_nhh.Size = new Size(250, 27);
            dtp_nhh.TabIndex = 5;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(25, 388);
            lb.Name = "lb";
            lb.Size = new Size(81, 20);
            lb.TabIndex = 0;
            lb.Text = "Số công tơ";
            // 
            // tb_sct
            // 
            tb_sct.Location = new Point(25, 411);
            tb_sct.Name = "tb_sct";
            tb_sct.Size = new Size(251, 27);
            tb_sct.TabIndex = 1;
            // 
            // cb_hangxe
            // 
            cb_hangxe.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_hangxe.FormattingEnabled = true;
            cb_hangxe.Location = new Point(25, 42);
            cb_hangxe.Name = "cb_hangxe";
            cb_hangxe.Size = new Size(251, 28);
            cb_hangxe.TabIndex = 3;
            cb_hangxe.SelectedIndexChanged += cb_hangxe_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 19);
            label11.Name = "label11";
            label11.Size = new Size(147, 20);
            label11.TabIndex = 0;
            label11.Text = "Lọc tên xe theo hãng";
            // 
            // ThemXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 537);
            Controls.Add(dtp_nhh);
            Controls.Add(dtp_ndk);
            Controls.Add(rd_0);
            Controls.Add(rd_1);
            Controls.Add(cb_hangxe);
            Controls.Add(cb_name);
            Controls.Add(cb_mausac);
            Controls.Add(button1);
            Controls.Add(tb_sct);
            Controls.Add(tb_dongia);
            Controls.Add(tb_somay);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tb_chiphi);
            Controls.Add(tb_sokhung);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(tb_bienso);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label1);
            MaximumSize = new Size(589, 584);
            MinimumSize = new Size(589, 584);
            Name = "ThemXe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemXe";
            FormClosed += ThemXe_FormClosed;
            Load += ThemXe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_name;
        private Label label2;
        private TextBox tb_bienso;
        private Label label3;
        private TextBox tb_sokhung;
        private Label label4;
        private TextBox tb_somay;
        private Label label5;
        private TextBox tb_dongia;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox tb_chiphi;
        private Button button1;
        private ComboBox cb_mausac;
        private ComboBox cb_name;
        private RadioButton rd_1;
        private RadioButton rd_0;
        private DateTimePicker dtp_ndk;
        private DateTimePicker dtp_nhh;
        private Label lb;
        private TextBox tb_sct;
        private ComboBox cb_hangxe;
        private Label label11;
    }
}