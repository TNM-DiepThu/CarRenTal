using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class MauSacVM
    {
        public Guid Id { get; set; }
        public string TenMauSac { get; set; }

        public MauSacVM()
        {
            
        }
        public MauSacVM(MauSac mauSac)
        {
            this.Id = mauSac.Id;
            this.TenMauSac = mauSac.TenMauSac;
        }

    }
}
