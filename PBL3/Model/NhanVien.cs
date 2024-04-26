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
        protected bool active;
        public Taikhoan Taikhoan { get; set; }
        public bool Active { get { return active; } private set { } }
        public NhanVien(int uid, string fullname, string sodt, string email, string vaitro, Taikhoan taikhoan, bool active)
            : base(uid, fullname, sodt, email, vaitro)
        {
            this.Taikhoan = taikhoan;
            this.active = active;
        }
        public NhanVien() { }
    }
}
