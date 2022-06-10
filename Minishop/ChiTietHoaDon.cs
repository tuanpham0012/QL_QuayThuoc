using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minishop
{
    
    public partial class ChiTietHoaDon : Form
    {
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        DungChung dc = new DungChung();
        String MaHD = "", NgayBan = "", TenNV = "", TenKH = "";

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        public ChiTietHoaDon(String MaHD, String NgayBan,  String TenNV, String TenKH)
        {
            InitializeComponent();
            this.MaHD = MaHD;
            this.NgayBan = NgayBan;
            this.TenNV = TenNV;
            this.TenKH = TenKH;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            label1.Text = "Hóa Đơn Mã: " + MaHD;
            label3.Text = "Thời gian bán: " + String.Format("{0:dd/MM/yyyy HH:mm:ss}", NgayBan);
            label2.Text = "Người bán: " + TenNV;
            lbl_KH.Text = "Khách hàng: " + TenKH;
   

            String slt = "s.TenSP, s.MaSP, s.LoaiSP, s.GiaBan, s.Discount, s.DonVi, b.SoLuong";
            String tbl = "San_Pham_Da_Ban as b Left Join San_Pham as s ON b.ID_SanPham = s.ID_SanPham";
            String param = String.Format("Where b.MaHoaDon = '{0}'", MaHD);


            dataGridView_CTHD.DataSource = dc.query(slt, tbl, param);

          
        }

    }
}
