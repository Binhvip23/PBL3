using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class Phim
    {
        public int Id { get; set; }
        public string Tenphim { get; set; }
        public string Theloai { get; set; }
        public string Mota { get; set; }
        public int Thoiluong { get; set; }
        public Phim(int id, string tenphim, string theloai, int thoiluong, string mota)
        {
            Id = id;
            Tenphim = tenphim;
            Theloai = theloai;
            Thoiluong = thoiluong;
            Mota = mota;
        }
        public Phim() { }
        public Phim(string name)
        {
            Tenphim = name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Tenphim);
            return sb.ToString();
        }
    }
}
