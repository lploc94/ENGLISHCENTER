namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    partial class NhapDiemThi
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
            this.maLopComboBox = new System.Windows.Forms.ComboBox();
            this.maPhongComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bangDiemGridView = new System.Windows.Forms.DataGridView();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KETQUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maHocVienTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maKiemTraComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngayThiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.diemThiTextBox = new System.Windows.Forms.TextBox();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.xoaTrangButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // maLopComboBox
            // 
            this.maLopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maLopComboBox.FormattingEnabled = true;
            this.maLopComboBox.Location = new System.Drawing.Point(100, 54);
            this.maLopComboBox.Name = "maLopComboBox";
            this.maLopComboBox.Size = new System.Drawing.Size(177, 21);
            this.maLopComboBox.TabIndex = 2;
            // 
            // maPhongComboBox
            // 
            this.maPhongComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maPhongComboBox.FormattingEnabled = true;
            this.maPhongComboBox.Location = new System.Drawing.Point(100, 94);
            this.maPhongComboBox.Name = "maPhongComboBox";
            this.maPhongComboBox.Size = new System.Drawing.Size(177, 21);
            this.maPhongComboBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bangDiemGridView);
            this.groupBox1.Location = new System.Drawing.Point(4, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // bangDiemGridView
            // 
            this.bangDiemGridView.AllowUserToAddRows = false;
            this.bangDiemGridView.AllowUserToDeleteRows = false;
            this.bangDiemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHV,
            this.HOTEN,
            this.MALOP,
            this.MAPHONG,
            this.MAKT,
            this.NGAYTHI,
            this.DIEMTHI,
            this.KETQUA});
            this.bangDiemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangDiemGridView.Location = new System.Drawing.Point(3, 17);
            this.bangDiemGridView.MultiSelect = false;
            this.bangDiemGridView.Name = "bangDiemGridView";
            this.bangDiemGridView.Size = new System.Drawing.Size(766, 280);
            this.bangDiemGridView.TabIndex = 0;
            this.bangDiemGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bangDiemGridView_RowHeaderMouseClick);
            // 
            // MAHV
            // 
            this.MAHV.DataPropertyName = "MAHV";
            this.MAHV.HeaderText = "Mã học viên";
            this.MAHV.Name = "MAHV";
            this.MAHV.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên học viên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã lớp";
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // MAKT
            // 
            this.MAKT.DataPropertyName = "MAKT";
            this.MAKT.HeaderText = "Mã Kiểm Tra";
            this.MAKT.Name = "MAKT";
            this.MAKT.ReadOnly = true;
            // 
            // NGAYTHI
            // 
            this.NGAYTHI.DataPropertyName = "NGAYTHI";
            this.NGAYTHI.HeaderText = "Ngày thi";
            this.NGAYTHI.Name = "NGAYTHI";
            this.NGAYTHI.ReadOnly = true;
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.DataPropertyName = "DIEMTHI";
            this.DIEMTHI.HeaderText = "Điểm thi";
            this.DIEMTHI.Name = "DIEMTHI";
            this.DIEMTHI.ReadOnly = true;
            // 
            // KETQUA
            // 
            this.KETQUA.DataPropertyName = "KETQUA";
            this.KETQUA.HeaderText = "Kết quả";
            this.KETQUA.Name = "KETQUA";
            this.KETQUA.ReadOnly = true;
            // 
            // themButton
            // 
            this.themButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.themButton.Location = new System.Drawing.Point(25, 436);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(75, 23);
            this.themButton.TabIndex = 5;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã học viên";
            // 
            // maHocVienTextBox
            // 
            this.maHocVienTextBox.Location = new System.Drawing.Point(100, 13);
            this.maHocVienTextBox.Name = "maHocVienTextBox";
            this.maHocVienTextBox.Size = new System.Drawing.Size(177, 21);
            this.maHocVienTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã kiểm tra";
            // 
            // maKiemTraComboBox
            // 
            this.maKiemTraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maKiemTraComboBox.FormattingEnabled = true;
            this.maKiemTraComboBox.Location = new System.Drawing.Point(406, 12);
            this.maKiemTraComboBox.Name = "maKiemTraComboBox";
            this.maKiemTraComboBox.Size = new System.Drawing.Size(177, 21);
            this.maKiemTraComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thi";
            // 
            // ngayThiDateTimePicker
            // 
            this.ngayThiDateTimePicker.Location = new System.Drawing.Point(406, 48);
            this.ngayThiDateTimePicker.Name = "ngayThiDateTimePicker";
            this.ngayThiDateTimePicker.Size = new System.Drawing.Size(177, 21);
            this.ngayThiDateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Điểm thi";
            // 
            // diemThiTextBox
            // 
            this.diemThiTextBox.Location = new System.Drawing.Point(406, 94);
            this.diemThiTextBox.Name = "diemThiTextBox";
            this.diemThiTextBox.Size = new System.Drawing.Size(177, 21);
            this.diemThiTextBox.TabIndex = 13;
            // 
            // xoaButton
            // 
            this.xoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xoaButton.Location = new System.Drawing.Point(124, 436);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 14;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // suaButton
            // 
            this.suaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.suaButton.Location = new System.Drawing.Point(223, 436);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 15;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            this.suaButton.Click += new System.EventHandler(this.suaButton_Click);
            // 
            // xoaTrangButton
            // 
            this.xoaTrangButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xoaTrangButton.Location = new System.Drawing.Point(322, 436);
            this.xoaTrangButton.Name = "xoaTrangButton";
            this.xoaTrangButton.Size = new System.Drawing.Size(75, 23);
            this.xoaTrangButton.TabIndex = 16;
            this.xoaTrangButton.Text = "Xóa Trắng";
            this.xoaTrangButton.UseVisualStyleBackColor = true;
            this.xoaTrangButton.Click += new System.EventHandler(this.xoaTrangButton_Click);
            // 
            // NhapDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 471);
            this.Controls.Add(this.xoaTrangButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.diemThiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngayThiDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maKiemTraComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maHocVienTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maPhongComboBox);
            this.Controls.Add(this.maLopComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiemThi";
            this.Text = "Nhập Điểm Thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox maLopComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bangDiemGridView;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maHocVienTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox maKiemTraComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngayThiDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diemThiTextBox;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button xoaTrangButton;
        private System.Windows.Forms.ComboBox maPhongComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KETQUA;
    }
}