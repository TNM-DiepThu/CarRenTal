using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Configuration
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("Nhan_vien");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.HoTen).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.GioiTinh).HasColumnType("Bit").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.SDT).HasColumnType("int").IsRequired();
            builder.Property(x=>x.NgaySinh).HasColumnType("DateTime").IsRequired();
            builder.Property(x=>x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.ChucVu).WithMany(y => y.NhanVien).HasForeignKey(c => c.IdChucVu);
            
        }
    }
}
