namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    partial class NhapKhoaHoc
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbMaKhoaHoc = new System.Windows.Forms.TextBox();
			this.tbTenKhoaHoc = new System.Windows.Forms.TextBox();
			this.tbTaiLieuGiangDay = new System.Windows.Forms.TextBox();
			this.tbMoTa = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoaTrang = new System.Windows.Forms.Button();
			this.cbTongThoiGian = new System.Windows.Forms.ComboBox();
			this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.THOIGIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TAILIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khóa học";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khóa học";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(631, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mô tả";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(316, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tài liệu giảng dạy";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Tổng thời gian";
			// 
			// tbMaKhoaHoc
			// 
			this.tbMaKhoaHoc.Location = new System.Drawing.Point(119, 18);
			this.tbMaKhoaHoc.Name = "tbMaKhoaHoc";
			this.tbMaKhoaHoc.Size = new System.Drawing.Size(164, 21);
			this.tbMaKhoaHoc.TabIndex = 5;
			// 
			// tbTenKhoaHoc
			// 
			this.tbTenKhoaHoc.Location = new System.Drawing.Point(119, 66);
			this.tbTenKhoaHoc.Name = "tbTenKhoaHoc";
			this.tbTenKhoaHoc.Size = new System.Drawing.Size(164, 21);
			this.tbTenKhoaHoc.TabIndex = 6;
			// 
			// tbTaiLieuGiangDay
			// 
			this.tbTaiLieuGiangDay.Location = new System.Drawing.Point(430, 18);
			this.tbTaiLieuGiangDay.Multiline = true;
			this.tbTaiLieuGiangDay.Name = "tbTaiLieuGiangDay";
			this.tbTaiLieuGiangDay.Size = new System.Drawing.Size(164, 128);
			this.tbTaiLieuGiangDay.TabIndex = 7;
			// 
			// tbMoTa
			// 
			this.tbMoTa.Location = new System.Drawing.Point(693, 18);
			this.tbMoTa.Multiline = true;
			this.tbMoTa.Name = "tbMoTa";
			this.tbMoTa.Size = new System.Drawing.Size(164, 128);
			this.tbMoTa.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dgvKhoaHoc);
			this.groupBox1.Location = new System.Drawing.Point(3, 167);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(864, 258);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// dgvKhoaHoc
			// 
			this.dgvKhoaHoc.AllowUserToAddRows = false;
			this.dgvKhoaHoc.AllowUserToDeleteRows = false;
			this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.THOIGIAN,
            this.TAILIEU,
            this.MOTA});
			this.dgvKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKhoaHoc.Location = new System.Drawing.Point(3, 17);
			this.dgvKhoaHoc.Name = "dgvKhoaHoc";
			this.dgvKhoaHoc.Size = new System.Drawing.Size(858, 238);
			this.dgvKhoaHoc.TabIndex = 0;
			this.dgvKhoaHoc.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhoaHoc_RowHeaderMouseClick);
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnThem.Location = new System.Drawing.Point(26, 437);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 11;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnXoa.Location = new System.Drawing.Point(127, 437);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSua.Location = new System.Drawing.Point(228, 437);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoaTrang
			// 
			this.btnXoaTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnXoaTrang.Location = new System.Drawing.Point(329, 437);
			this.btnXoaTrang.Name = "btnXoaTrang";
			this.btnXoaTrang.Size = new System.Drawing.Size(75, 23);
			this.btnXoaTrang.TabIndex = 14;
			this.btnXoaTrang.Text = "Xóa trắng";
			this.btnXoaTrang.UseVisualStyleBackColor = true;
			this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
			// 
			// cbTongThoiGian
			// 
			this.cbTongThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTongThoiGian.FormattingEnabled = true;
			this.cbTongThoiGian.Items.AddRange(new object[] {
            "1 tháng",
            "2 tháng",
            "3 tháng",
            "4 tháng",
            "5 tháng",
            "6 tháng"});
			this.cbTongThoiGian.Location = new System.Drawing.Point(119, 119);
			this.cbTongThoiGian.Name = "cbTongThoiGian";
			this.cbTongThoiGian.Size = new System.Drawing.Size(164, 21);
			this.cbTongThoiGian.TabIndex = 16;
			// 
			// MAKH
			// 
			this.MAKH.DataPropertyName = "MAKH";
			this.MAKH.HeaderText = "Mã khóa học";
			this.MAKH.Name = "MAKH";
			// 
			// TENKH
			// 
			this.TENKH.DataPropertyName = "TENKH";
			this.TENKH.HeaderText = "Tên khóa học";
			this.TENKH.Name = "TENKH";
			// 
			// THOIGIAN
			// 
			this.THOIGIAN.DataPropertyName = "THOIGIAN";
			this.THOIGIAN.HeaderText = "Tổng thời gian";
			this.THOIGIAN.Name = "THOIGIAN";
			// 
			// TAILIEU
			// 
			this.TAILIEU.DataPropertyName = "TAILIEU";
			this.TAILIEU.HeaderText = "Tài liệu giảng dạy";
			this.TAILIEU.Name = "TAILIEU";
			// 
			// MOTA
			// 
			this.MOTA.DataPropertyName = "MOTA";
			this.MOTA.HeaderText = "Mô tả";
			this.MOTA.Name = "MOTA";
			// 
			// NhapKhoaHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 472);
			this.Controls.Add(this.cbTongThoiGian);
			this.Controls.Add(this.btnXoaTrang);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbMoTa);
			this.Controls.Add(this.tbTaiLieuGiangDay);
			this.Controls.Add(this.tbTenKhoaHoc);
			this.Controls.Add(this.tbMaKhoaHoc);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NhapKhoaHoc";
			this.Text = "Nhập Khóa Học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaKhoaHoc;
        private System.Windows.Forms.TextBox tbTenKhoaHoc;
        private System.Windows.Forms.TextBox tbTaiLieuGiangDay;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoaTrang;
		private System.Windows.Forms.ComboBox cbTongThoiGian;
		private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN;
		private System.Windows.Forms.DataGridViewTextBoxColumn TAILIEU;
		private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
	}
}