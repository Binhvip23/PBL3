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
        public Taikhoan Taikhoan { get; set; }
        protected bool active;
        public bool Active { get { return active; } set { active = value; } }
        public NhanVien(int uid, string fullname, string sodt, string email, string vaitro, Taikhoan taikhoan, bool active)
            : base(uid, fullname, sodt, email, vaitro)
        {
            this.Taikhoan = taikhoan;
            this.active = active;
        }
        public NhanVien() { }
    }
}
