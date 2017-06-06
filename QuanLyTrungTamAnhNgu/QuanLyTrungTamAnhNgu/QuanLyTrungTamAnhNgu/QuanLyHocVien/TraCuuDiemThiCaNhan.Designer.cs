namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    partial class TraCuuDiemThiCaNhan
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
            this.maHocVienTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bangDiemGridView = new System.Windows.Forms.DataGridView();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traCuuDiemThiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // maHocVienTextBox
            // 
            this.maHocVienTextBox.Location = new System.Drawing.Point(107, 25);
            this.maHocVienTextBox.Name = "maHocVienTextBox";
            this.maHocVienTextBox.Size = new System.Drawing.Size(168, 21);
            this.maHocVienTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bangDiemGridView);
            this.groupBox1.Location = new System.Drawing.Point(1, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bangDiemGridView
            // 
            this.bangDiemGridView.AllowUserToAddRows = false;
            this.bangDiemGridView.AllowUserToDeleteRows = false;
            this.bangDiemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.HoTen,
            this.DiemGK,
            this.DiemCK,
            this.TongDiem,
            this.KetQua});
            this.bangDiemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangDiemGridView.Location = new System.Drawing.Point(3, 17);
            this.bangDiemGridView.MultiSelect = false;
            this.bangDiemGridView.Name = "bangDiemGridView";
            this.bangDiemGridView.ReadOnly = true;
            this.bangDiemGridView.Size = new System.Drawing.Size(755, 320);
            this.bangDiemGridView.TabIndex = 0;
            // 
            // MaHV
            // 
            this.MaHV.DataPropertyName = "MaHV";
            this.MaHV.HeaderText = "Mã học viên";
            this.MaHV.Name = "MaHV";
            this.MaHV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Tên học viên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // DiemGK
            // 
            this.DiemGK.DataPropertyName = "DIEMGK";
            this.DiemGK.HeaderText = "Điểm phần 1";
            this.DiemGK.Name = "DiemGK";
            this.DiemGK.ReadOnly = true;
            // 
            // DiemCK
            // 
            this.DiemCK.DataPropertyName = "DIEMCK";
            this.DiemCK.HeaderText = "Điểm phần 2";
            this.DiemCK.Name = "DiemCK";
            this.DiemCK.ReadOnly = true;
            // 
            // TongDiem
            // 
            this.TongDiem.DataPropertyName = "TONGDIEM";
            this.TongDiem.HeaderText = "Tổng điểm";
            this.TongDiem.Name = "TongDiem";
            this.TongDiem.ReadOnly = true;
            // 
            // KetQua
            // 
            this.KetQua.DataPropertyName = "KETQUA";
            this.KetQua.HeaderText = "Kết quả";
            this.KetQua.Name = "KetQua";
            this.KetQua.ReadOnly = true;
            // 
            // traCuuDiemThiButton
            // 
            this.traCuuDiemThiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.traCuuDiemThiButton.Location = new System.Drawing.Point(26, 427);
            this.traCuuDiemThiButton.Name = "traCuuDiemThiButton";
            this.traCuuDiemThiButton.Size = new System.Drawing.Size(75, 23);
            this.traCuuDiemThiButton.TabIndex = 3;
            this.traCuuDiemThiButton.Text = "Tra cứu";
            this.traCuuDiemThiButton.UseVisualStyleBackColor = true;
            this.traCuuDiemThiButton.Click += new System.EventHandler(this.traCuuDiemThiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // TraCuuDiemThiCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traCuuDiemThiButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maHocVienTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TraCuuDiemThiCaNhan";
            this.Text = "Tra Cứu Điểm Thi Cá Nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maHocVienTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bangDiemGridView;
        private System.Windows.Forms.Button traCuuDiemThiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
        private System.Windows.Forms.Label label2;
    }
}