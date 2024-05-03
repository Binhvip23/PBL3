using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class LichChieuDAO
    {
        private static LichChieuDAO _instace;
        private DataTable _dt;
        public static LichChieuDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new LichChieuDAO();
                return _instace;
            }
            private set { }
        }
        public DataTable Dt { get { return _dt; } private set { _dt = value; } }
        public LichChieuDAO()
        {
            
        }
        public void AddDR(LichChieu lich)
        {
            _dt.Rows.Add(lich.Id, lich.Phim.Tenphim, lich.NgayChieu, lich.GioChieu, lich.NVQL.Fullname);
        }
        public void Update(LichChieu lich)
        {
            DataRow[] change = _dt.Select("ID = " + lich.Id + " ");
            if (change.Length > 0)
            {
                DataRow updaterow = change[0];
                updaterow["Phim"] = lich.Phim.Tenphim;
                updaterow["Ngay chieu"] = lich.NgayChieu;
                updaterow["Gio chieu"] = lich.GioChieu;
                updaterow["NVQL"] = lich.NVQL.Fullname;
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
        public List<LichChieu> GetAllLichChieu()
        {
            List<LichChieu> result = new List<LichChieu>();
            foreach (DataRow row in _dt.Rows)
            {
                result.Add(new LichChieu
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Phim = new Phim(row["Phim"].ToString()),
                    NgayChieu = Convert.ToDateTime(row["Ngay chieu"]),
                    GioChieu = Convert.ToInt32(row["Gio chieu"].ToString()),
                    NVQL = new NVQL(row["NVQL"].ToString()),
                });
            }
            return result;
        }
    }
}
