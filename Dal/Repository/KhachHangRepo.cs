using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class KhachHangRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public KhachHangRepo()
        {
            
        }
        public List<KhachHang> GetALL()
        {
            return db.khachHangs.ToList();
        }
        public bool Update(KhachHang khachHang)
        {
            try
            {
                db.khachHangs.Update(khachHang);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(KhachHang khachHang)
        {
            try
            {
                db.khachHangs.Add(khachHang);
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
