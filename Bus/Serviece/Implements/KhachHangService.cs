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
        HoaDonChiTietRepo _HoaDonChiTietRepo = new HoaDonChiTietRepo();
        List<HoaDonChiTiet> _lstHDCT;
        XeRepo _xeRepo = new XeRepo();
        List<Xe> _lstXe;

        public KhachHangService()
        {
            _lstKhachHang = _khachHangRepo.GetALL();
            _lsthoaDonThueXes = _hoaDonThueXerepo.GetALL();
            _lstHDCT = _HoaDonChiTietRepo.GetALL();
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
            var result = from 
                          t in _lsthoaDonThueXes 
                         join c in _lstHDCT on t.Id equals c.IdHoaDon
                         where t.IdKhachHang == id
                         select c;
            decimal slhd = result.Count();
            decimal sumHD = result.Sum(c => c.TongTien);
            return new decimal[] { slhd, sumHD };
        }
    }
}
