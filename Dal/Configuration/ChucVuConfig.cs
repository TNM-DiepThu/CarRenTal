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
    public class ChucVuConfig : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("Chức Vụ");
            builder.HasKey(t => t.Id);
            builder.Property(x=>x.TenChucVu).HasColumnType("nvarchar(100)").IsRequired();
            

        }
    }
}
