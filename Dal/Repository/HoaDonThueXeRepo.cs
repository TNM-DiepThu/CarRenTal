using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class HoaDonThueXeRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public HoaDonThueXeRepo()
        {
            
        }
        public List<HoaDonThueXe> GetALL()
        {
            return db.hoaDonThueXes.ToList();
        }
        public bool Update(HoaDonThueXe hoaDonChoThueXe)
        {
            try
            {
                db.hoaDonThueXes.FirstOrDefault(p=>p.Id==hoaDonChoThueXe.Id).TrangThai=hoaDonChoThueXe.TrangThai;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(HoaDonThueXe hoaDonChoThueXe)
        {
            try
            {
                db.hoaDonThueXes.Add(hoaDonChoThueXe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
