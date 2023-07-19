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
    public class DangKiemConfig : IEntityTypeConfiguration<DangKiem>
    {
        public void Configure(EntityTypeBuilder<DangKiem> builder)
        {
            builder.ToTable("Đăng kiểm");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NgayDangKiem).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.NgayHetHan).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.Xe).WithMany(x=>x.DangKiem).HasForeignKey(x=>x.IdXe);

        }
    }
}
