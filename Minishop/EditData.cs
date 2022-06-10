using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Minishop
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            DungChung.loadData();

            // Nhân Viên
            String sql = "SELECT * FROM Nhan_Vien";
            OleDbDataAdapter ad = new OleDbDataAdapter(sql, DungChung.conn);
            DataTable tb = new DataTable();
            ad.Fill(tb);

            dataGridView_NhanVien.DataSource = tb;

            // Sản Phẩm
            sql = "SELECT * FROM San_Pham";
            ad = new OleDbDataAdapter(sql, DungChung.conn);
            tb = new DataTable();
            ad.Fill(tb);

            dataGridView_SP.DataSource = tb;

        }

        private void dataGridView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_NhanVien.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtMail.Text = row.Cells[2].Value.ToString();
                txtGT.Text = row.Cells[4].Value.ToString();
                dateTime.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtLuong.Text = row.Cells[7].Value.ToString();
                txtChucVu.Text = row.Cells[8].Value.ToString();


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            SanPham sp = new SanPham();
            sp.Close();

            this.Close();
        }

        private void refesh_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtMail.Text = null;
            txtGT.Text = null;
            txtDiaChi.Text = null;
            txtLuong.Text = null;
            txtChucVu.Text = null;
        }

       
        

        private void ThemData_Click(object sender, EventArgs e)
        {
            if( txtName == null || txtMail == null || txtGT == null || txtChucVu == null)
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                DungChung.loadData();

                String sql = String.Format("INSERT INTO Nhan_Vien (TenNhanVien, Email, MatKhau, GioiTinh, NgaySinh, DiaChi, Luong, ID_RoLe) VALUES ('{0}', '{1}', '1', {2}, '{3}', '{4}', {5}, {6})", txtName.Text, txtMail.Text, txtGT.Text, dateTime.Text, txtDiaChi.Text, txtLuong.Text, txtChucVu.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Nhân Viên Thành Công");


                EditData_Load(sender, e);

            }

            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (txtName == null || txtMail == null || txtGT == null || txtChucVu == null)
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                DungChung.loadData();

                String sql = String.Format("UPDATE Nhan_Vien SET TenNhanVien = '{0}', Email = '{1}', GioiTinh = {2}, DiaChi = '{3}', Luong = {4}, ID_RoLe = {5}, NgaySinh = '{6}' Where ID_NguoiDung = {7}", txtName.Text, txtMail.Text, txtGT.Text, txtDiaChi.Text, txtLuong.Text, txtChucVu.Text, dateTime.Text, txtID.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Nhân Viên Thành Công");

                

                EditData_Load(sender, e);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "" )
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi nào đó để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {


                DungChung.loadData();

                 String sql = String.Format("DELETE FROM Nhan_Vien Where ID_NguoiDung = {0}", txtID.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Nhân Viên Thành Công");

                EditData_Load(sender, e);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameTable = comboBox1.SelectedItem.ToString();
            if (nameTable == "Nhan_Vien")
            {
                pn_NhanVien.Visible = true;
                pnSanPham.Visible = false;
            }
            else if (nameTable == "San_Pham")
            {
                pn_NhanVien.Visible = false;
                pnSanPham.Visible = true;
            }
        }

        private void dataGridView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_SP.Rows[e.RowIndex];

                txtId_Sp.Text = row.Cells[0].Value.ToString();
                txtNameSp.Text = row.Cells[1].Value.ToString();
                txtMaSp.Text = row.Cells[2].Value.ToString();
                txtLoaiSp.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtDis.Text = row.Cells[5].Value.ToString();
                txtDonVi.Text = row.Cells[6].Value.ToString();


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNameSp == null || txtMaSp == null || txtLoaiSp == null || txtGiaBan == null || txtDonVi == null)
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                DungChung.loadData();

                String sql = String.Format("INSERT INTO San_Pham " +
                                           "(TenSP, MaSP, LoaiSP, GiaBan, Discount, DonVi) " +
                                    "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", txtNameSp.Text, txtMaSp.Text, txtLoaiSp.Text, txtGiaBan.Text, txtDis.Text, txtDonVi.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Sản phẩm Thành Công");

                EditData_Load(sender, e);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtName == null || txtMail == null || txtGT == null || txtChucVu == null)
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                DungChung.loadData();

                String sql = String.Format("UPDATE San_Pham SET " +
                                           " TenSP = '{0}', MaSP = '{1}', LoaiSP = '{2}', GiaBan = {3}, Discount = {4}, DonVi = '{5}' Where ID_SanPham = {6}", txtNameSp.Text, txtMaSp.Text, txtLoaiSp.Text, txtGiaBan.Text, txtDis.Text, txtDonVi.Text, txtId_Sp.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Sản Phẩm Thành Công");

                EditData_Load(sender, e);

            }
        }

        private void delete_sp_Click(object sender, EventArgs e)
        {
            if (txtId_Sp.Text =="" )
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi nào đó để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {


                DungChung.loadData();

                String sql = String.Format("DELETE FROM San_Pham Where ID_SanPham = {0}", txtId_Sp.Text);
                OleDbCommand cmd = new OleDbCommand(sql, DungChung.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Sản Phẩm Thành Công");

                EditData_Load(sender, e);
            }

            
        }

        private void refesh2_Click(object sender, EventArgs e)
        {
            txtId_Sp.Text = null;
            txtNameSp.Text = null;
            txtMaSp.Text = null;
            txtLoaiSp.Text = null;
            txtGiaBan.Text = null;
            txtDis.Text = null;
            txtLoaiSp.Text = null;
            txtSL.Text = null;
            txtDonVi = null;
            
        }

        private void pnSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
