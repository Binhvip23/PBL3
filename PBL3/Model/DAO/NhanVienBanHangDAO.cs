using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class NhanVienBanHangDAO
    {
        TaiKhoanDAO taikhoanDAO;
        private readonly string ConnectionString = "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
        private static NhanVienBanHangDAO _instace;
        public static NhanVienBanHangDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new NhanVienBanHangDAO();
                return _instace;
            }
            private set { }
        }
        NhanVienBanHangDAO()
        {
            taikhoanDAO = TaiKhoanDAO.Instance;
        }
        public void Add(NVBH nhanvien)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO NhanVienBanHang (Id, Fullname, SoDt, Email, Vaitro, Active,TenTk) VALUES (@id, @ten,@sdt,@email,@vaitro,@active,@tentk)", connection);
                command.Parameters.AddWithValue("@id", nhanvien.Id);
                command.Parameters.AddWithValue("@ten", nhanvien.Fullname);
                command.Parameters.AddWithValue("@sdt", nhanvien.SoDT);
                command.Parameters.AddWithValue("@email", nhanvien.Email);
                command.Parameters.AddWithValue("@vaitro", nhanvien.Vaitro);
                command.Parameters.AddWithValue("@active", nhanvien.Active);
                command.Parameters.AddWithValue("@tentk", nhanvien.TenTK);
                command.ExecuteNonQuery();
                taikhoanDAO.Add(new Taikhoan(nhanvien.TenTK));
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM NhanVienBanHang WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(NVBH nhanvien)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE NhanVienBanHang SET Fullname = @ten, SoDt = @sdt, Email = @email, Vaitro = @vaitro, Active = @active, TenTk = @tentk WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", nhanvien.Id);
                command.Parameters.AddWithValue("@ten", nhanvien.Fullname);
                command.Parameters.AddWithValue("@sdt", nhanvien.SoDT);
                command.Parameters.AddWithValue("@email", nhanvien.Email);
                command.Parameters.AddWithValue("@vaitro", nhanvien.Vaitro);
                command.Parameters.AddWithValue("@active", nhanvien.Active);
                command.Parameters.AddWithValue("@tentk", nhanvien.TenTK);
                command.ExecuteNonQuery();
            }
        }
        public List<NVBH> GetAllNhanVien()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM NhanVienBanHang", connection);
                var reader = command.ExecuteReader();
                List<NVBH> result = new List<NVBH>();
                while (reader.Read())
                {
                    result.Add(new NVBH
                    {
                        Id = reader.GetInt32(0),
                        Fullname = reader.GetString(1),
                        SoDT = reader.GetString(2),
                        Email = reader.GetString(3),
                        Vaitro = reader.GetString(4),
                        Active = reader.GetBoolean(5),
                        TenTK = reader.GetString(6)
                    }) ;
                }
                return result;
            }
        }
        public NVBH GetNhanVien(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM NhanVienBanHang WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return new NVBH
                {
                    Id = reader.GetInt32(0),
                    Fullname = reader.GetString(1),
                    SoDT = reader.GetString(2),
                    Email = reader.GetString(3),
                    Vaitro = reader.GetString(4),
                    Active = reader.GetBoolean(5),
                    TenTK = reader.GetString(6),
                };
            }
        }
    }
}
