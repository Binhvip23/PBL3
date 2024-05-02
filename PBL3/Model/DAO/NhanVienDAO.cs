using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL3.Model;

namespace PBL3.Model.DAO
{
    internal class NhanVienDAO
    {
        private static NhanVienDAO _instace;
        private DataTable _dt;
        public static NhanVienDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new NhanVienDAO();
                return _instace;
            }
            private set { }
        }
        public DataTable Dt { get { return _dt; } private set { _dt = value; } }
        /*create a new DataTable with columns: ID, Fullname,PhoneNumber,Email,Role,Username*/
        public NhanVienDAO()
        {
            _dt = new DataTable();
            _dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID",typeof(int)),
                new DataColumn("Fullname",typeof(string)),
                new DataColumn("SoDT",typeof(string)),
                new DataColumn("Email",typeof(string)),
                new DataColumn("Role",typeof(string)),
                new DataColumn("Username",typeof(string)),
                new DataColumn("Active",typeof(int)),

            });
            _dt.Rows.Add(01, "NVA", "0123456789", "Testmail01@mail.com", "Quản lý", "NVQL1",true);
            _dt.Rows.Add(02, "TTC", "0534556789", "Testmail02@gmail.com", "Nhân viên bán hàng", "NVBH1",true);
            _dt.Rows.Add(03, "NVB", "0123456549", "Testmail03@mail.com", "Nhân viên bán hàng", "NVBH2",true);
            _dt.Rows.Add(04, "NVC", "0126555389", "Testmail04@mail.com", "Quản lý", "NVQL2",false);
            _dt.Rows.Add(05, "NVF", "0129586789", "Testmail05@mail.com", "Nhân viên bán hàng", "NVBH3",true);
        }
        /*Add a new DataRow to the DataTable*/
        public void AddDR(NhanVien nv)
        {
            _dt.Rows.Add(nv.Id, nv.Fullname, nv.SoDT, nv.Email, nv.Vaitro, nv.Taikhoan,nv.Active);
        }
        /*Update a DataRow in the DataTable*/
        public void Update(NhanVien nv)
        {
            DataRow[] change = _dt.Select("ID = " + nv.Id + " ");
            if (change.Length > 0)
            {
                DataRow updaterow = change[0];
                updaterow["Fullname"] = nv.Fullname;
                updaterow["SoDT"] = nv.SoDT;
                updaterow["Email"] = nv.Email;
                updaterow["Role"] = nv.Vaitro;
                updaterow["Username"] = nv.Taikhoan;
                updaterow["Active"] = nv.Active;
            }
        }
        /*Delete a DataRow in the DataTable*/
        public void Del(int id)
        {
            DataRow[] del = _dt.Select("ID =" + id + " ");
            if (del.Length > 0)
            {
                del[0].Delete();
            }
        }
        /*Get all NhanVien in the DataTable*/
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (DataRow row in _dt.Rows)
            {
                NhanVien nv = new NhanVien
                {
                    Id = Convert.ToInt32(row["ID"]),
                    Fullname = row["Fullname"].ToString(),
                    SoDT = row["SoDT"].ToString(),
                    Email = row["Email"].ToString(),
                    Vaitro = row["Role"].ToString(),
                    Taikhoan = new Taikhoan(row["Username"].ToString()),
                    Active = Convert.ToBoolean(row["Active"]),
                };
                list.Add(nv);
            }
            return list;
        }

    }
}
