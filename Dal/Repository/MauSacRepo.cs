using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class MauSacRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public MauSacRepo()
        {
            
        }
        public List<MauSac> GetALL()
        {
            return db.mauSacs.ToList();
        }
        public bool Update(MauSac mauSac)
        {
            try
            {
                db.mauSacs.Update(mauSac);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(MauSac mauSac)
        {
            try
            {
                db.mauSacs.Add(mauSac);
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
