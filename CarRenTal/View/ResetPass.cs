using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View
{
    public partial class ResetPass : Form
    {
        private Form currentFormChild;
        public ResetPass()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            // childForm.Dock = DockStyle.Fill;
            pn_rePass.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận hủy", "Hủy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                OpenChildForm(new Login());
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (true)
            {
                OpenChildForm(new Login());
            }
        }

        private void cb_showPas_CheckedChanged(object sender, EventArgs e)
        {
            tx_newPass.UseSystemPasswordChar = !cb_showPas.Checked;
            tx_rePass.UseSystemPasswordChar = !cb_showPas.Checked;
        }
    }
}
