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

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class TraCuuDiemThiMotLop : DevExpress.XtraEditors.XtraForm
    {
        private BusinessLogicLayer.service.Thi thiService;
        private BusinessLogicLayer.service.LopHoc lopHocService;
        public TraCuuDiemThiMotLop()
        {
            InitializeComponent();
            InitializeService();
            PopulateMaLop();
        }
        private void InitializeService()
        {
            thiService = new BusinessLogicLayer.service.Thi();
            lopHocService = new BusinessLogicLayer.service.LopHoc();
        }


        private void traCuuDiemThiButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string _maLop = maLopComboBox.Text;
            var _dataTable = thiService.findDiemThiByMaLop(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maLop);
            UIHelper.PopulateGridViewWithDataTable(bangDiemGridView, _dataTable);
            this.Cursor = Cursors.Arrow;
        }
        private int PopulateMaLop()
        {
            DataTable _dataTable = lopHocService.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(_dataTable, maLopComboBox);
            return 0;
        }
    }
}