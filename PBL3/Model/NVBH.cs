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
        public NVBH() { }
    }
}
