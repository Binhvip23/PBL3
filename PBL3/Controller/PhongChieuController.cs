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
        public delegate bool MyDel(string s1,string s2);
        public MyDel del;
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
        public List<PhongChieu> sortByID()
        {

            List<PhongChieu> phongchieuList = database.GetAllPhongChieu();

            // Sử dụng thuật toán Bubble Sort để sắp xếp danh sách theo Id tăng dần
            for (int i = 0; i < phongchieuList.Count - 1; i++)
            {
                for (int j = 0; j < phongchieuList.Count - i - 1; j++)
                {
                    if (phongchieuList[j].Id <phongchieuList[j + 1].Id)
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
            List<PhongChieu> phongchieuList = database.GetAllPhongChieu();

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
            List<PhongChieu> phongchieuList = database.GetAllPhongChieu();

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


        public void DeletePhongChieu(int id)
        {
            database.Del(id);
        }

        public List<PhongChieu> Search(int? id = null, string name = null, bool matchAllCriteria = true)
        {
            List<PhongChieu> results = new List<PhongChieu>();

            if (getAllPhongChieu() == null)
            {
                // Handle case where getAllPhongChieu() might return null
                return results;
            }

            foreach (PhongChieu phongChieu in getAllPhongChieu())
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

        public List<PhongChieu> getAllPhongChieu()
        {
            return database.GetAllPhongChieu();
        }
       /* public bool tangdan(string s1,string s2)
        {
            return string.Compare(s1, s2) > 0;
        }
        public bool giamdan(string s1, string s2)
        {
            return string.Compare(s1, s2) < 0;
        }
*/
    }
}
