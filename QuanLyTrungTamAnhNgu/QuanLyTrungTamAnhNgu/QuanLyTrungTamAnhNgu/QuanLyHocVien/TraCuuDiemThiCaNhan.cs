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

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class TraCuuDiemThiCaNhan : DevExpress.XtraEditors.XtraForm
    {
        private BusinessLogicLayer.service.Thi thiService;
        public TraCuuDiemThiCaNhan()
        {
            InitializeComponent();
            InitializeService();
        }
        private void InitializeService()
        {
            thiService = new BusinessLogicLayer.service.Thi();
        }

        private void traCuuDiemThiButton_Click(object sender, EventArgs e)
        {

        }
    }
}