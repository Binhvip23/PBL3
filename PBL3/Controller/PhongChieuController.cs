using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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
        public int GetPhongChieuid(string name)
        {
            foreach(PhongChieu chieu in GetAllPhongChieu())
            {
                if (chieu.Name == name)
                {
                    return chieu.Id;
                }      
            }
            return 0;
        }
        public List<PhongChieu> GetAllPhongChieu(string name ="")
        {
            return database.GetAllPhongChieu(name);
        }
        public List<PhongChieu> GetAllPhongChieuPhim(int id)
        {
            return database.GetAllPhongChieuDangChieuPhim(id);
        }
        public bool CheckPhongChieuPhim(int idphim, int idphong)
        {
            if(idphim==0 || idphong == 0) return false;
            foreach(PhongChieu chieu in GetAllPhongChieuPhim(idphim))
            {
                if (chieu.Id == idphong) return true;
            }
            return false;
        }
        public void ThemPhongChieuPhim(int idphim, int idphong)
        {
            if(!CheckPhongChieuPhim(idphim, idphong))
                database.ThemPhongChieuPhim(idphim, idphong);
            else MessageBox.Show("Phim đã ở trong phòng chiếu này!");
        }
        public void XoaPhongChieuPhim(int idphim, int idphong)
        {
            database.XoaPhongChieuPhim(idphim, idphong);
        }

        public List<PhongChieu> sortByID()
        {

            List<PhongChieu> phongchieuList = database.GetAllPhongChieu("");

            // Sử dụng thuật toán Bubble Sort để sắp xếp danh sách theo Id tăng dần
            for (int i = 0; i < phongchieuList.Count - 1; i++)
            {
                for (int j = 0; j < phongchieuList.Count - i - 1; j++)
                {
                    if (phongchieuList[j].Id < phongchieuList[j + 1].Id)
                    {
                        // Hoán đổi hai phần tử nếu cần thiết để sắp xếp
                        PhongChieu temp = phongchieuList[j];
                        phongchieuList[j] = phongchieuList[j + 1];
                        phongchieuList[j + 1] = temp;
                    }
                }
            }
            return phongchieuList;

        }
        public List<PhongChieu> sortByName(bool tang)
        {
            List<PhongChieu> phongchieuList = database.GetAllPhongChieu("");

            // Sử dụng thuật toán Bubble Sort để sắp xếp danh sách theo Name
            for (int i = 0; i < phongchieuList.Count - 1; i++)
            {
                for (int j = 0; j < phongchieuList.Count - i - 1; j++)
                {
                    // So sánh theo thứ tự tăng dần hoặc giảm dần
                    if ((tang && string.Compare(phongchieuList[j].Name, phongchieuList[j + 1].Name) > 0) ||
                        (!tang && string.Compare(phongchieuList[j].Name, phongchieuList[j + 1].Name) < 0))
                    {
                        // Hoán đổi hai phần tử nếu cần thiết để sắp xếp
                        PhongChieu temp = phongchieuList[j];
                        phongchieuList[j] = phongchieuList[j + 1];
                        phongchieuList[j + 1] = temp;
                    }
                }
            }
            return phongchieuList;
        }
        public List<PhongChieu> sortBysucchua(bool tang)
        {
            List<PhongChieu> phongchieuList = database.GetAllPhongChieu("");

            // Sử dụng thuật toán Bubble Sort để sắp xếp danh sách theo SucChua
            for (int i = 0; i < phongchieuList.Count - 1; i++)
            {
                for (int j = 0; j < phongchieuList.Count - i - 1; j++)
                {
                    // So sánh theo thứ tự tăng dần hoặc giảm dần
                    if ((tang && phongchieuList[j].SucChua > phongchieuList[j + 1].SucChua) ||
                        (!tang && phongchieuList[j].SucChua < phongchieuList[j + 1].SucChua))
                    {
                        // Hoán đổi hai phần tử nếu cần thiết để sắp xếp
                        PhongChieu temp = phongchieuList[j];
                        phongchieuList[j] = phongchieuList[j + 1];
                        phongchieuList[j + 1] = temp;
                    }
                }
            }

            return phongchieuList;
        }

    }
}
