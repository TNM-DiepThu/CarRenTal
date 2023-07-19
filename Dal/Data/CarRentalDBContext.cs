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
        public DbSet<KhachHang> baoDuongs { get; set; }
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

        // thêm đường dẫn
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        // đổi tên server
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-04RP8E0L\SQLEXPRESS;Database=DBDA1TEST;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        // áp dụng tất cả asemmbly . 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
