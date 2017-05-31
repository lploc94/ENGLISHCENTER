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

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class NhapDiemThi : DevExpress.XtraEditors.XtraForm
    {
        private BusinessLogicLayer.service.LopHoc lopHocService;
        private BusinessLogicLayer.service.Thi thiService;
        private BusinessLogicLayer.service.PhongHoc phongHocService;
        private BusinessLogicLayer.service.KiemTra kiemTraService;

        public NhapDiemThi()
        {
            InitializeComponent();
            IntilializeService();
            PopulateMaLop();
            PopulateMaPhong();
            PopulateMaKiemTra();
            PopulateBangDiemGridView();
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            InsertOrUpdateCurrentValueToDatabase();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            var _maHV = getCurrentSelectedId();
            if(_maHV == "")
            {
                DialogHelper.ShowErrorDialog("Bạn phải chọn một dòng để xóa");
                return;
            }
            thiService.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV);
        }

        private void suaButton_Click(object sender, EventArgs e)
        {
            var _maHV = getCurrentSelectedId();
            var _maHVTextBoxValue = maHocVienTextBox.Text;
            if (_maHV == "")
            {
                DialogHelper.ShowErrorDialog("Bạn phải chọn một dòng để sửa");
                return;
            }
            if (_maHV != _maHVTextBoxValue)
            {
                DialogHelper.ShowErrorDialog("Bạn không được sửa maHV");
                return;
            }
            InsertOrUpdateCurrentValueToDatabase(true);

        }
        private int InsertOrUpdateCurrentValueToDatabase(bool isUpdate = false)
        {
            int _diemThi;
            string _maHV = maHocVienTextBox.Text;
            string _maLop = maLopComboBox.Text;
            int _maPhong = int.Parse(maPhongComboBox.Text);
            string _maKiemTra = maKiemTraComboBox.Text;
            string _diemThiString = diemThiTextBox.Text;
            DateTime _ngayThi = ngayThiDateTimePicker.Value;
            bool _isDiemThiValid = int.TryParse(_diemThiString, out _diemThi);
            if (_maHV == "" ||
                _diemThiString == "" ||
                !_isDiemThiValid)
            {
                DialogHelper.ShowErrorDialog("Các trường không được rỗng");
                return 1; 
            }
            int _ketQua = _diemThi >= 5 ? 1 : 0;
            bool isSuccess = true;
            if (!isUpdate)
            {
                isSuccess = thiService.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV, _maKiemTra, _maLop, _maPhong, _ngayThi, _diemThi, _ketQua) == 0;      
            }
            else
            {
                isSuccess = thiService.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV, _maKiemTra, _maLop, _maPhong, _ngayThi, _diemThi, _ketQua) == 0;
            }
            if (isSuccess)
            {
                PopulateBangDiemGridView();
                return 0;
            }
            else
            {
                DialogHelper.ShowErrorDialog("Có lỗi xảy ra khi cập nhật dữ liệu");
                return 1;
            }

        } 

        private void xoaTrangButton_Click(object sender, EventArgs e)
        {

        }
        private string getCurrentSelectedId()
        {
            if (bangDiemGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = bangDiemGridView.SelectedRows[0];
                return row.Cells["MAHV"].Value.ToString();

            }else
            {
                return "";
            }
           

        }
        private int IntilializeService()
        {
            lopHocService = new BusinessLogicLayer.service.LopHoc();
            thiService = new BusinessLogicLayer.service.Thi();
            phongHocService = new BusinessLogicLayer.service.PhongHoc();
            kiemTraService = new BusinessLogicLayer.service.KiemTra();
            return 0;
        }
        private int PopulateBangDiemGridView()
        {
            DataTable dataTable = thiService.getAllWithTenHocVien(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            bangDiemGridView.DataSource = dataTable;
            return 0;
        }


        private int PopulateMaLop()
        {
            DataTable dataTable = lopHocService.getAllId(AccountHelper.getAccountId(),AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(dataTable, maLopComboBox);
            return 0;
        }
        private int PopulateMaPhong()
        {
            DataTable dataTable = phongHocService.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(dataTable, maPhongComboBox);
            return 0;
        }

        private int PopulateMaKiemTra()
        {
            DataTable dataTable = kiemTraService.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(dataTable, maKiemTraComboBox);
            return 0;
        }

        private void bangDiemGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = bangDiemGridView.SelectedRows[0];
            maHocVienTextBox.Text = row.Cells["MAHV"].Value.ToString();
            maLopComboBox.SelectedValue = row.Cells["MALOP"].Value.ToString();
            maPhongComboBox.SelectedValue = row.Cells["MAPHONG"].Value.ToString();
            maKiemTraComboBox.SelectedValue = row.Cells["MAKT"].Value.ToString();
            ngayThiDateTimePicker.Value = (DateTime)row.Cells["NGAYTHI"].Value;
            diemThiTextBox.Text = row.Cells["DIEMTHI"].Value.ToString();
        }
    }
}