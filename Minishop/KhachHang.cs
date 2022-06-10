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
    public partial class KhachHang : Form
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
        public KhachHang()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
            Dtgv_Kh.DataSource = dc.query("*", "KhachHang", "");


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*TaoDonThuoc.Mhk = label1.Text;
           // this.Close();*/
        }

        private void Dtgv_Kh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Dtgv_Kh.DataSource = dc.query("*", "KhachHang", "Where TenKhachHang Like '%" + txt_TenKH.Text + "%'");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dtgv_Kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.Dtgv_Kh.Rows[e.RowIndex];

                    TaoDonThuoc.IDKh = row.Cells[1].Value.ToString();
                    TaoDonThuoc.TenKh = row.Cells[3].Value.ToString();
                    TaoDonThuoc.MaKh = row.Cells[2].Value.ToString();
                    TaoDonThuoc.DcKh = row.Cells[5].Value.ToString();
                    TaoDonThuoc.SdtKh = row.Cells[6].Value.ToString();

                    this.Close();
                }


            }
        }
    }
}
