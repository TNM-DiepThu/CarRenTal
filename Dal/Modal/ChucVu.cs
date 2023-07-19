using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class ChucVu
    {
       
        public Guid Id { get; set; }
        public string TenChucVu { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<NhanVien> NhanVien { get; set; }
    }
}
