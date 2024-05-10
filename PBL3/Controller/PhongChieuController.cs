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

        public List<PhongChieu> Search(int? id = null, string name = null, bool matchAllCriteria = true)
        {
            List<PhongChieu> results = new List<PhongChieu>();

            if (GetAllPhongChieu() == null)
            {
                // Handle case where getAllPhongChieu() might return null
                return results;
            }

            foreach (PhongChieu phongChieu in GetAllPhongChieu())
            {
                bool matchFound = true;

                if (id.HasValue && phongChieu.Id != id.Value)
                {
                    matchFound = false;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    if (matchAllCriteria)
                    {
                        // Exact match for name
                        matchFound = matchFound && phongChieu.Name == name;
                    }
                    else
                    {
                        // Partial match for name using Contains
                        matchFound = matchFound && phongChieu.Name.Contains(name);
                    }
                }

                if (matchFound)
                {
                    results.Add(phongChieu);
                }
            }

            return results;
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
