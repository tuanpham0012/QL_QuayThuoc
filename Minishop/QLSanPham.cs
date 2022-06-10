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
    public partial class QLSanPham : Form
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

        public QLSanPham()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNameSp.Text == "" || txtMaSp.Text == "" || txtLoaiSp.Text == "" || txtGiaBan.Text == "" || txtDonVi.Text == "")
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {

                String param = String.Format("TenSP = '{0}', MaSP = '{1}', LoaiSP = '{2}', GiaBan = {3}, Discount = {4}, DonVi = '{5}' Where ID_SanPham = {6}", txtNameSp.Text, txtMaSp.Text, txtLoaiSp.Text, txtGiaBan.Text, txtDis.Text, txtDonVi.Text, txtId_Sp.Text);

                dc.Update("San_Pham", param);
               
                MessageBox.Show("Cập Nhật Sản Phẩm Thành Công");

                QLSanPham_Load(sender, e);

            }
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
           
            dataGridView_SP.DataSource = dc.query("*", "San_Pham", "");
            DataTable tb_lsp = dc.query("*", "LoaiSanPham", "");

            DataTable tb_dv = dc.query("*", "DonViTinh", "");

            txtLoaiSp.DisplayMember = "LoaiSP";
            txtLoaiSp.ValueMember = "LoaiSP";
            txtLoaiSp.DataSource = tb_lsp;

            txtDonVi.DisplayMember = "DonViTinh";
            txtDonVi.ValueMember = "DonViTinh";
            txtDonVi.DataSource = tb_dv;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNameSp.Text == "" || txtMaSp.Text == "" || txtLoaiSp.Text == "" || txtGiaBan.Text == "" || txtDonVi.Text == "")
            {
                MessageBox.Show("Không để trống thông tin có dấu * ");
            }
            else
            {
                String Columns = "(TenSP, MaSP, LoaiSP, GiaBan, Discount, DonVi)";
                String Values = String.Format("('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", txtNameSp.Text, txtMaSp.Text, txtLoaiSp.Text, txtGiaBan.Text, txtDis.Text, txtDonVi.Text);

                dc.Insert("San_Pham", Columns, Values);

              
                MessageBox.Show("Thêm Sản phẩm Thành Công");

                QLSanPham_Load(sender, e);

            }
        }

        private void delete_sp_Click(object sender, EventArgs e)
        {
            if (txtId_Sp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi nào đó để xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {

                DungChung dc = new DungChung();

                String param = String.Format("Where ID_SanPham = {0}", txtId_Sp.Text);

                dc.Delete("San_Pham", param);
                MessageBox.Show("Xóa Sản Phẩm Thành Công");

                QLSanPham_Load(sender, e);
            }
            
        }

        private void refesh2_Click(object sender, EventArgs e)
        {
            txtId_Sp.Text = "";
            txtNameSp.Text = "";
            txtMaSp.Text = "";
            txtLoaiSp.Text = "";
            txtGiaBan.Text = "";
            txtDis.Text = "";
            txtLoaiSp.Text = "";
            txtSL.Text = "";
            txtDonVi.Text = "";

            QLSanPham_Load(sender, e);
        }

        private void dataGridView_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView_SP.Rows[e.RowIndex];

                txtId_Sp.Text = row.Cells[0].Value.ToString();
                txtNameSp.Text = row.Cells[1].Value.ToString();
                txtMaSp.Text = row.Cells[2].Value.ToString();
                txtLoaiSp.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtDis.Text = row.Cells[5].Value.ToString();
                txtSL.Text = row.Cells[7].Value.ToString();
                txtDonVi.Text = row.Cells[6].Value.ToString();

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView_SP.DataSource = dc.query("*", "San_Pham", "Where TenSP like '%" + textBox1.Text +"%'");
        }
    }
}
