namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    partial class TraCuuKhoaHoc
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
			this.cbMaKhoaHoc = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvTraCuu = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khóa học";
			// 
			// cbMaKhoaHoc
			// 
			this.cbMaKhoaHoc.FormattingEnabled = true;
			this.cbMaKhoaHoc.Location = new System.Drawing.Point(116, 20);
			this.cbMaKhoaHoc.Name = "cbMaKhoaHoc";
			this.cbMaKhoaHoc.Size = new System.Drawing.Size(121, 21);
			this.cbMaKhoaHoc.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dgvTraCuu);
			this.groupBox1.Location = new System.Drawing.Point(3, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(770, 368);
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
            this.Column5});
			this.dgvTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTraCuu.Location = new System.Drawing.Point(3, 17);
			this.dgvTraCuu.Name = "dgvTraCuu";
			this.dgvTraCuu.Size = new System.Drawing.Size(764, 348);
			this.dgvTraCuu.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MAKH";
			this.Column1.HeaderText = "Mã Khóa Học";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TENKH";
			this.Column2.HeaderText = "Tên Khóa Học";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "THOIGIAN";
			this.Column3.HeaderText = "Tổng thời gian";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "TAILIEU";
			this.Column4.HeaderText = "Tài Liệu Giảng Dạy";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "MOTA";
			this.Column5.HeaderText = "Mô Tả";
			this.Column5.Name = "Column5";
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnTraCuu.Location = new System.Drawing.Point(26, 445);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
			this.btnTraCuu.TabIndex = 3;
			this.btnTraCuu.Text = "Tra cứu";
			this.btnTraCuu.UseVisualStyleBackColor = true;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// TraCuuKhoaHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 480);
			this.Controls.Add(this.btnTraCuu);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbMaKhoaHoc);
			this.Controls.Add(this.label1);
			this.Name = "TraCuuKhoaHoc";
			this.Text = "Tra Cứu Khóa Học";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTraCuu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaKhoaHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTraCuu;
        private System.Windows.Forms.Button btnTraCuu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}