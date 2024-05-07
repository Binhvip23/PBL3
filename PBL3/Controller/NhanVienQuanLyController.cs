using PBL3.Model;
using PBL3.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Controller
{
    internal class NhanVienQuanLyController
    {
        NhanVienQuanLyDAO dao;
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
                Taikhoan = new Taikhoan(tentk)
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
                Taikhoan = new Taikhoan(tentk)
            };
            dao.AddNVQL(nvql);
        }
        public void GetNhanVienById(int id)
        {
            dao.GetNVQL(id);
        }
    }
}
