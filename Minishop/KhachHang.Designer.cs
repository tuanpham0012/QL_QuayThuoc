namespace Minishop
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Dtgv_Kh = new System.Windows.Forms.DataGridView();
            this.ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TichDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv_Kh)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(134, 88);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(150, 20);
            this.txt_TenKH.TabIndex = 0;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(13, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Dtgv_Kh
            // 
            this.Dtgv_Kh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dtgv_Kh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgv_Kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgv_Kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_KhachHang,
            this.MaKhachHang,
            this.TenKhachHang,
            this.TichDiem,
            this.DiaChi,
            this.SoDienThoai,
            this.select});
            this.Dtgv_Kh.Location = new System.Drawing.Point(26, 137);
            this.Dtgv_Kh.Name = "Dtgv_Kh";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dtgv_Kh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgv_Kh.Size = new System.Drawing.Size(697, 250);
            this.Dtgv_Kh.TabIndex = 3;
            this.Dtgv_Kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgv_Kh_CellClick);
            this.Dtgv_Kh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgv_Kh_CellDoubleClick);
            // 
            // ID_KhachHang
            // 
            this.ID_KhachHang.DataPropertyName = "ID_KhachHang";
            this.ID_KhachHang.HeaderText = "ID";
            this.ID_KhachHang.Name = "ID_KhachHang";
            this.ID_KhachHang.ReadOnly = true;
            this.ID_KhachHang.Visible = false;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "Ma_KhachHang";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 130;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 140;
            // 
            // TichDiem
            // 
            this.TichDiem.DataPropertyName = "Tich_Diem";
            this.TichDiem.HeaderText = "Tích Diểm";
            this.TichDiem.Name = "TichDiem";
            this.TichDiem.ReadOnly = true;
            this.TichDiem.Width = 80;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số DT";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 110;
            // 
            // select
            // 
            this.select.HeaderText = "Chọn";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.select.Text = "Chọn";
            this.select.UseColumnTextForButtonValue = true;
            this.select.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh Sách Khách Hàng";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtgv_Kh);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenKH);
            this.Name = "KhachHang";
            this.Text = "DS Khách Hàng";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv_Kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView Dtgv_Kh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TichDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}