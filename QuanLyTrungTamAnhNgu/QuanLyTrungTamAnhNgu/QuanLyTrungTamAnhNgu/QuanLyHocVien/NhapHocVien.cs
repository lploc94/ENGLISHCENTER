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
using System.Windows;

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class NhapHocVien : DevExpress.XtraEditors.XtraForm
    {
        HocVien hv = new HocVien();
        LopHoc lh = new LopHoc();
        //       KhoaHoc kh = new KhoaHoc();
        DangKy dk = new DangKy();
        ThongTinHocPhi tthp = new ThongTinHocPhi();
        Thi thi = new Thi();
        //sử dụng một biến phụ để lưu giá trị ban đầu của mã lớp áp dụng cho trường hợp update xóa rồi insert lại trong đăng ký
        string malop_phu;
        public NhapHocVien()
        {
            InitializeComponent();
        }

        private void NhapHocVien_Load(object sender, EventArgs e)
        {
            Load_HV();
            EditButton(true, false, false, false);
        }
        private void XoaText()
        {
            //đưa các trường về rỗng để nhập lần sau
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cbxTinhTrang.Text = "";
        }
        private void Load_HV()
        {
           
            DataTable table_temp = new DataTable();
            table_temp.Columns.Add("MAHV");
            table_temp.Columns.Add("HOTEN");
            table_temp.Columns.Add("GIOITINH");
            table_temp.Columns.Add("NGSINH");
            table_temp.Columns.Add("DIACHI");
            table_temp.Columns.Add("SDT");
            table_temp.Columns.Add("EMAIL");
            table_temp.Columns.Add("NGDK");
            table_temp.Columns.Add("TINHTRANG");
            table_temp.Columns.Add("MALOP");
            DataTable tb = hv.join(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            int lenght = tb.Rows.Count;
            for (int i = 0; i < lenght; i++)
            {
                string mahv = tb.Rows[i][0].ToString();
                string tenhv = tb.Rows[i][1].ToString();
                string ngaysinh = tb.Rows[i][3].ToString();
                string diachi = tb.Rows[i][4].ToString();
                string sdt = tb.Rows[i][5].ToString();
                string email = tb.Rows[i][6].ToString();
                string ngaydangky = tb.Rows[i][7].ToString();
                string malop = tb.Rows[i][9].ToString();
                if (tb.Rows[i][2].ToString() == "1")
                {
                    if (tb.Rows[i][8].ToString() == "1")
                    {
                        string gioitinh = "Nam";
                        string tinhtrang = "Còn Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop);
                    }
                    else
                    {
                        string gioitinh = "Nam";
                        string tinhtrang = "Thôi Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop);
                    }
                }
                else
                {
                    if (tb.Rows[i][8].ToString() == "1")
                    {
                        string gioitinh = "Nữ";
                        string tinhtrang = "Còn Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop);
                    }
                    else
                    {
                        string gioitinh = "Nữ";
                        string tinhtrang = "Thôi Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop);
                    }
                }
            }
            dgvNhapHocVien.DataSource = table_temp;
            //hiển thị mã học viên
            DataTable tb_hv = new DataTable();
            tb_hv = hv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            txtMaHV.Text = "HV" + (Convert.ToInt32(tb_hv.Rows[tb.Rows.Count][0].ToString().Remove(0, 2)) + 1).ToString();

            //đưa dữ liệu vào trong combox lớp học
            DataTable lophoc = lh.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            cbxLopHoc.DataSource = lophoc;
            cbxLopHoc.DisplayMember = lophoc.Columns[0].ToString();
            cbxLopHoc.ValueMember = lophoc.Columns[0].ToString();

            //xóa combobox tình trạng trước khi thêm vào
            cbxTinhTrang.Items.Clear();
            //đưa dữ liệu vào trong combox tình trạng
            cbxTinhTrang.Items.Add("Còn Học");
            cbxTinhTrang.Items.Add("Thôi Học");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int flat_hv;
            int flat_dk;
            //insert dữ liệu trong bản học viên
            if (rdNam.Checked)
            {

                if (cbxTinhTrang.Text == "Còn Học")
                {
                    flat_hv = hv.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 1, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 1, dtNgaySinh.Value);
                    
                }
                else
                    flat_hv = hv.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 1, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 0, dtNgaySinh.Value);

            }
            else
            {
                if (cbxTinhTrang.Text == "Còn Học")
                    flat_hv = hv.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 0, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 1, dtNgaySinh.Value);

                else
                    flat_hv = hv.insert(AccountHelper.getAccountId(),AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 0, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 0, dtNgaySinh.Value);
            }

            //insert bảng đăng ký

            flat_dk = dk.insert(AccountHelper.getAccountId(),AccountHelper.getAccoutPassword(), cbxLopHoc.Text, txtMaHV.Text);

            if (flat_hv == 1 && flat_dk == 1)
            {
                Load_HV();
                DialogHelper.ExtendedShowErrorDialog("Thêm thành công", "", 1, 2);
            }
            else
            {
                Load_HV();
                DialogHelper.ExtendedShowErrorDialog("Thêm không thành công", "", 1, 1);
            }


            XoaText();
            EditButton(false, false, false, true);
            this.Cursor = Cursors.Arrow;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int flat_dk = dk.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, cbxLopHoc.Text);
                int flat_tthp = tthp.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text);
                int flat_thi = thi.deleteMaHV(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text);
                int flat_hv = hv.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text);


                if (flat_hv == 1 && flat_dk == 1)
                {
                    DialogHelper.ExtendedShowErrorDialog("Xóa thành công", "", 1, 2);
                }
                else
                {
                    DialogHelper.ExtendedShowErrorDialog("Xóa không thành công", "", 1, 1);
                }
            }
            Load_HV();
            XoaText();
            EditButton(true, false, false, false);
            this.Cursor = Cursors.Arrow;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int flat_hv;
            int flat_dk;
            int flat_dkcn = 0;
            //update dữ liệu trong bản học viên
            if (rdNam.Checked)
            {
                if (cbxTinhTrang.Text == "Còn Học")
                    flat_hv = hv.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 1, txtDiaChi.Text, txtSDT.Text, txtEmail.Text,dtNgayDK.Value, 1,dtNgaySinh.Value);

                else
                    flat_hv = hv.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 1, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 0, dtNgaySinh.Value);


            }
            else
            {
                if (cbxTinhTrang.Text == "Còn Học")
                    flat_hv = hv.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 0, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 1, dtNgaySinh.Value);

                else
                    flat_hv = hv.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, txtHoTen.Text, 0, txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayDK.Value, 0, dtNgaySinh.Value);
            }

            //update bảng đăng ký
            flat_dk = dk.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), txtMaHV.Text, malop_phu);
            if (flat_dk == 1)
            {
                flat_dkcn = dk.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), cbxLopHoc.Text, txtMaHV.Text);
            }
            else
            {
                DialogHelper.ExtendedShowErrorDialog("Cập nhât không thành công", "", 1, 1);
            }



            if (flat_hv == 1 && flat_dkcn == 1)
            {
                Load_HV();
                DialogHelper.ExtendedShowErrorDialog("Cập nhật thành công", "", 1, 2);
            }
            else
            {
                Load_HV();
                DialogHelper.ExtendedShowErrorDialog("Cập nhật không thành công", "", 1, 1);
            }


            XoaText();
            EditButton(true, false, false, false);
            this.Cursor = Cursors.Arrow;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            EditButton(true, false, false, false);
            XoaText();
            Load_HV();
            this.Cursor = Cursors.Arrow;
        }

        private void dgvNhapHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvNhapHocVien.CurrentRow.Index;
            txtMaHV.Text = dgvNhapHocVien.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhapHocVien.Rows[row].Cells[1].Value.ToString();
            if (dgvNhapHocVien.Rows[row].Cells[2].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
            dtNgaySinh.Text = dgvNhapHocVien.Rows[row].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhapHocVien.Rows[row].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhapHocVien.Rows[row].Cells[5].Value.ToString();
            txtEmail.Text = dgvNhapHocVien.Rows[row].Cells[6].Value.ToString();
            dtNgayDK.Text = dgvNhapHocVien.Rows[row].Cells[7].Value.ToString();
            if (dgvNhapHocVien.Rows[row].Cells[8].Value.ToString() == "Còn Học")
            {
                cbxTinhTrang.Text = "Còn Học";
            }
            else
            {
                cbxTinhTrang.Text = "Thôi Học";
            }

            //  cbxLopHoc.DisplayMember = dataGridView1.Rows[row].Cells[9].Value.ToString();
            cbxLopHoc.SelectedValue = dgvNhapHocVien.Rows[row].Cells[9].Value.ToString();
            malop_phu = dgvNhapHocVien.Rows[row].Cells[9].Value.ToString();
            EditButton(false, true, true, true);
        }
        private void EditButton(bool them, bool xoa,bool sua,bool xoatrang)
        {
            btnThem.Enabled = them;
            btnXoa.Enabled = xoa;
            btnSua.Enabled = sua;
            btnXoaTrang.Enabled = xoatrang;
        }

    }
}