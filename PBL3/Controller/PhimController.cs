using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Controller
{
    internal class PhimController
    {
        private PhimDAO database;
        public PhimController()
        {
            database = PhimDAO.Instance;
        }
        public void AddPhim(Model.Phim phim)
        {
            database.AddDR(phim);
        }
        public void AddPhim(int id, string name, string theloai, int thoiluong, string mota)
        {
            database.AddDR(new Phim
            {
                Id = id,
                Tenphim = name,
                Theloai = theloai,
                Thoiluong = thoiluong,
                Mota = mota
            });
        }
        public void UpdatePhim(Model.Phim phim)
        {
            database.Update(phim);
        }
        public void UpdatePhim(int id, string name, string theloai, int thoiluong, string mota)
        {
            database.Update(new Phim
            {
                Id = id,
                Tenphim = name,
                Theloai = theloai,
                Thoiluong = thoiluong,
                Mota = mota
            });
        }
        public void DeletePhim(int id)
        {
            database.Del(id);
        }
        public List<Phim> GetAllPhim()
        {
            return database.GetAllPhim();
        }
    }
}
