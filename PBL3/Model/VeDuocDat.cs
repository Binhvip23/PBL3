using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class VeDuocDat : PhongChieu
    {
        public int Id { get; private set; }
        public int Sove { get; private set; }
        public int Tongtien { get; private set; }
        public bool TrangThai { get; private set; }
        public string HinhThuc { get; private set; }
        public VeDuocDat() { }
    }
}
