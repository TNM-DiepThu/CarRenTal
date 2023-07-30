using Bus.ViewModal;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IXeServiece
    {
        List<XeVM> GetAll();
        public string GetMauSacName(Guid Id);
        public int GetLoaiXe(Guid Id);
        public string GetTenLoaiXe(Guid Id);
        public string GetTenHangXe(Guid Id);
        public bool Add(XeVM v,DangKiem dk);
        public bool UpdateM(XeVM v);

    }
}
