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
    public partial class MainLoginForm : Form
    {
        private Form currentFormChild;
        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void MainLoginForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new LoginForm());
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
            pn_show.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
