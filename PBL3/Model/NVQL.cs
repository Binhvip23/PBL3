using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class NVQL : NhanVien
    {
        public NVQL() : base()
        {
        }
        public NVQL(string name) : base()
        {
            this.fullname = name;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.fullname);
            return stringBuilder.ToString();
        }
    }
}
