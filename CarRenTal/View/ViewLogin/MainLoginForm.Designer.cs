namespace CarRenTal.View.ViewLogin
{
    partial class MainLoginForm
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
            pn_show = new Panel();
            SuspendLayout();
            // 
            // pn_show
            // 
            pn_show.Location = new Point(0, 0);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(589, 722);
            pn_show.TabIndex = 0;
            // 
            // MainLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(589, 721);
            Controls.Add(pn_show);
            MaximizeBox = false;
            MaximumSize = new Size(607, 768);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(607, 768);
            Name = "MainLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += MainLoginForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel pn_show;
    }
}