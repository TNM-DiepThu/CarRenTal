using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class TaiKhoan
    {
        
        public string username { get; set; }       
        public string password { get; set; }

        public int TrangThai { get; set; }
        public Guid IdNhanVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
