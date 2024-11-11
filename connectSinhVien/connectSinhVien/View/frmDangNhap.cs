using System;
using System.Windows.Forms;
using Controller;  

namespace connectSinhVien.View
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
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

                // Kiểm tra đăng nhập
                NguoiDungController nguoiDungController = new NguoiDungController();
                if (nguoiDungController.CheckLogin(taikhoan, matkhau))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở form mới sau khi đăng nhập thành công
                    frmLop frm = new frmLop(); // Giả sử bạn có form frmLop để chuyển đến
                    frm.Show();

                    // Ẩn form đăng nhập hiện tại
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear(); // Xóa mật khẩu nếu đăng nhập không thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
          
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
