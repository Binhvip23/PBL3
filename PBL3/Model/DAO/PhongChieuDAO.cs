using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class PhongChieuDAO
    {
        //private readonly string Connection = "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
        private readonly string Connection= "Data Source=192.168.1.11;Initial Catalog=\"rap phim\";User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True";
        private static PhongChieuDAO _instance;
        private GheNgoiDAO gheNgoiDAO;
        public static PhongChieuDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PhongChieuDAO();
                return _instance;
            }
            private set { }
        }
        PhongChieuDAO()
        {
            gheNgoiDAO = GheNgoiDAO.Instance;
        }
        public void AddDR(PhongChieu chieu)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO PhongChieu (Id, Name, SucChua, Mota) VALUES (@id, @name, @succhua, @mota)", connection);
                command.Parameters.AddWithValue("@id", chieu.Id);
                command.Parameters.AddWithValue("@name", chieu.Name);
                command.Parameters.AddWithValue("@succhua", chieu.SucChua);
                command.Parameters.AddWithValue("@mota", chieu.Mota);
                command.ExecuteNonQuery();
                for (int i=0;i<chieu.SucChua;i++)
                {
                    gheNgoiDAO.Add(new GheNgoi { Id = i+1, trangthai = true }, chieu.Id);
                }
            }
        }
        public void Update(PhongChieu chieu)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE PhongChieu SET Name = @name, SucChua = @succhua, Mota = @mota WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", chieu.Id);
                command.Parameters.AddWithValue("@name", chieu.Name);
                command.Parameters.AddWithValue("@succhua", chieu.SucChua);
                command.Parameters.AddWithValue("@mota", chieu.Mota);
                command.ExecuteNonQuery();
                for (int i = 0; i < chieu.SucChua; i++)
                {
                    gheNgoiDAO.Del(i+1, chieu.Id);
                }
                for(int i=0;i<chieu.SucChua;i++)
                {
                    gheNgoiDAO.Add(new GheNgoi { Id = i + 1, trangthai = true }, chieu.Id);
                }
            }
        }
        public void Del(int id)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM PhongChieu WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public List<PhongChieu> GetAllPhongChieu(string name)
        {
            List<PhongChieu> results = new List<PhongChieu>();
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM PhongChieu", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(name=="" || reader.GetString(1).Equals(name))
                    {
                        results.Add(new PhongChieu
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SucChua = reader.GetInt32(2),
                            Mota = reader.IsDBNull(3) ? "" : reader.GetString(3)
                        });
                    }
                }
            }
            return results;
        }
        public List<PhongChieu> GetAllPhongChieuDangChieuPhim(int id)
        {
            List<PhongChieu> list =new List<PhongChieu>();
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                string query = @"select  PhongChieu.Id,PhongChieu.Name,PhongChieu.Succhua,PhongChieu.Mota
                    from PhongChieu 
                    INNER JOIN LichChieu_PhongChieu ON LichChieu_PhongChieu.IdPhongChieu=PhongChieu.Id
                    INNER JOIN LichChieu ON LichChieu_PhongChieu.IdLichChieu=LichChieu.Id
                    Where LichChieu.Id=@id";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PhongChieu
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        SucChua = reader.GetInt32(2),
                        Mota = reader.IsDBNull(3) ? "" : reader.GetString(3)
                    });
                }
                
            }
            return list;
        }
        public void ThemPhongChieuPhim(int idphong, int idlichchieu)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO LichChieu_PhongChieu (IdPhongChieu,IdLichChieu) VALUES (@idphong,@idlc)", connection);
                command.Parameters.AddWithValue("@idlc", idlichchieu);
                command.Parameters.AddWithValue("@idphong", idphong);
                command.ExecuteNonQuery();
            }
        }
        public void XoaPhongChieuPhim(int idPhongChieu, int idLichChieu)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM LichChieu_PhongChieu WHERE IdLichChieu = @idlc AND IdPhongChieu = @idphong", connection);
                command.Parameters.AddWithValue("@idlc", idLichChieu);
                command.Parameters.AddWithValue("@idphong", idPhongChieu);
                command.ExecuteNonQuery();
            }
        }
    }
}
