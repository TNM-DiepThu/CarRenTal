using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    public class TaiKhoanService
    {
        TaiKhoanRepo taiKhoanRepo=new TaiKhoanRepo();
        ChucVuRepo chucVuRepo = new ChucVuRepo();
        NhanVienRepo nhanVienRepo= new NhanVienRepo();
        List<NhanVien> _lstNhanVien;
        List<ChucVu> _lstChucVu;
        List<TaiKhoan> _lstTaiKhoan;
        
        public TaiKhoanService()
        {
            _lstChucVu= chucVuRepo.GetChucVu();
            _lstNhanVien=nhanVienRepo.GetNhanVien();
            _lstTaiKhoan = taiKhoanRepo.GetTaiKhoan();
        }

        public List<NhanVien> GetDataGrid(string name)
        {
            try
            {
                var result = from n in _lstNhanVien
                             join t in _lstTaiKhoan on n.Id equals t.IdNhanVien
                             join c in _lstChucVu on n.IdChucVu equals c.Id
                             where c.TenChucVu == "Nhân viên" && n.HoTen.Contains(name) && n.TrangThai == 1
                             select n;
                return result.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<ChucVu> GetAll()
        {
            return _lstChucVu;
        }
        public TaiKhoan FindTaiKhoan(Guid id)
        {
            return _lstTaiKhoan.FirstOrDefault(p => p.IdNhanVien == id);
        }
    }
}
