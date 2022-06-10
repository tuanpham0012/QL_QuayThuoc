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
    
    public partial class HoaDonDaBan : Form
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

        String param;String tbl; String slt;
        public HoaDonDaBan()
        {
            InitializeComponent();
        }

        private void HoaDonDaBan_Load(object sender, EventArgs e)
        {
            

            slt = "h.ID_HoaDon, h.MaHoaDon, h.NgayTao, h.ThanhTien, n.TenNhanVien, k.TenKhachHang";
            tbl = "((Hoa_Don_Da_Ban as h Left Join Nhan_Vien as n ON h.ID_NguoiDung = n.ID_NguoiDung) Left Join KhachHang as k ON h.ID_KhachHang = k.ID_KhachHang)";
            param = "Where h.ID_HoaDon > 0 Order By h.ID_HoaDon DESC";

            dataGridView_hddb.DataSource = dc.query(slt, tbl, param);

            


        }

        private void dataGridView_hddb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_hddb.Columns[e.ColumnIndex].Index.ToString() == "0")
            {
                if (e.RowIndex >= 0)
                {
                    String MaHD = dataGridView_hddb.Rows[e.RowIndex].Cells[2].Value.ToString();
                    String NgayBan = dataGridView_hddb.Rows[e.RowIndex].Cells[3].Value.ToString();
                    String tenNV = dataGridView_hddb.Rows[e.RowIndex].Cells[5].Value.ToString();
                    String tenKH = dataGridView_hddb.Rows[e.RowIndex].Cells[6].Value.ToString();


                    ChiTietHoaDon c = new ChiTietHoaDon(MaHD, NgayBan, tenNV, tenKH);
                    c.Show();
                }
            }
               
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String time = dateTimePicker1.Text;

            String start = time + " 00:00:00";
            String end = time + " 23:59:59";

            param = String.Format(" Where h.NgayTao > #{0}# and h.NgayTao < #{1}# Order By h.ID_HoaDon DESC", start, end);

            dataGridView_hddb.DataSource = dc.query(slt, tbl, param);

            //MessageBox.Show(start + " " + end);  
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReFesh_Click(object sender, EventArgs e)
        {
            HoaDonDaBan_Load(sender, e);

        }
    }
}
