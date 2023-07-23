namespace CarRenTal.View.QuanLyChoThueXe
{
    partial class HistoryCTX
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
            dgvHistoryCTX = new DataGridView();
            lbSLchoThue = new Label();
            btnExit = new Button();
            cbbLoaiGheNgoi = new ComboBox();
            tbSearch = new TextBox();
            btnSearch = new Button();
            dtTimeStart = new DateTimePicker();
            dtTimeEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryCTX).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoryCTX
            // 
            dgvHistoryCTX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryCTX.Location = new Point(12, 86);
            dgvHistoryCTX.Name = "dgvHistoryCTX";
            dgvHistoryCTX.RowHeadersWidth = 62;
            dgvHistoryCTX.RowTemplate.Height = 33;
            dgvHistoryCTX.Size = new Size(1454, 601);
            dgvHistoryCTX.TabIndex = 16;
            // 
            // lbSLchoThue
            // 
            lbSLchoThue.AutoSize = true;
            lbSLchoThue.Location = new Point(143, 730);
            lbSLchoThue.Name = "lbSLchoThue";
            lbSLchoThue.Size = new Size(327, 25);
            lbSLchoThue.TabIndex = 14;
            lbSLchoThue.Text = "Số lượng xe cho thuê được trong tháng";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1305, 725);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiGheNgoi
            // 
            cbbLoaiGheNgoi.FormattingEnabled = true;
            cbbLoaiGheNgoi.Location = new Point(689, 31);
            cbbLoaiGheNgoi.Name = "cbbLoaiGheNgoi";
            cbbLoaiGheNgoi.Size = new Size(224, 33);
            cbbLoaiGheNgoi.TabIndex = 11;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(44, 32);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(441, 31);
            tbSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtTimeStart
            // 
            dtTimeStart.Location = new Point(967, 32);
            dtTimeStart.Name = "dtTimeStart";
            dtTimeStart.Size = new Size(236, 31);
            dtTimeStart.TabIndex = 17;
            // 
            // dtTimeEnd
            // 
            dtTimeEnd.Location = new Point(1221, 32);
            dtTimeEnd.Name = "dtTimeEnd";
            dtTimeEnd.Size = new Size(236, 31);
            dtTimeEnd.TabIndex = 18;
            // 
            // HistoryCTX
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 784);
            Controls.Add(dtTimeEnd);
            Controls.Add(dtTimeStart);
            Controls.Add(dgvHistoryCTX);
            Controls.Add(lbSLchoThue);
            Controls.Add(btnExit);
            Controls.Add(cbbLoaiGheNgoi);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Name = "HistoryCTX";
            Text = "Lịch sử cho thuê xe";
            ((System.ComponentModel.ISupportInitialize)dgvHistoryCTX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoryCTX;
        private Label lbSLchoThue;
        private Button btnExit;
        private ComboBox cbbLoaiGheNgoi;
        private TextBox tbSearch;
        private Button btnSearch;
        private DateTimePicker dtTimeStart;
        private DateTimePicker dtTimeEnd;
    }
}