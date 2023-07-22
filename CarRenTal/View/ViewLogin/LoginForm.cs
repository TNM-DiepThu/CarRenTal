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
    public partial class LoginForm : Form
    {
        private Form currentFormChild;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lb_forgotPass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmailVerifyForm());
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
            pn_login.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
