namespace Minishop
{
    partial class HoaDonDaBan
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
            this.dataGridView_hddb = new System.Windows.Forms.DataGridView();
            this.ID_HoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.exit = new System.Windows.Forms.Button();
            this.ReFesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hddb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_hddb
            // 
            this.dataGridView_hddb.AllowUserToAddRows = false;
            this.dataGridView_hddb.AllowUserToDeleteRows = false;
            this.dataGridView_hddb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_hddb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_hddb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hddb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HoaDon,
            this.MaHoaDon,
            this.NgayTao,
            this.ThanhTien,
            this.TenNhanVien,
            this.KhachHang,
            this.button});
            this.dataGridView_hddb.Location = new System.Drawing.Point(30, 133);
            this.dataGridView_hddb.Name = "dataGridView_hddb";
            this.dataGridView_hddb.ReadOnly = true;
            this.dataGridView_hddb.Size = new System.Drawing.Size(761, 299);
            this.dataGridView_hddb.TabIndex = 0;
            this.dataGridView_hddb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hddb_CellContentClick);
            // 
            // ID_HoaDon
            // 
            this.ID_HoaDon.DataPropertyName = "ID_HoaDon";
            this.ID_HoaDon.HeaderText = "ID";
            this.ID_HoaDon.Name = "ID_HoaDon";
            this.ID_HoaDon.ReadOnly = true;
            this.ID_HoaDon.Visible = false;
            this.ID_HoaDon.Width = 40;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Width = 110;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày Bán";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            this.NgayTao.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Giá Hóa Đơn";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Người Bán";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            this.TenNhanVien.Width = 140;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "TenKhachHang";
            this.KhachHang.HeaderText = "Khách Hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            this.KhachHang.Width = 140;
            // 
            // button
            // 
            this.button.HeaderText = "";
            this.button.Name = "button";
            this.button.ReadOnly = true;
            this.button.Text = "Chi Tiết";
            this.button.UseColumnTextForButtonValue = true;
            this.button.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa Đơn Đã Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Bán";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(13, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ReFesh
            // 
            this.ReFesh.Location = new System.Drawing.Point(237, 89);
            this.ReFesh.Name = "ReFesh";
            this.ReFesh.Size = new System.Drawing.Size(75, 23);
            this.ReFesh.TabIndex = 5;
            this.ReFesh.Text = "Làm Mới";
            this.ReFesh.UseVisualStyleBackColor = true;
            this.ReFesh.Click += new System.EventHandler(this.ReFesh_Click);
            // 
            // HoaDonDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 490);
            this.Controls.Add(this.ReFesh);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_hddb);
            this.MaximizeBox = false;
            this.Name = "HoaDonDaBan";
            this.Text = "Hóa Đơn Đã Bán";
            this.Load += new System.EventHandler(this.HoaDonDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hddb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_hddb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewButtonColumn button;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ReFesh;
    }
}