using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minishop
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TaoDonThuoc sp = new TaoDonThuoc();
            this.Hide();
            sp.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonNhap hd = new HoaDonNhap();
            hd.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            HoaDonDaBan hd = new HoaDonDaBan();
            hd.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SanPhamSapHet sp = new SanPhamSapHet();
            sp.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DungChung.ID_Role = -99;
            DungChung.DSChucNang = null;
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
           // mnuTaiKhoan.Enabled = (DungChung.DSChucNang.IndexOf("mnuTaiKhoan") > -1);
            mnuDangXuat.Enabled = (DungChung.DSChucNang.IndexOf("mnuDangXuat") > -1);
            mnuDoiMatKhau.Enabled = (DungChung.DSChucNang.IndexOf("mnuDoiMatKhau") > -1);


            mnuTaoHoaDon.Enabled = (DungChung.DSChucNang.IndexOf("mnuTaoHoaDon") > -1);

            mnuThongKe.Enabled = (DungChung.DSChucNang.IndexOf("mnuThongKe") > -1);
            mnuHoaDonNhap.Enabled = (DungChung.DSChucNang.IndexOf("mnuHoaDonNhap") > -1);
            mnuHoaDonDaBan.Enabled = (DungChung.DSChucNang.IndexOf("mnuHoaDonDaBan") > -1);
            mnuSanPhamSapHet.Enabled = (DungChung.DSChucNang.IndexOf("mnuSanPhamSapHet") > -1);

            mnuNghiepVu.Enabled = (DungChung.DSChucNang.IndexOf("mnuNghiepVu") > -1);
            mnuQLSanPham.Enabled = (DungChung.DSChucNang.IndexOf("mnuQLSanPham") > -1);
            mnuQLNhanVien.Enabled = (DungChung.DSChucNang.IndexOf("mnuQLNhanVien") > -1);
           
        }

        private void mnuQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien ql = new QLNhanVien();
            ql.Show();
        }

        private void mnuQLSanPham_Click(object sender, EventArgs e)
        {
            QLSanPham ql = new QLSanPham();
            ql.Show();
        }
    }
}
