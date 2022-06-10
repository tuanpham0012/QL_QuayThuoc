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
    public partial class HoaDonNhap : Form
    {
        // ẩn 
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

        String tbl;String table;String param = "";

        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            tbl = " h.MaHoaDonNhap, h.NgayNhap, n.TenNhanVien";
            table = "Hoa_Don_Nhap as h Left Join Nhan_Vien as n ON h.ID_NguoiDung = n.ID_NguoiDung";

            dataGridView1.DataSource = dc.query(tbl, table, param);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( dataGridView1.Columns[e.ColumnIndex].Index.ToString() == "1")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    String MaHD = row.Cells[2].Value.ToString();

                    String s = "s.TenSP, s.LoaiSP, s.GiaBan, n.SoLuong";
                    String t = "San_Pham_Nhap as n Left Join San_Pham s ON n.ID_SanPham = s.ID_SanPham";
                    String p = String.Format(" Where n.MaHoaDonNhap like '{0}'", MaHD);

                    dataGridView2.DataSource = dc.query(s, t, p);
                    //MessageBox.Show(MaHD);
                }
            }
            
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
