using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class LichChieu
    {
        public int Id { get; set; }
        public string TenPhim { get; set; }
        public DateTime NgayChieu { get; set; }
        public int GioChieu { get; set; }
        public string TenNVQL { get; set; }
        public LichChieu() { }
    }
}
