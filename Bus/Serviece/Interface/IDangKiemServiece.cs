using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IDangKiemServiece
    {
        public List<DangKiem> GetAll();
        public List<DangKiem> GetAllDK(Guid id);
        public DateTime NgayHHDangKiem(Guid id);

        public bool Add(DangKiem p);

        public bool Edit(DangKiem p,Guid id);
    }
}
