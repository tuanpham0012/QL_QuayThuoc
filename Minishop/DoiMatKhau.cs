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
    public partial class DoiMatKhau : Form
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

        //khóa
        /*private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }*/
            DungChung dc = new DungChung();
        String name = "";
        String pass = "";
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            String param = "Where ID_NguoiDung = " + DungChung.ID_User;
            DataTable tb = dc.query("*", "Nhan_Vien", param);

            if( tb.Rows.Count > 0)
            {
                name = tb.Rows[0]["TenNhanVien"].ToString();
                pass = tb.Rows[0]["MatKhau"].ToString();

                lbl_Name.Text = name;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (!tb_mkM.Text.Equals(tb_xnMK.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                return;
            }
            if (!tb_mk.Text.Equals(pass))
            {
                MessageBox.Show("Sai mật khẩu!");
                return;
            }

            String param = String.Format("MatKhau = '{0}'  where ID_NguoiDung = {1}",tb_mkM.Text, DungChung.ID_User);
            dc.Update("Nhan_Vien", param);

            MessageBox.Show("Đổi mật khẩu thành công!");

            DungChung.ID_Role = -99;
            DungChung.DSChucNang = null;
            this.Close();
            DangNhap.ActiveForm.Close();
            
            DangNhap dn = new DangNhap();
            dn.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
