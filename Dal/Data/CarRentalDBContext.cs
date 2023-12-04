using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Data
{
    public class CarRentalDBContext:DbContext
    {
        public CarRentalDBContext()
        {
            
        }
        public DbSet<BaoDuong> baoDuongs { get; set; }
        public DbSet<BaoHiem> baoHiems { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<DangKiem> dangKiems { get; set; }
        public DbSet<HangXe> hangXes { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<HoaDonThueXe> hoaDonThueXes { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<LoaiXe> loaiXes { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<NguoiThan> nguoiThans { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<TaiKhoan> taiKhoans { get; set; }
        public DbSet<Xe> xes { get; set; }
        public DbSet<XeBaoHiem> xeBaoHiems { get; set; }
        public DbSet<ChiPhiPhatSinh> chiPhiPhatSinhs { get; set; }
        public DbSet<LoaiPhuPhi> loaiPhuPhis { get; set; }
        public DbSet<TheChap> theChaps { get; set; }
        public DbSet<TaiSanTheChap> taiSanThes { get; set; }
        public DbSet<GiayToTheChap> giayToThes { get; set; }

        // thêm đường dẫn
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        // đổi tên server
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-TD4QPLI2\SQLEXPRESS;Database=DBDA1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        // áp dụng tất cả asemmbly . 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
