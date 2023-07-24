using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class NguoiThanRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public NguoiThanRepo()
        {
            
        }
        public List<NguoiThan> GetALL()
        {
            return db.nguoiThans.ToList();
        }
        public bool Update(NguoiThan nguoiThan)
        {
            try
            {
                db.nguoiThans.Update(nguoiThan);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(NguoiThan nguoiThan)
        {
            try
            {
                db.nguoiThans.Add(nguoiThan);
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
