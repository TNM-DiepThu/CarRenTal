using Bus.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Interface
{
    public interface IMauSacServiece
    {
        public List<MauSacVM> GetAll();
        public string Creat(MauSacVM vm);
        public string Edit(MauSacVM p);
        public bool Delete(Guid id);
    }
}
