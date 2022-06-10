using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Minishop
{
    public partial class TaoDonThuoc : Form
    {
        public static string IDKh = string.Empty;
        public static string TenKh = string.Empty;
        public static string MaKh = string.Empty;
        public static string DcKh = string.Empty;
        public static string SdtKh = string.Empty;

        DungChung dc = new DungChung();
        
        public TaoDonThuoc()
        {
            InitializeComponent();
        }
        public TaoDonThuoc( String a)
        {
            InitializeComponent();
            lbl_MKH.Text = a;
        }


        void deleted_donhang()
        {   
            String param = String.Format("Where ID_NguoiDung = {0}", DungChung.ID_User);

            dc.Delete("Don_Hang", param);

        }


        private void thêmSửaXóaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DoiMatKhau dn = new DoiMatKhau();
            //this.Hide();
            dn.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DungChung.ID_Role = -99;
            DungChung.DSChucNang = null;
            this.Close();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        

        private void SanPham_Load(object sender, EventArgs e)
        {
            // mnuTaiKhoan.Enabled = (DungChung.DSChucNang.IndexOf("mnuTaiKhoan") > -1);
            mnuDangXuat.Enabled = (DungChung.DSChucNang.IndexOf("mnuDangXuat") > -1);
            mnuDoiMatKhau.Enabled = (DungChung.DSChucNang.IndexOf("mnuDoiMatKhau") > -1);


            //mnuTaoHoaDon.Enabled = (DungChung.DSChucNang.IndexOf("mnuTaoHoaDon") > -1);

            mnuThongKe.Enabled = (DungChung.DSChucNang.IndexOf("mnuThongKe") > -1);
            mnuHoaDonNhap.Enabled = (DungChung.DSChucNang.IndexOf("mnuHoaDonNhap") > -1);
            mnuHoaDonDaBan.Enabled = (DungChung.DSChucNang.IndexOf("mnuHoaDonDaBan") > -1);
            mnuSanPhamSapHet.Enabled = (DungChung.DSChucNang.IndexOf("mnuSanPhamSapHet") > -1);

            mnuNghiepVu.Enabled = (DungChung.DSChucNang.IndexOf("mnuNghiepVu") > -1);
            mnuQLSanPham.Enabled = (DungChung.DSChucNang.IndexOf("mnuQLSanPham") > -1);
            mnuQLNhanVien.Enabled = (DungChung.DSChucNang.IndexOf("mnuQLNhanVien") > -1);


            int tongTien = 0;


            dataGridView_SanPham.DataSource = dc.query("*", "San_Pham", "");

            String slt = "s.TenSP, s.MaSP, s.LoaiSP, s.GiaBan, s.Discount, s.DonVi, d.ID_DonHang, d.ID_SanPham, d.SoLuong, d.TongGia";
            String tbl = "Don_Hang as d Left Join San_Pham as s ON d.ID_SanPham = s.ID_SanPham";
            String param = String.Format("Where d.ID_NguoiDung = {0}", DungChung.ID_User);

            dataGridView_DonHang.DataSource = dc.query(slt, tbl, param);

            int count = dataGridView_DonHang.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                tongTien += int.Parse(dataGridView_DonHang.Rows[i].Cells[11].Value.ToString());
            }

            lblTien.Text = String.Format("{0:#,##0}", tongTien) + " đ ";
            lbl_username.Text = DungChung.User_name +"( " + DungChung.Role_name + ")";

        }

        private void dataGridView_SanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_SanPham.Rows[e.RowIndex];
                
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            String param = String.Format("Where TenSP like '%{0}%' or MaSP like '%{0}%' or LoaiSP like '%{0}%' or DonVi like '%{0}%'", txtTimKiem.Text);


            dataGridView_SanPham.DataSource = dc.query("*", "San_Pham", param);

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_SanPham.Columns[e.ColumnIndex].Index.ToString() == "0")
            {
                if (e.RowIndex >= 0)
                {
                    int SoLuong = 0;
                    
                    DataGridViewRow row_sp = this.dataGridView_SanPham.Rows[e.RowIndex];

                    String ID_SP = row_sp.Cells[1].Value.ToString();
                    String id_user = DungChung.ID_User.ToString();
                    int TongGia = int.Parse(row_sp.Cells[5].Value.ToString()) - int.Parse(row_sp.Cells[6].Value.ToString());

                    int SL = int.Parse(row_sp.Cells[8].Value.ToString());

                    if (SL == 0)
                    {
                        MessageBox.Show("Sản phẩm tạm thời hết hàng!!");
                        return;
                    }

                    String param = String.Format("Where ID_SanPham = {0} and ID_NguoiDung = {1}", ID_SP, DungChung.ID_User);
                    DataTable td = dc.query("*", "Don_Hang", param);


                    if (td.Rows.Count > 0)
                    {
                        MessageBox.Show("Sản Phẩm đã nằm trong giỏ hàng!");

                    }
                    else
                    {
                        SoLuong++;
                        String Columns = "(ID_SanPham, SoLuong, TongGia, ID_NguoiDung)";
                        String Values = String.Format("({0}, {1}, {2}, {3})", ID_SP, SoLuong, TongGia, id_user);

                        dc.Insert("Don_Hang", Columns, Values);


                    }


                    SanPham_Load(sender, e);



                    /*string msg = dataGridView_SanPham.Rows[e.RowIndex].Cells[0].Value.ToString() + " - "     //sửa
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[1].Value.ToString() + " - "     // xóa
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[2].Value.ToString() + " - "     //TÊN SP
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[3].Value.ToString() + " - "     // MÃ SP
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[4].Value.ToString() + " - "     // loại sp
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[5].Value.ToString() + " - "     // giá sp
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[6].Value.ToString() + " - "     //giảm giá sp
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[7].Value.ToString() + " - "     // đơn vị
                            + dataGridView_SanPham.Rows[e.RowIndex].Cells[8].Value.ToString() + " - "     // id_donHang
                            ;       // tong tien
                    MessageBox.Show(msg);*/
                }
            }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id_sp = dataGridView_DonHang.Rows[e.RowIndex].Cells[9].Value.ToString();

            String slt = "s.SoLuong, d.SoLuong";
            String tbl = "Don_Hang d Left Join San_Pham s ON d.ID_SanPham = s.ID_SanPham";
            String param = String.Format("Where d.ID_SanPham = {0}", id_sp);

            DataTable tb_donHang = dc.query(slt, tbl, param);

            int soluong_sp = int.Parse(tb_donHang.Rows[0][0].ToString());

            String action = this.dataGridView_DonHang.Columns[e.ColumnIndex].Index.ToString();
            String id_donhang = dataGridView_DonHang.Rows[e.RowIndex].Cells[8].Value.ToString();


            if (action == "0")
            {
                int soluong;
                String result = "def";

                while (result != "")
                {
                    result = Interaction.InputBox("Nhập Số lượng", "sửa số lượng", dataGridView_DonHang.Rows[e.RowIndex].Cells[10].Value.ToString());

                    if (result != "")
                    {
                        try
                        {
                            soluong = int.Parse(result);

                            if (soluong < 0)
                            {
                                MessageBox.Show("Số lượng phải > 0!!");
                                continue;
                            }
                            if (soluong == 0)
                            {
                                result = "";
                                action = "1";
                                continue;
                            }
                            if (soluong > soluong_sp)
                            {
                                MessageBox.Show("Số lượng sản phẩm trong kho không đủ ( sl còn " + soluong_sp + " )!!");
                                continue;
                            }


                            int tongGia = soluong * int.Parse(dataGridView_DonHang.Rows[e.RowIndex].Cells[5].Value.ToString()) - soluong * int.Parse(dataGridView_DonHang.Rows[e.RowIndex].Cells[6].Value.ToString());

                            param = String.Format("SoLuong = {0}, TongGia = {1} Where Id_DonHang = {2}", soluong, tongGia, id_donhang);

                            dc.Update("Don_Hang", param);


                            MessageBox.Show("Cập nhật thành công");
                            break;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("vui lòng nhập số!!");
                        }
                    }


                }

                SanPham_Load(sender, e);


            }

            if (action == "1")


            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result.Equals(DialogResult.OK))
                {
                    param = String.Format("Where ID_DonHang = {0}", id_donhang);

                    dc.Delete("Don_Hang", param);

                    SanPham_Load(sender, e);
                }


            }

            /*string msg = dataGridView_DonHang.Rows[e.RowIndex].Cells[0].Value.ToString() + " - "     //sửa
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[1].Value.ToString() + " - "     // xóa
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[2].Value.ToString() + " - "     //TÊN SP
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[3].Value.ToString() + " - "     // MÃ SP
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[4].Value.ToString() + " - "     // loại sp
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[5].Value.ToString() + " - "     // giá sp
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[6].Value.ToString() + " - "     //giảm giá sp
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[7].Value.ToString() + " - "     // đơn vị
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[8].Value.ToString() + " - "     // id_donHang
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[9].Value.ToString() + " - "     // id_sp
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[10].Value.ToString() + " - "     // soluong trong don hang
                        + dataGridView_DonHang.Rows[e.RowIndex].Cells[11].Value.ToString() + " - ";       // tong tien

            String action = this.dataGridView_DonHang.Columns[e.ColumnIndex].Index.ToString();

            MessageBox.Show(msg + action);*/

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (IDKh == "")
            {
                MessageBox.Show("Chưa có khách hàng!");
                return;
            }

            String param = String.Format("Where ID_NguoiDung = {0}", DungChung.ID_User);

            DataTable tb_thanhToan = dc.query("*", "Don_Hang", param);


            if (tb_thanhToan.Rows.Count == 0)
            {
                MessageBox.Show("Hóa Đơn Trống!!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IDKh == "") 
            {
                MessageBox.Show("Vui lòng chọn thông tin khách hàng!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán hóa đơn này không?", "Thanh Toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.OK))
            {
                DataTable tb = dc.query("ID_HoaDon", "Hoa_Don_Da_Ban", "Where ID_HoaDon > 0 Order By ID_HoaDon DESC");
                int count = int.Parse(tb.Rows[0][0].ToString()) + 1;
                String MaHD = "HDB";
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


                int TongGiaDonHang = 0;
                String id_sp;
                String SoLuong;

                for (int i = 0; i < tb_thanhToan.Rows.Count; i++)
                {
                    id_sp = tb_thanhToan.Rows[i]["ID_SanPham"].ToString();
                    SoLuong = tb_thanhToan.Rows[i]["SoLuong"].ToString();
                    TongGiaDonHang += int.Parse(tb_thanhToan.Rows[i]["TongGia"].ToString());

                    String Columns = "(MaHoaDon, ID_SanPham, SoLuong, NgayBan, ID_NguoiDung)";
                    String Values = String.Format("('{0}', {1}, {2}, '{3}', {4})", MaHD, id_sp, SoLuong, dateTimePicker1.Value.ToString(), DungChung.ID_User);

                    dc.Insert("San_Pham_Da_Ban", Columns, Values);

                    param = String.Format("where ID_SanPham = {0}", id_sp);

                    DataTable tb_sp = dc.query("SoLuong", "San_Pham", param);

                    int sl = int.Parse(tb_sp.Rows[0]["SoLuong"].ToString()) - int.Parse(SoLuong);

                    param = String.Format("SoLuong = {0} Where ID_SanPham = {1}", sl, id_sp);
                    dc.Update("San_Pham", param);
                }
                String Column = "(MaHoaDon, NgayTao, ID_NguoiDung, ID_KhachHang, ThanhTien)";
                String Value = String.Format("('{0}', '{1}', {2}, {3}, {4})", MaHD, dateTimePicker1.Value.ToString(), DungChung.ID_User, IDKh, TongGiaDonHang);

                dc.Insert("Hoa_Don_Da_Ban", Column, Value);

                int thang = DateTime.Now.Month;
                int nam = DateTime.Now.Year;
                String p = String.Format("Where Month(Thang) = {0} and year(Thang) = {1}", thang, nam);
                DataTable doanhThu = dc.query("DoanhThuBanHang", "DoanhThu", p);

                int DoanhthuThang = int.Parse(doanhThu.Rows[0]["DoanhThuBanHang"].ToString()) + TongGiaDonHang;

                param = String.Format("DoanhThuBanHang = {0} " + p, DoanhthuThang);

                dc.Update("DoanhThu", param);

                MessageBox.Show("Thanh Toán Thành Công!");

                deleted_donhang();

                SanPham_Load(sender, e);

            }
            //MessageBox.Show(tb.Rows[0]["s.SoLuong"].ToString() + " " + tb.Rows[0]["d.SoLuong"].ToString());
            //MessageBox.Show(MaDonHang.ToString());
        }

        private void Destroy_DH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy đơn thuốc không??", "Delete Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {
                deleted_donhang();

                MessageBox.Show("Xóa Đơn Hàng Thành Công!!");

                SanPham_Load(sender, e);
            }
            else
            {
                return;
            }
            
        }

        private void btn_refeshh_Click(object sender, EventArgs e)
        {
            SanPham_Load(sender, e);
            txtTimKiem.Text = null;
            
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonDaBan hd = new HoaDonDaBan();
            hd.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPhamSapHet sp = new SanPhamSapHet();
            sp.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QLSanPham ql = new QLSanPham();
            ql.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonNhap hd = new HoaDonNhap();
            hd.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cb_KHnew_Click(object sender, EventArgs e)
        {
            ThemKhachHang themKhachHang = new ThemKhachHang();
            themKhachHang.ShowDialog();
            if (!string.IsNullOrEmpty(TenKh) && !string.IsNullOrEmpty(MaKh) && !string.IsNullOrEmpty(DcKh))
            {
                this.lbl_MKH.Text = MaKh;
                this.lbl_name.Text = TenKh;
                this.lbl_DC.Text = DcKh;
                this.lbl_Sdt.Text = SdtKh;
            }
        }

        private void ds_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHang ts = new KhachHang();
            ts.ShowDialog();
            if (!string.IsNullOrEmpty(TenKh) && !string.IsNullOrEmpty(MaKh) && !string.IsNullOrEmpty(DcKh))
            {
                this.lbl_MKH.Text = MaKh;
                this.lbl_name.Text = TenKh;
                this.lbl_DC.Text = DcKh;
                this.lbl_Sdt.Text = SdtKh;
            }
        }

        private void mnuQLSanPham_Click(object sender, EventArgs e)
        {
            QLSanPham ql = new QLSanPham();
            ql.Show();
        }

        private void mnuQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien ql = new QLNhanVien();
            ql.Show();
        }

        private void lblTien_Click(object sender, EventArgs e)
        {

        }
    }
}
