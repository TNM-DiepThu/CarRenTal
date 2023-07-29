using Bus.Serviece.Interface;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class XeBaoHiemServiece : IXeBaoHiemServiece
    {
        CarRentalDBContext _context;
        public XeBaoHiemServiece()
        {
            _context = new CarRentalDBContext();
        }
        public List<XeBaoHiem> GetAll()
        {
            List<XeBaoHiem> dsXeBaoHiem = _context.xeBaoHiems.ToList();
            return dsXeBaoHiem;
        }

        public DateTime NgayHHBaoHiem(Guid id)
        {
            XeBaoHiem baohiem = _context.xeBaoHiems.FirstOrDefault(h => h.IdXe == id);
            if (baohiem != null)
            {
                return baohiem.NgayKetThuc;
            }
            return DateTime.MinValue;
        }
    }
}
