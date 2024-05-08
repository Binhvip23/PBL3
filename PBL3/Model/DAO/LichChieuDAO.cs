using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class LichChieuDAO
    {
        private static LichChieuDAO _instace;
        private readonly string ConnectionString= "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
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
        public void AddDR(LichChieu lich)
        {
            /*insert a LichChieu object into database*/
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand("INSERT INTO LichChieu (Id, Phim, NgayChieu, GioChieu, IdNVQL) VALUES (@id, @phim, @ngaychieu, @giochieu, @nvql)", connection);
                command.Parameters.AddWithValue("@id", lich.Id);
                command.Parameters.AddWithValue("@phim", lich.Phim.Tenphim);
                command.Parameters.AddWithValue("@ngaychieu", lich.NgayChieu);
                command.Parameters.AddWithValue("@giochieu", lich.GioChieu);
                command.Parameters.AddWithValue("@nvql", lich.NVQL.Id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(LichChieu lich)
        {
            /*update a row in database*/
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand("UPDATE LichChieu SET Phim = @phim, NgayChieu = @ngaychieu, GioChieu = @giochieu, IdNVQL = @nvql WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", lich.Id);
                command.Parameters.AddWithValue("@phim", lich.Phim.Tenphim);
                command.Parameters.AddWithValue("@ngaychieu", lich.NgayChieu);
                command.Parameters.AddWithValue("@giochieu", lich.GioChieu);
                command.Parameters.AddWithValue("@nvql", lich.NVQL.Id);
                command.ExecuteNonQuery();
            }
        }
        /*del a row in database*/
        public void Del(int id)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand("DELETE FROM LichChieu WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public List<LichChieu> GetAllLichChieu()
        {
            List<LichChieu> result = new List<LichChieu>();
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                String query = "select lc.Id,p.TenPhim,nv.Fullname,lc.NgayChieu,lc.GioChieu from LichChieu lc LEFt join Phim p on lc.IdPhim=p.Id left join NhanVienQuanLy nv on nv.Id=lc.IdNVQL";
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LichChieu lich = new LichChieu
                    {
                        Id = reader.GetInt32(0),
                        Phim = new Phim { Tenphim = reader.GetString(1) },
                        NVQL = new NVQL { Fullname = reader.GetString(2) },
                        NgayChieu = reader.GetDateTime(3),
                        GioChieu = reader.GetInt32(4),
                    };
                    result.Add(lich);
                }
            }
            return result;
        }
        public List<LichChieu> GetPhongChieu(int id)
        {
            List<LichChieu> result = new List<LichChieu>();
            using (var connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                string query = "select lc.Id,p.TenPhim,nv.Fullname,lc.NgayChieu,lc.GioChieu from LichChieu lc LEFt join Phim p on lc.IdPhim=p.Id left join NhanVienQuanLy nv on nv.Id=lc.IdNVQL WHERE IdPhongChieu = @id";
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LichChieu lich = new LichChieu
                    {
                        Id = reader.GetInt32(0),
                        Phim = new Phim { Tenphim = reader.GetString(1) },
                        NVQL = new NVQL{ Fullname = reader.GetString(2) },
                        NgayChieu = reader.GetDateTime(3),
                        GioChieu = reader.GetInt32(4),
                    };
                    result.Add(lich);
                }
            }
            return result;
        }
    }
}
