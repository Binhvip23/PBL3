using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Controller
{
    internal class PhimController
    {
        readonly private PhimDAO database;
        private static PhimController instance;
        public static PhimController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhimController();
                }
                return instance;
            }
            private set { }
        }
        public PhimController()
        {
            database = PhimDAO.Instance;
        }
        public void AddPhim(Phim phim)
        {
            database.Add(phim);
        }
        public void AddPhim(int id, string name, string theloai, int thoiluong, string mota)
        {
            database.Add(new Phim
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
        public List<Phim> GetAllPhim(string name ="")
        {
            return database.GetAllPhim(name);
        }

        public List<Phim> GetAllPhim()
        {
            return database.GetAllPhim();
        }

        public int TimKiemPhim(string name)
        {
            foreach (Phim phim in GetAllPhim())
            {
                if (phim.Tenphim.Equals(name))
                {
                    return phim.Id;
                }
            }
            return 0;
        }
        public int Size()
        {
            int size = 0;
            foreach(Phim phim in Instance.GetAllPhim())
            {
                size++;
            }
            return size;
        }
    }
}
