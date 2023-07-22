using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class LoginService
    {
        string _otp;
        public LoginService()
        {
            
        }
        bool senMail(string otp, string email)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("hungnv2082001@gmail.com", "dxaffezuvyvivsih");

                MailMessage message = new MailMessage("hungnv2082001@gmail.com", email);
                message.Subject = "Yêu cầu xác minh tài khoản";
                message.Body = $"Bạn đã gửi yêu cầu xác minh tài khoản, mã xác minh của bạn là: {otp}";

                mailclient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string CreateOTP()
        {
            Random random = new Random();
            string otp="";
            for (int i = 0; i < 4; i++)
            {
                otp+= random.Next(9).ToString()+"";
            }
            return otp;
        }
        public void Get_verification_code(string email)
        {
            _otp= CreateOTP();
            senMail(_otp, email);
        }
        public bool VerifyOTP(string userOTP)
        {
            return userOTP ==_otp.ToString();
        }
    }
}
