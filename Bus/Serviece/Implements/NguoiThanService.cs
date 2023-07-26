using Bus.Serviece.Interface;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class NguoiThanService:INguoiThanService
    {
        NguoiThanRepo _nguoiThanRepo;

        public NguoiThanService()
        {
            _nguoiThanRepo = new NguoiThanRepo();
        }

        public List<NguoiThan> GetAll()
        {
            return _nguoiThanRepo.GetALL();
        }

        public bool CreateNguoiThan(NguoiThan nguoiThan)
        {
            return _nguoiThanRepo.Create(nguoiThan);
        }

        public bool UpdateNguoiThan(NguoiThan nguoiThan)
        {
            return _nguoiThanRepo.Update(nguoiThan);
        }
    }
}
