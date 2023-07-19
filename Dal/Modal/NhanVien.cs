using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class NhanVien
    {
       
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        public DateTime NgaySinh { get; set; }      
        public int TrangThai { get; set; }
        public Guid IdChucVu { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<HoaDonThueXe> HoaDonThueXes { get; set; }
    }
}
