using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class HangXeRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();


        public List<HangXe> GetALL()
        {
            return db.hangXes.ToList();
        }
        public bool Update(HangXe hangXe)
        {
            try
            {
                db.hangXes.Update(hangXe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(HangXe hangXe)
        {
            try
            {
                db.hangXes.Add(hangXe);
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
