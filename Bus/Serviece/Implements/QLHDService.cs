using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class QLHDService
    {
        HoaDonChiTietRepo _HDCTRepo;
        HoaDonThueXeRepo _HDRepo;
        XeRepo _XeRepo;
        KhachHangRepo _KhachHangRepo;
        NhanVienRepo _NhanVienRepo;
        List<HoaDonChiTiet> _lstHDCT;
        List<HoaDonThueXe> _lstHD;
        List<Xe> _lstXe;
        List<KhachHang> _lstKhachHang;
        List<NhanVien> _lstNhanVien;
        public QLHDService()
        {
            _lstHD = _HDRepo.GetALL();
            _lstHDCT = _HDCTRepo.GetALL();
            _lstXe = _XeRepo.GetXe();
            _lstKhachHang = _KhachHangRepo.GetALL();
            _lstNhanVien = _NhanVienRepo.GetNhanVien();
        }
        public List<HoaDonThueXe>GetData(int trangThai, DateTime minDate, DateTime maxDate)
        {
            try
            {
                var hoaDon = from hd in _lstHD
                             join hdct in _lstHDCT on hd.Id equals hdct.IdHoaDon
                             join x in _lstXe on hdct.IdXe equals x.ID
                             join k in _lstKhachHang on hd.IdKhachHang equals k.Id
                             join n in _lstNhanVien on hd.IdNhanVien equals n.Id
                             where hdct.TrangThai == trangThai && (hdct.NgayBatDau > minDate) && hdct.NgayKetThuc < maxDate
                             select hd;
                List<HoaDonThueXe> _lstHoaDon = hoaDon.ToList();
                foreach (var item in _lstHoaDon)
                {
                    item.KhachHang = _lstKhachHang.FirstOrDefault(p => p.Id == item.IdKhachHang);
                    item.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == item.IdNhanVien);
                    item.HoaDonChiTiets = _lstHDCT.Where(p => p.IdHoaDon == item.Id).ToList();
                    foreach (var hd in item.HoaDonChiTiets)
                    {
                        hd.Xe = _lstXe.FirstOrDefault(p => p.ID == hd.IdXe);
                    }
                }
                return _lstHoaDon;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
