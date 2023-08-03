using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class ChiPhiPhatSinhRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public ChiPhiPhatSinhRepo()
        {
            
        }
        public List<ChiPhiPhatSinh> GetALL()
        {
            return db.chiPhiPhatSinhs.ToList();
        }
        public bool Update(ChiPhiPhatSinh chiPhiPhatSinh)
        {
            try
            {
                db.chiPhiPhatSinhs.Update(chiPhiPhatSinh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(ChiPhiPhatSinh chiPhiPhatSinh)
        {
            try
            {
                db.chiPhiPhatSinhs.Add(chiPhiPhatSinh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveAll(ChiPhiPhatSinh chiPhiPhatSinh)
        {
            try
            {
                db.chiPhiPhatSinhs.RemoveRange(db.chiPhiPhatSinhs.Where(p=>p.IdHDCT==chiPhiPhatSinh.IdHDCT));
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
