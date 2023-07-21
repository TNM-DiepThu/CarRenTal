using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Configuration
{
    public class TaiSanTheChapConfig : IEntityTypeConfiguration<TaiSanTheChap>
    {
        public void Configure(EntityTypeBuilder<TaiSanTheChap> builder)
        {
            builder.ToTable("Tai San The Chap");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.LoaiTaiSan).HasColumnType("nvarchar(100)").IsRequired();

        }
    }
}
