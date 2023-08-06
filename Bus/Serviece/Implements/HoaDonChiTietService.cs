using Dal.Modal;
using Dal.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    
    public class HoaDonChiTietService
    {
        HoaDonChiTietRepo HDCTRepo= new HoaDonChiTietRepo();
        HoaDonThueXeRepo HoaDonThueXeRepo= new HoaDonThueXeRepo();
        KhachHangRepo KhachHangRepo= new KhachHangRepo();
        XeRepo xeRepo = new XeRepo();
        ChiPhiPhatSinhRepo phuPhiRepo= new ChiPhiPhatSinhRepo();
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        LoaiPhuPhiRepo loaiPhuPhiRepo = new LoaiPhuPhiRepo();
        GiayToTheChapRepo giayToRepo= new GiayToTheChapRepo();
        TaiSanTheChapRepo taiSanRepo= new TaiSanTheChapRepo();
        TheChapRepo theChapRepo= new TheChapRepo();
        List<HoaDonChiTiet> _lstHDCT;
        HoaDonService hoaDonService = new HoaDonService();
        XeRepo XeRepo = new XeRepo();
        List<Xe> _lstXe;

        ChiPhiPhatSinhRepo CPSTRepo = new ChiPhiPhatSinhRepo();
        List<ChiPhiPhatSinh> _lstCPPS;


        public HoaDonChiTietService()
        {
            _lstHDCT = new List<HoaDonChiTiet>();
            _lstXe = new List<Xe>();
            _lstCPPS = new List<ChiPhiPhatSinh> ();
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return HDCTRepo.GetALL().ToList();
        }
        public List<GiayToTheChap> GetGiayTo()
        {
            return giayToRepo.GetALL().ToList();
        }
        public List<TaiSanTheChap> GetTaiSan()
        {
            return taiSanRepo.GetALL().ToList();
        }
        public List<LoaiPhuPhi> GetLoaiPhuPhi()
        {
            return loaiPhuPhiRepo.GetALL().ToList();
        }


        public bool CreateHDCT (HoaDonChiTiet hdct)
        {
            return HDCTRepo.Create(hdct);
        }
        public bool UpdateHDCT(HoaDonChiTiet hdct)
        {
            return HDCTRepo.Update(hdct);
        }

        public List<Xe> GetListXe (Guid Idxe)
        {
            var rusult = from x in _lstXe
                         join hd in _lstHDCT on x.ID equals hd.IdXe
                         where hd.TrangThai == 1
                         select x;

            return rusult.ToList();
        }

        public List<HoaDonChiTiet> GetHDCT(int tThai, string timKiem)
        {
            List<HoaDonChiTiet> lstHDCT;
            if (tThai == 3)
            {
                 lstHDCT = HDCTRepo.GetALL().Where(p => p.TrangThai == 2&& DateTime.Now.Date>= p.NgayKetThuc).ToList();
            }
            else if (tThai == 1)
            {
                 lstHDCT = HDCTRepo.GetALL().Where(p => p.TrangThai == tThai).ToList();
            }
            else
            {
                 lstHDCT = HDCTRepo.GetALL().Where(p => p.TrangThai == tThai && DateTime.Now.Date < p.NgayKetThuc).ToList();
            }
            
            foreach (var hdct in lstHDCT)
            {
                hdct.Xe = xeRepo.GetXe().FirstOrDefault(p => p.ID == hdct.IdXe);
                hdct.HoaDonThueXe = HoaDonThueXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.IdHoaDon);
                hdct.HoaDonThueXe.KhachHang= KhachHangRepo.GetALL().FirstOrDefault(p => p.Id == hdct.HoaDonThueXe.IdKhachHang);
                hdct.Xe.LoaiXe= loaiXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.Xe.IdLoaiXe);
                hdct.theChaps= theChapRepo.GetAll().Where(p=>p.IdHDCT==hdct.Id).ToList();
                hdct.chiPhiPhatSinhs= phuPhiRepo.GetALL().Where(p=>p.IdHDCT==hdct.Id).ToList();
                foreach (var item in hdct.chiPhiPhatSinhs)
                {
                    item.LoaiPhuPhi= loaiPhuPhiRepo.GetALL().FirstOrDefault(p=>p.Id==item.IdLPP);
                }
            }
            if (timKiem != null)
            {
                lstHDCT = lstHDCT.Where(p => p.HoaDonThueXe.KhachHang.Name.ToUpper().Contains(timKiem.ToUpper()) || p.HoaDonThueXe.KhachHang.CCCD.Contains(timKiem.ToUpper())).ToList();
            }
            return lstHDCT;
        }

        public void CreateTheChap(TheChap theChap)
        {
            theChapRepo.Create(theChap);
        }

        public void UpdateTheChap(TheChap theChap)
        {
            theChap=theChapRepo.GetAll().FirstOrDefault(p=>p.IdHDCT==theChap.Id);
            theChap.TinhTrang = 2;
            theChapRepo.Update(theChap);

        }

        public void CreatePhuPhi(ChiPhiPhatSinh phuPhi)
        {
            phuPhiRepo.Create(phuPhi);
        }

        public void RemoveChiPhi(ChiPhiPhatSinh chiPhiPhatSinh)
        {
            phuPhiRepo.RemoveAll(chiPhiPhatSinh);
        }

        public LoaiXe Top1XeDay()
        {
            List<HoaDonChiTiet> lstHDCT = HDCTRepo.GetALL();
            foreach (var hdct in lstHDCT)
            {
                hdct.Xe = xeRepo.GetXe().FirstOrDefault(p => p.ID == hdct.IdXe);
                hdct.HoaDonThueXe = HoaDonThueXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.IdHoaDon);
                hdct.HoaDonThueXe.KhachHang = KhachHangRepo.GetALL().FirstOrDefault(p => p.Id == hdct.HoaDonThueXe.IdKhachHang);
                hdct.Xe.LoaiXe = loaiXeRepo.GetALL().FirstOrDefault(p => p.Id == hdct.Xe.IdLoaiXe);
                hdct.chiPhiPhatSinhs = phuPhiRepo.GetALL().Where(p => p.IdHDCT == hdct.Id).ToList();
                foreach (var item in hdct.chiPhiPhatSinhs)
                {
                    item.LoaiPhuPhi = loaiPhuPhiRepo.GetALL().FirstOrDefault(p => p.Id == item.IdLPP);
                }
            }
            var mostRentedVehicleType = lstHDCT
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

        public void UpdateData()
        {
            foreach (var item in HoaDonThueXeRepo.GetALL())
            {
                hoaDonService.CheckHoaDon(item);
            }
        }
    }
}
