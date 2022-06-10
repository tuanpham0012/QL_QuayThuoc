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
    public partial class DangNhap : Form
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
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtEmail.Text == "")
            {
                alert_email.Visible = true;
                return;
            }
            OleDbConnection conn = new OleDbConnection();

            
            string param = string.Format(" WHERE Email='{0}' and MatKhau='{1}'", txtEmail.Text, txtPass.Text);
           
            DataTable tb = dc.query("*", "Nhan_Vien", param);
            
            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Tên truy cập và mật khẩu không đúng!");
                return;
            }
            DungChung.ID_Role = int.Parse(tb.Rows[0]["ID_Role"].ToString());
            DungChung.ID_User = int.Parse(tb.Rows[0]["ID_NguoiDung"].ToString());
            DungChung.User_name = tb.Rows[0]["TenNhanVien"].ToString();

            DataTable role = dc.query("*", "Roles", "Where ID_Role = " + DungChung.ID_Role);

            DungChung.Role_name = role.Rows[0]["Role"].ToString();

            //Lay ds chuc nang duoc su dung

            String slt = "User_ChucNang.ID, User_ChucNang.IDChucNang, ChucNang.TenChucNang";
            String table = "User_ChucNang INNER JOIN ChucNang ON ChucNang.ID = User_ChucNang.IDChucNang";
            String pr = string.Format(" WHERE User_ChucNang.ID_Role={0}", DungChung.ID_Role);


            DataTable tb_cn = dc.query(slt, table, pr);
            
            string DSMenu = "";
            for (int i = 0; i < tb_cn.Rows.Count; i++)
            {
                DSMenu = DSMenu + tb_cn.Rows[i]["TenChucNang"].ToString() + "-";
            }
            this.Hide();

            //MessageBox.Show(DSMenu);
            DungChung.DSChucNang = DSMenu;
            TrangChu frm = new TrangChu();
            frm.ShowDialog();
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {


        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            alert_email.Visible = false;
        }
    }
}
