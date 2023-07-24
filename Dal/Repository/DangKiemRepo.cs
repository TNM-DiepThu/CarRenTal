using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class DangKiemRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public DangKiemRepo()
        {
            
        }
        public List<DangKiem> GetALL()
        {
            return db.dangKiems.ToList();
        }
        public bool Update(DangKiem dangKiem)
        {
            try
            {
                db.dangKiems.Update(dangKiem);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(DangKiem dangKiem)
        {
            try
            {
                db.dangKiems.Add(dangKiem);
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
