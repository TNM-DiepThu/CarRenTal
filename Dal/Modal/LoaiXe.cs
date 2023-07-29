using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class LoaiXe
    {
       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LoaiNguyenLieu { get; set; }
        public int SoGhe { get; set; }
        public string LoaiSoXe { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<Xe> Xe { get; set; }
        public Guid IdHangXe { get; set; }
        public virtual HangXe HangXe { get; set; }

    }
}
