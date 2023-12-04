using NUnit.Framework;
using CarRenTal.View.ViewLogin;
using CarRenTal.View._7.QuanLyTaiKhoan;
using CarRenTal.View._1.ChoThueXe;



namespace DemoTest

{
    [TestFixture]
    public class Tests
    {
        public LoginForm _login;
        public QuanLyTaiKhoan _quanLyTaiKhoan;
        public ChonKhachHangForm _chonKhachHangForm;

        [SetUp]
        public void Setup()
        {
            _login = new LoginForm();
            _quanLyTaiKhoan = new QuanLyTaiKhoan();
            _chonKhachHangForm = new ChonKhachHangForm();
        }

        [Test]
        // "Đăng nhập thành công với "" Tên đăng nhập""
        //và "" Mật khẩu"" đúng trong CSDL"
        public void TC_Nunit_01()
        {
            _login.tx_user.Text = "phucnk";
            _login.tx_pass.Text = "123";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.True);
        }
        [Test]
        //"Đăng nhập thất bại với "" Tên đăng nhập""
        //không tồn tại trong CSDL"
        public void TC_Nunit_02()
        {
            _login.tx_user.Text = "phucnk12345";
            _login.tx_pass.Text = "1";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.False);
        }
        [Test]
        //"Đăng nhập thất bại với "" mật khẩu""
        //để trống"
        public void TC_Nunit_03()
        {
            _login.tx_user.Text = "phucnk123";
            _login.tx_pass.Text = "";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.False);
        }
        [Test]
        //"Đăng nhập thất bại với "tên đăng nhập""
        //để trống"
        public void TC_Nunit_04()
        {
            _login.tx_user.Text = "";
            _login.tx_pass.Text = "1";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.False);
        }
        [Test]
        //"Đăng nhập thất bại với "mật khẩu""
        //để trống"
        public void TC_Nunit_05()
        {
            _login.tx_user.Text = "phucnk123";
            _login.tx_pass.Text = "";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.False);
        }
        [Test]
        //"Đăng nhập thất bại với "Tên dăng nhập" và"mật khẩu""
        //để trống"
        public void TC_Nunit_06()
        {
            _login.tx_user.Text = "";
            _login.tx_pass.Text = "";
            _login.bt_login_Click(null, null);


            Assert.That(_login.LoginCheck, Is.False);
        }

        [Test]
        //""Thêm khách hàng thành công với tất cả các trường
        //thông tin đầy đủ và đúng định dạng
        public void TC_Nunit_07()
        {
            _chonKhachHangForm.tx_nameKH.Text = "Nguyễn Văn Điểm";
            _chonKhachHangForm.tx_nameNT.Text = "Nguyễn Văn Điểm";
            _chonKhachHangForm.tx_cccdKH.Text = "123456789123";
            _chonKhachHangForm.tx_cccdNT.Text = "123456789124";
            _chonKhachHangForm.cbb_gtinhKH.Text = "Nam";
            _chonKhachHangForm.cbb_gtinhNT.Text = "Nam";
            _chonKhachHangForm.tx_diaChiKH.Text = "Hà Nội";
            _chonKhachHangForm.tx_diaChiNT.Text = "Hà Nội";
            _chonKhachHangForm.dtp_ngaySinhKH.Text = "12/1/2023";
            _chonKhachHangForm.tx_sdtNT.Text = "0969616833";
            _chonKhachHangForm.tx_sdtKH.Text = "0969616834";


            _chonKhachHangForm.button1_Click(null, null);


            Assert.That(_chonKhachHangForm.AddKH, Is.False);
        }


        [Test]
        //"Thêm khách hàng thất bại khi nhập sai đinh dạng "" tên KH"

        public void TC_Nunit_08()
        {
            _chonKhachHangForm.tx_nameKH.Text = "Nguyễn";
            _chonKhachHangForm.tx_nameNT.Text = "Nguyễn Văn Điểm";
            _chonKhachHangForm.tx_cccdKH.Text = "123456789123";
            _chonKhachHangForm.tx_cccdNT.Text = "123456789124";
            _chonKhachHangForm.cbb_gtinhKH.Text = "Nam";
            _chonKhachHangForm.cbb_gtinhNT.Text = "Nam";
            _chonKhachHangForm.tx_diaChiKH.Text = "Hà Nội";
            _chonKhachHangForm.tx_diaChiNT.Text = "Hà Nội";
            _chonKhachHangForm.dtp_ngaySinhKH.Text = "12/1/2023";
            _chonKhachHangForm.tx_sdtNT.Text = "0969616833";
            _chonKhachHangForm.tx_sdtKH.Text = "0969616834";


            _chonKhachHangForm.button1_Click(null, null);


            Assert.That(_chonKhachHangForm.AddKH, Is.False);
        }

        [Test]
        //"Thêm khách hàng thất bại khi nhập sai đinh dạng "" tên người thân"

        public void TC_Nunit_09()
        {
            _chonKhachHangForm.tx_nameKH.Text = "Nguyễn Văn Điểm";
            _chonKhachHangForm.tx_nameNT.Text = "Nguyễn";
            _chonKhachHangForm.tx_cccdKH.Text = "123456789123";
            _chonKhachHangForm.tx_cccdNT.Text = "123456789124";
            _chonKhachHangForm.cbb_gtinhKH.Text = "Nam";
            _chonKhachHangForm.cbb_gtinhNT.Text = "Nam";
            _chonKhachHangForm.tx_diaChiKH.Text = "Hà Nội";
            _chonKhachHangForm.tx_diaChiNT.Text = "Hà Nội";
            _chonKhachHangForm.dtp_ngaySinhKH.Text = "12/1/2023";
            _chonKhachHangForm.tx_sdtNT.Text = "0969616833";
            _chonKhachHangForm.tx_sdtKH.Text = "0969616834";


            _chonKhachHangForm.button1_Click(null, null);


            Assert.That(_chonKhachHangForm.AddKH, Is.False);
        }
        [Test]
        //Thêm khách hàng t thất bại khi  nhập sai định dạng sđt KH
        public void TC_Nunit_10()
        {
            {
                _chonKhachHangForm.tx_nameKH.Text = "Nguyễn Văn Điểm";
                _chonKhachHangForm.tx_nameNT.Text = "Nguyễn Văn Điểm";
                _chonKhachHangForm.tx_cccdKH.Text = "123456789123";
                _chonKhachHangForm.tx_cccdNT.Text = "123456789124";
                _chonKhachHangForm.cbb_gtinhKH.Text = "Nam";
                _chonKhachHangForm.cbb_gtinhNT.Text = "Nam";
                _chonKhachHangForm.tx_diaChiKH.Text = "Hà Nội";
                _chonKhachHangForm.tx_diaChiNT.Text = "Hà Nội";
                _chonKhachHangForm.dtp_ngaySinhKH.Text = "12/1/2023";
                _chonKhachHangForm.tx_sdtNT.Text = "0969";
                _chonKhachHangForm.tx_sdtKH.Text = "0969616834";


                _chonKhachHangForm.button1_Click(null, null);


                Assert.That(_chonKhachHangForm.AddKH, Is.False);
            }
        }


        [TearDown]
        public void Teadow()
        {
            _login.Dispose();
        }
    }
}
