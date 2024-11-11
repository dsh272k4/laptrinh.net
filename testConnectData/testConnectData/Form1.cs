using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace testConnectData
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["qlsinhvien"].ConnectionString;
            conn = new SqlConnection(conString);
            conn.Open();
            hienthi();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void hienthi()
        {
            try
            {
                string sqlSELECT = "SELECT * FROM tblSV";
                SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dssinhvien.DataSource = dt;
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = "INSERT INTO tblSV VALUES(@masv, @tensv)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("@masv", txtMa.Text);
                cmd.Parameters.AddWithValue("@tensv", txtTen.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUPDATE = "UPDATE tblSV SET tensv = @tensv WHERE masv = @masv";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
                cmd.Parameters.AddWithValue("@masv", txtMa.Text);
                cmd.Parameters.AddWithValue("@tensv", txtTen.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDELETE = "DELETE FROM tblSV WHERE masv = @masv";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("@masv", txtMa.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }

        
    }
}
