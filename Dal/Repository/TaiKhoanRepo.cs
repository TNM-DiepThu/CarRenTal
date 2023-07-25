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
        public List<TaiKhoan> GetTaiKhoan()
        {
            return db.taiKhoans.ToList();
        }
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
              //  db.taiKhoans.Update(taiKhoan);
                db.taiKhoans.FirstOrDefault(x => x.username==taiKhoan.username).password=taiKhoan.password;
                db.taiKhoans.FirstOrDefault(x => x.username==taiKhoan.username).TrangThai=taiKhoan.TrangThai;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AddTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                db.taiKhoans.Add(taiKhoan);
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
