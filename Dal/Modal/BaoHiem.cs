using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class BaoHiem
    {
       
        public Guid Id { get; set; }
        public string LoaiBaoHiem { get; set; }
        public DateTime ThoiHan { get; set; }
        public int TrangThai { get; set; }
        public ICollection<XeBaoHiem> xeBaoHiems { get; set; }
    }
}
