using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class HoaDonDAO
    {
        private readonly string Connection = "Data Source=DESKTOP-3Q9K9U2;Initial Catalog=QLCine;Integrated Security=True";
        private static HoaDonDAO _instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonDAO();
                return _instance;
            }
            private set { }
        }
        public void Add(HoaDon hd)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO HoaDon (Id, TongTien, MoTa, TenKhach, TenNVBH) VALUES (@id, @tongtien, @mota, @tenkhach, @tennvbh)", connection);
                command.Parameters.AddWithValue("@id", hd.Id);
                command.Parameters.AddWithValue("@tongtien", hd.TongTien);
                command.Parameters.AddWithValue("@mota", hd.MoTa);
                command.Parameters.AddWithValue("@tenkhach", hd.TenKhach);
                command.Parameters.AddWithValue("@tennvbh", hd.TenNVBH);
                command.ExecuteNonQuery();
            }
        }

    }
}
