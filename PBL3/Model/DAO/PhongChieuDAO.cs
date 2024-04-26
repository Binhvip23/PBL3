using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class PhongChieuDAO
    {
        private static PhongChieuDAO _instace;
        private DataTable _dt;
        public static PhongChieuDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new PhongChieuDAO();
                return _instace;
            }
            private set { }
        }
        public DataTable Dt { get { return _dt; } private set { _dt = value; } }
        public PhongChieuDAO()
        {
            _dt = new DataTable();
            _dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID",typeof(int)),
                new DataColumn("Name",typeof(string)),
                new DataColumn("Suc chua",typeof(int)),
                new DataColumn("Mota",typeof(string)),
            });
            _dt.Rows.Add(1, "Room01", 80, "3D");
            _dt.Rows.Add(2, "Room02", 50, "4D");
            _dt.Rows.Add(3, "Room03", 30, "5D");
            _dt.Rows.Add(4, "Room04", 40, "6D");
            _dt.Rows.Add(5, "Room05", 80, "7D");
        }
        public void AddDR(PhongChieu phong)
        {
            _dt.Rows.Add(phong.Id, phong.Name, phong.SucChua, phong.Mota);
        }
        public void Update(PhongChieu phong)
        {
            DataRow[] change = _dt.Select("ID = " + phong.Id + " ");
            if (change.Length > 0)
            {
                DataRow updaterow = change[0];
                updaterow["ID"] = phong.Id;
                updaterow["Name"] = phong.Name;
                updaterow["Suc chua"] = phong.SucChua;
                updaterow["Mota"] = phong.Mota;
            }
        }
        public void Del(int id)
        {
            DataRow[] del = _dt.Select("ID =" + id + " ");
            if (del.Length > 0)
            {
                foreach (DataRow row in del)
                {
                    _dt.Rows.Remove(row);
                }
            }
        }
        public List<PhongChieu> GetAllPhongChieu()
        {
            List<PhongChieu> result = new List<PhongChieu>();
            foreach (DataRow row in _dt.Rows)
            {
                result.Add(new PhongChieu
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    SucChua = Convert.ToInt32(row["Suc chua"].ToString()),
                    Mota = row["Mota"].ToString(),
                });
            }
            return result;
        }
    }
}
