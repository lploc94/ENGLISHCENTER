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
		private BusinessLogicLayer.service.Thi thiService;
		private BusinessLogicLayer.service.PhongHoc phongHocService;
		private BusinessLogicLayer.service.KiemTra kiemTraService;

		public NhapLopHocMoi()
        {
            InitializeComponent();
		}

		
	}
}