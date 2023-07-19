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
    public class KhachHangConfig : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("Khách hàng");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.GioiTinh).HasColumnType("Bit").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.SDT).HasColumnType("int").IsRequired();
            
        }
    }
}
