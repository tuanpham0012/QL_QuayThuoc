namespace Minishop
{
    partial class NhapHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.id_sp,
            this.name_sp,
            this.ma_sp,
            this.loai_sp,
            this.gia_sp,
            this.giamgia,
            this.dv_sp,
            this.sl_sp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(64, 121);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(564, 272);
            this.dataGridView1.TabIndex = 8;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(64, 77);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "Nhập Hàng";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập Thuốc";
            // 
            // id_sp
            // 
            this.id_sp.DataPropertyName = "ID_SanPham";
            this.id_sp.HeaderText = "ID_Sp";
            this.id_sp.Name = "id_sp";
            this.id_sp.ReadOnly = true;
            this.id_sp.Visible = false;
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
            this.sl_sp.HeaderText = "Số Lượng Nhập";
            this.sl_sp.Name = "sl_sp";
            this.sl_sp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sl_sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sl_sp.Width = 60;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_sp;
    }
}