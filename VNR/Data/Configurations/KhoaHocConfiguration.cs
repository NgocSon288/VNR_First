using VNR.Entities;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VNR.Data.Configurations
{
    public class KhoaHocConfiguration : IEntityTypeConfiguration<KhoaHoc>
    {
        public void Configure(EntityTypeBuilder<KhoaHoc> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TenKhoaHoc)
                .HasMaxLength(100);
        }
    }
}