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
    public class LoaiXeServiece : ILoaiXeServiece
    {
        string tenhangxe;
        CarRentalDBContext _context;
        
        public LoaiXeServiece()
        {
            _context = new CarRentalDBContext();
        }

        public bool Creat(LoaiXe p)
        {
            try
            {
                var existingHangXe = _context.loaiXes.FirstOrDefault(h => h.Name == p.Name);

                if (existingHangXe != null)
                {
                    return true;
                }
                else
                {                   
                    var loaixe = new LoaiXe()
                    {
                        Id = Guid.NewGuid(),
                        Name = p.Name,
                        LoaiNguyenLieu = p.LoaiNguyenLieu,
                        SoGhe = p.SoGhe,
                        LoaiSoXe = p.LoaiSoXe,
                        NhienLieuTieuThu = p.NhienLieuTieuThu,
                        TrangThai = p.TrangThai,
                    };
                    HangXe hangXe = _context.hangXes.FirstOrDefault(h => h.Name == tenhangxe);
                    if (hangXe != null)
                    {
                        loaixe.Id = hangXe.Id;                       
                    }
                    _context.Add(loaixe);
                    _context.SaveChanges();
                    return false;
                }


            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid id)
        {
            var del = _context.loaiXes.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                _context.loaiXes.Remove(del);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Edit(LoaiXeVM p)
        {
            if (p == null) return false;

            var x = _context.loaiXes.FirstOrDefault(c => c.Id == p.Id);
            if (x == null) return false;

            x.Name = p.Name;
            x.LoaiNguyenLieu = p.LoaiNguyenLieu;
            x.SoGhe = p.SoGhe;
            x.LoaiSoXe = p.LoaiSoXe;
            x.NhienLieuTieuThu = p.NhienLieuTieuThu;
            x.TrangThai = p.TrangThai;

            try
            {
                _context.Update(x);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi trong quá trình cập nhật dữ liệu: " + ex.Message);
                return false;
            }
        }

        public List<LoaiXeVM> GetAll()
        {
            List<LoaiXe> danhSachLoaiXe = _context.loaiXes.ToList();

            // Chuyển đổi danh sách các loại xe sang danh sách các LoaiXeVM
            List<LoaiXeVM> danhSachLoaiXeVM = danhSachLoaiXe.Select(loaiXe => new LoaiXeVM(loaiXe)).ToList();

            return danhSachLoaiXeVM;
        }
    }
}
