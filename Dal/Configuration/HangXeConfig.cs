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
    public class HangXeConfig : IEntityTypeConfiguration<HangXe>
    {
        public void Configure(EntityTypeBuilder<HangXe> builder)
        {
            builder.ToTable("Hang_Xe");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();

        }
    }
}
