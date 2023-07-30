using Bus.Serviece.Interface;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class DangKiemServiece : IDangKiemServiece
    {
        CarRentalDBContext _context;       
        public DangKiemServiece()
        {
            
            _context = new CarRentalDBContext();
           
        }

        public bool Add(DangKiem p)
        {
            try
            {
                DangKiem dk = new DangKiem()
                {
                    Id = Guid.NewGuid(),
                    NgayDangKiem = p.NgayDangKiem,
                    NgayHetHan = p.NgayHetHan,
                    ChiPhi = p.ChiPhi,
                    
                   
            };

                _context.Add(dk);
                _context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public bool Edit(DangKiem p, Guid id)
        {
            try
            {
                var bd = _context.dangKiems.FirstOrDefault(x => x.Id == p.Id);
                if (bd != null)
                {
                    bd.NgayDangKiem = p.NgayDangKiem;
                    bd.NgayHetHan = p.NgayHetHan;
                    bd.ChiPhi = p.ChiPhi;
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

        public List<DangKiem> GetAll()
        {
            List<DangKiem> dsDangKiem = _context.dangKiems.ToList();
            return dsDangKiem;
        }

        public List<DangKiem> GetAllDK(Guid id)
        {
            List<DangKiem> dsDangKiem = _context.dangKiems.Where(x => x.IdXe == id).ToList();
            return dsDangKiem;
        }

        public DateTime NgayHHDangKiem(Guid id)
        {
            DangKiem baohiem = _context.dangKiems.FirstOrDefault(h => h.IdXe == id);          
            if (baohiem != null)
            {
                return baohiem.NgayHetHan;
            }          
            return DateTime.MinValue;
        }
    }
}
