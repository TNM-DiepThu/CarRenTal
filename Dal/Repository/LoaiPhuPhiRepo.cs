using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class LoaiPhuPhiRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();


        public List<LoaiPhuPhi> GetALL()
        {
            return db.loaiPhuPhis.ToList();
        }
        public bool Update(LoaiPhuPhi loaiPhuPhi)
        {
            try
            {
                db.loaiPhuPhis.Update(loaiPhuPhi);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(LoaiPhuPhi loaiPhuPhi)
        {
            try
            {
                db.loaiPhuPhis.Add(loaiPhuPhi);
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
