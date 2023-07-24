using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class XeRepo
    {
        CarRentalDBContext db= new CarRentalDBContext();
        public XeRepo()
        {
            
        }
        public List<Xe> GetXe() 
        { 
            return db.xes.ToList();
        }
        public bool UpdateXe(Xe xe)
        {
            try
            {
                db.xes.Update(xe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CreateXe(Xe xe)
        {
            try
            {
                db.xes.Add(xe);
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
