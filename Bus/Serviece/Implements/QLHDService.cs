using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class QLHDService
    {
        HoaDonChiTietRepo _HDCTRepo = new HoaDonChiTietRepo();
        HoaDonThueXeRepo _HDRepo = new HoaDonThueXeRepo();
        XeRepo _XeRepo = new XeRepo();
        LoaiXeRepo _loaiXeRepo = new LoaiXeRepo();
        KhachHangRepo _KhachHangRepo = new KhachHangRepo();
        NhanVienRepo _NhanVienRepo = new NhanVienRepo();
        TheChapRepo _theChapRep= new TheChapRepo();       
        List<HoaDonChiTiet> _lstHDCT;
        List<HoaDonThueXe> _lstHD;
        List<Xe> _lstXe;
        List<KhachHang> _lstKhachHang;
        List<NhanVien> _lstNhanVien;
        List<LoaiXe> _lstLoaiXe;

        public QLHDService()
        {

            _lstHDCT = _HDCTRepo.GetALL();
            _lstXe = _XeRepo.GetXe();
            _lstKhachHang = _KhachHangRepo.GetALL();
            _lstNhanVien = _NhanVienRepo.GetNhanVien();
            _lstLoaiXe = _loaiXeRepo.GetALL();
        }
        public List<HoaDonThueXe> GetData(DateTime minDate, DateTime maxDate, string search)
        {
            try
            {
                List<HoaDonThueXe> _lstHoaDon = _HDRepo.GetALL();
                _lstHoaDon = _lstHoaDon.Where(p => p.NgayTao >= minDate.Date && p.NgayTao <= maxDate.Date).ToList();
                foreach (var item in _lstHoaDon)
                {
                    item.KhachHang = _lstKhachHang.FirstOrDefault(p => p.Id == item.IdKhachHang);
                    item.NhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == item.IdNhanVien);
                    item.HoaDonChiTiets = _lstHDCT.Where(p => p.IdHoaDon == item.Id).ToList();                 
                    foreach (var hd in item.HoaDonChiTiets)
                    {
                        hd.Xe = _lstXe.FirstOrDefault(p => p.ID == hd.IdXe);
                        hd.Xe.LoaiXe = _lstLoaiXe.FirstOrDefault(p => p.Id == hd.Xe.IdLoaiXe);
                        hd.theChaps = _theChapRep.GetAll().Where(p => p.IdHDCT == hd.Id).ToList();
                    }
                }

                Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
                 
                if (regex.IsMatch(search))
                {
                    if (search.Length>7)
                    {
                        return null;
                    }
                    _lstHoaDon = _lstHoaDon.Where(p => p.SoHopDong==int.Parse(search)).ToList();
                }
                _lstHoaDon = _lstHoaDon.Where(p => p.KhachHang.Name.ToLower().Contains(search.ToLower())).ToList();
                return _lstHoaDon;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public decimal TinhTien(HoaDonThueXe hd)
        {
            List < HoaDonChiTiet > lstHDCT= hd.HoaDonChiTiets.ToList();
            decimal tongTien = 0;
            foreach (var item in lstHDCT)
            {
                if (item.TrangThai==0)
                {
                    continue;
                }
                if (item.TrangThai == 1|| item.TrangThai==4)
                {
                    tongTien += item.TienCoc;
                    continue;
                }
                if (item.TrangThai==5)
                {
                    tongTien -= item.TienCoc;
                    continue;
                }
                tongTien += item.TongTien;               
            }
            return tongTien;
        }
    }
}
