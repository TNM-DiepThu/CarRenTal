using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class Xe_BaoHiemRepo
    {

        CarRentalDBContext db = new CarRentalDBContext();
        public Xe_BaoHiemRepo()
        {

        }
        public List<XeBaoHiem> GetAll()
        {
            return db.xeBaoHiems.ToList();
        }
        public bool Update(XeBaoHiem xeBaoHiem)
        {
            try
            {
                db.xeBaoHiems.Update(xeBaoHiem);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(XeBaoHiem xeBaoHiem)
        {
            try
            {
                db.xeBaoHiems.Add(xeBaoHiem);
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
