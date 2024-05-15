using System;
using System.Collections.Generic;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;

namespace PBL3.Model.DAO
{
    internal class NhanVienQuanLyDAO
    {
        TaiKhoanDAO taiKhoanDAO;
        private readonly string ConnectionString = "Data Source=MSI;Initial Catalog=\"rap phim\";Integrated Security=True";
        //private readonly string ConnectionString = "Data Source=192.168.1.148;Initial Catalog=\"rap phim\";User ID=sa;Password=VeryStr0ngP@ssw0rd;Trust Server Certificate=True";
        private static NhanVienQuanLyDAO instance;
        private NhanVienQuanLyDAO() 
        {
            taiKhoanDAO = TaiKhoanDAO.Instance;
        }
        public static NhanVienQuanLyDAO Instance
        {
            get
            {
                if (instance == null) instance = new NhanVienQuanLyDAO();
                return instance;
            }
            private set { instance = value; }
        }
        /*get all the employees in the database*/
        public List<NVQL> GetAllNVQL()
        {
            using (var connection =new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM NhanVienQuanLy", connection);
                var reader = command.ExecuteReader();
                var result = new List<NVQL>();
                while (reader.Read())
                {
                    var nvql = new NVQL
                    {
                        Id = reader.GetInt32(0),
                        Fullname = reader.GetString(1),
                        SoDT = reader.GetString(2),
                        Email = reader.GetString(3),
                        Vaitro = reader.GetString(4),
                        Active = reader.GetBoolean(5),
                        TenTK = reader.GetString(6)
                    };
                    result.Add(nvql);
                }
                return result;
            }
        }
        /*delete an employee in the database*/
        public void DeleteNVQL(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM NhanVienQuanLy WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        /*update an employee in the database*/
        public void UpdateNVQL(NVQL nVQL)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE NhanVienQuanLy SET Fullname = @ten, SoDt = @sdt, Email = @email, Vaitro = @vaitro, Active = @active WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", nVQL.Id);
                command.Parameters.AddWithValue("@ten", nVQL.Fullname);
                command.Parameters.AddWithValue("@sdt", nVQL.SoDT);
                command.Parameters.AddWithValue("@email", nVQL.Email);
                command.Parameters.AddWithValue("@vaitro", nVQL.Vaitro);
                command.Parameters.AddWithValue("@active", nVQL.Active);
                command.ExecuteNonQuery();
            }
        }
        /*add an employee to the database*/
        public void AddNVQL(NVQL nVQL)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO NhanVienQuanLy VALUES(@id, @ten, @sdt, @email, @vaitro, @active, @tentk)", connection);
                command.Parameters.AddWithValue("@id", nVQL.Id);
                command.Parameters.AddWithValue("@ten", nVQL.Fullname);
                command.Parameters.AddWithValue("@sdt", nVQL.SoDT);
                command.Parameters.AddWithValue("@email", nVQL.Email);
                command.Parameters.AddWithValue("@vaitro", nVQL.Vaitro);
                command.Parameters.AddWithValue("@active", nVQL.Active);
                command.Parameters.AddWithValue("@tentk", nVQL.TenTK);
                command.ExecuteNonQuery();
            }
        }
        /*get the employee with the given id*/
        public NVQL GetNVQL(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM NhanVienQuanLy WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new NVQL
                    {
                        Id = reader.GetInt32(0),
                        Fullname = reader.GetString(1),
                        SoDT = reader.GetString(2),
                        Email = reader.GetString(3),
                        Vaitro = reader.GetString(4),
                        Active = reader.GetBoolean(5),
                        TenTK = reader.GetString(6)
                    };
                }
                return null;
            }
        }
    }
}
