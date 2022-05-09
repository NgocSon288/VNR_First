using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VNR.Entities
{
    public class MonHoc
    {
        public int Id { get; set; }

        public string TenMonHoc { get; set; }

        public string MoTa { get; set; }

        public int KhoaHocId { get; set; }

        public KhoaHoc KhoaHoc { get; set; }
    }
}