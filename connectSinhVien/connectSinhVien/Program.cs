using connectSinhVien.View;
using System;
using System.Windows.Forms;

namespace connectSinhVien
{
    internal static class Program
    {
        /// <summary>
        /// Điểm vào chính cho ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Đặt kiểu giao diện Windows cho ứng dụng
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap()); // Khởi chạy form đăng nhập
        }
    }
}
