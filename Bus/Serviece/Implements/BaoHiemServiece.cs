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
    public class BaoHiemServiece : IBaoHiemServiece
    {
        CarRentalDBContext _context;
        public BaoHiemServiece()
        {
            _context = new CarRentalDBContext();
        }
        public bool Add(BaoHiemVM vm)
        {
            try
            {
               
               
                
                    var baohiem = new BaoHiem()
                    {
                        Id = Guid.NewGuid(),
                        LoaiBaoHiem = vm.LoaiBaoHiem,
                        TrangThai =vm.TrangThai,
                    };

                    _context.Add(baohiem);
                    _context.SaveChanges();
                    return true;
               
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid id)
        {
            var del = _context.baoHiems.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                _context.baoHiems.Remove(del);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Edit(BaoHiemVM vm)
        {
            if (vm == null) return false;

            var baohiem = _context.baoHiems.FirstOrDefault(c => c.Id == vm.Id);
            if (baohiem == null) return false;

            baohiem.LoaiBaoHiem = vm.LoaiBaoHiem;

            try
            {
                _context.Update(baohiem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
               
                return false;
            }
        }

        public List<BaoHiemVM> GetAll()
        {
            List<BaoHiem> lstbaohiem = _context.baoHiems.ToList();
            List<BaoHiemVM> lstbaoHiemVMs = lstbaohiem.Select(x => new BaoHiemVM(x)).ToList();
            return lstbaoHiemVMs;
        }
    }
}
