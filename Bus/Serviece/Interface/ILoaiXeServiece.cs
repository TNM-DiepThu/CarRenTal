using Bus.ViewModal;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface ILoaiXeServiece
    {
        public List<LoaiXeVM> GetAll();
        public bool Creat(LoaiXe p);
        public bool Delete(Guid id);
        public bool Edit(LoaiXeVM p);
    }
}
