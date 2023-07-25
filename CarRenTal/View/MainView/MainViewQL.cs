using CarRenTal.View._7.QuanLyTaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.MainView
{
    public partial class MainViewQL : Form
    {
        public MainViewQL()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;  // close form firt
            childForm.FormBorderStyle = FormBorderStyle.None; // of window controls
            childForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childForm);
            pn_main.BringToFront();
            childForm.Show();
        }

        private void ChangeBackGroundButton(Button buttonAction)
        {
            btnQLCTX.BackColor = Color.White;
            btnQLX.BackColor = Color.White;
            btnQLHD.BackColor = Color.White;
            btnQLNV.BackColor = Color.White;
            btnQLKH.BackColor = Color.White;
            btnQLTC.BackColor = Color.White;
            btnAccount.BackColor = Color.White;

            buttonAction.BackColor = Color.LightBlue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLCTX);
            //btnQLCTX.BackColor = Color.Blue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainViewQL_Load(object sender, EventArgs e)
        {

        }

        private void btnQLX_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLX);

        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLHD);
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLNV);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLKH);
        }

        private void btnQLTC_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new HangXeView());
            ChangeBackGroundButton(btnQLTC);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan());
            ChangeBackGroundButton(btnAccount);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            MessageBox.Show("đã click");
        }
    }
}
