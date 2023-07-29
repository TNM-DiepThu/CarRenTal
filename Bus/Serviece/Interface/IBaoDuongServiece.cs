using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IBaoDuongServiece
    {
        List<BaoDuong> GetAll(Guid id);
        public bool Add(BaoDuong p,Guid id);
        public bool Edit(BaoDuong p,Guid id);
        public bool update(int trangthai);
    }
}
