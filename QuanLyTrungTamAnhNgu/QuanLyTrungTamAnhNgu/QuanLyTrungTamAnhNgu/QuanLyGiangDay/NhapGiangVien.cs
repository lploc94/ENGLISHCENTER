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
using BusinessLogicLayer.service;
using QuanLyTrungTamAnhNgu.Helper;

namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    public partial class NhapGiangVien : DevExpress.XtraEditors.XtraForm
    {
        public NhapGiangVien()
        {
            InitializeComponent();

            InitCustom();
        }

        GiangVien gv;

        void InitCustom()
        {
            gv = new GiangVien();            
        }

        int a = 0;

        // hiện dữ liệu lên data grid view
        private void ShowTable(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            using (DataTable table = new DataTable())// gv.getAll(id, pass))
            {
                table.Columns.Add("MAGV", typeof(string));
                table.Columns.Add("TENGV", typeof(string));
                table.Columns.Add("GIOITINH", typeof(string));
                table.Columns.Add("NGSINH", typeof(DateTime));
                table.Columns.Add("DIACHI", typeof(string));
                table.Columns.Add("SDT", typeof(string));
                table.Columns.Add("EMAIL", typeof(string));
                table.Columns.Add("TRINHDO", typeof(string));
                table.Columns.Add("BANGCAP", typeof(string));
                table.Columns.Add("NGAYVL", typeof(DateTime));
                table.Columns.Add("HESO", typeof(double));

                DataTable newTable = gv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

                string tempGioiTinh = "";

                foreach (DataRow row in newTable.Rows)
                {
                    if (row.Field<int>(2) == 0)
                    {
                        tempGioiTinh = "nữ";
                    }
                    else
                    {
                        tempGioiTinh = "nam";
                    }

                    table.Rows.Add(
                        row.Field<string>(0), row.Field<string>(1), tempGioiTinh,
                        row.Field<DateTime>(3), row.Field<string>(4),
                        row.Field<string>(5), row.Field<string>(6), row.Field<string>(7),
                        row.Field<string>(8), row.Field<DateTime>(9), row.Field<double>(10));

                }

                dataGridView1.DataSource = table;
            }
        }

        private void InsertOrUpdateCurrentValueToDatabase(bool isUpdate = false)
        {
            string maGiangVien = txtMaGiangVien.Text;
            string tenGiangVien = txtTenGiangVien.Text;

            int gioiTinh;
            if(rbNam.Checked)
            {
                gioiTinh = 1;
            }
            else
            {
                gioiTinh = 0;
            }

            DateTime ngaySinh = dateNgaySinh.Value;

            string diaChi = txtDiaChi.Text;

            string SDT;
            try
            {
                int soDienThoai = int.Parse(txtSDT.Text);
                SDT = soDienThoai.ToString();
            }
            catch (Exception e)
            {
                DialogHelper.ShowErrorDialog("Số điện thoại nhập vào không hợp lệ!");
                return;
            }

            string email = txtEmail.Text;
            string trinhDo = txtTrinhDo.Text;
            string bangCap = txtBangCap.Text;

            DateTime ngayVL = dateNgayVaoLam.Value;

            double heSo;
            try { heSo = double.Parse(txtHeLuong.Text); }
            catch (Exception e)
            {
                DialogHelper.ShowErrorDialog("Hệ số lương nhập vào không hợp lệ!");
                return;
            }

            
            // điền thiếu thì báo lỗi
            if (maGiangVien == "" ||
                tenGiangVien == "" ||
                diaChi == "" ||
                SDT == "" ||
                email == "" ||
                trinhDo == "" ||
                heSo == 0)
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

                string _maGVRow = row.Cells["MAGV"].Value.ToString();

                if (maGiangVien != _maGVRow)
                {
                    DialogHelper.ShowCannotModifiyPrimaryKey();
                    return;
                }
            }

            
            bool isSuccess = true;
            if (!isUpdate)
            {
                isSuccess = gv.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maGiangVien, tenGiangVien, gioiTinh, ngaySinh.Date, diaChi, SDT, email, trinhDo, bangCap, ngayVL.Date, heSo) == 1;
            }
            else
            {
                isSuccess = gv.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maGiangVien, tenGiangVien, gioiTinh, ngaySinh.Date, diaChi, SDT, email, trinhDo, bangCap, ngayVL.Date, heSo) == 1;
            }


            if (isSuccess)
            {
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

        private void gridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            txtMaGiangVien.Text = row.Cells["MAGV"].Value.ToString();            
            dateNgaySinh.Value = (DateTime)row.Cells["NGSINH"].Value;
            txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
            txtTenGiangVien.Text = row.Cells["TENGV"].Value.ToString();
            txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            txtTrinhDo.Text = row.Cells["TRINHDO"].Value.ToString();
            dateNgayVaoLam.Value = (DateTime)row.Cells["NGAYVL"].Value;

            bool isFemale = (row.Cells["GIOITINH"].Value.ToString().Equals("nữ"));
            if(isFemale)
            {
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = true;
            }

            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            txtBangCap.Text = row.Cells["BANGCAP"].Value.ToString();
            txtHeLuong.Text = row.Cells["HESO"].Value.ToString();
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
            txtMaGiangVien.Text = "";
            txtEmail.Text = "";
            txtTenGiangVien.Text = "";
            txtDiaChi.Text = "";
            txtTrinhDo.Text = "";
            dateNgayVaoLam.Value = DateTime.Today;
            rbNu.Checked = true;
            txtSDT.Text = "";
            txtBangCap.Text = "";
            txtHeLuong.Text = "";
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

            var maGV = row.Cells["MAGV"].Value.ToString();

            gv.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maGV);
            ShowTable();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}