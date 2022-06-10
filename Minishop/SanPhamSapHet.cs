using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace Minishop
{
    public partial class SanPhamSapHet : Form
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
        public SanPhamSapHet()
        {
            InitializeComponent();
        }

        private void SapPhamSapHet_Load(object sender, EventArgs e)
        {
            

            String param = String.Format("Where SoLuong <= {0}", txtSL.Text);

            dataGridView1.DataSource = dc.query("*", "San_Pham", param);

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i <= (dataGridView1.Rows.Count - 1); i++)
            {

                bool rowAlreadyExist = false;
                bool checkedCell = (bool)dataGridView1.Rows[i].Cells[0].Value;

                if (checkedCell == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    if (dataGridView2.Rows.Count != 0)
                    {
                        for (int j = 0; j <= (dataGridView2.Rows.Count - 1); j++)
                        {
                            if (row.Cells[1].Value.ToString() == dataGridView2.Rows[j].Cells[1].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }


                        if (rowAlreadyExist == false)
                        {
                            dataGridView2.Rows.Add( false,
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(),
                                                   row.Cells[5].Value.ToString(),
                                                   row.Cells[6].Value.ToString(),
                                                   row.Cells[7].Value.ToString(),
                                                   row.Cells[8].Value.ToString());
                        }
                    }

                    else
                    {
                        dataGridView2.Rows.Add(false,
                                                   row.Cells[1].Value.ToString(),
                                                   row.Cells[2].Value.ToString(),
                                                   row.Cells[3].Value.ToString(),
                                                   row.Cells[4].Value.ToString(),
                                                   row.Cells[5].Value.ToString(),
                                                   row.Cells[6].Value.ToString(),
                                                   row.Cells[7].Value.ToString(),
                                                   row.Cells[8].Value.ToString());
                    }
                }
                }
            }

            private void dataGridView_sp1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*String msg = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + " - ";
                         

            MessageBox.Show(msg);*/
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView2.Rows.Count;
            bool del = false;

            for (int i = 0; i < row; i++)
            {
                   
                    bool checkCell = (bool)dataGridView2.Rows[i].Cells[0].Value;
                     
                    if (checkCell == true)
                    {
                        dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                        i--;
                        row--;
                        del = true;
                        dataGridView2.Update();

                    }
            }

            if (del == false)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn!");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = dataGridView2.Rows.Count;
            
            if(count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn!");
            }
            else
            {
                NhapHang nh = new NhapHang(dataGridView2);
                nh.Show();
            }
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SapPhamSapHet_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SapPhamSapHet_Load(sender, e);
        }
    }
}
