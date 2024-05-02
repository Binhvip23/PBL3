using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.Controller
{
    internal class NhanVienController
    {
        private static NhanVienDAO database;
        /*create a constructor*/
        public NhanVienController()
        {
            database = NhanVienDAO.Instance;
        }
        public void AddNhanVien(Model.NhanVien nv)
        {
            database.AddDR(nv);
        }
        /*create a method to add NhanVien with parameters*/
        public void AddNhanVien(int id, string name, string SoDt,string email,string vaitro,string username ,bool active)
        {
            database.AddDR(new NhanVien
            {
                Id = id,
                Fullname = name,
                SoDT = SoDt,
                Email = email,
                Vaitro = vaitro,
                Taikhoan = new Taikhoan(username),
                Active = active
            });
        }
        public void UpdateNhanVien(Model.NhanVien nv)
        {
            database.Update(nv);
        }
        public void UpdateNhanVien(int id, string name, string SoDt, string email, string vaitro, string username, bool active)
        {
            database.Update(new NhanVien
            {
                Id = id,
                Fullname = name,
                SoDT = SoDt,
                Email = email,
                Vaitro = vaitro,
                Taikhoan = new Taikhoan(username),
                Active = active
            });
        }
        public void DeleteNhanVien(int id)
        {
            database.Del(id);
        }
        public List<NhanVien> SearchNhanVien(String name)
        {
            List<NhanVien> nv = new List<NhanVien>();
            foreach (NhanVien a in GetAllNhanVien())
            {
                if (a.Fullname == name)
                {
                    nv.Add(a);
                }
            }
            return nv;
        }
        public List<NhanVien> GetAllNhanVien()
        {
            return database.GetAllNhanVien();
        }
    }
}
