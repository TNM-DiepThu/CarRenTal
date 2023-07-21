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
    public class TheChapConfig : IEntityTypeConfiguration<TheChap>
    {
        public void Configure(EntityTypeBuilder<TheChap> builder)
        {
            builder.ToTable("The Chap");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.MoTa).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.GiaTri).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x=>x.TinhTrang).HasColumnType("nvarchar(100)").IsRequired();
            builder.HasOne(x => x.HoaDonChiTiet).WithMany(x=>x.theChaps).HasForeignKey(x=>x.IdHDCT);
            builder.HasOne(x => x.GiayToTheChap).WithMany(x=>x.TheChap).HasForeignKey(x=>x.IdGiayTo);
            builder.HasOne(x => x.TaiSanTheChap).WithMany(x=>x.TheChap).HasForeignKey(x=>x.IdTS);
        }
    }
}
