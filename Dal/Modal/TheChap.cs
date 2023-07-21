using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class TheChap
    { 
        public Guid Id { get; set; }
        public string MoTa { get; set; }
        public decimal GiaTri { get; set; }
        public int TinhTrang { get; set; }
        public Guid IdHDCT { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }

        public Guid IdGiayTo { get; set; }
        public virtual GiayToTheChap GiayToTheChap { get; set; }

        public Guid IdTS { get; set; }
        public virtual TaiSanTheChap TaiSanTheChap { get; set; }

    }
}
