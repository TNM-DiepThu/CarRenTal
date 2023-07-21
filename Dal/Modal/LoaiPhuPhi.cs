using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class LoaiPhuPhi
    {
        public Guid Id { get; set; }
        public string TenLoaiPhuPhi { get; set; }
        public ICollection<ChiPhiPhatSinh> chiPhiPhatSinhs { get; set; }
    }
}
