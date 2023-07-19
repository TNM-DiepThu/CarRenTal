using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class XeBaoHiem
    {
        
        public Guid Id { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal ChiPhi { get; set; }
        public int TrangThai { get; set; }
        public Guid IdXe { get ; set; }
        public virtual Xe Xe { get; set; }
        public Guid IdHangBaoHiem { get; set; }
        public virtual BaoHiem BaoHiem { get; set; }
    }
}
