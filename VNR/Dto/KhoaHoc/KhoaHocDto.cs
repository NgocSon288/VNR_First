using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNR.Dto.MonHoc;

namespace VNR.Dto.KhoaHoc
{
    public class KhoaHocDto
    {
        public int Id { get; set; }

        public string TenKhoaHoc { get; set; }

        public List<MonHocDto> MonHocs { get; set; }
    }
}
