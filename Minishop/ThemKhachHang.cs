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
    public partial class ThemKhachHang : Form
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
        int count;
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_TenKH.Text == "" || txt_DC.Text == "" || txt_SDT.Text == "")
            {
                MessageBox.Show("Không để trống thông tin khách hàng");
                return;
            }

            String columns = "(Ma_KhachHang, TenKhachHang, DiaChi, SoDienThoai)";
            String values = String.Format("('{0}', '{1}', '{2}', {3})", lbl_MaKH.Text, txt_TenKH.Text, txt_DC.Text, txt_SDT.Text);
            dc.Insert("KhachHang", columns, values);
            MessageBox.Show("Thêm KHách Hàng Thành Công!");

            TaoDonThuoc.IDKh = count.ToString();
            TaoDonThuoc.MaKh = lbl_MaKH.Text;
            TaoDonThuoc.TenKh = txt_TenKH.Text;
            TaoDonThuoc.DcKh = txt_DC.Text;
            TaoDonThuoc.SdtKh = txt_SDT.Text;

            this.Close();

        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {


            DataTable tb = dc.query("ID_KhachHang", "KhachHang", "Where ID_KhachHang > 0 Order By ID_KhachHang DESC");
            count = int.Parse(tb.Rows[0][0].ToString()) + 1;
            String MaHD = "KH";
            if (count < 10)
            {
                MaHD += "0000" + count.ToString();
            }
            else if (count < 100)
            {
                MaHD += "000" + count.ToString();
            }
            else if (count < 1000)
            {
                MaHD += "00" + count.ToString();
            }
            else if (count < 1000)
            {
                MaHD += "0" + count.ToString();
            }

            lbl_MaKH.Text = MaHD;


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
