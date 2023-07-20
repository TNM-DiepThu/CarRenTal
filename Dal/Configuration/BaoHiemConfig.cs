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
    public class BaoHiemConfig : IEntityTypeConfiguration<BaoHiem>
    {
        public void Configure(EntityTypeBuilder<BaoHiem> builder)
        {
            builder.ToTable("Bao_Hiem");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.LoaiBaoHiem).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.ThoiHan).HasColumnType("DateTime").IsRequired();
            builder.Property(x=>x.TrangThai).HasColumnType("int").IsRequired();
            
        }
    }
}
