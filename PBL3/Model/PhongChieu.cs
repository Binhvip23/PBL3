using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal class PhongChieu
    {
        private int id;
        private List<LichChieu> lich;
        protected List<GheNgoi> ghengoi;
        protected string name;
        protected int succhua;
        protected string mota;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int SucChua { get { return succhua; } set { succhua = value; } }
        public string Mota { get { return mota; } set { mota = value; } }
        public List<GheNgoi> Ghengoi { get { return ghengoi; } set { ghengoi = value; } }
        public List<LichChieu> Lich { get { return lich; } set { lich = value; } }
        public PhongChieu(int id, List<GheNgoi> ghengoi, string name, int sucChua, string mota, List<LichChieu> lich)
        {
            this.id = id;
            this.name = name;
            this.succhua = sucChua;
            this.mota = mota;
            this.ghengoi = ghengoi;
            this.lich = lich;
        }
        public PhongChieu(int id, string name, int succhua, string mota, List<LichChieu> lich)
        {
            this.id = id;
            this.name = name;
            this.succhua = succhua;
            this.mota = mota;
            this.lich = lich;
            this.ghengoi = new List<GheNgoi>(succhua);
            for (int i = 0; i < succhua; i++)
            {
                ghengoi.Add(new GheNgoi(i + 1, false));
            }
        }
        public PhongChieu()
        {

        }
    }
}
