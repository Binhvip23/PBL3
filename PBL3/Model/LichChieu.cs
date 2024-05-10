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
        public Phim Phim { get; set; }
        public List<PhongChieu> PhongChieu { get; set; }
        public DateTime NgayChieu { get; set; }
        public int GioChieu { get; set; }
        public NVQL NVQL { get; set; }
        public LichChieu(NVQL nVQL, DateTime ngaychieu, int id, Phim phim,List<PhongChieu> phongChieus, int gioChieu)
        {
            NVQL = nVQL;
            NgayChieu = ngaychieu;
            Id = id;
            Phim = phim;
            GioChieu = gioChieu;
            PhongChieu= phongChieus;
        }
        public LichChieu() { }
    }
}
