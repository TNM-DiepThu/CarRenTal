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
        public string CreatHangXe(HangXeVM p);
        public bool DeleteHangXe(Guid id);
        public string UpdateHangXe(HangXe p);
        public bool GetHangXeById(Guid id);
        public bool GetHangXeByName(string name);
        public string GetTenHangXe(Guid id);

    }
}
