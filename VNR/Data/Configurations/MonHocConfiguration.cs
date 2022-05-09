using VNR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VNR.Data.Configurations
{
    public class MonHocConfiguration : IEntityTypeConfiguration<MonHoc>
    {
        public void Configure(EntityTypeBuilder<MonHoc> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TenMonHoc)
                .HasMaxLength(100);

            builder.Property(p => p.MoTa)
                .HasMaxLength(100);

            builder.HasOne(m => m.KhoaHoc)
                .WithMany(k => k.MonHocs)
                .HasForeignKey(m => m.KhoaHocId);
        }
    }
}