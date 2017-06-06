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
    public partial class TraCuuDiemThiCaNhan : DevExpress.XtraEditors.XtraForm
    {
        private BusinessLogicLayer.service.Thi thiService;
        public TraCuuDiemThiCaNhan()
        {
            InitializeComponent();
            InitializeService(); ;
            label2.Text = "Chỉ tra cứu được khi học viên có đầy đủ 2 cột điểm giữa kì và cuối kì";
        }
        private void InitializeService()
        {
            thiService = new BusinessLogicLayer.service.Thi();
        }

        private void traCuuDiemThiButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string _maHV = maHocVienTextBox.Text;
            if(_maHV == "")
            {
                DialogHelper.ShowMissingField();
                return;
            }
            var dataTable = thiService.findDiemThiByMaHV(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), _maHV);
            UIHelper.PopulateGridViewWithDataTable(bangDiemGridView, dataTable);
            this.Cursor = Cursors.Arrow;
        }
    }
}