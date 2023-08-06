using Bus.ViewModal;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class KhoanChiService
    {
        XeRepo xeRepo = new XeRepo();
        List<Xe> _lstXe;
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        List<LoaiXe> _lstLoaiXe;
        ChiPhiPhatSinhRepo CPPSRepo = new ChiPhiPhatSinhRepo();
        List<ChiPhiPhatSinh> _lstChiPhiPhatSinh;

        HoaDonChiTietRepo hoaDonChiTietRepo = new HoaDonChiTietRepo();

        XeService _XeService = new XeService();

        Xe_BaoHiemRepo xe_BaoHiemRepo = new Xe_BaoHiemRepo();
        DangKiemRepo DangKiemRepo = new DangKiemRepo();
        BaoDuongRepo baoDuongRepo = new BaoDuongRepo();
        List<XeBaoHiem> _lstBHX;
        List<DangKiem> _lstĐKX;
        List<BaoDuong> _lstBDX;
        List<HoaDonChiTiet> _lstHDCT;


        public KhoanChiService()
        {
            _lstXe = new List<Xe>();
            _lstLoaiXe = new List<LoaiXe>();
            _lstChiPhiPhatSinh = new List<ChiPhiPhatSinh>();
            _lstBHX = new List<XeBaoHiem>();
            _lstBDX = new List<BaoDuong>();
            _lstĐKX = new List<DangKiem>();

            _lstXe = _XeService.GetAll();
            _lstBHX = _XeService.GetAllBHX();
            _lstĐKX = _XeService.GetAllDKX();
            _lstBDX = _XeService.GetAllBDX();
            _lstHDCT = hoaDonChiTietRepo.GetALL();
        }

        public List<KhoanChi> GetKhoanChi(DateTime ngayBD)
        {
            List<KhoanChi> _lstKhoanChi = new List<KhoanChi>();

            //lấy các bảo hiểm đã chi trong ngày cụ thể
            var layKCBH = from bh in _lstBHX
                          join x in _lstXe on bh.IdXe equals x.ID
                          where bh.NgayBatDau == ngayBD
                          select new KhoanChi() { loaiChi = "Bảo Hiểm", loaiXe = x.LoaiXe.Name, bienSo = x.BienSo, ngayChi = bh.NgayBatDau, soTien = bh.ChiPhi };
            _lstKhoanChi.AddRange(layKCBH);

            //lấy đăng kiểm đã chi trong ngày cụ thể
            layKCBH = from dk in _lstĐKX
                      join x in _lstXe on dk.IdXe equals x.ID
                      where dk.NgayDangKiem == ngayBD
                      select new KhoanChi() { loaiChi = "Đăng Kiểm", loaiXe = x.LoaiXe.Name, bienSo = x.BienSo, ngayChi = dk.NgayDangKiem, soTien = dk.ChiPhi };
            _lstKhoanChi.AddRange(layKCBH);

            //lấy bảo dưỡng đã chi trong ngày cụ thể
            layKCBH = from bd in _lstBDX
                      join x in _lstXe on bd.IdXe equals x.ID
                      where bd.NgayDangKiem == ngayBD
                      select new KhoanChi() { loaiChi = "Bảo dưỡng", loaiXe = x.LoaiXe.Name, bienSo = x.BienSo, ngayChi = bd.NgayDangKiem, soTien = bd.ChiPhi };
            _lstKhoanChi.AddRange(layKCBH);

            //lấy tiền đền bù hợp đồng 
             var layBUKH = from ct in _lstHDCT 
                      join x in _lstXe on ct.IdXe equals x.ID
                           where ct.NgayBatDau == ngayBD && ct.TrangThai == 5

                           select new KhoanChi() { loaiChi = "Đền bù hợp đồng", loaiXe = x.LoaiXe.Name, bienSo = x.BienSo, ngayChi = ct.NgayBatDau, soTien = ct.TongTien };
            _lstKhoanChi.AddRange(layBUKH);
            return _lstKhoanChi;
        }




    }
}
