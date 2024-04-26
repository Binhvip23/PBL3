using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class HoaDon
    {
        private int id;
        protected double tongtien;
        protected string mota;
        private KhachHang khach;
        private NVBH nvbh;
        public NVBH Nvbh { get { return nvbh; } private set { } }
        public KhachHang Khach { get { return khach; } private set { } }
        public int Id { get { return id; } private set { } }
        public double Tongtien { get { return tongtien; } private set { } }
        public string Mota { get { return mota; } private set { } }
        public HoaDon(int id, double tongtien, string mota, KhachHang khach, NVBH nvbh)
        {
            this.id = id;
            this.tongtien = tongtien;
            this.mota = mota;
            this.khach = khach;
            this.nvbh = nvbh;
        }
    }
}
