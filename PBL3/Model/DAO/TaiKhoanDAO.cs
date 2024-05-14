using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class TaiKhoanDAO
    {
        private readonly string Connection= "Data Source=192.168.1.72;Initial Catalog=\"rap phim\";User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True";
        private static TaiKhoanDAO _instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaiKhoanDAO();
                return _instance;
            }
            private set { }
        }
        public void Add(Taikhoan tk)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO TaiKhoan (TenTK, MatKhau) VALUES (@username, @password)", connection);
                command.Parameters.AddWithValue("@username", tk.Name);
                command.Parameters.AddWithValue("@password", tk.Password);
                command.ExecuteNonQuery();
            }
        }
        public void Update(Taikhoan tk)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE TaiKhoan SET Password = @password,WHERE TenTK = @username", connection);
                command.Parameters.AddWithValue("@username", tk.Name);
                command.Parameters.AddWithValue("@password", tk.Password);
                command.ExecuteNonQuery();
            }
        }
        public void Del(string username)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM TaiKhoan WHERE TenTK = @username", connection);
                command.Parameters.AddWithValue("@username", username);
                command.ExecuteNonQuery();
            }
        }
    }
}
