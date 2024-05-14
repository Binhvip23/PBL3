using PBL3.Controller;
using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Model.DAO
{
    internal class LichChieuDAO
    {
        private static LichChieuDAO _instace;
        private static  PhimController PhimController;
        private static  NhanVienQuanLyController NhanVienQuanLyController;
        private readonly string ConnectionString = "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
        //private readonly string ConnectionString= "Data Source=192.168.1.72;Initial Catalog=\"rap phim\";User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True";
        public static LichChieuDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new LichChieuDAO();
                return _instace;
            }
            private set { }
        }
        LichChieuDAO()
        {
            PhimController = PhimController.Instance;
            NhanVienQuanLyController=NhanVienQuanLyController.Instance;
        }
        public void AddDR(LichChieu lich)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
               connection.Open();
               int idPhim = PhimController.TimKiemPhim(lich.TenPhim);
               int idNVQL = NhanVienQuanLyController.TimKiemNhanVien(lich.TenNVQL);
               if(idPhim==0)
               {
                   MessageBox.Show("Phim không tồn tại");
                    return;
               }
               if(idNVQL==0)
                {
                   MessageBox.Show("Nhân viên quản lý không tồn tại");
                    return;
               }
               string query = @"INSERT INTO LichChieu (Id, IdPhim, NgayChieu, GioChieu, IdNVQL) 
                    VALUES (@id, @Idphim, @ngaychieu, @giochieu, @nvql)";
               var command = new SqlCommand(query, connection);
               command.Parameters.AddWithValue("@id", lich.Id);
               command.Parameters.AddWithValue("@Idphim",idPhim) ;
               command.Parameters.AddWithValue("@ngaychieu", lich.NgayChieu);
               command.Parameters.AddWithValue("@giochieu", lich.GioChieu);
               command.Parameters.AddWithValue("@nvql", idNVQL);
               command.ExecuteNonQuery();
            }
        }
        public void Update(LichChieu lich)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int idPhim = PhimController.TimKiemPhim(lich.TenPhim);
                int idNVQL = NhanVienQuanLyController.TimKiemNhanVien(lich.TenNVQL);
                if (idPhim == 0)
                {
                    MessageBox.Show("Phim không tồn tại");
                    return;
                }
                if (idNVQL == 0)
                {
                    MessageBox.Show("Nhân viên quản lý không tồn tại");
                    return;
                }
                string query=@"UPDATE LichChieu 
                    SET IdPhim = @phim, NgayChieu = @ngaychieu, GioChieu = @giochieu, IdNVQL = @nvql
                    WHERE Id = @id";  
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", lich.Id);
                command.Parameters.AddWithValue("@phim", idPhim);
                command.Parameters.AddWithValue("@ngaychieu", lich.NgayChieu);
                command.Parameters.AddWithValue("@giochieu", lich.GioChieu);
                command.Parameters.AddWithValue("@nvql", idNVQL);
                command.ExecuteNonQuery();
            }
        }
        public void Del(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM LichChieu WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public List<LichChieu> GetAllLichChieu(string name)
        {
            List<LichChieu> result = new List<LichChieu>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                String query = @"SELECT lc.Id,p.TenPhim,nv.Fullname,lc.NgayChieu,lc.GioChieu 
                    FROM LichChieu lc 
                    LEFT JOIN Phim p on lc.IdPhim=p.Id 
                    LEFT JOIN NhanVienQuanLy nv on nv.Id=lc.IdNVQL";
                connection.Open();
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(name=="" || reader.GetString(1).Equals(name))
                    {
                        LichChieu lich = new LichChieu
                        {
                            Id = reader.GetInt32(0),
                            TenPhim = reader.GetString(1),
                            TenNVQL = reader.GetString(2),
                            NgayChieu = reader.GetDateTime(3),
                            GioChieu = reader.GetInt32(4),
                        };
                        result.Add(lich);
                    }
                }
            }
            return result;
        }
        public List<LichChieu> GetPhongChieu(int id)
        {
            List<LichChieu> result = new List<LichChieu>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT lc.Id,p.TenPhim,nv.Fullname,lc.NgayChieu,lc.GioChieu
                    FROM LichChieu lc 
                    LEFT JOIN Phim p on lc.IdPhim=p.Id 
                    LEFT JOIN NhanVienQuanLy nv on nv.Id=lc.IdNVQL 
                    WHERE IdPhongChieu = @id";
                connection.Open();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LichChieu lich = new LichChieu
                    {
                        Id = reader.GetInt32(0),
                        TenPhim = reader.GetString(1),
                        TenNVQL = reader.GetString(2),
                        NgayChieu = reader.GetDateTime(3),
                        GioChieu = reader.GetInt32(4),
                    };
                    result.Add(lich);
                }
            }
            return result;
        }
        public List<LichChieu> GetPhimDangChieu(int IdPhongChieu)
        {
            List<LichChieu> phimdangchieu = new List<LichChieu>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"SELECT lc.Id, p.TenPhim, lc.NgayChieu, lc.GioChieu, nv.Fullname
                FROM LichChieu lc
                Inner JOIN Phim p ON p.Id=lc.IdPhim
                INNER JOIN LichChieu_PhongChieu lcpp ON lc.Id = lcpp.IdLichChieu
                INNER JOIN PhongChieu pc ON lcpp.IdPhongChieu = pc.Id
                INNER JOIN NhanVienQuanLy nv ON lc.IdNVQL = nv.Id
                WHERE pc.Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", IdPhongChieu);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    LichChieu dangchieu = new LichChieu
                    {
                        Id = reader.GetInt32(0),
                        TenPhim = reader.GetString(1),
                        NgayChieu = reader.GetDateTime(2),
                        GioChieu = reader.GetInt32(3),
                        TenNVQL= reader.GetString(4)
                    };
                    phimdangchieu.Add(dangchieu);
                }
            }
            return phimdangchieu;
        }
        public void ThemPhimDangChieu(int idLC, int idPhong)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"INSERT INTO LichChieu_PhongChieu (IdLichChieu, IdPhongChieu) VALUES (@idLC, @idPhong)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(query, idLC);
                command.Parameters.AddWithValue(query, idPhong);
                command.ExecuteNonQuery();
            }
        }
    }
}
