using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VNR.Entities
{
    public class KhoaHoc
    {
        public int Id { get; set; }

        public string TenKhoaHoc { get; set; }

        public List<MonHoc> MonHocs { get; set; }
    }
}