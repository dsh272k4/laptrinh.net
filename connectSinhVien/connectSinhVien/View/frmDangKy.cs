using System;
using System.Windows.Forms;
using Controller; // Đảm bảo lớp NguoiDungController nằm trong namespace này
using Model;      // Đảm bảo lớp NguoiDung nằm trong namespace này

namespace connectSinhVien.View
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        // Sự kiện nút "Trở lại" để quay lại trang đăng nhập
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            // Mở form đăng nhập và đóng form đăng ký hiện tại
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Close();
        }

        // Sự kiện nút "Đăng Ký" để xử lý đăng ký tài khoản mới
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox
                string taikhoan = txtTaiKhoan.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();

                // Kiểm tra nếu tài khoản hoặc mật khẩu trống
                if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng NguoiDung mới
                NguoiDung nguoiDungMoi = new NguoiDung(taikhoan, matkhau);

                // Sử dụng NguoiDungController để thêm người dùng mới
                NguoiDungController nguoiDungController = new NguoiDungController();
                nguoiDungController.AddNguoiDung(nguoiDungMoi);

                // Hiển thị thông báo thành công
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa nội dung các trường nhập
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();

                // Trở lại form đăng nhập
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra khi đăng ký. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message); // In ra lỗi chi tiết cho mục đích debug
            }
        }
    }
}
