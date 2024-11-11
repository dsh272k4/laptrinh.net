using System;
using System.Data.SqlClient;

namespace Model
{
    public class NguoiDung
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public NguoiDung() { }

        public NguoiDung(string taikhoan, string matkhau)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
        }

        public NguoiDung(SqlDataReader reader)
        {
            TaiKhoan = reader["taikhoan"].ToString();
            MatKhau = reader["matkhau"].ToString();
        }
    }
}
