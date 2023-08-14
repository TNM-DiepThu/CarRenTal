using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class DoanhThu
    {
        internal ChiPhiPhatSinh? phuphi;
    
        public Guid idHD { get; set; }
        public int maHD { get; set; }
        public string tenXe { get; set; }
        public string bienSo { get; set; }
        public DateTime ngayBD { get; set; }
        public DateTime ngayKT { get; set; }

        public decimal tienCoc { get; set; }
        public decimal donGia { get; set; }
        public decimal phuPhi { get; set; }
        public decimal tongTien { get; set; }

        public string tenNV { get; set; }


        public DoanhThu()
        {

        }
    }
        
}
