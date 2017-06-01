namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    partial class TraCuuGiangVien
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
			this.cbMaGiaoVien = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvTraCuu = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã giáo viên";
			// 
			// cbMaGiaoVien
			// 
			this.cbMaGiaoVien.FormattingEnabled = true;
			this.cbMaGiaoVien.Location = new System.Drawing.Point(127, 21);
			this.cbMaGiaoVien.Name = "cbMaGiaoVien";
			this.cbMaGiaoVien.Size = new System.Drawing.Size(121, 21);
			this.cbMaGiaoVien.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dgvTraCuu);
			this.groupBox1.Location = new System.Drawing.Point(2, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(763, 326);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// dgvTraCuu
			// 
			this.dgvTraCuu.AllowUserToAddRows = false;
			this.dgvTraCuu.AllowUserToDeleteRows = false;
			this.dgvTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTraCuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.dgvTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTraCuu.Location = new System.Drawing.Point(3, 17);
			this.dgvTraCuu.Name = "dgvTraCuu";
			this.dgvTraCuu.Size = new System.Drawing.Size(757, 306);
			this.dgvTraCuu.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MAGV";
			this.Column1.HeaderText = "Mã giảng viên";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TENGV";
			this.Column2.HeaderText = "Tên giảng viên";
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
			this.Column4.DataPropertyName = "NGAYSINH";
			this.Column4.HeaderText = "Ngày sinh";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "DIACHI";
			this.Column5.HeaderText = "Địa chỉ";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "SDT";
			this.Column6.HeaderText = "SĐT";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "EMAIL";
			this.Column7.HeaderText = "Email";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "TRINHDO";
			this.Column8.HeaderText = "Trình độ";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "BANGCAP";
			this.Column9.HeaderText = "Bằng Cấp";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "NGAYVL";
			this.Column10.HeaderText = "Ngày vào làm";
			this.Column10.Name = "Column10";
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "HESO";
			this.Column11.HeaderText = "Hệ số lương";
			this.Column11.Name = "Column11";
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTraCuu.Location = new System.Drawing.Point(27, 426);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
			this.btnTraCuu.TabIndex = 3;
			this.btnTraCuu.Text = "Tra cứu";
			this.btnTraCuu.UseVisualStyleBackColor = true;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// TraCuuGiangVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 461);
			this.Controls.Add(this.btnTraCuu);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbMaGiaoVien);
			this.Controls.Add(this.label1);
			this.Name = "TraCuuGiangVien";
			this.Text = "Tra Cứu Giảng Viên";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaGiaoVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private System.Windows.Forms.Button btnTraCuu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
	}
}