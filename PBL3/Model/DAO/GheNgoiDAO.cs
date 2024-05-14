using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.DAO
{
    internal class GheNgoiDAO
    {
        private readonly string Connection = "Data Source=192.168.1.148;Initial Catalog=\"rap phim\";User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True";
        private static GheNgoiDAO _instance;
        public static GheNgoiDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GheNgoiDAO();
                return _instance;
            }
            private set { }
        }
        public void Add(GheNgoi ghe,int IdPhong)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO GheNgoi (Id, TrangThai, IdPhong) VALUES (@id,@trangthai,@idphong)", connection);
                command.Parameters.AddWithValue("@id", ghe.Id);
                command.Parameters.AddWithValue("@trangthai", ghe.trangthai);
                command.Parameters.AddWithValue("@idphong",IdPhong);
                command.ExecuteNonQuery();
            }
        }
        public void Update(GheNgoi ghe)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE GheNgoi SET TrangThai=@trangthai WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@trangthai", ghe.trangthai);
                command.ExecuteNonQuery();
            }
        }
        public void Del(int id,int Idphong)
        {
            using (var connection = new SqlConnection(Connection))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM GheNgoi WHERE Id = @id and IdPhong=@idphong", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idphong", Idphong);
                command.ExecuteNonQuery();
            }
        }
    }
}
