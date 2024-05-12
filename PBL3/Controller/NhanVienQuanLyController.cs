using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Controller
{
    internal class NhanVienQuanLyController
    {
        readonly NhanVienQuanLyDAO dao;
        private static NhanVienQuanLyController _instance;
        private NhanVienQuanLyController()
        {
            dao = NhanVienQuanLyDAO.Instance;
        }
        public static NhanVienQuanLyController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVienQuanLyController();
                return _instance;
            }
            private set { }
        }
        public List<NVQL> GetAllNhanVien()
        {
            return dao.GetAllNVQL();
        }
        public void DeleteNhanVien(int id)
        {
            dao.DeleteNVQL(id);
        }
        public void UpdateNhanVien(int id, string ten, string sdt, string email, string vaitro, string tentk, bool active)
        {
            NVQL nvql = new NVQL
            {
                Id = id,
                Fullname = ten,
                SoDT = sdt,
                Email = email,
                Vaitro = vaitro,
                Active = active,
                TenTK = tentk
            };
            dao.UpdateNVQL(nvql);
        }
        public void AddNhanVien(int id, string ten, string sdt, string email, string vaitro, string tentk, bool active)
        {
            NVQL nvql = new NVQL
            {
                Id = id,
                Fullname = ten,
                SoDT = sdt,
                Email = email,
                Vaitro = vaitro,
                Active = active,
                TenTK = tentk
            };
            dao.AddNVQL(nvql);
        }
        public void GetNhanVienById(int id)
        {
            dao.GetNVQL(id);
        }
        public static int Size()
        {
            int size = 0;
            foreach(NVQL nVQL in Instance.GetAllNhanVien())
            {
                size++;
            }
            return size;
        }
        public int TimKiemNhanVien(string name)
        {
            int timkiem = 0;
            foreach(NVQL nVQL in Instance.GetAllNhanVien())
            {
                if (nVQL.Fullname == name) return nVQL.Id;
            }
            return timkiem;
        }
    }
}
