using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PBL3.Model;
using PBL3.Model.DAO;

namespace PBL3.Controller
{
    internal class PhongChieuController
    {
        private PhongChieuDAO database;
        public PhongChieuController()
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
        public List<PhongChieu> getAllPhongChieu()
        {
            return database.GetAllPhongChieu();
        }
    }
}
