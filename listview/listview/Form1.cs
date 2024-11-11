using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi=lvSanPham.SelectedItems[0];
                string ma=lvi.SubItems[0].Text;
                string ten =lvi.SubItems[1].Text;
                string gia=lvi.SubItems[2].Text;
                txtMa.Text = ma;
                txtTen.Text = ten;
                txtGia.Text = gia;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtMa.Text);
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(txtGia.Text);
            lvSanPham.Items.Add(item);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item=lvSanPham.SelectedItems[0];
                item.SubItems[0].Text = txtMa.Text;
                item.SubItems [1].Text = txtTen.Text;
                item.SubItems[2].Text = txtGia.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0) { 
                lvSanPham.Items.Remove(lvSanPham.SelectedItems [0]);
            }
            else
            {
                MessageBox.Show("ban chua chon dong de xoa");
            }
        }
    }
}
