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
    public class NguoiThanConfig : IEntityTypeConfiguration<NguoiThan>
    {
        public void Configure(EntityTypeBuilder<NguoiThan> builder)
        {
            builder.ToTable("Nguoi_than");
            builder.HasKey(x => x.Id);
            builder.Property(p=> p.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.GioiTinh).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired(); 
            builder.Property(x => x.SDT).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CCCD).HasColumnType("varchar(50)").IsRequired();
            builder.HasOne(x => x.KhachHangs).WithMany(y=> y.NguoiThans).HasForeignKey(x=>x.IdKhachHang);
        }
    }
}
