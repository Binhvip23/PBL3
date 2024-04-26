using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class PhimDAO
    {
        private static PhimDAO _instace;
        private DataTable _dt;
        public static PhimDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new PhimDAO();
                return _instace;
            }
            private set { }
        }
        public DataTable Dt { get { return _dt; } private set { _dt = value; } }
        public PhimDAO()
        {
            _dt = new DataTable();
            _dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID",typeof(int)),
                new DataColumn("Ten phim",typeof(string)),
                new DataColumn("The loai",typeof(string)),
                new DataColumn("Thoi luong",typeof(int)),
                new DataColumn("Mo ta",typeof(string))
            });
            _dt.Rows.Add(01, "Phim01", "Kinh dị", 137, "Phim troll");
            _dt.Rows.Add(02, "Phim02", "Kinh dị", 150, "Phim troll");
            _dt.Rows.Add(03, "Phim03", "Hài", 120, "Phim troll");
            _dt.Rows.Add(04, "Phim04", "Lãng mạn", 200, "Phim troll");
            _dt.Rows.Add(05, "Phim05", "Viễn tưởng", 100, "Phim troll");
        }
        public void AddDR(Phim phim)
        {
            _dt.Rows.Add(phim.Id, phim.Tenphim, phim.Theloai, phim.Thoiluong, phim.Mota);
        }
        public void Update(Phim phim)
        {
            DataRow[] change = _dt.Select("ID = " + phim.Id + " ");
            if (change.Length > 0)
            {
                DataRow updaterow = change[0];
                updaterow["Ten phim"] = phim.Tenphim;
                updaterow["The loai"] = phim.Theloai;
                updaterow["Thoi luong"] = phim.Thoiluong;
                updaterow["Mo ta"] = phim.Mota;
            }
        }
        public void Del(int id)
        {
            DataRow[] del = _dt.Select("ID =" + id + " ");
            if (del.Length > 0)
            {
                foreach (DataRow row in del)
                {
                    _dt.Rows.Remove(row);
                }
            }
        }
        public List<Phim> GetAllPhim()
        {
            List<Phim> result = new List<Phim>();
            foreach (DataRow row in _dt.Rows)
            {
                result.Add(new Phim
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Tenphim = row["Ten phim"].ToString(),
                    Theloai = row["The loai"].ToString(),
                    Thoiluong = Convert.ToInt32(row["Thoi luong"].ToString()),
                    Mota = row["Mo ta"].ToString(),
                });
            }
            return result;
        }
    }
}
