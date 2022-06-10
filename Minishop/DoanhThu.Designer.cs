namespace Minishop
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThuBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraLuongNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhieuChiKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DoanhThu,
            this.DoanhThuBanHang,
            this.TienNhapHang,
            this.TraLuongNhanVien,
            this.PhieuChiKhac,
            this.Thang});
            this.dataGridView1.Location = new System.Drawing.Point(14, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID_DoanhThu
            // 
            this.ID_DoanhThu.DataPropertyName = "ID_DoanhThu";
            this.ID_DoanhThu.HeaderText = "ID";
            this.ID_DoanhThu.Name = "ID_DoanhThu";
            this.ID_DoanhThu.ReadOnly = true;
            this.ID_DoanhThu.Visible = false;
            // 
            // DoanhThuBanHang
            // 
            this.DoanhThuBanHang.DataPropertyName = "DoanhThuBanHang";
            this.DoanhThuBanHang.HeaderText = "DT Bán Hàng";
            this.DoanhThuBanHang.Name = "DoanhThuBanHang";
            this.DoanhThuBanHang.ReadOnly = true;
            // 
            // TienNhapHang
            // 
            this.TienNhapHang.DataPropertyName = "TienNhapHang";
            this.TienNhapHang.HeaderText = "Tiền Nhập Hàng";
            this.TienNhapHang.Name = "TienNhapHang";
            this.TienNhapHang.ReadOnly = true;
            // 
            // TraLuongNhanVien
            // 
            this.TraLuongNhanVien.DataPropertyName = "TraLuongNhanVien";
            this.TraLuongNhanVien.HeaderText = "Trả Lương";
            this.TraLuongNhanVien.Name = "TraLuongNhanVien";
            this.TraLuongNhanVien.ReadOnly = true;
            // 
            // PhieuChiKhac
            // 
            this.PhieuChiKhac.DataPropertyName = "PhieuChiKhac";
            this.PhieuChiKhac.HeaderText = "Chi Khác";
            this.PhieuChiKhac.Name = "PhieuChiKhac";
            this.PhieuChiKhac.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            dataGridViewCellStyle3.Format = "MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.Thang.DefaultCellStyle = dataGridViewCellStyle3;
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThuBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraLuongNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuChiKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}