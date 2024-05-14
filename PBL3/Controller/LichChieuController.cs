using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
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
      
        public void AddLichChieu(Model.LichChieu lich)
        {
            database.AddDR(lich);
        }
        public void AddLichChieu(int id, string name, DateTime date, int giochieu, string nvql)
        {
            try
            {
                database.AddDR(new LichChieu
                {
                    Id = id,
                    TenPhim = name,
                    NgayChieu = date,
                    GioChieu = giochieu,
                    TenNVQL= nvql
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller bug " + ex.Message);
            }
        }
      
        public void UpdateLichChieu(Model.LichChieu lich)
        {
            database.Update(lich);
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
        public List<LichChieu> GetAllLichChieu(string name ="")
        {
            return database.GetAllLichChieu(name);
        }
        public List<LichChieu> GetPhimDangChieu(int idphong)
        {
            return database.GetPhimDangChieu(idphong);
        }
        public void ThemPhimDangChieu(int idphim, int idphong)
        {
            database.ThemPhimDangChieu(idphim, idphong);
        }
    }
}
