using PBL3.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Model.DAO
{
    internal class PhimDAO
    {
        private readonly string ConnectionString= "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
        private static PhimDAO _instace;
        public static PhimDAO Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new PhimDAO();
                return _instace;
            }
            private set { }
        }
        public void Add(Phim phim)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Phim (Id,Tenphim, LoaiPhim, Thoiluong, Mota) 
                    VALUES (@id,@name, @loai, @thoiluong, @mota)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", phim.Id);
                command.Parameters.AddWithValue("@name", phim.Tenphim);
                command.Parameters.AddWithValue("@loai", phim.Theloai);
                command.Parameters.AddWithValue("@thoiluong", phim.Thoiluong);
                command.Parameters.AddWithValue("@mota", phim.Mota);

                command.ExecuteNonQuery();
            }

        }
        public void Update(Phim phim)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Phim SET Tenphim = @name, LoaiPhim = @loai, Thoiluong = @thoiluong, Mota = @mota WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", phim.Id);
                command.Parameters.AddWithValue("@name", phim.Tenphim);
                command.Parameters.AddWithValue("@loai", phim.Theloai);
                command.Parameters.AddWithValue("@thoiluong", phim.Thoiluong);
                command.Parameters.AddWithValue("@mota", phim.Mota);

                command.ExecuteNonQuery();
            }
        }
        public void Del(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Phim WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
        public List<Phim> GetAllPhim(string name)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Tenphim, LoaiPhim, Thoiluong, ISNULL(Mota, '') AS Mota FROM Phim", connection); // Use ISNULL for null handling

                var reader = command.ExecuteReader();
                List<Phim> result = new List<Phim>();
                while (reader.Read())
                {
                    if (name=="" || reader.GetString(1).Equals(name))
                    {
                        result.Add(new Phim
                        {
                            Id = reader.GetInt32(0),
                            Tenphim = reader.GetString(1),
                            Theloai = reader.GetString(2),
                            Thoiluong = reader.GetInt32(3),
                            Mota = reader.IsDBNull(4) ? string.Empty : reader.GetString(4) // Check for null using IsDBNull
                        });
                    }
                }
                return result;
            }
        }
    }
}
