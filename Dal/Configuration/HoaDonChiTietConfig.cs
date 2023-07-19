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
    public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("Hoá đơn chi tiết");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NgayBatDau).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.NgayKetThuc).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.TongTien).HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.DonGia).HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.SoLuong).HasColumnType("Int").IsRequired();
            builder.Property(x => x.PhuPhi).HasColumnType("DECIMAL").IsRequired();
            builder.HasOne(x => x.HoaDonThueXe).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x=>x.IdHoaDon);
            builder.HasOne(x => x.Xe).WithMany(x => x.HoaDonChiTiets).HasForeignKey(x=>x.IdXe);




        }
    }
}
