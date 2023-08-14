using Bus.Serviece.Implements;
using Bus.ViewModal;
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
using ZXing;

namespace CarRenTal.View._6.QuanLyThuChi
{
    public partial class QLCTView : Form
    {
        DoanhThuService DTService = new DoanhThuService();
        List<DoanhThu> _lstDoanhThu;
        List<HoaDonChiTiet> _lstHoaDonCT;

        decimal _doanhThu = 0;
        decimal _HieuXuatNgay = 100000000;
        decimal _HieuXuatThang = 3000000000;
        decimal _HieuXuatNam = 36000000000;
        int _amountCar = 0;

        public QLCTView()
        {
            InitializeComponent();
            _lstDoanhThu = new List<DoanhThu>();
            _lstHoaDonCT = new List<HoaDonChiTiet>();

        }
        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentFormChild != null)
        //    {
        //        currentFormChild.Close();
        //    }
        //    currentFormChild = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    // childForm.Dock = DockStyle.Fill;
        //    pn_show.Controls.Add(childForm);
        //    // pnlBody.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietThuChiView chiTietThuChiView = new ChiTietThuChiView();
            chiTietThuChiView.TopLevel = true;
            chiTietThuChiView.BringToFront();
            chiTietThuChiView.Show();
        }

        private void QLCTView_Load(object sender, EventArgs e)
        {
            GetHSDoanhThu(dtNDTTheoNgay.Value);
            GetHSDoanhThuThang(dtNDTTheoNgay.Value);
            GetHSDoanhThuNam(dtNDTTheoNgay.Value);

            SLXeChoThueTrongNgay();
            SLXeChoThueTrongThang();
            SLXeChoThueTrongNam();

            var result = DTService.Top1XeThang(dtNDTTheoNgay.Value);
            if (result != null)
            {
                lbXeTop1Thang.Visible = true;
                lbXeTop1Thang.Text = result.Name;
            }
            else
            {
                lbXeTop1Thang.Text = "0";
            }

            var resultNam = DTService.Top1XeNam(dtNDTTheoNgay.Value);
            if (resultNam != null)
            {
                lbXeTop1Nam.Visible = true;
                lbXeTop1Nam.Text = resultNam.Name;
            }
            else
            {
                lbXeTop1Nam.Text = "0";
            }


        }

        public void GetHSDoanhThu(DateTime dtb)
        {
            _lstHoaDonCT = DTService.GetDoanhThugay();

            foreach (var i in _lstHoaDonCT.Where(c => c.NgayBatDau.Date == DateTime.Now.Date))
            {
                _doanhThu += decimal.Parse((i.TongTien + i.chiPhiPhatSinhs.Sum(c => c.GiaTien)).ToString());
            }
            lbHieuXuat.Visible = true;
            lbTDTNgay.Text = _doanhThu.ToString();
            lbTDTNgay.Visible = true;
            lbHieuXuat.Text = ((_doanhThu / _HieuXuatNgay) * 100).ToString("#.###") + "%";
            lbXDCTNgay.Visible = true;
            lbXDCTNgay.Text = _lstHoaDonCT.Count(c => c.NgayBatDau.Date == DateTime.Now.Date).ToString();
        }
        public void GetHSDoanhThuThang(DateTime dtb)
        {
            _lstHoaDonCT = DTService.GetDoanhThugay();

            foreach (var i in _lstHoaDonCT.Where(c => c.NgayBatDau.Month == dtb.Month))
            {
                _doanhThu += decimal.Parse((i.TongTien + i.chiPhiPhatSinhs.Sum(c => c.GiaTien)).ToString());
            }
            lbHSDoanhThuThang.Visible = true;
            lbTDTThang.Text = _doanhThu.ToString();
            lbTDTThang.Visible = true;
            lbHSDoanhThuThang.Text = ((_doanhThu / _HieuXuatThang) * 100).ToString("#.##") + "%";
            lbXeDCThang.Visible = true;
            lbXeDCThang.Text = _lstHoaDonCT.Where(c => c.NgayBatDau.Month == dtb.Month).ToList().Count.ToString();
        }
        public void GetHSDoanhThuNam(DateTime dtb)
        {
            _lstHoaDonCT = DTService.GetDoanhThugay();

            foreach (var i in _lstHoaDonCT.Where(c => c.NgayBatDau.Year == dtb.Year))
            {
                _doanhThu += decimal.Parse((i.TongTien + i.chiPhiPhatSinhs.Sum(c => c.GiaTien)).ToString());
            }
            lbHSDoanhThuNam.Visible = true;
            lbTDTNam.Text = _doanhThu.ToString();
            lbTDTNam.Visible = true;
            lbHSDoanhThuNam.Text = ((_doanhThu / _HieuXuatNam) * 100).ToString("#.##") + "%";
            lbXeDCTNam.Visible = true;
            lbXeDCTNam.Text = _lstHoaDonCT.Where(c => c.NgayBatDau.Year == dtb.Year).ToList().Count.ToString();
        }

        public void SLXeChoThueTrongNam()
        {
            //var ruslt = DTService.GetDoanhThuNam(dtNDTTheoNgay.Value);
            //if (ruslt != null)
            //{
            //    for (int i = 0; i < ruslt.Count; i++)
            //    {
            //        _amountCar++;
            //    }
            //    lbXeDCTNam.Visible = true;
            //    lbXeDCTNam.Text = _amountCar.ToString();
            //}
            //else
            //{
            //    lbXeDCTNam.Text = "0";
            //}

        }
        public void SLXeChoThueTrongThang()
        {


            //var ruslt = DTService.GetDoanhThuThang(dtNDTTheoNgay.Value);
            //if (ruslt != null)
            //{
            //    for (int i = 0; i < ruslt.Count; i++)
            //    {
            //        _amountCar++;
            //    }
            //    lbXeDCThang.Visible = true;
            //    lbXeDCThang.Text = _amountCar.ToString();
            //}
            //else
            //{
            //    lbXeDCThang.Text = "0";
            //}

        }
        public void SLXeChoThueTrongNgay()
        {
            //var ruslt = DTService.GetDoanhThus(dtNDTTheoNgay.Value);
            //if (ruslt != null)
            //{
            //    for (int i = 0; i < ruslt.Count; i++)
            //    {
            //        _amountCar++;
            //    }
            //    lbXDCTNgay.Visible = true;
            //    lbXDCTNgay.Text = _amountCar.ToString();
            //}
            //else
            //{
            //    lbXDCTNgay.Text = "0";
            //}

        }

        private void dtNDTTheoNgay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
