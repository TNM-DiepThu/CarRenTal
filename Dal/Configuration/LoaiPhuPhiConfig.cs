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
    public class LoaiPhuPhiConfig : IEntityTypeConfiguration<LoaiPhuPhi>
    {
        public void Configure(EntityTypeBuilder<LoaiPhuPhi> builder)
        {
            builder.ToTable("LoaiPhuPhi");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.TenLoaiPhuPhi).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
