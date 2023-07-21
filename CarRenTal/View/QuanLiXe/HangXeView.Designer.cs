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
            ShowHangXe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ShowHangXe).BeginInit();
            SuspendLayout();
            // 
            // ShowHangXe
            // 
            ShowHangXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowHangXe.Location = new Point(222, 58);
            ShowHangXe.Name = "ShowHangXe";
            ShowHangXe.RowHeadersWidth = 51;
            ShowHangXe.RowTemplate.Height = 29;
            ShowHangXe.Size = new Size(566, 362);
            ShowHangXe.TabIndex = 0;
            // 
            // HangXeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShowHangXe);
            Name = "HangXeView";
            Text = "HangXeView";
            ((System.ComponentModel.ISupportInitialize)ShowHangXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ShowHangXe;
    }
}