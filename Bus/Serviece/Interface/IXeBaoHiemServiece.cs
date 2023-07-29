using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IXeBaoHiemServiece
    {
        List<XeBaoHiem> GetAll ();
        public DateTime NgayHHBaoHiem(Guid id);
    }
}
