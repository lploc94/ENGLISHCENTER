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

namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    public partial class NhapLopHocMoi : DevExpress.XtraEditors.XtraForm
    {
		private BusinessLogicLayer.service.LopHoc lopHocService;
		private BusinessLogicLayer.service.CT_LopHoc CT_LopHocService;

		public NhapLopHocMoi()
        {
			InitializeComponent();
		}

		
		private void PopulateLopHocDataGidView()
		{

		}


		private void InitializeService()
		{
			lopHocService = new BusinessLogicLayer.service.LopHoc();
			CT_LopHocService = new BusinessLogicLayer.service.CT_LopHoc();
		}
	}
}