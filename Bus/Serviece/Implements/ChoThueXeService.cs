using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Modal;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace Bus.Serviece.Implements
{
    public class ChoThueXeService
    {
        XeRepo xeRepo = new XeRepo();
        HoaDonChiTietRepo hoaDonChiTietRepo = new HoaDonChiTietRepo();
        BaoDuongRepo baoDuongRepo = new BaoDuongRepo();
        Xe_BaoHiemRepo xe_BaoHiemRepo = new Xe_BaoHiemRepo();
        HangXeRepo hangXeRepo = new HangXeRepo();
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        GiayToTheChapRepo giayToRepo = new GiayToTheChapRepo();
        TaiSanTheChapRepo taiSanRepo = new TaiSanTheChapRepo();
        KhachHangRepo khachHangRepo = new KhachHangRepo();
        NguoiThanRepo nguoiThanRepo = new NguoiThanRepo();
        DangKiemRepo dangKiemRepo = new DangKiemRepo();
        MauSacRepo mauSacRepo= new MauSacRepo();
        HoaDonThueXeRepo hoaDonRepo = new HoaDonThueXeRepo();
        TheChapRepo theChapRepo= new TheChapRepo();
        List<Xe> lstXe;
        List<HoaDonChiTiet> lstHoaDonChitiet;
        List<BaoDuong> lstBaoDuong;
        List<XeBaoHiem> lstXeBaoHiem;
        List<HangXe> lstHangXe;
        List<LoaiXe> lstLoaiXe;
        List<GiayToTheChap> lstGiayToTheChap;
        List<TaiSanTheChap> lstTaiSan;
        List<KhachHang> lstKhachHang;
        List<NguoiThan> lstNguoiThan;
        List<DangKiem> lstDangKiem;
        public ChoThueXeService()
        {
            lstXe = xeRepo.GetXe();
            lstHoaDonChitiet = hoaDonChiTietRepo.GetALL();
            lstBaoDuong = baoDuongRepo.GetALL();
            lstXeBaoHiem = xe_BaoHiemRepo.GetAll();
            lstHangXe = hangXeRepo.GetALL();
            lstLoaiXe = loaiXeRepo.GetALL();
            lstTaiSan = taiSanRepo.GetALL();
            lstGiayToTheChap = giayToRepo.GetALL();
            lstKhachHang = khachHangRepo.GetALL();
            lstNguoiThan = nguoiThanRepo.GetALL();
            lstDangKiem= dangKiemRepo.GetALL();
        }

        public bool CreateKH(KhachHang khachHang, NguoiThan nguoiThan)
        {

            try
            {
                 bool addKH= khachHangRepo.Create(khachHang);
                bool addNT = nguoiThanRepo.Create(nguoiThan);
                lstNguoiThan.Add(nguoiThan);
                lstKhachHang.Add(khachHang);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public List<Xe> DataXe(DateTime startDate, DateTime endDate,List<HoaDonChiTiet> xeDaChon)
        {
            //var resul2 = from xe in lstXe                 
            //             join hd in lstHoaDonChitiet on xe.ID equals hd.IdXe
            //             join bd in lstBaoDuong on xe.ID equals bd.IdXe
            //             join lx in lstLoaiXe on xe.IdLoaiXe equals lx.Id
            //             join hx in lstHangXe on lx.IdHangXe equals hx.Id
            //             join dk in lstDangKiem on xe.ID equals dk.Id
            //             where xe.TrangThai!=1 ||
            //             (((startDate>hd.NgayBatDau&&startDate<hd.NgayKetThuc)||(endDate > hd.NgayBatDau && endDate < hd.NgayKetThuc))&& (hd.TrangThai==2&& hd.TrangThai==3))||
            //             bd.TrangThai==0|| dk.NgayHetHan<endDate||
            //             hx.Id!= hangXe||
            //             lx.LoaiNguyenLieu!=nhienLieu||
            //             lx.SoGhe!= soGhe||
            //             lx.LoaiNguyenLieu!= nhienLieu                        
            //             select xe;
            if (startDate.Date>endDate)
            {
                return new List<Xe>();
            }
            List<Xe> result = xeRepo.GetXe();
            // Loại xe đã chọn
            var checkDK = from xe in lstXe
                      join hd in xeDaChon on xe.ID equals hd.IdXe
                      where (((startDate >= hd.NgayBatDau && startDate <= hd.NgayKetThuc) || (endDate >= hd.NgayBatDau && endDate <= hd.NgayKetThuc)))
                      select xe;
            if (checkDK != null && result != null)
            {
                result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
            }
            //kiểm tra đăng kiểm
             checkDK = from xe in lstXe
                          join dk in lstDangKiem on xe.ID equals dk.IdXe
                          where dk.NgayHetHan < endDate 
                          select xe;

            if (checkDK != null && result != null)
            {
                result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
            }
            //kiểm tra xe có đang cho thuê hay không
            checkDK = from xe in lstXe
                          join hd in lstHoaDonChitiet on xe.ID equals hd.IdXe
                          where (((startDate >= hd.NgayBatDau && startDate <= hd.NgayKetThuc) || (endDate >= hd.NgayBatDau && endDate <= hd.NgayKetThuc)) && (hd.TrangThai == 2 || hd.TrangThai == 1)) 
                          select xe;
            if (checkDK != null && result != null)
            {
                result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
            }
            //kiểm tra xe có đang bảo dưỡng hay không
            checkDK = from xe in lstXe
                          join bd in lstBaoDuong on xe.ID equals bd.IdXe
                          where bd.TrangThai ==1
                          select xe;
            if (checkDK != null && result != null)
            {
                result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
            }
            //kiểm tra xe  hoạt động
            checkDK = from xe in lstXe
                      where xe.TrangThai != 1
                      select xe;

            if (checkDK != null && result != null)
            {
                result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
            }
           
            if (result==null)
            {
                return result; 
            }
            foreach (var item in result)
            {
                item.MauSac = mauSacRepo.GetALL().FirstOrDefault(p => p.Id == item.IdMauSac);
                item.LoaiXe = lstLoaiXe.FirstOrDefault(p => p.Id == item.IdLoaiXe);
                item.LoaiXe.HangXe = lstHangXe.FirstOrDefault(p => p.Id == item.LoaiXe.IdHangXe);
            }
            return result.ToList();
        }
        public List<HangXe> GetHangXe()
        {
            List<HangXe> hangXes = new List<HangXe>();
            hangXes.Add(new HangXe() { Id=Guid.NewGuid(),Name="Tất cả"});
            hangXes.AddRange( hangXeRepo.GetALL().Where(p => p.TrangThai == 1).ToList());
            return hangXes;
        }
        public List<KhachHang> GetKhachHang(string name)
        {
            return khachHangRepo.GetALL().Where(p=>p.Name.ToLower().Contains(name.ToLower()) || p.CCCD==name).ToList();
        }
        public KhachHang FindByCCCD(string cccd)
        {
             return khachHangRepo.GetALL().FirstOrDefault(p => p.CCCD==cccd);
        }
        public NguoiThan FindNTbyIdKH(Guid id)
        {
            return nguoiThanRepo.GetALL().FirstOrDefault(p => p.IdKhachHang == id);
        }

        public bool UpdateKH(KhachHang khachHang, NguoiThan nguoiThan)
        {
            try
            {
                khachHang.Id = lstKhachHang.FirstOrDefault(p=>p.CCCD==khachHang.CCCD).Id;
                nguoiThan.IdKhachHang = khachHang.Id;
                nguoiThan.Id = lstNguoiThan.FirstOrDefault(p=>p.IdKhachHang==khachHang.Id).Id;
                bool addKH = khachHangRepo.Update(khachHang);
                bool addNT = nguoiThanRepo.Update(nguoiThan);
                lstKhachHang = khachHangRepo.GetALL();
                lstNguoiThan = nguoiThanRepo.GetALL();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public int CreateSoHopDong()
        {
            int max=1;
            foreach (var item in hoaDonRepo.GetALL())
            {
                if (item.SoHopDong>max)
                {
                    max = item.SoHopDong;
                }
            }
            max++;
            return max;
        }

        public void CreateHD(HoaDonThueXe hd)
        {
            hoaDonRepo.Create(hd);
        }

        public void CreateHDCT(HoaDonChiTiet hdct)
        {
            hoaDonChiTietRepo.Create(hdct);
            lstHoaDonChitiet = hoaDonChiTietRepo.GetALL();
        }

        public List<GiayToTheChap> GetGiayTo()
        {
           return giayToRepo.GetALL();
        }

        public List<TaiSanTheChap> GetTaiSan()
        {
            return taiSanRepo.GetALL();
        }

        public void CreateTC(TheChap theChap)
        {
            theChapRepo.Create(theChap);
        }


    }
}
