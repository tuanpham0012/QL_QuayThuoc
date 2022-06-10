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
    public partial class QLNhanVien : Form
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

        String slt;String table;String param;

        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void ThemData_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMail.Text == "" || cb_GT.Text == "")
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                DataTable tb = dc.query("ID_NguoiDung", "Nhan_Vien", "Where ID_NguoiDung > 0 Order By ID_NguoiDung DESC");
                int count = int.Parse(tb.Rows[0][0].ToString()) + 1;
                String MaHD = "NV";
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

                
                String tbl = "Nhan_Vien";
                String columns = "(MaNV, TenNhanVien, Email, MatKhau, GioiTinh, NgaySinh, DiaChi, Luong, ID_RoLe, ID_TrangThai)";
                String values = String.Format("('{0}', '{1}', '{2}', '1', '{3}', '{4}', '{5}', {6}, {7}, {8})", MaHD, txtName.Text, txtMail.Text, cb_GT.Text, dateTime.Text, txtDiaChi.Text, txtLuong.Text, cb_ChucVu.SelectedValue.ToString(), cb_trangthai.SelectedValue.ToString());

                dc.Insert(tbl, columns, values);

                /*String sql = String.Format("INSERT INTO Nhan_Vien (TenNhanVien, Email, MatKhau, GioiTinh, NgaySinh, DiaChi, Luong, ID_RoLe) VALUES ('{0}', '{1}', '1', {2}, '{3}', '{4}', {5}, {6})", txtName.Text, txtMail.Text, txtGT.Text, dateTime.Text, txtDiaChi.Text, txtLuong.Text, txtChucVu.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();*/
                MessageBox.Show("Thêm Nhân Viên Thành Công");


                QLNhanVien_Load(sender, e);

            }
            
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            slt = "n.*, r.Role, t.TrangThai";
            table = "((Nhan_Vien n Left Join Roles r ON n.ID_Role = r.ID_Role ) Left Join TrangThai t ON n.ID_TrangThai = t.ID_TrangThai)";
            param = "";



            dataGridView_NV.DataSource = dc.query(slt, table, param);

            DataTable GioiTinh = dc.query("*", "GioiTinh", "");
            DataTable ChucVu = dc.query("*", "Roles", "");
            DataTable TrangThai = dc.query("*", "TrangThai", "");

            cb_ChucVu.DisplayMember = "Role";
            cb_ChucVu.ValueMember = "ID_Role";
            cb_ChucVu.DataSource = ChucVu;

            cb_GT.DisplayMember = "GioiTinh";
            cb_GT.ValueMember = "ID_GioiTinh";
            cb_GT.DataSource = GioiTinh;

            cb_trangthai.DisplayMember = "TrangThai";
            cb_trangthai.ValueMember = "ID_TrangThai";
            cb_trangthai.DataSource = TrangThai;


        }

        private void dataGridView_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_NV.Rows[e.RowIndex];

                lbl_MaNV.Text = row.Cells[1].Value.ToString();
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtMail.Text = row.Cells[3].Value.ToString();
                cb_GT.Text = row.Cells[5].Value.ToString();
                dateTime.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                txtDiaChi.Text = row.Cells[7].Value.ToString();
                txtLuong.Text = row.Cells[8].Value.ToString();

                cb_ChucVu.Text = row.Cells[11].Value.ToString();
                cb_trangthai.Text = row.Cells[12].Value.ToString();

                if (cb_ChucVu.SelectedValue.ToString() == "2")
                {
                    cb_ChucVu.Enabled = false;
                }
                else
                {
                    cb_ChucVu.Enabled = true;
                }

               // label11.Text = cb_trangthai.SelectedValue.ToString() + " - " + cb_ChucVu.SelectedValue.ToString();

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtMail.Text == "" || cb_GT.Text == "")
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                
                DungChung dc = new DungChung();

                String param = String.Format("TenNhanVien = '{0}', Email = '{1}', GioiTinh = '{2}', DiaChi = '{3}', Luong = {4}, ID_RoLe = {5}, NgaySinh = '{6}', ID_TrangThai = {7}, MaNV = '{8}'  Where ID_NguoiDung = {9}", txtName.Text, txtMail.Text, cb_GT.Text, txtDiaChi.Text, txtLuong.Text, cb_ChucVu.SelectedValue.ToString(), dateTime.Text, cb_trangthai.SelectedValue.ToString(), lbl_MaNV.Text, txtID.Text); ;

                dc.Update("Nhan_Vien", param);

                /*String sql = String.Format("UPDATE Nhan_Vien SET TenNhanVien = '{0}', Email = '{1}', GioiTinh = {2}, DiaChi = '{3}', Luong = {4}, ID_RoLe = {5}, NgaySinh = '{6}' Where ID_NguoiDung = {7}", txtName.Text, txtMail.Text, txtGT.Text, txtDiaChi.Text, txtLuong.Text, txtChucVu.Text, dateTime.Text, txtID.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();*/
                MessageBox.Show("Sửa Nhân Viên Thành Công");



                QLNhanVien_Load(sender, e);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi nào đó để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {

                String param = String.Format("Where ID_NguoiDung = {0}", txtID.Text);

                dc.Delete("Nhan_Vien", param);

                /*String sql = String.Format("DELETE FROM Nhan_Vien Where ID_NguoiDung = {0}", txtID.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();*/
                MessageBox.Show("Xóa Nhân Viên Thành Công");

                QLNhanVien_Load(sender, e);
            }
        }

        private void refesh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtMail.Text = "";
            cb_GT.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
           

            QLNhanVien_Load(sender, e);
        }

        private void pn_NhanVien_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_MaNV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            slt = "n.*, r.Role, t.TrangThai";
            table = "((Nhan_Vien n Left Join Roles r ON n.ID_Role = r.ID_Role ) Left Join TrangThai t ON n.ID_TrangThai = t.ID_TrangThai)";
            param = "where TenNhanVien like '%" + textBox1.Text + "%'";



            dataGridView_NV.DataSource = dc.query(slt, table, param);
        }
    }
}
