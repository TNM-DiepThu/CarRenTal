using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus;
using Bus.Serviece.Implements;

namespace CarRenTal.View.ViewLogin
{
    public partial class EmailVerifyForm : Form
    {
        Form currentFormChild;
        int min, seconds, countOTPFail=0;
        LoginService loginService;
        public EmailVerifyForm()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            if (loginService.VerifyOTP(tx_emailOTP.Text))
            {
                OpenChildForm(new ResetPassForm());
            }
            else
            {
                countOTPFail++;
                MessageBox.Show("Vui lòng kiểm tra email hoặc mã của bạn");
                if (countOTPFail>=3)
                {
                    MessageBox.Show("Tài khoản của bạn bị khóa tạm thời, liên hệ quản lý để mở lại");
                }
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
            pn_emailVerify.Controls.Add(childForm);
            // pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void tx_email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsValid(tx_email.Text))
                {
                    lb_sendOTP.Enabled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lb_sendOTP_Click(object sender, EventArgs e)
        {
            min = 3; seconds = 0;
            timer1.Start();
            lb_time.Visible = true;
            lb_time.Text= min.ToString()+":"+seconds.ToString();
            lb_sendOTP.Enabled = false;
            if (true)
            {
                loginService.Get_verification_code(tx_email.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = min.ToString() + ":" + seconds.ToString();
            if (min==0&& seconds==0)
            {
                lb_sendOTP.Enabled = true;
                lb_time.Visible = false;
                timer1.Stop();
            }
            if (min>0&& seconds==0)
            {
                seconds = 60;
                min--;
            }
            seconds--;

        }

        
    }
}
