﻿using Bus.Serviece.Implements;
using Dal.Modal;
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
        public bool checkLogin = false;
        private Form currentFormChild;
        LoginService loginService;

       public bool LoginCheck {  get; set; }

        public LoginForm()
        {
            InitializeComponent();
            loginService = new LoginService();

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

        public void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                var result = loginService.CheckLogin(tx_user.Text, tx_pass.Text);
                if (result != null)
                {
                    LoginCheck = true;
                    checkLogin = true;
                    tx_pass.Text = "";
                    this.Hide();
                    View.MainView.MainViewQL main = new View.MainView.MainViewQL(result);
                    main.Show();
                    this.Show();

                }
                else
                {

                    checkLogin = false;
                    LoginCheck = false;
                  //  MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception)
            {
                checkLogin = false;
                //   MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pn_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
