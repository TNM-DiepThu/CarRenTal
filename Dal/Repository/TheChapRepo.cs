using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class TheChapRepo
    {

        CarRentalDBContext db = new CarRentalDBContext();
        public TheChapRepo()
        {

        }
        public List<TheChap> GetAll()
        {
            return db.theChaps.ToList();
        }
        public bool Update(TheChap theChap)
        {
            try
            {
                db.theChaps.Update(theChap);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(TheChap theChap)
        {
            try
            {
                db.theChaps.Add(theChap);
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
