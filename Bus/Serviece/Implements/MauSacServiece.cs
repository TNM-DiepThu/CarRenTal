using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class MauSacServiece : IMauSacServiece
    {

        CarRentalDBContext _context;
        public MauSacServiece()
        {
            _context = new CarRentalDBContext();
        }

        public string Creat(MauSacVM vm)
        {
            try
            {
                var existingMauSac = _context.mauSacs.FirstOrDefault(h => h.TenMauSac == vm.TenMauSac);

                if (existingMauSac != null)
                {
                    return "Tên màu đã tồn tại";
                }
                else
                {
                    var mausac = new MauSac()
                    {
                        Id = Guid.NewGuid(),
                        TenMauSac = vm.TenMauSac,
                        
                    };

                    _context.Add(mausac);
                    _context.SaveChanges();
                    return "Thành công";
                }
            }
            catch (Exception)
            {

                return "không thành công";
            }
        }

        public bool Delete(Guid id)
        {
            var del = _context.mauSacs.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                _context.mauSacs.Remove(del);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public string Edit(MauSacVM p)
        {
            if (p == null) return "Không thành công";

            var mausac = _context.mauSacs.FirstOrDefault(c => c.Id == p.Id);
            if (mausac == null) return "Không thành công";

            mausac.TenMauSac = p.TenMauSac;           

            try
            {
                _context.Update(mausac);
                _context.SaveChanges();
                return "Thành công";
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Lỗi trong quá trình cập nhật dữ liệu: " + ex.Message);
                return "Không thành công";
            }
        }

        public List<MauSacVM> GetAll()
        {
            List<MauSac> mauSacs = _context.mauSacs.ToList();           
            List<MauSacVM> lstMauSac = mauSacs.Select(x => new MauSacVM(x)).ToList();
            return lstMauSac;
        }
    }
}
