using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNR.Data;
using VNR.Entities;
using VNR.Services.Interfaces;

namespace VNR.Services
{
    public class MonHocService : IMonHocService
    {
        private readonly AppDbContext _context;
        public MonHocService(AppDbContext context)
        {
            this._context = context;
        } 
    }
}
