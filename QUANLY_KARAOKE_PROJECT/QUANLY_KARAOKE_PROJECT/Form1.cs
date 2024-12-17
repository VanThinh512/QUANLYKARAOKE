using QUANLY_KARAOKE_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_KARAOKE_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quảnLýLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyLoaiPhong frm = new FormQuanLyLoaiPhong();
            frm.Show();
        }
        private void BindGrid(List<PHONG> listPhong, List<SAN_PHAM> listSanPham)
        {
            dataGridView_Phong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dataGridView_Phong.Rows.Add();
                dataGridView_Phong.Rows[index].Cells[0].Value = item.TenPhong;
            }
            dataGridView_SanPham.Rows.Clear();
            foreach (var item in listSanPham)
            {
                int index = dataGridView_SanPham.Rows.Add();
                dataGridView_SanPham.Rows[index].Cells[0].Value = item.IDSanPham;
                dataGridView_SanPham.Rows[index].Cells[1].Value = item.TenSanPham;
                dataGridView_SanPham.Rows[index].Cells[2].Value = item.DonGia;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KaraokeContextDB context = new KaraokeContextDB();
                List<PHONG> listPhong = context.PHONGs.ToList(); //lấy các lớp
                List<SAN_PHAM> listSanPham = context.SAN_PHAM.ToList();
                BindGrid(listPhong, listSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
