using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class XeVM
    {
        public Guid ID { get; set; }
        public string BienSo { get; set; }
        public int SoKhung { get; set; }
        public int SoMay { get; set; }
        public decimal DonGia { get; set; }
        public int SoCongTo { get; set; }
        public int TrangThai { get; set; }
        public int TrangThaiBaoHiem{ get; set;}
        public int TrangThaiDangKiem{ get; set;}
    }
}
