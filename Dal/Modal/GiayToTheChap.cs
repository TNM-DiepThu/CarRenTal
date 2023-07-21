using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class GiayToTheChap
    {
        public Guid Id { get; set; }
        public string LoaiGiayTo { get; set; }
         
        public ICollection<TheChap> TheChap { get; set; }
    }
}
