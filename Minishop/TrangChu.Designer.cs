namespace Minishop
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonDaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPhamSapHet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 406);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuTaoHoaDon,
            this.mnuNghiepVu,
            this.mnuThongKe,
            this.mnuTaiKhoan});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(834, 24);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Trang chủ";
            // 
            // mnuTaoHoaDon
            // 
            this.mnuTaoHoaDon.Name = "mnuTaoHoaDon";
            this.mnuTaoHoaDon.Size = new System.Drawing.Size(88, 20);
            this.mnuTaoHoaDon.Text = "Tạo Hóa Đơn";
            this.mnuTaoHoaDon.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnuNghiepVu
            // 
            this.mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNhanVien,
            this.mnuQLSanPham});
            this.mnuNghiepVu.Name = "mnuNghiepVu";
            this.mnuNghiepVu.Size = new System.Drawing.Size(57, 20);
            this.mnuNghiepVu.Text = "Quản lí";
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuQLNhanVien.Text = "Nhân Viên";
            this.mnuQLNhanVien.Click += new System.EventHandler(this.mnuQLNhanVien_Click);
            // 
            // mnuQLSanPham
            // 
            this.mnuQLSanPham.Name = "mnuQLSanPham";
            this.mnuQLSanPham.Size = new System.Drawing.Size(180, 22);
            this.mnuQLSanPham.Text = "Sản Phẩm";
            this.mnuQLSanPham.Click += new System.EventHandler(this.mnuQLSanPham_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonNhap,
            this.mnuHoaDonDaBan,
            this.mnuSanPhamSapHet});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(69, 20);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mnuHoaDonNhap
            // 
            this.mnuHoaDonNhap.Name = "mnuHoaDonNhap";
            this.mnuHoaDonNhap.Size = new System.Drawing.Size(171, 22);
            this.mnuHoaDonNhap.Text = "Hóa Đơn Nhập";
            this.mnuHoaDonNhap.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem1_Click);
            // 
            // mnuHoaDonDaBan
            // 
            this.mnuHoaDonDaBan.Name = "mnuHoaDonDaBan";
            this.mnuHoaDonDaBan.Size = new System.Drawing.Size(171, 22);
            this.mnuHoaDonDaBan.Text = "Hóa đơn đã bán";
            this.mnuHoaDonDaBan.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // mnuSanPhamSapHet
            // 
            this.mnuSanPhamSapHet.Name = "mnuSanPhamSapHet";
            this.mnuSanPhamSapHet.Size = new System.Drawing.Size(171, 22);
            this.mnuSanPhamSapHet.Text = "Sản Phẩm Sắp Hết";
            this.mnuSanPhamSapHet.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau,
            this.mnuDangXuat,
            this.thoátToolStripMenuItem});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(145, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 445);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonDaBan;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPhamSapHet;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSanPham;
    }
}