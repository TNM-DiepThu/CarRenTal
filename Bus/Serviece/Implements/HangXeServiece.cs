using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class HangXeServiece : IHangXeServiece
    {
        CarRentalDBContext _context;
        public HangXeServiece()
        {
            _context = new CarRentalDBContext();
        }

        public bool CreatHangXe(HangXeVM p)
        {
            try
            {
                var hangxe = new HangXe()
                {
                    Id = new Guid(),
                    Name = p.Name,
                    TrangThai = 0,
                };
                _context.Add(hangxe);
                _context.SaveChanges();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<HangXe> GetAllHangXe()
        {
            var listHX =  _context.hangXes.ToList();

            return listHX ;
        }
    }
}
