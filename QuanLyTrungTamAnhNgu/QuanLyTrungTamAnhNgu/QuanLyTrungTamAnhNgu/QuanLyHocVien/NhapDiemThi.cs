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

        }

        private void xoaButton_Click(object sender, EventArgs e)
        {

        }

        private void suaButton_Click(object sender, EventArgs e)
        {

        }

        private void xoaTrangButton_Click(object sender, EventArgs e)
        {

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
    }
}