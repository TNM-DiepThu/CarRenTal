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
    public class MauSacConfig : IEntityTypeConfiguration<MauSac>
    {
        public void Configure(EntityTypeBuilder<MauSac> builder)
        {
            builder.ToTable("Màu sắc");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.TenMauSac).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
