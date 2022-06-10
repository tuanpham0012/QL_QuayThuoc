namespace Minishop
{
    partial class QLNhanVien
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
            this.pn_NhanVien = new System.Windows.Forms.Panel();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.refesh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.ThemData = new System.Windows.Forms.Button();
            this.dataGridView_NV = new System.Windows.Forms.DataGridView();
            this.ID_NguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pn_NhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_NhanVien
            // 
            this.pn_NhanVien.Controls.Add(this.cb_trangthai);
            this.pn_NhanVien.Controls.Add(this.label3);
            this.pn_NhanVien.Controls.Add(this.cb_ChucVu);
            this.pn_NhanVien.Controls.Add(this.lbl_MaNV);
            this.pn_NhanVien.Controls.Add(this.label1);
            this.pn_NhanVien.Controls.Add(this.txtID);
            this.pn_NhanVien.Controls.Add(this.cb_GT);
            this.pn_NhanVien.Controls.Add(this.dateTime);
            this.pn_NhanVien.Controls.Add(this.refesh);
            this.pn_NhanVien.Controls.Add(this.button3);
            this.pn_NhanVien.Controls.Add(this.Edit);
            this.pn_NhanVien.Controls.Add(this.ThemData);
            this.pn_NhanVien.Controls.Add(this.dataGridView_NV);
            this.pn_NhanVien.Controls.Add(this.txtName);
            this.pn_NhanVien.Controls.Add(this.txtDiaChi);
            this.pn_NhanVien.Controls.Add(this.txtMail);
            this.pn_NhanVien.Controls.Add(this.txtLuong);
            this.pn_NhanVien.Controls.Add(this.label10);
            this.pn_NhanVien.Controls.Add(this.label9);
            this.pn_NhanVien.Controls.Add(this.label8);
            this.pn_NhanVien.Controls.Add(this.label7);
            this.pn_NhanVien.Controls.Add(this.label6);
            this.pn_NhanVien.Controls.Add(this.label5);
            this.pn_NhanVien.Controls.Add(this.label4);
            this.pn_NhanVien.Location = new System.Drawing.Point(12, 95);
            this.pn_NhanVien.Name = "pn_NhanVien";
            this.pn_NhanVien.Size = new System.Drawing.Size(924, 453);
            this.pn_NhanVien.TabIndex = 3;
            this.pn_NhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_NhanVien_Paint);
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Location = new System.Drawing.Point(782, 59);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(121, 21);
            this.cb_trangthai.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Trạng Thái";
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(668, 122);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(87, 21);
            this.cb_ChucVu.TabIndex = 30;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(115, 23);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(23, 13);
            this.lbl_MaNV.TabIndex = 29;
            this.lbl_MaNV.Text = "null";
            this.lbl_MaNV.Click += new System.EventHandler(this.lbl_MaNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã nhân viên: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(361, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 20);
            this.txtID.TabIndex = 27;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cb_GT
            // 
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cb_GT.Location = new System.Drawing.Point(622, 58);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(61, 21);
            this.cb_GT.TabIndex = 26;
            this.cb_GT.SelectedIndexChanged += new System.EventHandler(this.txtGT_SelectedIndexChanged);
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(94, 123);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(130, 20);
            this.dateTime.TabIndex = 25;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // refesh
            // 
            this.refesh.Location = new System.Drawing.Point(710, 182);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(75, 23);
            this.refesh.TabIndex = 24;
            this.refesh.Text = "Làm Mới";
            this.refesh.UseVisualStyleBackColor = true;
            this.refesh.Click += new System.EventHandler(this.refesh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 182);
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
            // dataGridView_NV
            // 
            this.dataGridView_NV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_NV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NguoiDung,
            this.MaNV,
            this.TenNhanVien,
            this.Email,
            this.MatKhau,
            this.GioiTinh,
            this.NgaySinh,
            this.address,
            this.Luong,
            this.ChucVu,
            this.TrangThai,
            this.ID_Role,
            this.ID_TrangThai});
            this.dataGridView_NV.Location = new System.Drawing.Point(35, 245);
            this.dataGridView_NV.Name = "dataGridView_NV";
            this.dataGridView_NV.Size = new System.Drawing.Size(855, 205);
            this.dataGridView_NV.TabIndex = 19;
            this.dataGridView_NV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NV_CellContentClick);
            // 
            // ID_NguoiDung
            // 
            this.ID_NguoiDung.DataPropertyName = "ID_NguoiDung";
            this.ID_NguoiDung.HeaderText = "ID Nhân Viên";
            this.ID_NguoiDung.Name = "ID_NguoiDung";
            this.ID_NguoiDung.Visible = false;
            this.ID_NguoiDung.Width = 80;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 80;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 110;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            dataGridViewCellStyle2.Format = "*******";
            dataGridViewCellStyle2.NullValue = null;
            this.MatKhau.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Visible = false;
            this.MatKhau.Width = 85;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 80;
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
            this.address.Width = 70;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.Width = 70;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "Role";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 80;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 90;
            // 
            // ID_Role
            // 
            this.ID_Role.DataPropertyName = "ID_Role";
            this.ID_Role.HeaderText = "ID_Role";
            this.ID_Role.Name = "ID_Role";
            this.ID_Role.Visible = false;
            // 
            // ID_TrangThai
            // 
            this.ID_TrangThai.DataPropertyName = "ID_TrangThai";
            this.ID_TrangThai.HeaderText = "ID_TrangThai";
            this.ID_TrangThai.Name = "ID_TrangThai";
            this.ID_TrangThai.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(305, 123);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(106, 20);
            this.txtDiaChi.TabIndex = 16;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(167, 20);
            this.txtMail.TabIndex = 15;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(481, 123);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(92, 20);
            this.txtLuong.TabIndex = 14;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày Sinh";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(601, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chức Vụ (*)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Lương";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giới Tính (*)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email (*)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa Chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhân Viên (*)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản Lý Nhân Viên";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tìm Nhân Viên";
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 547);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pn_NhanVien);
            this.Controls.Add(this.label2);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            this.pn_NhanVien.ResumeLayout(false);
            this.pn_NhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_NhanVien;
        private System.Windows.Forms.ComboBox cb_GT;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button refesh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ThemData;
        private System.Windows.Forms.DataGridView dataGridView_NV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ChucVu;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TrangThai;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}