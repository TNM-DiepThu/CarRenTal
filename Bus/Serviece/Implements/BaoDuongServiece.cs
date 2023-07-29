using Bus.Serviece.Interface;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class BaoDuongServiece : IBaoDuongServiece
    {
        CarRentalDBContext _context;
        public BaoDuongServiece()
        {
            _context = new CarRentalDBContext();
        }

        public bool Add(BaoDuong p,Guid id)
        {
            try { 
            BaoDuong bd = new BaoDuong();
            {
                bd.Id = p.Id;
                bd.NgayDangKiem = p.NgayDangKiem;
                bd.NgayHetHan = p.NgayHetHan;
                bd.ChiPhi = p.ChiPhi;
                bd.SoCongToBaoDuong = p.SoCongToBaoDuong;
                bd.ChiTiet = p.ChiTiet;
                bd.TrangThai = (p.NgayHetHan < DateTime.Now) ? 1 : 0;
                bd.IdXe = id;

            }
            _context.Add(bd);
            _context.SaveChanges();
            return true;
            }   
            catch (Exception ex) { return  false; }
        }

        public bool Edit(BaoDuong p,Guid Id)
        {
            try
            {
                var bd = _context.baoDuongs.FirstOrDefault(x => x.Id == p.Id);
                if (bd != null)
                {
                    bd.NgayDangKiem = p.NgayDangKiem;
                    bd.NgayHetHan = p.NgayHetHan;
                    bd.ChiPhi = p.ChiPhi;
                    bd.SoCongToBaoDuong = p.SoCongToBaoDuong;
                    bd.ChiTiet = p.ChiTiet;
                    bd.TrangThai = (p.NgayHetHan < DateTime.Now) ? 1 : 0;
                    _context.Update(bd);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<BaoDuong> GetAll(Guid id)
        {
            var baoduonglst = _context.baoDuongs.Where(x => x.IdXe == id).ToList();
            return baoduonglst;
        }

        public bool update(int trangthai)
        {
            try
            {
                var all = _context.baoDuongs.ToList();
                foreach (var bd in all)
                {
                    if(bd.NgayHetHan < DateTime.Now)
                    {
                        bd.TrangThai = 1;
                    }
                    else { bd.TrangThai = 0; }
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
