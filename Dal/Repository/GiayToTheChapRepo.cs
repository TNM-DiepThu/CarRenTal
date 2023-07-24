using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class GiayToTheChapRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public GiayToTheChapRepo()
        {
            
        }
        public List<GiayToTheChap> GetALL()
        {
            return db.giayToThes.ToList();
        }
        public bool Update(GiayToTheChap giayToTheChap)
        {
            try
            {
                db.giayToThes.Update(giayToTheChap);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(GiayToTheChap giayToTheChap)
        {
            try
            {
                db.giayToThes.Add(giayToTheChap);
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
