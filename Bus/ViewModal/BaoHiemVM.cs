using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class BaoHiemVM
    {
        
        public Guid Id { get; set; }
        public string LoaiBaoHiem { get; set; }
        public int TrangThai { get; set; }
        public BaoHiemVM()
        {
            
        }
        public BaoHiemVM(BaoHiem baoHiem)
        {
            this.Id = baoHiem.Id;
            this.LoaiBaoHiem = baoHiem.LoaiBaoHiem;
            this.TrangThai = baoHiem.TrangThai;
        }
    }
}
