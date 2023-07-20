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
    internal class XeBaoHiemConfig : IEntityTypeConfiguration<XeBaoHiem>
    {
        public void Configure(EntityTypeBuilder<XeBaoHiem> builder)
        {
            builder.ToTable("Xe_bao_hiem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NgayBatDau).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.NgayKetThuc).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.ChiPhi).HasColumnType("DECIMAL").IsRequired();
            builder.Property(x=>x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.BaoHiem).WithMany(x=>x.xeBaoHiems).HasForeignKey(x=>x.IdHangBaoHiem);
            builder.HasOne(x => x.Xe).WithMany(x=>x.xeBaoHiems).HasForeignKey(x=>x.IdXe);

        }
    }
}
