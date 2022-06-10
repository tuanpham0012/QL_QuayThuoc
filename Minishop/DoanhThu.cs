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
    public partial class DoanhThu : Form
    {
        DungChung dc = new DungChung();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dc.query("*", "DoanhThu", "");



            

            /*int DoanhthuThang = int.Parse(doanhThu.Rows[0]["DoanhThuBanHang"].ToString());

            label1.Text = DoanhthuThang.ToString();*/

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String thang =  dateTimePicker1.Text;
            int nam = DateTime.Now.Year;
            String p = String.Format("Where Month(Thang) = {0} and year(Thang) = {1}", thang, nam);

            DataTable doanhThu = dc.query("DoanhThuBanHang", "DoanhThu", p);
            dataGridView1.DataSource = doanhThu;
        }
    }
}
