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
    public class GiayToTheChapConfig : IEntityTypeConfiguration<GiayToTheChap>
    {
        public void Configure(EntityTypeBuilder<GiayToTheChap> builder)
        {
            builder.ToTable("Giay To The Chap");
            builder.HasKey(x => x.Id);  
            builder.Property(x=>x.LoaiGiayTo).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
