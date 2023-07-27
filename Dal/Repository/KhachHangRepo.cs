using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository
{
    public class KhachHangRepo
    {
        CarRentalDBContext db = new CarRentalDBContext();

        public KhachHangRepo()
        {
            
        }
        public List<KhachHang> GetALL()
        {
            return db.khachHangs.ToList();
        }
        public bool Update(KhachHang khachHang)
        {
            try
            {
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).Name= khachHang.Name;
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).GioiTinh= khachHang.GioiTinh;
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).DiaChi= khachHang.DiaChi;
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).SDT= khachHang.SDT;
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).CCCD= khachHang.CCCD;
                db.khachHangs.FirstOrDefault(x => x.Id== khachHang.Id).NgaySinh= khachHang.NgaySinh;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create(KhachHang khachHang)
        {
            try
            {
                db.khachHangs.Add(khachHang);
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
