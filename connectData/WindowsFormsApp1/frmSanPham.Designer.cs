namespace QLBH
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtMoTaChiTiet = new System.Windows.Forms.TextBox();
            this.txtMoTaNgan = new System.Windows.Forms.TextBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(6, 58);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(654, 492);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(125, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(426, 20);
            this.txtTimKiem.TabIndex = 11;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(585, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiSP);
            this.groupBox1.Controls.Add(this.txtMoTaChiTiet);
            this.groupBox1.Controls.Add(this.txtMoTaNgan);
            this.groupBox1.Controls.Add(this.txtHinhAnh);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 464);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(100, 328);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(201, 21);
            this.cmbLoaiSP.TabIndex = 11;
            // 
            // txtMoTaChiTiet
            // 
            this.txtMoTaChiTiet.Location = new System.Drawing.Point(100, 219);
            this.txtMoTaChiTiet.Multiline = true;
            this.txtMoTaChiTiet.Name = "txtMoTaChiTiet";
            this.txtMoTaChiTiet.Size = new System.Drawing.Size(201, 92);
            this.txtMoTaChiTiet.TabIndex = 5;
            // 
            // txtMoTaNgan
            // 
            this.txtMoTaNgan.Location = new System.Drawing.Point(100, 183);
            this.txtMoTaNgan.Name = "txtMoTaNgan";
            this.txtMoTaNgan.Size = new System.Drawing.Size(201, 20);
            this.txtMoTaNgan.TabIndex = 4;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(100, 147);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(201, 20);
            this.txtHinhAnh.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(100, 109);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(201, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(100, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(201, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(100, 28);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Loại SP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mô tả chi tiết:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mô tả ngắn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hình ảnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã SP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 556);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Location = new System.Drawing.Point(12, 482);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(245, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(172, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(92, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(11, 36);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoTaChiTiet;
        private System.Windows.Forms.TextBox txtMoTaNgan;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
    }
}