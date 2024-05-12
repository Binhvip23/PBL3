using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class NhanVien : NguoiDung
    {
        public string TenTK { get; set; }
        protected bool active;
        public bool Active { get { return active; } set { active = value; } }
        public NhanVien() { }
    }
}
