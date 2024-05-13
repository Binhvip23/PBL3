using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.Model;
using PBL3.Model.DAO;

namespace PBL3.Controller
{
    internal class PhongChieuController
    {
        readonly private PhongChieuDAO database;
        private static PhongChieuController _instance;
        public static PhongChieuController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhongChieuController();
                }
                return _instance;
            }
            private set { }
        }
        private PhongChieuController()
        {
            database = PhongChieuDAO.Instance;
        }
        public void AddPhongChieu(Model.PhongChieu chieu)
        {
            database.AddDR(chieu);
        }
        public void AddPhongChieu(int id, string name, int succhua, string mota)
        {
            database.AddDR(new PhongChieu
            {
                Id = id,
                Name = name,
                SucChua = succhua,
                Mota = mota
            });
        }
        public void UpdatePhongChieu(Model.PhongChieu chieu)
        {
            database.Update(chieu);
        }
        public void UpdatePhongChieu(int id, string name, int succhua, string mota)
        {
            database.Update(new PhongChieu
            {
                Id = id,
                Name = name,
                SucChua = succhua,
                Mota = mota
            });
        }
        public void DeletePhongChieu(int id)
        {
            database.Del(id);
        }
        public List<PhongChieu> GetAllPhongChieu(string name ="")
        {
            return database.GetAllPhongChieu(name);
        }
        public List<PhongChieu> GetAllPhongChieuPhim(int id)
        {
            return database.GetAllPhongChieuDangChieuPhim(id);
        }
    }
}
