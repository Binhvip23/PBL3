using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Controller
{
    internal class LichChieuController
    {
        readonly private LichChieuDAO database;
        private static LichChieuController _instance;
        public static LichChieuController Instance
        {
            get {
                if(_instance == null)
                    _instance = new LichChieuController();
                return _instance; 
            }
            private set { }
        }

        private LichChieuController()

        {
            database = LichChieuDAO.Instance;
        }
        public void AddLichChieu(int id, string name, DateTime date, int giochieu, string nvql)
        {
            if (GetLichChieu(id) != null)
                throw new Exception("Id lịch chiếu đã tồn tại!");
            database.AddDR(new LichChieu
            {
                Id = id,
                TenPhim = name,
                NgayChieu = date,
                GioChieu = giochieu,
                TenNVQL= nvql
            });
        }
        public void UpdateLichChieu(int id, string name, DateTime date, int giochieu, string nvql)
        {
            database.Update(new Model.LichChieu
            {
                Id = id,
                TenPhim = name,
                NgayChieu = date,
                GioChieu = giochieu,
                TenNVQL= nvql
            });
        }
        public void DeleteLichChieu(int id)
        {
            database.Del(id);
        }
        public LichChieu GetLichChieu(int id)
        {
            foreach(LichChieu lc in GetAllLichChieu())
            {
                if (lc.Id == id) return lc;
            }
            return null;
        }
        public List<int> GetLichChieuid(string name)
        {
            List<int> list = new List<int>();
            foreach(LichChieu lc in GetAllLichChieu())
            {
                if (lc.TenPhim == name) 
                {
                    list.Add(lc.Id);
                } 
            }
            return list;
        }
        public List<LichChieu> GetAllLichChieu(string name ="")
        {
            return database.GetAllLichChieu(name);
        }
        public List<LichChieu> GetPhimDangChieu(int idphong)
        {
            return database.GetPhimDangChieu(idphong);
        }
        public bool CheckPhimDangChieu(int idPhim,int IdPhong)
        {
            foreach(LichChieu lich in GetPhimDangChieu(IdPhong))
            {
                if (lich.Id == idPhim) return true;
            }
            return false;
        }
        public void ThemPhimDangChieu(int idphim, int idphong)
        {
            if(!CheckPhimDangChieu(idphim,idphong))
                database.ThemPhimDangChieu(idphim, idphong);
            else
                throw new Exception("Phim đã có trong phòng chiếu");
        }
        public void XoaPhimDangChieu(int idphim, int idphong)
        {
            database.XoaPhimDangChieu(idphim, idphong);
        }
    }
}
