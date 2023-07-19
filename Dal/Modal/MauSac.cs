using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class MauSac
    {
       
        public Guid Id { get; set; }
        public string TenMauSac { get; set; }
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
