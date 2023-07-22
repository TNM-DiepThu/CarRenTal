using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.ViewLogin
{
    public partial class ResetPassForm : Form
    {
        public ResetPassForm()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                OpenChildForm(new ResetPassForm());
            }
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
            pn_resetPass.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn trở lại đăng nhập", "Trở lại", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OpenChildForm(new LoginForm());
            }


        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            tx_newPass.UseSystemPasswordChar = !cb_showPass.Checked;
            tx_rePass.UseSystemPasswordChar = !cb_showPass.Checked;
        }
    }
}
