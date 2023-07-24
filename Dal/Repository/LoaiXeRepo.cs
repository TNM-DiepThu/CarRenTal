using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class LoaiXeRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public LoaiXeRepo()
        {
            
        }
        public List<LoaiXe> GetALL()
        {
            return db.loaiXes.ToList();
        }
        public bool Update(LoaiXe loaiXe)
        {
            try
            {
                db.loaiXes.Update(loaiXe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(LoaiXe loaiXe)
        {
            try
            {
                db.loaiXes.Add(loaiXe);
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
