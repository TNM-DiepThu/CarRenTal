using Bus.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IBaoHiemServiece
    {
        public List<BaoHiemVM> GetAll();
        public bool Add(BaoHiemVM vm);      
        public bool Delete(Guid id);
        public bool Edit(BaoHiemVM vm);
        public string GetTenBaoHiem(Guid id);
        public Guid GetIdBaoHiemByLoaiBaoHiem(string loaiBaoHiem);
        public bool update(int trangthai);
        
    }
}
