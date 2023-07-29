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
        public DateTime NgayHHDangKiem(Guid id);
    }
}
