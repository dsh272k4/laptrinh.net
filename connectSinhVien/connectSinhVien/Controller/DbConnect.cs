using System;
using System.Data.SqlClient;

namespace Controller
{
    public class DbConnect
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            try
            {
                string connectionString = "Server=DUONG2724;Database=quanlysinhvien;User Id=sa;Password=dsh272k4;TrustServerCertificate=True;";
                conn = new SqlConnection(connectionString);
                conn.Open();
                Console.WriteLine("Kết nối thành công");
            }
            catch (Exception e)
            {
                Console.WriteLine("Không thể kết nối đến cơ sở dữ liệu: " + e.Message);
                throw new Exception("Không thể kết nối đến cơ sở dữ liệu: " + e.Message);
            }
            return conn;
        }
    }
}
