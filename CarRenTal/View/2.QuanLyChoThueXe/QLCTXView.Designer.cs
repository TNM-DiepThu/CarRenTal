namespace CarRenTal.View.QuanLyChoThueXe
{
    partial class QLCTXView
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
            btnSearch = new Button();
            tbSearch = new TextBox();
            cbbSLCho = new ComboBox();
            btnHistory = new Button();
            btnHoaDon = new Button();
            lbSLXeChoThue = new Label();
            lbSLXeTrong = new Label();
            dgvXeChoThue = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvXeChoThue).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(44, 43);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(441, 31);
            tbSearch.TabIndex = 2;
            // 
            // cbbSLCho
            // 
            cbbSLCho.FormattingEnabled = true;
            cbbSLCho.Location = new Point(728, 42);
            cbbSLCho.Name = "cbbSLCho";
            cbbSLCho.Size = new Size(224, 33);
            cbbSLCho.TabIndex = 3;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(1009, 41);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(112, 34);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "Lịch sử cho thuê";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += button2_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Location = new Point(1319, 737);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(112, 34);
            btnHoaDon.TabIndex = 5;
            btnHoaDon.Text = "In hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbSLXeChoThue
            // 
            lbSLXeChoThue.AutoSize = true;
            lbSLXeChoThue.Location = new Point(149, 742);
            lbSLXeChoThue.Name = "lbSLXeChoThue";
            lbSLXeChoThue.Size = new Size(59, 25);
            lbSLXeChoThue.TabIndex = 6;
            lbSLXeChoThue.Text = "label1";
            // 
            // lbSLXeTrong
            // 
            lbSLXeTrong.AutoSize = true;
            lbSLXeTrong.Location = new Point(640, 742);
            lbSLXeTrong.Name = "lbSLXeTrong";
            lbSLXeTrong.Size = new Size(59, 25);
            lbSLXeTrong.TabIndex = 7;
            lbSLXeTrong.Text = "label2";
            // 
            // dgvXeChoThue
            // 
            dgvXeChoThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeChoThue.Location = new Point(12, 119);
            dgvXeChoThue.Name = "dgvXeChoThue";
            dgvXeChoThue.RowHeadersWidth = 62;
            dgvXeChoThue.RowTemplate.Height = 33;
            dgvXeChoThue.Size = new Size(1454, 601);
            dgvXeChoThue.TabIndex = 8;
            // 
            // QLCTXView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 784);
            Controls.Add(dgvXeChoThue);
            Controls.Add(lbSLXeTrong);
            Controls.Add(lbSLXeChoThue);
            Controls.Add(btnHoaDon);
            Controls.Add(btnHistory);
            Controls.Add(cbbSLCho);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Name = "QLCTXView";
            Text = "QLCTXView";
            ((System.ComponentModel.ISupportInitialize)dgvXeChoThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbbSLCho;
        private Button btnHistory;
        private Button btnHoaDon;
        private Label lbSLXeChoThue;
        private Label lbSLXeTrong;
        private DataGridView dgvXeChoThue;
    }
}