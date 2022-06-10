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
    public partial class NhapHang : Form
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
        DataGridView data = new DataGridView();
        int a;
        
        public NhapHang( DataGridView dt)
        {

            InitializeComponent();
            a = dt.Rows.Count;



            for(int i = 0; i < a; i++)
            {
                DataGridViewRow row = dt.Rows[i];

                dataGridView1.Rows.Add(row.Cells[1].Value.ToString(),
                               row.Cells[2].Value.ToString(),
                               row.Cells[3].Value.ToString(),
                               row.Cells[4].Value.ToString(),
                               row.Cells[5].Value.ToString(),
                               row.Cells[6].Value.ToString(),
                               row.Cells[7].Value.ToString());
            }

        }

        private void NhapHang_Load(object sender, EventArgs e)
        {

            /*a = data.Rows.Count;


            for (int i = 0; i < a; i++)
            {
                DataGridViewRow row = data.Rows[i];

                dataGridView1.Rows.Add(row.Cells[1].Value.ToString(),
                               row.Cells[2].Value.ToString(),
                               row.Cells[3].Value.ToString(),
                               row.Cells[4].Value.ToString(),
                               row.Cells[5].Value.ToString(),
                               row.Cells[6].Value.ToString(),
                               row.Cells[7].Value.ToString(),
                               row.Cells[8].Value.ToString());
            }*/


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            

            DataTable tb = new DataTable();

            tb = dc.query("ID", "Hoa_Don_Nhap", " Where ID > 0 ORDER BY ID DESC");
            int count = int.Parse(tb.Rows[0][0].ToString());
            String MaHD = "DHN";
            if (count < 10)
            {
                MaHD += "000000" + count.ToString(); 
            }
            else if (count < 100)
            {
                MaHD += "00000" + count.ToString();
            }
            else if (count < 1000)
            {
                MaHD += "0000" + count.ToString();
            }
            else if (count < 1000)
            {
                MaHD += "000" + count.ToString();
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int SoLuong;
                String sl;

                if (dataGridView1.Rows[i].Cells[7].Value == null)
                {
                    sl = "Error";
                }
                else
                {
                    sl = dataGridView1.Rows[i].Cells[7].Value.ToString();
                }

                try
                {
                    SoLuong = int.Parse(sl);
                    if (SoLuong < 0)
                    {
                        MessageBox.Show("Số lượng sản phẩm phải >= 0! (" + dataGridView1.Rows[i].Cells[1].Value.ToString() + " )");
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi nhập số lượng sản phẩm! (" + dataGridView1.Rows[i].Cells[1].Value.ToString() + " )");
                    return;
                }

            }

            String id_nv = DungChung.ID_User.ToString();
            String time = DateTime.Now.ToString();

            /*int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            String p = String.Format("Where Month(Thang) = {0} and year(Thang) = {1}", thang, nam);
            DataTable doanhThu = dc.query("DoanhThuBanHang", "DoanhThu", p);

            int TienNhapHang = int.Parse(doanhThu.Rows[0]["DoanhThuBanHang"].ToString());*/

            /* param = String.Format("DoanhThuBanHang = {0} " + p, DoanhthuThang);

             dc.Update("DoanhThu", param);*/



            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                String id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                String SoLuongNhap = dataGridView1.Rows[i].Cells[7].Value.ToString();
                DataTable dataTable = dc.query("SoLuong", "San_Pham", "Where ID_SanPham = " + id);
                int slCon = int.Parse(dataTable.Rows[0][0].ToString()) + int.Parse(SoLuongNhap);
                

                String column = "(MaHoaDonNhap, ID_SanPham, SoLuong, ID_NguoiDung, NgayNhap)";
                String value = String.Format("('{0}', {1}, {2}, {3}, '{4}')", MaHD, id, SoLuongNhap, id_nv, time);

                dc.Insert("San_Pham_Nhap", column, value);

                String param = String.Format(" SoLuong = {0} Where ID_SanPham = {1}", slCon, id);
                dc.Update("San_Pham", param);


            }
            String columns = "(MaHoaDonNhap, NgayNhap, ID_NguoiDung)";
            String values = String.Format("('{0}', '{1}', {2})", MaHD, time, id_nv);

            dc.Insert("Hoa_Don_Nhap", columns, values);

            MessageBox.Show("Cập nhật thành công");

        }
    }
}
