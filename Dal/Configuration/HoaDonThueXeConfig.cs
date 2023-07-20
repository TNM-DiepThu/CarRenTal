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
    public class HoaDonThueXeConfig : IEntityTypeConfiguration<HoaDonThueXe>
    {
        public void Configure(EntityTypeBuilder<HoaDonThueXe> builder)
        {
            builder.ToTable("Hoa_don_thue_xe");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NgayTao).HasColumnType("DateTime").IsRequired();
            builder.Property(x=>x.SoHopDong).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.NhanVien).WithMany(y => y.HoaDonThueXes).HasForeignKey(c => c.IdNhanVien);
            builder.HasOne(x => x.KhachHang).WithMany(y => y.HoaDonThueXe).HasForeignKey(c => c.IdKhachHang);

        }
    }
}
