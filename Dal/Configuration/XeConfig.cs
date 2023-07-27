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
    internal class XeConfig : IEntityTypeConfiguration<Xe>
    {
        public void Configure(EntityTypeBuilder<Xe> builder)
        {
            builder.ToTable("Xe");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.BienSo).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.SoKhung).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.SoMay).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DonGia).HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.SoCongTo).HasColumnType("int").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.MauSac).WithMany(c => c.Xes).HasForeignKey(y => y.IdMauSac);
            

        }
    }
}
