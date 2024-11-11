using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;

namespace Controller
{
    public class NguoiDungController
    {
        private SqlConnection conn;

        public NguoiDungController()
        {
            conn = new DbConnect().GetConnection();
        }

        // Phương thức kiểm tra đăng nhập
        public bool CheckLogin(string taikhoan, string matkhau)
        {
            string query = "SELECT * FROM nguoidung WHERE taikhoan=@taikhoan AND matkhau=@matkhau";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                    cmd.Parameters.AddWithValue("@matkhau", matkhau);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows; // Trả về true nếu người dùng tồn tại
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Có lỗi xảy ra: " + e.Message);
                return false;
            }
        }

        // Phương thức lấy danh sách tất cả người dùng
        public List<NguoiDung> GetAllNguoiDung()
        {
            List<NguoiDung> lst = new List<NguoiDung>();
            string query = "SELECT * FROM nguoidung";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NguoiDung obj = new NguoiDung(reader);
                        lst.Add(obj);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Có lỗi xảy ra khi lấy dữ liệu: " + e.Message);
                throw new Exception("Có lỗi xảy ra khi lấy dữ liệu: " + e.Message);
            }
            return lst;
        }

        // Phương thức thêm người dùng mới
        public void AddNguoiDung(NguoiDung nguoiDung)
        {
            string query = "INSERT INTO nguoidung (taikhoan, matkhau) VALUES (@taikhoan, @matkhau)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taikhoan", nguoiDung.TaiKhoan);
                    cmd.Parameters.AddWithValue("@matkhau", nguoiDung.MatKhau);

                    int rowsInserted = cmd.ExecuteNonQuery(); // Kiểm tra số dòng được thêm
                    if (rowsInserted > 0)
                    {
                        Console.WriteLine("Đăng ký thành công. Người dùng đã được thêm vào cơ sở dữ liệu.");
                    }
                    else
                    {
                        Console.WriteLine("Đăng ký thất bại. Không có dòng nào được thêm.");
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Có lỗi xảy ra khi tạo tài khoản: " + e.Message);
                throw new Exception("Có lỗi xảy ra khi tạo tài khoản: " + e.Message);
            }
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            try
            {
                if (conn != null && conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Có lỗi xảy ra khi đóng kết nối: " + e.Message);
            }
        }
    }
}
