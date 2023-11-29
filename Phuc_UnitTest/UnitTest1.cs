using CarRenTal.View.MainView;
using CarRenTal.View._7.QuanLyTaiKhoan;
using NUnit.Framework;
using Dal.Modal;
using Dal.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuc_UnitTest
{
    [TestFixture]
    public class Tests
    {
        public MainViewQL _FrmQL;
        public QuanLyTaiKhoan _FrmQLTK;

        TaiKhoanRepo taiKhoanRepo = new TaiKhoanRepo();
        ChucVuRepo chucVuRepo = new ChucVuRepo();
        NhanVienRepo nhanVienRepo = new NhanVienRepo();
        List<NhanVien> _lstNhanVien;
        List<ChucVu> _lstChucVu;
        List<TaiKhoan> _lstTaiKhoan;

        [SetUp]
        public void Setup()
        {
            _lstChucVu = chucVuRepo.GetChucVu();
            _lstNhanVien = nhanVienRepo.GetNhanVien();
            _lstTaiKhoan = taiKhoanRepo.GetTaiKhoan();

            //_FrmQL = new MainViewQL();
            _FrmQLTK = new QuanLyTaiKhoan();
            //_FrmQL.btnAccount_Click(null, null);
            
        }

        //Đăng xuất rol quản lý thành công
        [Test]
        public void TC_Suc_Logout01()
        {

            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;
            var result = AccountQL.ToList()[0];

            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // Click vào nút Đăng Xuất
            _FrmQL.btnDangXuat_Click(null, null);

            // Kiểm tra xem Form đã được đóng chưa
            Assert.IsTrue(_FrmQL.IsDisposed);
        }


        //Đăng xuất rol nhân viên thành công
        [Test]
        public void TC_Suc_Logout02()
        {
            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "hungnv" && t.password == "1" && t.TrangThai == 1)
                            select t;
            var result = AccountQL.ToList()[0];

            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // Click vào nút Đăng Xuất
            _FrmQL.btnDangXuat_Click(null, null);

            // Kiểm tra xem Form đã được đóng chưa
            Assert.IsTrue(_FrmQL.IsDisposed);
        }


        //Đăng xuất rol Quản lý thất bại
        [Test]
        public void TC_USuc_Logout03()
        {
            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQL.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi sự kiện đăng xuất, nhưng không đóng form
            _FrmQL.btnDangXuat_Click(null, null);

            // Kiểm tra xem Form có đóng hay không
            Assert.IsFalse(formClosed, "Form đã đóng khi ấn không đồng ý");
        }
        

        //Đăng xuất rol nhân viên thất bại
        [Test]
        public void TC_USuc_Logout04()
        {
            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "hungnv" && t.password == "1" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQL.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi sự kiện đăng xuất, nhưng không đóng form
            _FrmQL.btnDangXuat_Click(null, null);

            // Kiểm tra xem Form có đóng hay không
            Assert.IsFalse(formClosed, "Form đã đóng khi ấn không đồng ý");
        }

        //Dữ liệu 1

        [Test]
        public void TC_Suc_InsertAc05()
        {
            // Khởi đông main form
            

            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "Nguyễn Văn A";
            _FrmQLTK.cbb_gioiTinh.SelectedIndex = 0;
            _FrmQLTK.tx_adress.Text = "Như là A";
            _FrmQLTK.tx_sdt.Text = "0369639117";
            _FrmQLTK.tx_email.Text = "nkphuc221@gmail.com";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "phucnk1";
            _FrmQLTK.tx_pass.Text = "1";


            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsTrue(_FrmQLTK.checkCreat, "Insert thành công");
        }
        [Test]


        //Dữ liệu 2
        public void TC_Suc_InsertAc06()
        {
            // Khởi đông main form


            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "Nguyễn Văn B";
            _FrmQLTK.cbb_gioiTinh.SelectedIndex = 1;
            _FrmQLTK.tx_adress.Text = "Như là B";
            _FrmQLTK.tx_sdt.Text = "0369639117";
            _FrmQLTK.tx_email.Text = "nkphuc221@gmail.com";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "phucnk2";
            _FrmQLTK.tx_pass.Text = "2";


            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsTrue(_FrmQLTK.checkCreat, "Insert thành công");
        }


        //Để trống tất cả các trường thông tin

        [Test]

        public void TC_Suc_InsertAc07()
        {
            // Khởi đông main form
            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "";
            _FrmQLTK.cbb_gioiTinh.SelectedIndex = 1;
            _FrmQLTK.tx_adress.Text = "";
            _FrmQLTK.tx_sdt.Text = "";
            _FrmQLTK.tx_email.Text = "";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "";
            _FrmQLTK.tx_pass.Text = "";

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQLTK.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsFalse(formClosed, "Email không hợp lệ, không được bỏ trống các trường");
        }



        // Sai định dạng Email
        [Test]
        public void TC_Suc_InsertAc08()
        {
            // Khởi đông main form


            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "Nguyễn Văn B";
            _FrmQLTK.cbb_gioiTinh.SelectedIndex = 1;
            _FrmQLTK.tx_adress.Text = "Như là B";
            _FrmQLTK.tx_sdt.Text = "0369639117";
            _FrmQLTK.tx_email.Text = "nkphuc221gmail.com";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "phucnk2";
            _FrmQLTK.tx_pass.Text = "2";

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQLTK.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsFalse(formClosed, "Email không hợp lệ");
        }


        // Sai giới tính
        [Test]
        public void TC_Suc_InsertAc09()
        {
            // Khởi đông main form


            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "Nguyễn Văn B";
            _FrmQLTK.cbb_gioiTinh.SelectedItem = null ;
            _FrmQLTK.tx_adress.Text = "Như là B";
            _FrmQLTK.tx_sdt.Text = "0369639117";
            _FrmQLTK.tx_email.Text = "nkphuc221@gmail.com";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "phucnk2";
            _FrmQLTK.tx_pass.Text = "2";

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQLTK.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsFalse(formClosed, "Không được để trống giới tính");
        }


        // Số điện thoại không hợp lệ
        [Test]
        public void TC_Suc_InsertAc10()
        {
            // Khởi đông main form


            var AccountQL = from t in _lstTaiKhoan
                            join n in _lstNhanVien on t.IdNhanVien equals n.Id
                            join c in _lstChucVu on n.IdChucVu equals c.Id
                            where (t.username == "phucnk" && t.password == "123" && t.TrangThai == 1)
                            select t;

            var result = AccountQL.ToList()[0];
            result.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == result.IdNhanVien);
            result.NhanVien.ChucVu = _lstChucVu.FirstOrDefault(p => p.Id == result.NhanVien.IdChucVu);

            _FrmQL = new MainViewQL(result);

            // mở form quản lý tài khoản

            _FrmQLTK.QuanLyTaiKhoan_Load(null, null);

            // Thêm dữ liệu
            _FrmQLTK.lb_id.Text = Guid.NewGuid().ToString();
            _FrmQLTK.tx_hoTen.Text = "Nguyễn Văn B";
            _FrmQLTK.cbb_gioiTinh.SelectedIndex = 1;
            _FrmQLTK.tx_adress.Text = "Như là B";
            _FrmQLTK.tx_sdt.Text = "03696391";
            _FrmQLTK.tx_email.Text = "nkphuc221@gmail.com";
            _FrmQLTK.dtp_dob.Value = DateTime.Now;

            _FrmQLTK.tx_user.Text = "phucnk2";
            _FrmQLTK.tx_pass.Text = "2";

            // Sử dụng sự kiện FormClosing để kiểm tra việc đóng form
            bool formClosed = false;
            _FrmQLTK.FormClosing += (sender, e) =>
            {
                formClosed = true;
            };

            // Gọi nút add dữ liệu trên 
            _FrmQLTK.bt_add_Click(null, null);

            // Kiểm tra với kết quả
            Assert.IsFalse(formClosed, "Số điện thoại không đúng định dạng");
        }
    }
}
