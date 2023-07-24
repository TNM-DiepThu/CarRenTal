using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class BaoHiemRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public BaoHiemRepo()
        {
            
        }
        public List<BaoHiem> GetALL()
        {
            return db.baoHiems.ToList();
        }
        public bool Update(BaoHiem baoHiem)
        {
            try
            {
                db.baoHiems.Update(baoHiem);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(BaoHiem baoHiem)
        {
            try
            {
                db.baoHiems.Add(baoHiem);
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
