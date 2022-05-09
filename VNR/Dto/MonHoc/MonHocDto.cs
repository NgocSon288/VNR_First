using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNR.Dto.KhoaHoc;

namespace VNR.Dto.MonHoc
{
    public class MonHocDto
    {
        public int Id { get; set; }

        public string TenMonHoc { get; set; }

        public string MoTa { get; set; }

        public int KhoaHocId { get; set; }

        public KhoaHocDto KhoaHoc { get; set; }
    }
}
