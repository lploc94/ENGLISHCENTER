﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicLayer.service;
using QuanLyTrungTamAnhNgu.Helper;

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class TraCuuThongTinHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public TraCuuThongTinHocPhi()
        {
            InitializeComponent();
        }

        private void TraCuuThongTinHocPhi_Load(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            DataTable tb = new DataTable();
            tb = hv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            cbxMaHV.ValueMember = tb.Columns[0].ToString();
            cbxMaHV.DisplayMember = tb.Columns[0].ToString();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            HocPhi tthp = new HocPhi();
            dgvTraCuu.DataSource = tthp.getjoin_hv(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaHV.Text);
        }
    }
}