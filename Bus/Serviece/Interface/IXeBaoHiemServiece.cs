using Bus.ViewModal;
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
        List<XeBaoHiemVM> GetAll (Guid id);
        public DateTime NgayHHBaoHiem(Guid id);
        public bool Add(XeBaoHiemVM p, Guid id);
        public bool Edit(XeBaoHiemVM p, Guid Id);
    }
}
