using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class NhanVienRepo
    {
        CarRentalDBContext db;
        public NhanVienRepo()
        {
            db = new CarRentalDBContext();
        }
        public List<NhanVien> GetNhanVien()
        {
            return db.nhanViens.ToList();
        }
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
           //     db.nhanViens.Update(nhanVien);
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).HoTen=nhanVien.HoTen;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).GioiTinh=nhanVien.GioiTinh;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).DiaChi=nhanVien.DiaChi;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).SDT=nhanVien.SDT;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).NgaySinh=nhanVien.NgaySinh;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).Email=nhanVien.Email;
                db.nhanViens.FirstOrDefault(p=>p.Id == nhanVien.Id).TrangThai=nhanVien.TrangThai;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            try
            {
                db.nhanViens.Add(nhanVien);
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
