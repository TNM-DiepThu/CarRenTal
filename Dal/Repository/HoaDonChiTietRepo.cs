using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class HoaDonChiTietRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public HoaDonChiTietRepo()
        {
            
        }
        public List<HoaDonChiTiet> GetALL()
        {
            return db.hoaDonChiTiets.ToList();
        }
        public bool Update(HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {
                db.hoaDonChiTiets.Update(hoaDonChiTiet);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(HoaDonChiTiet hoaDonChiTiet)
        {
            try
            {
                db.hoaDonChiTiets.Add(hoaDonChiTiet);
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
