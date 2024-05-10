using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class NVBH : NhanVien
    {
        private double kpi;
        public double Kpi { get { return kpi; } set { kpi = value; } }
        public NVBH(int uid, string name, string sodt, string email, string vaitro, Taikhoan taikhoan, bool active, double kpi=0)
            : base(uid, name, sodt, email, vaitro, taikhoan, active)
        {
            this.kpi = kpi;
        }
        public NVBH() { }
    }
}
