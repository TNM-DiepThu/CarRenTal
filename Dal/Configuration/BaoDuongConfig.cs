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
    public class BaoDuongConfig : IEntityTypeConfiguration<BaoDuong>
    {
        public void Configure(EntityTypeBuilder<BaoDuong> builder)
        {
            //đặt tên bảng
            builder.ToTable("Bao_Duong");
            // set khoá chính
            builder.HasKey(p => p.Id);
            //set thuộc tính
            builder.Property(p => p.NgayDangKiem).HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.NgayHetHan).HasColumnType("DateTime").IsRequired();
            builder.Property(p => p.ChiPhi).HasColumnType("Decimal").IsRequired();
            builder.Property(x => x.SoCongToBaoDuong).HasColumnType("int").IsRequired();
            builder.HasOne(x=>x.Xe).WithMany(y=>y.baoDuongs).HasForeignKey(x=>x.IdXe);

        }
    }
}
