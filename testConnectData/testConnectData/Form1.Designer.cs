namespace testConnectData
{
    partial class Form1
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dssinhvien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(54, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(212, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 41);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sach sinh vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên SV";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(135, 70);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(332, 22);
            this.txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(135, 122);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(332, 22);
            this.txtTen.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(366, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 41);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dssinhvien
            // 
            this.dssinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssinhvien.Location = new System.Drawing.Point(54, 247);
            this.dssinhvien.Name = "dssinhvien";
            this.dssinhvien.RowHeadersWidth = 51;
            this.dssinhvien.RowTemplate.Height = 24;
            this.dssinhvien.Size = new System.Drawing.Size(413, 196);
            this.dssinhvien.TabIndex = 9;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 455);
            this.Controls.Add(this.dssinhvien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dssinhvien;
    }
}

