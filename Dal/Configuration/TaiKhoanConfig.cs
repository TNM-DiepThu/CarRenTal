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
    internal class TaiKhoanConfig : IEntityTypeConfiguration<TaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.ToTable("Tai_khoan");
            builder.HasKey(p => p.username);
            builder.Property(p => p.password);
            builder.HasOne(t => t.NhanVien).WithOne(nv => nv.TaiKhoan).HasForeignKey<TaiKhoan>(t => t.IdNhanVien).IsRequired();


        }
    }
}
