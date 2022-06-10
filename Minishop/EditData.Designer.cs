namespace Minishop
{
    partial class EditData
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_NhanVien = new System.Windows.Forms.Panel();
            this.refesh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.ThemData = new System.Windows.Forms.Button();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.ID_NguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pnSanPham = new System.Windows.Forms.Panel();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView_SP = new System.Windows.Forms.DataGridView();
            this.ID_Sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refesh2 = new System.Windows.Forms.Button();
            this.delete_sp = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtLoaiSp = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.txtNameSp = new System.Windows.Forms.TextBox();
            this.txtId_Sp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtGT = new System.Windows.Forms.ComboBox();
            this.pn_NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.pnSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhan_Vien",
            "San_Pham"});
            this.comboBox1.Location = new System.Drawing.Point(92, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Bảng";
            // 
            // pn_NhanVien
            // 
            this.pn_NhanVien.Controls.Add(this.txtGT);
            this.pn_NhanVien.Controls.Add(this.dateTime);
            this.pn_NhanVien.Controls.Add(this.refesh);
            this.pn_NhanVien.Controls.Add(this.button3);
            this.pn_NhanVien.Controls.Add(this.Edit);
            this.pn_NhanVien.Controls.Add(this.ThemData);
            this.pn_NhanVien.Controls.Add(this.dataGridView_NhanVien);
            this.pn_NhanVien.Controls.Add(this.txtName);
            this.pn_NhanVien.Controls.Add(this.txtDiaChi);
            this.pn_NhanVien.Controls.Add(this.txtMail);
            this.pn_NhanVien.Controls.Add(this.txtLuong);
            this.pn_NhanVien.Controls.Add(this.txtChucVu);
            this.pn_NhanVien.Controls.Add(this.txtID);
            this.pn_NhanVien.Controls.Add(this.label10);
            this.pn_NhanVien.Controls.Add(this.label9);
            this.pn_NhanVien.Controls.Add(this.label8);
            this.pn_NhanVien.Controls.Add(this.label7);
            this.pn_NhanVien.Controls.Add(this.label6);
            this.pn_NhanVien.Controls.Add(this.label5);
            this.pn_NhanVien.Controls.Add(this.label4);
            this.pn_NhanVien.Controls.Add(this.label3);
            this.pn_NhanVien.Controls.Add(this.label2);
            this.pn_NhanVien.Location = new System.Drawing.Point(92, 63);
            this.pn_NhanVien.Name = "pn_NhanVien";
            this.pn_NhanVien.Size = new System.Drawing.Size(835, 442);
            this.pn_NhanVien.TabIndex = 2;
            this.pn_NhanVien.Visible = false;
            this.pn_NhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // refesh
            // 
            this.refesh.Location = new System.Drawing.Point(620, 182);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(75, 23);
            this.refesh.TabIndex = 24;
            this.refesh.Text = "Làm Mới";
            this.refesh.UseVisualStyleBackColor = true;
            this.refesh.Click += new System.EventHandler(this.refesh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(274, 182);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Sửa";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ThemData
            // 
            this.ThemData.Location = new System.Drawing.Point(103, 182);
            this.ThemData.Name = "ThemData";
            this.ThemData.Size = new System.Drawing.Size(75, 23);
            this.ThemData.TabIndex = 21;
            this.ThemData.Text = "Thêm";
            this.ThemData.UseVisualStyleBackColor = true;
            this.ThemData.Click += new System.EventHandler(this.ThemData_Click);
            // 
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NguoiDung,
            this.MatKhau,
            this.TrangThai,
            this.TenNhanVien,
            this.Email,
            this.GioiTinh,
            this.NgaySinh,
            this.address,
            this.Luong,
            this.ChucVu});
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(32, 234);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(745, 205);
            this.dataGridView_NhanVien.TabIndex = 19;
            this.dataGridView_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhanVien_CellClick);
            // 
            // ID_NguoiDung
            // 
            this.ID_NguoiDung.DataPropertyName = "ID_NguoiDung";
            this.ID_NguoiDung.HeaderText = "ID Nhân Viên";
            this.ID_NguoiDung.Name = "ID_NguoiDung";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = false;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // address
            // 
            this.address.DataPropertyName = "DiaChi";
            this.address.HeaderText = "Địa Chỉ";
            this.address.Name = "address";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ID_Role";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(287, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(296, 120);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(106, 20);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(491, 54);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(179, 20);
            this.txtMail.TabIndex = 15;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(493, 120);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(92, 20);
            this.txtLuong.TabIndex = 14;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(730, 120);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(67, 20);
            this.txtChucVu.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 20);
            this.txtID.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày Sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chức Vụ (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giới Tính (*)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhân Viên (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản Lý Nhân Viên";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(257, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 25;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pnSanPham
            // 
            this.pnSanPham.Controls.Add(this.txtSL);
            this.pnSanPham.Controls.Add(this.label19);
            this.pnSanPham.Controls.Add(this.dataGridView_SP);
            this.pnSanPham.Controls.Add(this.refesh2);
            this.pnSanPham.Controls.Add(this.delete_sp);
            this.pnSanPham.Controls.Add(this.btnSua);
            this.pnSanPham.Controls.Add(this.btnThem);
            this.pnSanPham.Controls.Add(this.txtDonVi);
            this.pnSanPham.Controls.Add(this.txtDis);
            this.pnSanPham.Controls.Add(this.txtGiaBan);
            this.pnSanPham.Controls.Add(this.txtLoaiSp);
            this.pnSanPham.Controls.Add(this.txtMaSp);
            this.pnSanPham.Controls.Add(this.txtNameSp);
            this.pnSanPham.Controls.Add(this.txtId_Sp);
            this.pnSanPham.Controls.Add(this.label18);
            this.pnSanPham.Controls.Add(this.label17);
            this.pnSanPham.Controls.Add(this.label16);
            this.pnSanPham.Controls.Add(this.label15);
            this.pnSanPham.Controls.Add(this.label14);
            this.pnSanPham.Controls.Add(this.label13);
            this.pnSanPham.Controls.Add(this.label12);
            this.pnSanPham.Controls.Add(this.label11);
            this.pnSanPham.Location = new System.Drawing.Point(95, 63);
            this.pnSanPham.Name = "pnSanPham";
            this.pnSanPham.Size = new System.Drawing.Size(848, 454);
            this.pnSanPham.TabIndex = 26;
            this.pnSanPham.Visible = false;
            this.pnSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSanPham_Paint);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(690, 120);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(631, 123);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Số Lượng";
            // 
            // dataGridView_SP
            // 
            this.dataGridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Sp,
            this.TenSp,
            this.MaSP,
            this.LoaiSp,
            this.Gia,
            this.GiamGia,
            this.DonVi});
            this.dataGridView_SP.Location = new System.Drawing.Point(63, 234);
            this.dataGridView_SP.Name = "dataGridView_SP";
            this.dataGridView_SP.Size = new System.Drawing.Size(743, 205);
            this.dataGridView_SP.TabIndex = 19;
            this.dataGridView_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SP_CellClick);
            // 
            // ID_Sp
            // 
            this.ID_Sp.DataPropertyName = "ID_SanPham";
            this.ID_Sp.HeaderText = "ID Sản Phẩm";
            this.ID_Sp.Name = "ID_Sp";
            // 
            // TenSp
            // 
            this.TenSp.DataPropertyName = "TenSP";
            this.TenSp.HeaderText = "Tên Sản Phẩm";
            this.TenSp.Name = "TenSp";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // LoaiSp
            // 
            this.LoaiSp.DataPropertyName = "LoaiSP";
            this.LoaiSp.HeaderText = "Loại SP";
            this.LoaiSp.Name = "LoaiSp";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GiaBan";
            this.Gia.HeaderText = "Giá Bán";
            this.Gia.Name = "Gia";
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "Discount";
            this.GiamGia.HeaderText = "Giảm Giá";
            this.GiamGia.Name = "GiamGia";
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.Name = "DonVi";
            // 
            // refesh2
            // 
            this.refesh2.Location = new System.Drawing.Point(585, 182);
            this.refesh2.Name = "refesh2";
            this.refesh2.Size = new System.Drawing.Size(75, 23);
            this.refesh2.TabIndex = 18;
            this.refesh2.Text = "Làm Mới";
            this.refesh2.UseVisualStyleBackColor = true;
            this.refesh2.Click += new System.EventHandler(this.refesh2_Click);
            // 
            // delete_sp
            // 
            this.delete_sp.Location = new System.Drawing.Point(404, 182);
            this.delete_sp.Name = "delete_sp";
            this.delete_sp.Size = new System.Drawing.Size(75, 23);
            this.delete_sp.TabIndex = 17;
            this.delete_sp.Text = "Xóa";
            this.delete_sp.UseVisualStyleBackColor = true;
            this.delete_sp.Click += new System.EventHandler(this.delete_sp_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(230, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(91, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(480, 120);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(100, 20);
            this.txtDonVi.TabIndex = 14;
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(271, 120);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(105, 20);
            this.txtDis.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(75, 120);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 12;
            // 
            // txtLoaiSp
            // 
            this.txtLoaiSp.Location = new System.Drawing.Point(692, 67);
            this.txtLoaiSp.Name = "txtLoaiSp";
            this.txtLoaiSp.Size = new System.Drawing.Size(140, 20);
            this.txtLoaiSp.TabIndex = 11;
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(480, 67);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(72, 20);
            this.txtMaSp.TabIndex = 10;
            // 
            // txtNameSp
            // 
            this.txtNameSp.Location = new System.Drawing.Point(256, 67);
            this.txtNameSp.Name = "txtNameSp";
            this.txtNameSp.Size = new System.Drawing.Size(100, 20);
            this.txtNameSp.TabIndex = 9;
            // 
            // txtId_Sp
            // 
            this.txtId_Sp.Enabled = false;
            this.txtId_Sp.Location = new System.Drawing.Point(91, 67);
            this.txtId_Sp.Name = "txtId_Sp";
            this.txtId_Sp.Size = new System.Drawing.Size(36, 20);
            this.txtId_Sp.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(422, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Đơn Vị (*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(593, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Loại Sản Phẩm (*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(387, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Mã Sản Phẩm (*)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(203, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "% Giảm GIá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(159, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tên Sản Phẩm (*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giá Bán (*)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "ID Sản Phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quản Lý Sản Phẩm";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "dd/MM/yyyy";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(91, 120);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(130, 20);
            this.dateTime.TabIndex = 25;
            // 
            // txtGT
            // 
            this.txtGT.FormattingEnabled = true;
            this.txtGT.Items.AddRange(new object[] {
            "True",
            "False"});
            this.txtGT.Location = new System.Drawing.Point(749, 52);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(61, 21);
            this.txtGT.TabIndex = 26;
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 517);
            this.Controls.Add(this.pnSanPham);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pn_NhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EditData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditData_Load);
            this.pn_NhanVien.ResumeLayout(false);
            this.pn_NhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.pnSanPham.ResumeLayout(false);
            this.pnSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_NhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_NhanVien;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button refesh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ThemData;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Panel pnSanPham;
        private System.Windows.Forms.DataGridView dataGridView_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.Button refesh2;
        private System.Windows.Forms.Button delete_sp;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtLoaiSp;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.TextBox txtNameSp;
        private System.Windows.Forms.TextBox txtId_Sp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox txtGT;
    }
}