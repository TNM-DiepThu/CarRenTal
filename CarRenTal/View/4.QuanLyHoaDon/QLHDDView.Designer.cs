namespace CarRenTal.View._4._QuanLyHoaDon
{
    partial class QLHDDView
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
            dtTimeEnd = new DateTimePicker();
            dtTimeStart = new DateTimePicker();
            dgvHistoryCTX = new DataGridView();
            btnExit = new Button();
            cbbTrangThai = new ComboBox();
            tbSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistoryCTX).BeginInit();
            SuspendLayout();
            // 
            // dtTimeEnd
            // 
            dtTimeEnd.Location = new Point(1221, 30);
            dtTimeEnd.Name = "dtTimeEnd";
            dtTimeEnd.Size = new Size(236, 31);
            dtTimeEnd.TabIndex = 26;
            // 
            // dtTimeStart
            // 
            dtTimeStart.Location = new Point(967, 30);
            dtTimeStart.Name = "dtTimeStart";
            dtTimeStart.Size = new Size(236, 31);
            dtTimeStart.TabIndex = 25;
            // 
            // dgvHistoryCTX
            // 
            dgvHistoryCTX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoryCTX.Location = new Point(12, 84);
            dgvHistoryCTX.Name = "dgvHistoryCTX";
            dgvHistoryCTX.RowHeadersWidth = 62;
            dgvHistoryCTX.RowTemplate.Height = 33;
            dgvHistoryCTX.Size = new Size(1454, 601);
            dgvHistoryCTX.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1280, 714);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 49);
            btnExit.TabIndex = 22;
            btnExit.Text = "Tạo hóa đơn";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Location = new Point(689, 29);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(224, 33);
            cbbTrangThai.TabIndex = 21;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(44, 30);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(441, 31);
            tbSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(515, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // QLHDDView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 784);
            Controls.Add(dtTimeEnd);
            Controls.Add(dtTimeStart);
            Controls.Add(dgvHistoryCTX);
            Controls.Add(btnExit);
            Controls.Add(cbbTrangThai);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Name = "QLHDDView";
            Text = "QLHDDView";
            ((System.ComponentModel.ISupportInitialize)dgvHistoryCTX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtTimeEnd;
        private DateTimePicker dtTimeStart;
        private DataGridView dgvHistoryCTX;
        private Button btnExit;
        private ComboBox cbbTrangThai;
        private TextBox tbSearch;
        private Button btnSearch;
    }
}