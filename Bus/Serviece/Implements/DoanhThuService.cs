using Bus.ViewModal;
using Dal.Modal;
using Dal.Repository;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class DoanhThuService

    {
        XeRepo xeRepo = new XeRepo();
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        ChiPhiPhatSinhRepo CPPSRepo = new ChiPhiPhatSinhRepo();
        HoaDonThueXeRepo HoaDonThueXeRepo = new HoaDonThueXeRepo();
        HoaDonChiTietRepo HoaDonChiTietRepo = new HoaDonChiTietRepo();
        KhachHangRepo khachHangRepo = new KhachHangRepo();
        NhanVienRepo NhanVienRepo = new NhanVienRepo();
        ChiPhiPhatSinhRepo chiPhiPhatSinhRepo = new ChiPhiPhatSinhRepo();
        LoaiPhuPhiRepo loaiPhuPhiRepo = new LoaiPhuPhiRepo();

        List<LoaiXe> _lstLoaiXe;
        List<ChiPhiPhatSinh> _lstChiPhiPhatSinh;
        List<LoaiPhuPhi> _lstLoaiPhatSinh;
        List<Xe> _lstXe;

        List<HoaDonThueXe> _lstHĐTX;
        List<HoaDonChiTiet> _lstHĐCT;
        List<KhachHang> _lstKhachHang;
        List<NhanVien> _lstNhanVien;



        XeService _XeService = new XeService();
        public DoanhThuService()
        {
            _lstXe = new List<Xe>();
            _lstLoaiXe = new List<LoaiXe>();
            _lstChiPhiPhatSinh = new List<ChiPhiPhatSinh>();
            _lstLoaiPhatSinh = new List<LoaiPhuPhi>();

            _lstHĐTX = new List<HoaDonThueXe>();
            _lstHĐCT = new List<HoaDonChiTiet>();

            _lstXe = _XeService.GetAll();

            _lstHĐTX = _XeService.GetAllHDTX();
            _lstHĐCT = _XeService.GetAllHDCT();
            _lstLoaiPhatSinh = loaiPhuPhiRepo.GetALL();
            _lstChiPhiPhatSinh = chiPhiPhatSinhRepo.GetALL();
            _lstKhachHang = khachHangRepo.GetALL();
            _lstNhanVien = NhanVienRepo.GetNhanVien();
        }

        public List<DoanhThu> GetDoanhThus(DateTime ngayBD)
        {
            List<DoanhThu> _lstDoanhThu = new List<DoanhThu>();

            var getMHD = from ct in _lstHĐCT
                         join hd in _lstHĐTX on ct.IdHoaDon equals hd.Id
                         join xe in _lstXe on ct.IdXe equals xe.ID
                         join cp in _lstChiPhiPhatSinh on ct.Id equals cp.IdHDCT
                         join nv in _lstNhanVien on hd.IdNhanVien equals nv.Id
                         where ct.NgayBatDau == ngayBD && ct.TrangThai == 1 || ct.TrangThai == 2 || ct.TrangThai == 3 || ct.TrangThai == 4
                         select new DoanhThu()
                         {
                             maHD = hd.SoHopDong,
                             tenXe = xe.LoaiXe.Name,
                             bienSo = xe.BienSo,
                             ngayBD = ct.NgayBatDau,
                             ngayKT = ct.NgayKetThuc,
                             tienCoc = ct.TienCoc,
                             donGia = xe.DonGia,
                             phuPhi = cp.GiaTien,
                             tongTien = ct.TongTien,
                             tenNV = nv.HoTen
                         };
            _lstDoanhThu.AddRange(getMHD);
            return _lstDoanhThu;
        }

        public List<DoanhThu> GetDoanhThuThang(DateTime thang)
        {
            List<DoanhThu> _lstDoanhThu = new List<DoanhThu>();
            var getMHD = from ct in _lstHĐCT
                         join hd in _lstHĐTX on ct.IdHoaDon equals hd.Id
                         join xe in _lstXe on ct.IdXe equals xe.ID
                         join cp in _lstChiPhiPhatSinh on ct.Id equals cp.IdHDCT
                         where ct.NgayBatDau.Month == thang.Month /* && ct.Id in (from cp in _lstChiPhiPhatSinh select cp.IdHDCT)*/ && ct.TrangThai == 1 || ct.TrangThai == 2 || ct.TrangThai == 3 || ct.TrangThai == 4
                         select new DoanhThu()
                         {
                             maHD = hd.SoHopDong,
                             tenXe = xe.LoaiXe.Name,
                             bienSo = xe.BienSo,
                             ngayBD = ct.NgayBatDau,
                             ngayKT = ct.NgayKetThuc,
                             tienCoc = ct.TienCoc,
                             donGia = xe.DonGia,
                             phuPhi = cp.GiaTien,
                             tongTien = ct.TongTien,
                             tenNV = hd.IdNhanVien.ToString()
                         };
            _lstDoanhThu.AddRange(getMHD);

            return _lstDoanhThu;
        }

        public List<DoanhThu> GetDoanhThuNam(DateTime nam)
        {
            List<DoanhThu> _lstDoanhThu = new List<DoanhThu>();
            var getMHD = from ct in _lstHĐCT
                         join hd in _lstHĐTX on ct.IdHoaDon equals hd.Id
                         join xe in _lstXe on ct.IdXe equals xe.ID
                         join cp in _lstChiPhiPhatSinh on ct.Id equals cp.IdHDCT
                         where ct.NgayBatDau.Year == nam.Year  /* && ct.Id in (from cp in _lstChiPhiPhatSinh select cp.IdHDCT)*/ && ct.TrangThai == 1 || ct.TrangThai == 2 || ct.TrangThai == 3 || ct.TrangThai == 4
                         select new DoanhThu()
                         {
                             maHD = hd.SoHopDong,
                             tenXe = xe.LoaiXe.Name,
                             bienSo = xe.BienSo,
                             ngayBD = ct.NgayBatDau,
                             ngayKT = ct.NgayKetThuc,
                             tienCoc = ct.TienCoc,
                             donGia = xe.DonGia,
                             phuPhi = cp.GiaTien,
                             tongTien = ct.TongTien,
                             tenNV = hd.IdNhanVien.ToString()
                         };
            _lstDoanhThu.AddRange(getMHD);

            return _lstDoanhThu;
        }

        public LoaiXe Top1XeNam(DateTime dtBD)
        {
            List<HoaDonChiTiet> lstHDCT = HoaDonChiTietRepo.GetALL();
            foreach (var hdct in lstHDCT)
            {
                hdct.Xe = xeRepo.GetXe().FirstOrDefault(p => p.ID == hdct.IdXe);
                hdct.HoaDonThueXe = HoaDonThueXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.IdHoaDon);
                hdct.HoaDonThueXe.KhachHang = khachHangRepo.GetALL().FirstOrDefault(p => p.Id == hdct.HoaDonThueXe.IdKhachHang);
                hdct.Xe.LoaiXe = loaiXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.Xe.IdLoaiXe);
                hdct.chiPhiPhatSinhs = chiPhiPhatSinhRepo.GetALL().Where(p => p.IdHDCT == hdct.Id).ToList();
                foreach (var item in hdct.chiPhiPhatSinhs)
                {
                    item.LoaiPhuPhi = loaiPhuPhiRepo.GetALL().FirstOrDefault(p => p.Id == item.IdLPP);
                }
            }
            var mostRentedVehicleType = lstHDCT.Where(c => c.NgayBatDau.Year == dtBD.Year)
            .GroupBy(detail => detail.Xe.IdLoaiXe)
            .Select(group => new
            {
                LoaiXeId = group.Key,
                Count = group.Count()
            })
            .OrderByDescending(item => item.Count)
            .FirstOrDefault();

            if (mostRentedVehicleType != null)
            {
                var loaiXe = loaiXeRepo.GetALL()
                    .Where(loai => loai.Id == mostRentedVehicleType.LoaiXeId)
                    .FirstOrDefault();

                return loaiXe;
            }
            else
            {
                return null;
            }
        }

        public LoaiXe Top1XeThang(DateTime thang)
        {
            List<HoaDonChiTiet> lstHDCT = HoaDonChiTietRepo.GetALL();
            foreach (var hdct in lstHDCT)
            {
                hdct.Xe = xeRepo.GetXe().FirstOrDefault(p => p.ID == hdct.IdXe);
                hdct.HoaDonThueXe = HoaDonThueXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.IdHoaDon);
                hdct.HoaDonThueXe.KhachHang = khachHangRepo.GetALL().FirstOrDefault(p => p.Id == hdct.HoaDonThueXe.IdKhachHang);
                hdct.Xe.LoaiXe = loaiXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.Xe.IdLoaiXe);
                hdct.chiPhiPhatSinhs = chiPhiPhatSinhRepo.GetALL().Where(p => p.IdHDCT == hdct.Id).ToList();
                foreach (var item in hdct.chiPhiPhatSinhs)
                {
                    item.LoaiPhuPhi = loaiPhuPhiRepo.GetALL().FirstOrDefault(p => p.Id == item.IdLPP);
                }
            }
            var mostRentedVehicleType = lstHDCT.Where(c => c.NgayBatDau.Month == thang.Month)
            .GroupBy(detail => detail.Xe.IdLoaiXe)
            .Select(group => new
            {
                LoaiXeId = group.Key,
                Count = group.Count()
            })
            .OrderByDescending(item => item.Count)
            .FirstOrDefault();

            if (mostRentedVehicleType != null)
            {
                var loaiXe = loaiXeRepo.GetALL()
                    .Where(loai => loai.Id == mostRentedVehicleType.LoaiXeId)
                    .FirstOrDefault();

                return loaiXe;
            }
            else
            {
                return null;
            }
        }
    }
}

