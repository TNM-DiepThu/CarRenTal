using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dal.Repository;
using Dal.Modal;
namespace Bus.Serviece.Implements
{
    public class LoginService
    {
        string _otp;
        TaiKhoanRepo _taiKhoanRepo;
        NhanVienRepo _nhanVienRepo= new NhanVienRepo();
        ChucVuRepo _chucVuRepo= new ChucVuRepo();
        List<TaiKhoan> _lstTaiKhoan;
        List<ChucVu> _lstChucVu;
        List<NhanVien> _lstNhanVien;
        public LoginService()
        {
            _taiKhoanRepo = new TaiKhoanRepo();
            _lstChucVu = _chucVuRepo.GetChucVu();
            _lstNhanVien = _nhanVienRepo.GetNhanVien();
            _lstTaiKhoan = _taiKhoanRepo.GetTaiKhoan();
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
            string otp = "";
            for (int i = 0; i < 4; i++)
            {
                otp += random.Next(9).ToString() + "";
            }
            return otp;
        }
        public void Get_verification_code(string email)
        {
            _otp = CreateOTP();
            senMail(_otp, email);
        }
        public bool VerifyOTP(string userOTP)
        {
            try
            {
                if (string.IsNullOrEmpty(userOTP)) { return false; }
                    return userOTP == _otp.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TaiKhoan CheckLogin(string user, string password)
        {
            try
            {
                var lstresult = from t in _lstTaiKhoan
                             join n in _lstNhanVien on t.IdNhanVien equals n.Id
                             join c in _lstChucVu on n.IdChucVu equals c.Id
                             where (t.username == user && t.password == password && t.TrangThai == 1)
                             select t;
                var result= lstresult.ToList()[0];
                result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
                result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool CheckEmail(string email)
        {
            try
            {
                var result = _lstNhanVien.FirstOrDefault(x => x.Email == email);
                if (result!= null)
                {
                     return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdatePas(string newPass, string email)
        {
            try
            {
                var lstTaiKhoan = from t in _lstTaiKhoan
                                  join n in _lstNhanVien on t.IdNhanVien equals n.Id
                                  where n.Email == email
                                  select t;
                TaiKhoan taiKhoan = lstTaiKhoan.ToList()[0];
                taiKhoan.password = newPass;
                return _taiKhoanRepo.UpdateTaiKhoan(taiKhoan);
    

    }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
