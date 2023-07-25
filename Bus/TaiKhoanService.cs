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
       public  List<TaiKhoan> _lstTaiKhoan;
        
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
        public bool CreateNhanVien(NhanVien nhanVien)
        {
            nhanVien.IdChucVu = _lstChucVu.FirstOrDefault(p => p.TenChucVu == "Nhân viên").Id;
            return nhanVienRepo.AddNhanVien(nhanVien);
        } 
        public bool CreateTaiKhoan(TaiKhoan taiKhoan)
        {
            _lstTaiKhoan.Add(taiKhoan);
            return taiKhoanRepo.AddTaiKhoan(taiKhoan);
        }
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            _lstTaiKhoan.Single(x => x.username == taiKhoan.username).username= taiKhoan.username;
            _lstTaiKhoan.Single(x => x.username == taiKhoan.username).password= taiKhoan.password;
            return taiKhoanRepo.UpdateTaiKhoan(taiKhoan);
        }
        public bool UpdateNhanVien(NhanVien nhanVien)
        {
      
               
            nhanVien.IdChucVu = _lstChucVu.FirstOrDefault(p => p.TenChucVu == "Nhân viên").Id;
            return nhanVienRepo.UpdateNhanVien(nhanVien);
        }
        public bool DeleteTaiKhoan(TaiKhoan taiKhoan)
        {
            taiKhoan = _lstTaiKhoan.FirstOrDefault(p => p.username == taiKhoan.username);
            taiKhoan.TrangThai = 0;
            return taiKhoanRepo.UpdateTaiKhoan(taiKhoan);
        }
        public bool DeleteNhanVien(NhanVien nhanVien)
        {
            nhanVien = _lstNhanVien.FirstOrDefault(p => p.Id == nhanVien.Id);
            nhanVien.TrangThai = 0;
            return nhanVienRepo.UpdateNhanVien(nhanVien);
        }

        public bool CheckUser(string user)
        {
           return _lstTaiKhoan.Any(p=>p.username==user);
        }
    }
}
