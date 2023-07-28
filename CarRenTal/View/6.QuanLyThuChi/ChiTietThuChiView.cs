using Bus.Serviece.Implements;
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

namespace CarRenTal.View._6.QuanLyThuChi
{
    public partial class ChiTietThuChiView : Form
    {
        HoaDonChiTietService _HDCTService = new HoaDonChiTietService();
        List<HoaDonChiTiet> _lstHDCT;
        XeService _xeService = new XeService();
        List<Xe> _lstXe;
        List<LoaiXe> _lstLoaiXe;
        List<ChiPhiPhatSinh> _lstCPPS;
        List<XeBaoHiem> _lstXeBaoHiem;
        List<DangKiem> _lstDangKiem;
        List<BaoDuong> _lstBaoDuong;
        public ChiTietThuChiView()
        {
            InitializeComponent();
            _lstHDCT = new List<HoaDonChiTiet>();
            _lstXe = new List<Xe>();
        }



        private void ChiTietThuChiView_Load(object sender, EventArgs e)
        {

        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDoanhThu.Rows.Clear();

            dgvDoanhThu.ColumnCount = 10;

            dgvDoanhThu.Columns[0].Name = "Mã HD";
            dgvDoanhThu.Columns[1].Name = "Tên xe";
            dgvDoanhThu.Columns[2].Name = "Biển số";
            dgvDoanhThu.Columns[3].Name = "Ngày bắt đầu";
            dgvDoanhThu.Columns[4].Name = "Ngày kết thúc";
            dgvDoanhThu.Columns[5].Name = "Số ngày";
            dgvDoanhThu.Columns[6].Name = "Đơn giá";
            dgvDoanhThu.Columns[7].Name = "Phụ phí";
            dgvDoanhThu.Columns[8].Name = "Tổng tiền";

            foreach (var i in GetListXeInHDCT())
            {
                dgvDoanhThu.Rows.Add(i.IdHoaDon, i.Xe.LoaiXe, i.Xe.BienSo, i.NgayBatDau, i.NgayKetThuc, i.NgayKetThuc - i.NgayBatDau, i.DonGia, "", i.TongTien);
            }

        }

        private List<HoaDonChiTiet> GetListXeInHDCT()
        {
            _lstHDCT = _HDCTService.GetAll();
            _lstXe = _xeService.GetAll();
            _lstLoaiXe = _xeService.GetAllLoaiXe();
            foreach (var i in _lstHDCT)
            {
                i.Xe = _lstXe.FirstOrDefault(c => c.ID == i.IdXe);
                i.Xe.LoaiXe = _lstLoaiXe.FirstOrDefault(c => c.Id == i.Xe.IdLoaiXe);
                //i.chiPhiPhatSinhs = _lstCPPS.Where(c => c.IdHDCT == i.Id).ToList();
            }
            return _lstHDCT;
        }

        private void dgvBaoHiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBaoHiem.Rows.Clear();

            dgvBaoHiem.ColumnCount = 5;

            dgvBaoHiem.Columns[0].Name= "ID";
            dgvBaoHiem.Columns[1].Name= "Ngày mua";
            dgvBaoHiem.Columns[2].Name= "Hãng bảo hiểm";
            dgvBaoHiem.Columns[3].Name= "Chi phí";
            dgvBaoHiem.Columns[4].Name= "Xe";
            dgvBaoHiem.Columns[5].Name= "Trạng thái";

            _lstXeBaoHiem = _xeService.GetAllBHX();

            foreach (var i in _lstXeBaoHiem)
            {
                dgvBaoHiem.Rows.Add(i.Id, i.NgayBatDau, i.IdHangBaoHiem, i.ChiPhi, i.Xe.LoaiXe, i.TrangThai);
            }
        }

        private List<XeBaoHiem> GetXeInXeBH()
        {
            _lstXe = _xeService.GetAll();

            foreach (var i in _lstXeBaoHiem)
            {
                i.Xe.LoaiXe = _lstLoaiXe.FirstOrDefault(c=>c.Id== i.Xe.IdLoaiXe);
            }
            return _lstXeBaoHiem;
        }
    }
}
