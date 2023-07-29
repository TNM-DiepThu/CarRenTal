using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class TaiSanTheChapRepo
    {
        CarRentalDBContext db= new CarRentalDBContext();
        public TaiSanTheChapRepo()
        {
            
        }
        public List<TaiSanTheChap> GetALL()
        {
            return db.taiSanThes.ToList();
        }
        public bool Update(TaiSanTheChap taiSanTheChap)
        {
            try
            {
                db.taiSanThes.Update(taiSanTheChap);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(TaiSanTheChap taiSanTheChap)
        {
            try
            {
                db.taiSanThes.Add(taiSanTheChap);
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
