using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNR.Data;
using VNR.Dto.KhoaHoc;
using VNR.Entities;
using VNR.Services.Interfaces;

namespace VNR.Services
{
    public class KhoaHocService : IKhoaHocService
    {
        private readonly AppDbContext _context;
        public KhoaHocService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<List<KhoaHocDto>> GetAll()
        {
            return await _context.KhoaHocs
                .Select(x => new KhoaHocDto()
                {
                    Id = x.Id,
                    TenKhoaHoc = x.TenKhoaHoc
                })
                .ToListAsync();
        }

        public async Task<KhoaHocDto> GetById(int id)
        {
            var item = await _context.KhoaHocs
                .Include(x=>x.MonHocs)
                .FirstOrDefaultAsync(k => k.Id == id);

            return item != null ? new KhoaHocDto()
            {
                Id = item.Id,
                TenKhoaHoc = item.TenKhoaHoc,
                MonHocs = item.MonHocs
                .Select(m=> new Dto.MonHoc.MonHocDto()
                {
                    Id = m.Id,
                    TenMonHoc = m.TenMonHoc,
                    MoTa = m.MoTa
                }).ToList(),
            } : null;
        }
    }
}
