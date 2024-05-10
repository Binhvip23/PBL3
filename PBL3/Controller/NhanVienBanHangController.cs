using PBL3.Model.DAO;
using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Controller
{
    internal class NhanVienBanHangController
    {
        readonly NhanVienBanHangDAO NhanVienBanHangDAO;
        private static NhanVienBanHangController _instance;
        private NhanVienBanHangController()
        {
            NhanVienBanHangDAO = NhanVienBanHangDAO.Instance;
        }
        public static NhanVienBanHangController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVienBanHangController();
                return _instance;
            }
            private set { }
        }
        public void Add(NVBH nhanvien)
        {
            NhanVienBanHangDAO.Add(nhanvien);
        }
        public void Add(int id, string name,string sodt,string email,string vaitro,string taikhoan,bool active)
        {
            Taikhoan taikhoan1 = new Taikhoan(taikhoan);
            NVBH nhanvien = new NVBH(id, name, sodt, email, vaitro, taikhoan1, active);
            NhanVienBanHangDAO.Add(nhanvien);
        }
        public void Delete(int id)
        {
            NhanVienBanHangDAO.Delete(id);
        }
        public void Update(NVBH nhanvien)
        {
            NhanVienBanHangDAO.Update(nhanvien);
        }
        public void Update(int id, string name, string sodt, string email, string vaitro, string taikhoan, bool active)
        {
            Taikhoan taikhoan1 = new Taikhoan(taikhoan);
            NVBH nhanvien = new NVBH(id, name, sodt, email, vaitro, taikhoan1, active);
            NhanVienBanHangDAO.Update(nhanvien);
        }
        public List<NVBH> GetAllNhanVien()
        {
               return NhanVienBanHangDAO.GetAllNhanVien();
        }
        public static int Size()
        {
            int size = 0;
            foreach (NVBH nVBH in Instance.GetAllNhanVien())
            {
                size++;
            }
            return size;
        }
        public int TimKiemNhanVien(string name)
        {
            int timkiem = 0;
            foreach (NVBH nVBH in Instance.GetAllNhanVien())
            {
                if (nVBH.Taikhoan.Name == name) return nVBH.Id;
            }
            return timkiem;
        }
    }
}
