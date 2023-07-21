using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class ChiPhiPhatSinh
    {
        public Guid Id { get; set; }
        public decimal GiaTien { get; set; }
        public string MoTa { get; set; }
        public Guid IdHDCT { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }

        public Guid IdLPP { get; set; }
        public virtual LoaiPhuPhi LoaiPhuPhi { get; set; }
    }
}
