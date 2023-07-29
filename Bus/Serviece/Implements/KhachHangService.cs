using Bus.Serviece.Interface;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class KhachHangService : IKhachHangService
    {
        KhachHangRepo _khachHangRepo = new KhachHangRepo();
        List<KhachHang> _lstKhachHang;
        HoaDonThueXeRepo _hoaDonThueXerepo = new HoaDonThueXeRepo();
        List<HoaDonThueXe> _lsthoaDonThueXes;
        HoaDonChiTiet _HoaDonChiTietRepo = new HoaDonChiTiet();
        List<HoaDonChiTiet> _lstHDCT;
        XeRepo _xeRepo = new XeRepo();
        List<Xe> _lstXe;

        public KhachHangService()
        {
            _lstKhachHang = new List<KhachHang>();
            _xeRepo = new XeRepo();
            _lsthoaDonThueXes = new List<HoaDonThueXe>();
            _lstHDCT = new List<HoaDonChiTiet>();
        }
        public List<KhachHang> GetALL()
        {
            return _khachHangRepo.GetALL();
        }
        public KhachHang FindKhachHang(Guid id)
        {
            return _lstKhachHang.FirstOrDefault(p => p.Id == id);
        }

        public bool CreateKhachHang(KhachHang khachHang)
        {
            return _khachHangRepo.Create(khachHang);
        }
        public bool UpdateKhachHang(KhachHang khachHang)
        {
            return _khachHangRepo.Update(khachHang);
        }

        public decimal[] GetNumberXe(Guid id)
        {
            var result = from n in _lstKhachHang
                         join t in _lsthoaDonThueXes on n.Id equals t.IdKhachHang
                         join c in _lstHDCT on t.Id equals c.IdHoaDon
                         where t.IdKhachHang == id
                         select c;
            decimal slhd = result.Count();
            decimal sumHD = result.Sum(c => c.TongTien);
            return new decimal[] { slhd, sumHD };
        }
    }
}
