using CarRenTal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal
{
    public partial class EmailVerifyForm : Form
    {

        private Form currentFormChild;
        public EmailVerifyForm()
        {
            InitializeComponent();
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            if (true)
            {
                OpenChildForm(new ResetPass());
            }
        }
        public void OpenChildForm(Form childForm)
        {
            this.Text = childForm.Text;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_verify.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
