using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class TaiSanTheChap
    {
        public Guid Id { get; set; }
        public string LoaiTaiSan { get; set; }
        public ICollection<TheChap> TheChap { get; set; }
    }
}
