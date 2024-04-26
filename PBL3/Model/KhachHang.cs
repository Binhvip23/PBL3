using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class KhachHang : NguoiDung
    {
        public KhachHang(int uid, string name, string sodt, string email, string vaitro)
              : base(uid, name, sodt, email, vaitro)
        { }
    }
}
