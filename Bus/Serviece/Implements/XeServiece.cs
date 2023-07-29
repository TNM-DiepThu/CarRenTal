using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class XeServiece : IXeServiece
    {
        CarRentalDBContext _context;
        string namelx;
        string namems;
        public XeServiece()
        {
            _context = new CarRentalDBContext();
        }

        public bool Add(XeVM v,DangKiem dk)
        {
            try
            {                              
                var xe = new Xe()
                 {
                        ID = Guid.NewGuid(),
                        BienSo = v.BienSo,
                        SoKhung = v.SoKhung,
                        SoMay = v.SoMay,
                        SoCongTo = v.SoCongTo,
                        DonGia = v.DonGia,                       
                    };
                LoaiXe lx = _context.loaiXes.FirstOrDefault(h => h.Name == v.TenXe);
                if (lx != null)
                {
                    xe.IdLoaiXe = lx.Id;
                }

                MauSac ms = _context.mauSacs.FirstOrDefault(h => h.TenMauSac == v.MauSac);
                if (ms != null)
                {
                    xe.IdMauSac = ms.Id;
                }

                dk = new DangKiem()
                {
                    Id = Guid.NewGuid(),
                    NgayDangKiem = dk.NgayDangKiem,
                    NgayHetHan = dk.NgayHetHan,
                    ChiPhi = dk.ChiPhi,
                    IdXe = xe.ID,
                };


                _context.Add(xe);
                _context.Add(dk);
                _context.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<XeVM> GetAll()
        {
            List<Xe> dsXe = _context.xes.ToList();
            List<XeVM> dsXeVM = dsXe.Select(x => new XeVM(x)).ToList();
            return dsXeVM;
        }

        public int GetLoaiXe(Guid Id)
        {
            LoaiXe loaixe = _context.loaiXes.FirstOrDefault(h => h.Id == Id);

            if (loaixe != null)
            {
                return loaixe.SoGhe;
            }

            return int.MinValue;
        }

        public string GetMauSacName(Guid Id)
        {
            MauSac mausac = _context.mauSacs.FirstOrDefault(h => h.Id == Id);

            if (mausac != null)
            {
                return mausac.TenMauSac;
            }

            return string.Empty;
        }

        public string GetTenHangXe(Guid Id)
        {
            LoaiXe loaixe = _context.loaiXes.FirstOrDefault(h => h.Id == Id);    
            HangXe hangXe = _context.hangXes.FirstOrDefault(x=>x.Id == loaixe.IdHangXe);
            
            if (hangXe != null)
            {
                return hangXe.Name;
            }
            return string.Empty;

        }

        public string GetTenLoaiXe(Guid Id)
        {
            LoaiXe loaixe = _context.loaiXes.FirstOrDefault(h => h.Id == Id);
            if (loaixe != null)
            {
                return loaixe.Name;
            }

            // Nếu không tìm thấy, trả về một giá trị mặc định hoặc chuỗi rỗng
            return string.Empty;
        }
    }
}
