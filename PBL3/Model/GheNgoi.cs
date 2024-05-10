using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class GheNgoi
    {
        public int Id { get;  set; }
        public bool trangthai { get;  set; }
        public GheNgoi(int id, bool trangthai)
        {
            Id = id;
            this.trangthai = trangthai;
        }
        public GheNgoi() { }
    }
}
