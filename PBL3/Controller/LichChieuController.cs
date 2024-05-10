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
        //to do : them lien ket phim khi lien ket voi csdl
        public void AddLichChieu(int id, string name, DateTime date, int giochieu, string nvql)
        {
            try
            {
                database.AddDR(new LichChieu
                {
                    Id = id,
                    Phim = new Phim{Tenphim=name},
                    NgayChieu = date,
                    GioChieu = giochieu,
                    NVQL = new NVQL(nvql),
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
                Phim = new Phim {Tenphim=name },
                NgayChieu = date,
                GioChieu = giochieu,
                NVQL = new Model.NVQL(nvql),
            });
        }
        public void DeleteLichChieu(int id)
        {
            database.Del(id);
        }
        public void AddPhongChieu(LichChieu lichchieu,PhongChieu phong)
        {
            lichchieu.PhongChieu.Add(phong);            
        }
        public void AddPhongChieu(LichChieu lichchieu, List<PhongChieu> phong)
        {
            lichchieu.PhongChieu.AddRange(phong);
        }
        public List<LichChieu> GetAllLichChieu(string name ="")
        {
            return database.GetAllLichChieu(name);
        }
        public List<LichChieu> GetPhimDangChieu(int idphong)
        {
            return database.GetPhimDangChieu(idphong);
        }
    }
}
