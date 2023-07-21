using Bus.ViewModal;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IHangXeServiece
    {
        public List<HangXe> GetAllHangXe();
        public bool CreatHangXe(HangXeVM p);
    }
}
