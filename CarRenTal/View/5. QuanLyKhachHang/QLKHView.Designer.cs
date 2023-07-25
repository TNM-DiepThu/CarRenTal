namespace CarRenTal.View._5._QuanLyKhachHang
{
    partial class QLKHView
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
            dgvQLKH = new DataGridView();
            btnTrangThai = new Button();
            tbSearch = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).BeginInit();
            SuspendLayout();
            // 
            // dgvQLKH
            // 
            dgvQLKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLKH.Location = new Point(12, 88);
            dgvQLKH.Name = "dgvQLKH";
            dgvQLKH.RowHeadersWidth = 62;
            dgvQLKH.RowTemplate.Height = 33;
            dgvQLKH.Size = new Size(1454, 594);
            dgvQLKH.TabIndex = 31;
            dgvQLKH.CellClick += dgvQLKH_CellClick;
            dgvQLKH.CellContentClick += dgvQLKH_CellContentClick;
            // 
            // btnTrangThai
            // 
            btnTrangThai.Location = new Point(515, 25);
            btnTrangThai.Name = "btnTrangThai";
            btnTrangThai.Size = new Size(112, 34);
            btnTrangThai.TabIndex = 27;
            btnTrangThai.Text = "Trạng thái";
            btnTrangThai.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(44, 27);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(441, 31);
            tbSearch.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1321, 717);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 45);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // QLKHView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1478, 784);
            Controls.Add(dgvQLKH);
            Controls.Add(btnUpdate);
            Controls.Add(tbSearch);
            Controls.Add(btnTrangThai);
            Name = "QLKHView";
            Text = "QLKHView";
            Load += QLKHView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvQLKH;
        private Button btnTrangThai;
        private TextBox tbSearch;
        private Button btnUpdate;
    }
}