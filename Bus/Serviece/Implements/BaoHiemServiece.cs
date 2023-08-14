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
            baohiem.TrangThai = vm.TrangThai;

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

        public Guid GetIdBaoHiemByLoaiBaoHiem(string loaiBaoHiem)
        {

            BaoHiem baoHiem = _context.baoHiems.FirstOrDefault(bh => bh.LoaiBaoHiem == loaiBaoHiem);

            if (baoHiem != null)
            {
                return baoHiem.Id;
            }

            return Guid.Empty;
        }

        public string GetTenBaoHiem(Guid id)
        {
            BaoHiem x = _context.baoHiems.FirstOrDefault(h => h.Id == id);

            // Kiểm tra xem có tìm thấy hãng xe có Id là idHangXe không
            if (x != null)
            {
                return x.LoaiBaoHiem;
            }

            // Nếu không tìm thấy, trả về một giá trị mặc định hoặc chuỗi rỗng
            return string.Empty;
        }
        public bool update(int trangthai)
        {
            try
            {
                var all = _context.xeBaoHiems.ToList();
                foreach (var bd in all)
                {
                    if (bd.NgayKetThuc < DateTime.Now)
                    {
                        bd.TrangThai = 0;
                    }
                    else { bd.TrangThai = 1; }
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
