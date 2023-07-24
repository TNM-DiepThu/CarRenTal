using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class BaoDuongRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public BaoDuongRepo()
        {

        }
        public List<BaoDuong> GetALL()
        {
            return db.baoDuongs.ToList();
        }
        public bool Update(BaoDuong baoDuong)
        {
            try
            {
                db.baoDuongs.Update(baoDuong);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(BaoDuong baoDuong)
        {
            try
            {
                db.baoDuongs.Add(baoDuong);
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
