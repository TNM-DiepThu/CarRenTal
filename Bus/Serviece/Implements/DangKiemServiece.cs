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

        public List<DangKiem> GetAll()
        {
            List<DangKiem> dsDangKiem = _context.dangKiems.ToList();
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
