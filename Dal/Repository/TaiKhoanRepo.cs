using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class TaiKhoanRepo
    {
        CarRentalDBContext db;
        public TaiKhoanRepo() 
        {
            db = new CarRentalDBContext();
        }
        //public List<TaiKhoan> GetAll()
        //{
        //    return db.taiKhoans.ToList();
        //}
    }
}
