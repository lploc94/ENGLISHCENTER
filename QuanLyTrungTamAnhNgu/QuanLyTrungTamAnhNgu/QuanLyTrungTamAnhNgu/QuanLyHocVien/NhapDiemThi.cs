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
            var row = GetCurrentRow();
            if(row == null)
            {
                DialogHelper.ShowMissingSelectedRow();
                return;
            }
            var _maHVRowValue = row.Cells["MAHV"].Value.ToString();
            var _maLopRowValue = row.Cells["MALOP"].Value.ToString();
            var _maPhongRowValue = int.Parse(row.Cells["MAPHONG"].Value.ToString());
            var _maKTRowValue = row.Cells["MAKT"].Value.ToString();
            if (row == null)
            {
                DialogHelper.ShowMissingSelectedRow();
                return;
            }
            thiService.delete(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHVRowValue, _maKTRowValue, _maLopRowValue, _maPhongRowValue);
            PopulateBangDiemGridView();
        }

        private void suaButton_Click(object sender, EventArgs e)
        {
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
                DialogHelper.ShowMissingField();
                return 1; 
            }
            if (isUpdate)
            {
                var row = GetCurrentRow();
                if(row == null)
                {
                    DialogHelper.ShowMissingSelectedRow();
                    return 1;

                }
                var _maHVRowValue = row.Cells["MAHV"].Value.ToString();
                var _maLopRowValue = row.Cells["MALOP"].Value.ToString();
                var _maPhongRowValue = int.Parse(row.Cells["MAPHONG"].Value.ToString());
                var _maKTRowValue = row.Cells["MAKT"].Value.ToString();

                if(_maHVRowValue != _maHV 
                    || _maLopRowValue != _maLop
                    || _maPhongRowValue != _maPhong
                    || _maKTRowValue != _maKiemTra)
                {
                    DialogHelper.ShowCannotModifiyPrimaryKey();
                    return 1;
                }
            }
            int _ketQua = _diemThi >= 5 ? 1 : 0;
            bool isSuccess = true;
            if (!isUpdate)
            {
                isSuccess = thiService.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV, _maKiemTra, _maLop, _maPhong, _ngayThi, _diemThi, _ketQua) == 1;      
            }
            else
            {
                isSuccess = thiService.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV, _maKiemTra, _maLop, _maPhong, _ngayThi, _diemThi, _ketQua) == 1;
            }
            if (isSuccess)
            {
                PopulateBangDiemGridView();
                return 1;
            }
            else
            {
                DialogHelper.ShowErrorOnUpdate();
                return 0;
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
        private DataGridViewRow GetCurrentRow()
        {

            if (bangDiemGridView.SelectedRows.Count != 0)
            {
                DataGridViewRow row = bangDiemGridView.SelectedRows[0];
                return row;

            }
            else
            {
                return null;
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
            UIHelper.SetComboBoxSelectedValueByString(maLopComboBox,row.Cells["MALOP"].Value.ToString());
            UIHelper.SetComboBoxSelectedValueByString(maPhongComboBox,row.Cells["MAPHONG"].Value.ToString());
            UIHelper.SetComboBoxSelectedValueByString(maKiemTraComboBox,row.Cells["MAKT"].Value.ToString());
            ngayThiDateTimePicker.Value = (DateTime)row.Cells["NGAYTHI"].Value;
            diemThiTextBox.Text = row.Cells["DIEMTHI"].Value.ToString();
        }

       
    }
}