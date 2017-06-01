using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyTrungTamAnhNgu.Helper;
using BusinessLogicLayer;
using BusinessLogicLayer.service;

namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    public partial class NhapLopHocMoi : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtGiangVien;
        DataTable dtKhoaHoc;
        //DataTable dtPhongHoc;
        DataTable dtHocPhi;

        DataTable dtChiTiet;

        public NhapLopHocMoi()
        {
            InitializeComponent();


            InitMaKhoaHoc();
            InitGiangVien();
            InitHocPhi();

            InitChiTiet();

            ShowTable();

            label3.Hide();
            cbMaPhong.Hide();

            btnSua.Hide();
            btnXoa.Hide();

        }

        //void InitPhongHoc()
        //{
        //    PhongHoc ph = new PhongHoc();
        //    dtPhongHoc = ph.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


        //    PopulatePhongHoc();
        //}
        //private int PopulatePhongHoc()
        //{
        //    UIHelper.PopulateComboBoxWithDataTable(dtPhongHoc, cbMaPhong);
        //    return 0;
        //}
        #region init ---------
        void InitChiTiet()
        {
            CT_LopHoc chitiet = new CT_LopHoc();
            dtChiTiet = chitiet.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

            MessageBox.Show(dtChiTiet.Rows.Count.ToString());
        }

        void InitMaKhoaHoc()
        {
            KhoaHoc kh = new KhoaHoc();
            DataTable dt = kh.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


            dtKhoaHoc = new DataTable();
            dtKhoaHoc.Columns.Add("MAKH", typeof(string));
            var rowsTarget = dtKhoaHoc.Rows;

            var rows = dt.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                rowsTarget.Add(rows[i].Field<string>(0));
            }


            PopulateKhoaHoc();
        }

        private int PopulateKhoaHoc()
        {
            UIHelper.PopulateComboBoxWithDataTable(dtKhoaHoc, cbMaKhoaHoc);
            return 0;
        }

        void InitGiangVien()
        {
            GiangVien gv = new GiangVien();
            DataTable dt = gv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


            dtGiangVien = new DataTable();
            dtGiangVien.Columns.Add("TENGV", typeof(string));
            dtGiangVien.Columns.Add("MAGV", typeof(string));
            var rowsTarget = dtGiangVien.Rows;

            var rows = dt.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                rowsTarget.Add(rows[i].Field<string>(1), rows[i].Field<string>(0));
            }


            PopulateGiangVien();
        }

        private int PopulateGiangVien()
        {
            UIHelper.PopulateComboBoxWithDataTable(dtGiangVien, cbGiangVien);
            return 0;
        }

        void InitHocPhi()
        {
            HocPhi hp = new HocPhi();
            DataTable dt = hp.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


            dtHocPhi = new DataTable();
            dtHocPhi.Columns.Add("SOTIEN", typeof(string));
            dtHocPhi.Columns.Add("MAHP", typeof(string));
            var rowsTarget = dtHocPhi.Rows;

            var rows = dt.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                rowsTarget.Add(rows[i].Field<string>(2), rows[i].Field<string>(0));
            }

            PopulateHocPhi();
        }

        private int PopulateHocPhi()
        {
            UIHelper.PopulateComboBoxWithDataTable(dtHocPhi, cbHocPhi);
            return 0;
        }

        #endregion

        private void ShowTable()
        {
            LopHoc lophoc = new LopHoc();

            DataTable table = lophoc.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


            table.Columns.Add("MAGV", typeof(string));


            foreach (DataRow row in table.Rows)
            {
                row.SetField("MAGV", GetEqualName(row.Field<string>("MALOP"), dtChiTiet, 0, 1));
                row.SetField("MAGV", GetEqualName(row.Field<string>("MAGV"), dtGiangVien, 1, 0));

                row.SetField("MAHP", GetEqualName(row.Field<string>("MAHP"), dtHocPhi, 1, 0));
            }

            dataGridView1.DataSource = table;
        }

        string GetEqualName(string name, DataTable dt, int iSearch, int iReturn)
        {
            string a = name;

            foreach (DataRow row in dt.Rows)
            {
                if (name.Equals(row.Field<string>(iSearch)))
                {
                    return row.Field<string>(iReturn);
                }
            }

            return a;
        }

        private void InsertOrUpdateCurrentValueToDatabase(bool isUpdate = false)
        {
            string maLop = txtMaLopHoc.Text;
            string maKH = cbMaKhoaHoc.Text;

            string maGV = GetEqualName(cbGiangVien.Text, dtGiangVien, 0, 1);

            DateTime ngayBD = dateNgayBatDau.Value;

            DateTime ngayKT = dateNgayKetThuc.Value;

            string maHP = GetEqualName(cbHocPhi.Text, dtHocPhi, 0, 1);

            int siSo;
            try
            {
                siSo = int.Parse(txtSiSo.Text);
            }
            catch (Exception e)
            {
                DialogHelper.ShowErrorDialog("Sĩ số nhập vào không hợp lệ!");
                return;
            }

            // điền thiếu thì báo lỗi
            if (maLop == "" ||
                maKH == "" ||
                maGV == "" ||
                maHP == "" ||
                siSo == 0)
            {
                DialogHelper.ShowMissingField();
                return;
            }


            if (isUpdate)
            {
                var row = GetCurrentRow();
                if (row == null)
                {
                    DialogHelper.ShowMissingSelectedRow();
                    return;
                }

                string _maLopRow = row.Cells["MALOP"].Value.ToString();

                if (maLop != _maLopRow)
                {
                    DialogHelper.ShowCannotModifiyPrimaryKey();
                    return;
                }
            }


            bool isSuccess = true;

            LopHoc lophoc = new LopHoc();
            CT_LopHoc chitiet = new CT_LopHoc();

            if (!isUpdate)
            {
                isSuccess = lophoc.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, maKH, ngayBD.Date, ngayKT.Date, siSo, maHP) == 1;
                chitiet.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, maGV);
            }
            else
            {
                isSuccess = lophoc.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, maKH, ngayBD.Date, ngayKT.Date, siSo, maHP) == 1;


                string oldGV = GetEqualName(maLop, dtChiTiet, 0, 1);
                // nếu có thay giảng viên
                if (!oldGV.Equals(maGV))
                {
                    isSuccess &= chitiet.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, oldGV) == 1;
                    isSuccess &= chitiet.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, maGV) == 1;

                }
            }


            if (isSuccess)
            {
                InitChiTiet();
                ShowTable();
                ClearField();
                return;
            }
            else
            {
                DialogHelper.ShowErrorOnUpdate();
                return;
            }

        }

        private void gridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            txtMaLopHoc.Text = row.Cells["MALOP"].Value.ToString();
            cbMaKhoaHoc.Text = row.Cells["MAKH"].Value.ToString();
            cbGiangVien.Text = row.Cells["MAGV"].Value.ToString();

            dateNgayBatDau.Value = (DateTime)row.Cells["NGAYBD"].Value;
            dateNgayKetThuc.Value = (DateTime)row.Cells["NGAYKT"].Value;
            cbHocPhi.Text = row.Cells["MAHP"].Value.ToString();
            txtSiSo.Text = row.Cells["SISO"].Value.ToString();
        }

        private void keyPress_onlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

        private DataGridViewRow GetCurrentRow()
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                return row;
            }
            else
            {
                return null;
            }
        }

        private void ClearField()
        {
            txtMaLopHoc.Text = "";
            cbMaKhoaHoc.Text = "";
            cbGiangVien.Text = "";
            dateNgayBatDau.Value = DateTime.Today;
            dateNgayKetThuc.Value = DateTime.Today;
            cbHocPhi.Text = "";
            txtSiSo.Text = "";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertOrUpdateCurrentValueToDatabase();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            InsertOrUpdateCurrentValueToDatabase(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var row = GetCurrentRow();
            if (row == null)
            {
                DialogHelper.ShowMissingSelectedRow();
                return;
            }

            string maLop = row.Cells["MALOP"].Value.ToString();
            string maGV = GetEqualName(row.Cells["MAGV"].Value.ToString(), dtGiangVien, 1, 0);

            LopHoc lophoc = new LopHoc();
            CT_LopHoc chitiet = new CT_LopHoc();

            chitiet.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop, maGV);
            lophoc.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop);

            ShowTable();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}