﻿namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    partial class TraCuuDiemThiMotLop
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
            this.maLopComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bangDiemGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traCuuDiemThiButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // maLopComboBox
            // 
            this.maLopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maLopComboBox.FormattingEnabled = true;
            this.maLopComboBox.Location = new System.Drawing.Point(98, 20);
            this.maLopComboBox.Name = "maLopComboBox";
            this.maLopComboBox.Size = new System.Drawing.Size(160, 21);
            this.maLopComboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bangDiemGridView);
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 305);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bangDiemGridView
            // 
            this.bangDiemGridView.AllowUserToAddRows = false;
            this.bangDiemGridView.AllowUserToDeleteRows = false;
            this.bangDiemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangDiemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.bangDiemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangDiemGridView.Location = new System.Drawing.Point(3, 17);
            this.bangDiemGridView.MultiSelect = false;
            this.bangDiemGridView.Name = "bangDiemGridView";
            this.bangDiemGridView.ReadOnly = true;
            this.bangDiemGridView.Size = new System.Drawing.Size(723, 285);
            this.bangDiemGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHV";
            this.Column1.HeaderText = "Mã học viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Tên học viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIEMGK";
            this.Column3.HeaderText = "Điểm phần 1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DIEMCK";
            this.Column4.HeaderText = "Điểm phần 2";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TONGDIEM";
            this.Column5.HeaderText = "Tổng điểm";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "KETQUA";
            this.Column6.HeaderText = "Kết quả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // traCuuDiemThiButton
            // 
            this.traCuuDiemThiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.traCuuDiemThiButton.Location = new System.Drawing.Point(13, 411);
            this.traCuuDiemThiButton.Name = "traCuuDiemThiButton";
            this.traCuuDiemThiButton.Size = new System.Drawing.Size(75, 23);
            this.traCuuDiemThiButton.TabIndex = 3;
            this.traCuuDiemThiButton.Text = "Tra cứu";
            this.traCuuDiemThiButton.UseVisualStyleBackColor = true;
            this.traCuuDiemThiButton.Click += new System.EventHandler(this.traCuuDiemThiButton_Click);
            // 
            // TraCuuDiemThiMotLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 446);
            this.Controls.Add(this.traCuuDiemThiButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maLopComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TraCuuDiemThiMotLop";
            this.Text = "Tra Cứu Điểm Thi Của Một Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox maLopComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView bangDiemGridView;
        private System.Windows.Forms.Button traCuuDiemThiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}