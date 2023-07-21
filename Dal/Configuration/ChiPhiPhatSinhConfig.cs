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
    public class ChiPhiPhatSinhConfig : IEntityTypeConfiguration<ChiPhiPhatSinh>
    {
        public void Configure(EntityTypeBuilder<ChiPhiPhatSinh> builder)
        {
            builder.ToTable("Chi Phi Phat Sinh");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.GiaTien).HasColumnType("DECIMAL").IsRequired();
            builder.Property(x=>x.MoTa).HasColumnType("nvarchar(100)").IsRequired();
            builder.HasOne(x => x.LoaiPhuPhi).WithMany(x=>x.chiPhiPhatSinhs).HasForeignKey(x=>x.IdLPP);
            builder.HasOne(x => x.HoaDonChiTiet).WithMany(x=>x.chiPhiPhatSinhs).HasForeignKey(x=>x.IdHDCT);
        }
    }
}
