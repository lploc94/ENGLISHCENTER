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

        }
        private int PopulateMaLop()
        {
            DataTable dataTable = lopHocService.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(dataTable, maLopComboBox);
            return 0;
        }
    }
}