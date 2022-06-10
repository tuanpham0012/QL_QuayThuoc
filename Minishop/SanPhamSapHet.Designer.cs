namespace Minishop
{
    partial class SanPhamSapHet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedBox,
            this.ID,
            this.TenSP,
            this.MaSP,
            this.LoaiSP,
            this.GiaBan,
            this.Discount,
            this.DonVi,
            this.SoLuong,
            this.GiaNhap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sp1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sản Phẩm Sắp Hết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng sp còn <";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(156, 68);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(50, 20);
            this.txtSL.TabIndex = 3;
            this.txtSL.Text = "20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = ">>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.id_sp,
            this.name_sp,
            this.ma_sp,
            this.loai_sp,
            this.gia_sp,
            this.giamgia,
            this.dv_sp,
            this.sl_sp});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(610, 154);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Size = new System.Drawing.Size(519, 272);
            this.dataGridView2.TabIndex = 7;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 40;
            // 
            // id_sp
            // 
            this.id_sp.DataPropertyName = "ID_SanPham";
            this.id_sp.HeaderText = "ID_Sp";
            this.id_sp.Name = "id_sp";
            this.id_sp.ReadOnly = true;
            this.id_sp.Width = 40;
            // 
            // name_sp
            // 
            this.name_sp.DataPropertyName = "TenSP";
            this.name_sp.HeaderText = "Tên SP";
            this.name_sp.Name = "name_sp";
            this.name_sp.ReadOnly = true;
            this.name_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "MaSP";
            this.ma_sp.HeaderText = "Mã SP";
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.ReadOnly = true;
            this.ma_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ma_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ma_sp.Width = 60;
            // 
            // loai_sp
            // 
            this.loai_sp.DataPropertyName = "LoaiSP";
            this.loai_sp.HeaderText = "Loại SP";
            this.loai_sp.Name = "loai_sp";
            this.loai_sp.ReadOnly = true;
            this.loai_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loai_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.loai_sp.Width = 110;
            // 
            // gia_sp
            // 
            this.gia_sp.DataPropertyName = "GiaBan";
            this.gia_sp.HeaderText = "Giá Bán";
            this.gia_sp.Name = "gia_sp";
            this.gia_sp.ReadOnly = true;
            this.gia_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gia_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gia_sp.Visible = false;
            this.gia_sp.Width = 60;
            // 
            // giamgia
            // 
            this.giamgia.DataPropertyName = "Discount";
            this.giamgia.HeaderText = "Giảm Giá";
            this.giamgia.Name = "giamgia";
            this.giamgia.ReadOnly = true;
            this.giamgia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.giamgia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.giamgia.Visible = false;
            this.giamgia.Width = 60;
            // 
            // dv_sp
            // 
            this.dv_sp.DataPropertyName = "DonVi";
            this.dv_sp.HeaderText = "Đơn Vị";
            this.dv_sp.Name = "dv_sp";
            this.dv_sp.ReadOnly = true;
            this.dv_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dv_sp.Width = 60;
            // 
            // sl_sp
            // 
            this.sl_sp.DataPropertyName = "SoLuong";
            this.sl_sp.HeaderText = "Số Lượng";
            this.sl_sp.Name = "sl_sp";
            this.sl_sp.ReadOnly = true;
            this.sl_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sl_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sl_sp.Width = 60;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(947, 113);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(58, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1020, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Nhập SP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cập Nhật";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedBox
            // 
            this.checkedBox.HeaderText = "Select";
            this.checkedBox.Name = "checkedBox";
            this.checkedBox.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_SanPham";
            this.ID.HeaderText = "ID_Sp";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 40;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaSP.Width = 60;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại SP";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            this.LoaiSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoaiSP.Width = 110;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GiaBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GiaBan.Visible = false;
            this.GiaBan.Width = 60;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Giảm Giá";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Discount.Visible = false;
            this.Discount.Width = 60;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            this.DonVi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonVi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonVi.Width = 60;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoLuong.Width = 60;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // SanPhamSapHet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 524);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SanPhamSapHet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thống Kê- SP Sắp hết";
            this.Load += new System.EventHandler(this.SapPhamSapHet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_sp;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
    }
}