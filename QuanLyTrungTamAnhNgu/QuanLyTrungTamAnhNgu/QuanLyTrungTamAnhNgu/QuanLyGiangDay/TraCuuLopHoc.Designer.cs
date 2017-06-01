namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    partial class TraCuuLopHoc
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
			this.cbMaLopHoc = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvSinhVien = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbMaKhoaHoc = new System.Windows.Forms.TextBox();
			this.tbNgayKT = new System.Windows.Forms.TextBox();
			this.tbMaHocPhi = new System.Windows.Forms.TextBox();
			this.tbSiSo = new System.Windows.Forms.TextBox();
			this.tbMaGV = new System.Windows.Forms.TextBox();
			this.tbNgayBD = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã lớp học";
			// 
			// cbMaLopHoc
			// 
			this.cbMaLopHoc.FormattingEnabled = true;
			this.cbMaLopHoc.Location = new System.Drawing.Point(101, 16);
			this.cbMaLopHoc.Name = "cbMaLopHoc";
			this.cbMaLopHoc.Size = new System.Drawing.Size(121, 21);
			this.cbMaLopHoc.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.dgvSinhVien);
			this.groupBox1.Location = new System.Drawing.Point(3, 187);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(854, 205);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin học viên của lớp";
			// 
			// dgvSinhVien
			// 
			this.dgvSinhVien.AllowUserToAddRows = false;
			this.dgvSinhVien.AllowUserToDeleteRows = false;
			this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column9,
            this.Column8});
			this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSinhVien.Location = new System.Drawing.Point(3, 17);
			this.dgvSinhVien.Name = "dgvSinhVien";
			this.dgvSinhVien.Size = new System.Drawing.Size(848, 185);
			this.dgvSinhVien.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MAHV";
			this.Column1.HeaderText = "Mã học viên";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "HOTEN";
			this.Column2.HeaderText = "Tên học viên";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "GIOITINH";
			this.Column3.HeaderText = "Giới tính";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "NGSINH";
			this.Column4.HeaderText = "Ngày sinh";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "DIACHI";
			this.Column5.HeaderText = "Địa chỉ";
			this.Column5.Name = "Column5";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "SDT";
			this.Column7.HeaderText = "Điện thoại";
			this.Column7.Name = "Column7";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "EMAIL";
			this.Column6.HeaderText = "Email";
			this.Column6.Name = "Column6";
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "NGAYDK";
			this.Column9.HeaderText = "Ngày đăng ký";
			this.Column9.Name = "Column9";
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "TINHTRANG";
			this.Column8.HeaderText = "Tình trạng";
			this.Column8.Name = "Column8";
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTraCuu.Location = new System.Drawing.Point(32, 398);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
			this.btnTraCuu.TabIndex = 3;
			this.btnTraCuu.Text = "Tra cứu";
			this.btnTraCuu.UseVisualStyleBackColor = true;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.tbMaKhoaHoc);
			this.groupBox2.Controls.Add(this.tbNgayKT);
			this.groupBox2.Controls.Add(this.tbMaHocPhi);
			this.groupBox2.Controls.Add(this.tbSiSo);
			this.groupBox2.Controls.Add(this.tbMaGV);
			this.groupBox2.Controls.Add(this.tbNgayBD);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(3, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(851, 123);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin lớp học";
			// 
			// tbMaKhoaHoc
			// 
			this.tbMaKhoaHoc.Location = new System.Drawing.Point(108, 35);
			this.tbMaKhoaHoc.Name = "tbMaKhoaHoc";
			this.tbMaKhoaHoc.ReadOnly = true;
			this.tbMaKhoaHoc.Size = new System.Drawing.Size(111, 21);
			this.tbMaKhoaHoc.TabIndex = 21;
			// 
			// tbNgayKT
			// 
			this.tbNgayKT.Location = new System.Drawing.Point(552, 35);
			this.tbNgayKT.Name = "tbNgayKT";
			this.tbNgayKT.ReadOnly = true;
			this.tbNgayKT.Size = new System.Drawing.Size(113, 21);
			this.tbNgayKT.TabIndex = 18;
			// 
			// tbMaHocPhi
			// 
			this.tbMaHocPhi.Location = new System.Drawing.Point(320, 82);
			this.tbMaHocPhi.Name = "tbMaHocPhi";
			this.tbMaHocPhi.ReadOnly = true;
			this.tbMaHocPhi.Size = new System.Drawing.Size(110, 21);
			this.tbMaHocPhi.TabIndex = 17;
			// 
			// tbSiSo
			// 
			this.tbSiSo.Location = new System.Drawing.Point(552, 82);
			this.tbSiSo.Name = "tbSiSo";
			this.tbSiSo.ReadOnly = true;
			this.tbSiSo.Size = new System.Drawing.Size(113, 21);
			this.tbSiSo.TabIndex = 16;
			// 
			// tbMaGV
			// 
			this.tbMaGV.Location = new System.Drawing.Point(108, 82);
			this.tbMaGV.Name = "tbMaGV";
			this.tbMaGV.ReadOnly = true;
			this.tbMaGV.Size = new System.Drawing.Size(111, 21);
			this.tbMaGV.TabIndex = 15;
			// 
			// tbNgayBD
			// 
			this.tbNgayBD.Location = new System.Drawing.Point(320, 35);
			this.tbNgayBD.Name = "tbNgayBD";
			this.tbNgayBD.ReadOnly = true;
			this.tbNgayBD.Size = new System.Drawing.Size(110, 21);
			this.tbNgayBD.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(485, 85);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Sĩ số";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(255, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Mã Học Phí";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mã GV";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(485, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Ngày KT";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(255, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Ngày BĐ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mã khóa học";
			// 
			// TraCuuLopHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 433);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnTraCuu);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbMaLopHoc);
			this.Controls.Add(this.label1);
			this.Name = "TraCuuLopHoc";
			this.Text = "Tra Cứu Lớp Học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaLopHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaKhoaHoc;
        private System.Windows.Forms.TextBox tbNgayKT;
        private System.Windows.Forms.TextBox tbMaHocPhi;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.TextBox tbMaGV;
        private System.Windows.Forms.TextBox tbNgayBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
	}
}