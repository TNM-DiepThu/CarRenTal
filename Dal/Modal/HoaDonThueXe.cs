using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class HoaDonThueXe
    {
        
        public Guid Id { get; set; }
        public DateTime NgayTao { get; set; }
        public int SoHopDong { get; set; }
        public Guid IdKhachHang { get; set; }
        public virtual KhachHang KhachHang { get; set;}
        public Guid IdNhanVien {get; set;}
        public virtual NhanVien NhanVien { get; set;}
        public virtual ICollection<HoaDonChiTiet>  HoaDonChiTiets { get; set; }
    }
}
