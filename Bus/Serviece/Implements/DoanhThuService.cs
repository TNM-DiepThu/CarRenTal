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

        public List<DoanhThu> GetDoanhThus(DateTime date)
        {
            List<DoanhThu> _lstDoanhThu = new List<DoanhThu>();
            _lstHĐCT = _XeService.GetAllHDCT().Where(c=>c.NgayBatDau.Date == date.Date).ToList();
            foreach (var hdct in _lstHĐCT)
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
            foreach (var item in _lstHĐCT)
            {
               DoanhThu dtc = new DoanhThu()
               {
                   maHD = item.HoaDonThueXe.SoHopDong,
                   tenXe = item.Xe.LoaiXe.Name,
                   bienSo = item.Xe.BienSo,
                   ngayBD = item.NgayBatDau,
                   ngayKT = item.NgayKetThuc,
                   tienCoc = item.TienCoc,
                   donGia = item.DonGia,
                   tongTien = item.TongTien,
                   tenNV = item.HoaDonThueXe.KhachHang.Name,
               };
                decimal tong = 0;
                foreach (var item2 in item.chiPhiPhatSinhs) 
                {
                    tong += item2.GiaTien;
                }
                dtc.phuPhi = tong;
                _lstDoanhThu.Add(dtc);

            }
            return _lstDoanhThu;
        }
        public List<HoaDonChiTiet> GetDoanhThugay()
        {
            List<HoaDonChiTiet> _lstHDCT = new List<HoaDonChiTiet>();

            foreach (var i in _lstHĐCT)
            {
                i.chiPhiPhatSinhs = _lstChiPhiPhatSinh.Where(c => c.IdHDCT == i.Id).ToList();
            }

            return _lstHĐCT;
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

