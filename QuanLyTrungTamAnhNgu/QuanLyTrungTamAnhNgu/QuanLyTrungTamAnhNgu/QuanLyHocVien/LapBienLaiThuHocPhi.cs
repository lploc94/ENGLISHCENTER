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
    public partial class LapBienLaiThuHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public LapBienLaiThuHocPhi()
        {
            InitializeComponent();
        }

        private void LapBienLaiThuHocPhi_Load(object sender, EventArgs e)
        {
            Load_DL();
            EditButton(true, false, false, false);
        }

        private void Load_DL()
        {
            //load combobox mã học viên
            HocVien hv = new HocVien();
            DataTable tb_hv = new DataTable();
            tb_hv = hv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            cbxMaHV.DataSource = tb_hv;
            cbxMaHV.ValueMember = tb_hv.Columns[0].ToString();
            cbxMaHV.DisplayMember = tb_hv.Columns[0].ToString();



            //Load lên datagridview
            HocPhi hp = new HocPhi();
            dataGridView1.DataSource = hp.getjoin(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

        }

        private void cbxMaHV_TextChanged(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            DataTable tb_dk = new DataTable();
            tb_dk = dk.getByMaHV(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaHV.Text);
            cbxMaLop.DataSource = tb_dk;
            cbxMaLop.DisplayMember = tb_dk.Columns[1].ToString();
            cbxMaLop.ValueMember = tb_dk.Columns[1].ToString();
        }

        private void cbxMaLop_TextChanged(object sender, EventArgs e)
        {
            HocPhi hp = new HocPhi();
            txtSoTien.Text = hp.joinsotien(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaLop.Text);
        }

        private void txtTienThu_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThu.Text == "")
            {
                txtTienNo.Text = (Convert.ToInt64(txtSoTien.Text) - 0).ToString();
            }
            else
            {
                txtTienNo.Text = (Convert.ToInt64(txtSoTien.Text) - Convert.ToInt64(txtTienThu.Text)).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThongTinHocPhi tthp = new ThongTinHocPhi();
            tthp.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaHV.Text, cbxMaLop.Text, txtTienThu.Text, txtTienNo.Text, dtNgTT.Value);
            Load_DL();
            EditButton(false, false, false, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinHocPhi tthp = new ThongTinHocPhi();
            tthp.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaHV.Text);
            Load_DL();
            EditButton(true, false, false, false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            cbxMaHV.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            txtTienThu.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            cbxMaLop.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            dtNgTT.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            EditButton(false, true, true, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinHocPhi tthp = new ThongTinHocPhi();
            tthp.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxMaHV.Text, cbxMaLop.Text, txtTienThu.Text, txtTienNo.Text, dtNgTT.Value);
            Load_DL();
            EditButton(true, false, false, false);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtTienThu.Text = "";
            cbxMaHV.Text = "";
            cbxMaLop.Text = "";
            EditButton(true, false, false, false);
        }
        private void EditButton(bool them, bool xoa, bool sua, bool xoatrang)
        {
            btnThem.Enabled = them;
            btnXoa.Enabled = xoa;
            btnSua.Enabled = sua;
            btnXoaTrang.Enabled = xoatrang;
        }
    }
}