using VNR.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VNR.Data.Seed
{
    public static class DataSeeding
    {
        public static void InitData(this ModelBuilder builder)
        {
            builder.Entity<KhoaHoc>().HasData(new KhoaHoc
            {
                Id = 1,
                TenKhoaHoc = "Front End"
            },
            new KhoaHoc
            {
                Id = 2,
                TenKhoaHoc = "Back End"
            },
            new KhoaHoc
{
                Id = 3,
                TenKhoaHoc = "Dotnet Core"
            });


            builder.Entity<MonHoc>().HasData(new MonHoc
            {
                Id = 1,
                TenMonHoc = "Bootstrap",
                MoTa = "Description Bootstrap",
                KhoaHocId = 1
            },
            new MonHoc
            {
                Id = 2,
                TenMonHoc = "Angular JS",
                MoTa = "Description Angular JS",
                KhoaHocId = 1
            },
            new MonHoc
            {
                Id = 3,
                TenMonHoc = "Angular",
                MoTa = "Description Angular",
                KhoaHocId = 1
            },
            new MonHoc
            {
                Id = 4,
                TenMonHoc = "React JS",
                MoTa = "Description React JS",
                KhoaHocId = 1
            },
            new MonHoc
            {
                Id = 5,
                TenMonHoc = "Dotnet",
                MoTa = "Description Dotnet",
                KhoaHocId = 2
            },
            new MonHoc
            {
                Id = 6,
                TenMonHoc = "ASP NET",
                MoTa = "Description ASP NET",
                KhoaHocId = 2
            },
            new MonHoc
            {
                Id = 7,
                TenMonHoc = "Net Core",
                MoTa = "Description Net Core",
                KhoaHocId = 3
            });
        }
    }
}