﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class Taikhoan
    {
        public string Name { get; private set; }
        public string Password { get; set; }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(); ;
            stringBuilder.Append(Name);
            return stringBuilder.ToString();
        }
    }
}