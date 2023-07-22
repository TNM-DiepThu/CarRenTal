using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class ChucVuRepo
    {
        CarRentalDBContext db;
        public ChucVuRepo()
        {
            db = new CarRentalDBContext();
        }

        public List<ChucVu> GetChucVu()
        {
            return db.chucVus.ToList();
        }
    }
}
