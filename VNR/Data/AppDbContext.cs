using VNR.Data.Configurations; 
using VNR.Entities;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using VNR.Data.Seed;

namespace VNR.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new KhoaHocConfiguration());
            builder.ApplyConfiguration(new MonHocConfiguration());
             
            base.OnModelCreating(builder);

            builder.InitData();
        }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
    }
}