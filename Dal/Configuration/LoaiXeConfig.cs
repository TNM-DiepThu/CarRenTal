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
    public class LoaiXeConfig : IEntityTypeConfiguration<LoaiXe>
    {
        public void Configure(EntityTypeBuilder<LoaiXe> builder)
        {
            builder.ToTable("Loai_xe");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.LoaiNguyenLieu).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.SoGhe).HasColumnType("int").IsRequired();
            builder.Property(x => x.LoaiSoXe).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.NhienLieuTieuThu).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.HangXe).WithMany(x => x.LoaiXe).HasForeignKey(x=>x.IdHangXe);
        }
    }
}
