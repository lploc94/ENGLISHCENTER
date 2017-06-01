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
    public partial class TraCuuLopHoc : DevExpress.XtraEditors.XtraForm
    {
		private BusinessLogicLayer.service.CT_LopHoc CT_LopHocService;
		private BusinessLogicLayer.service.LopHoc lopHocService;

		private DataTable resultDataTable;

        public TraCuuLopHoc()
        {
            InitializeComponent();
			InitializeService();
			PopulateMaLopHocComboBox();
			PopulateResulteDataTable();
        }

		private void PopulateMaLopHocComboBox()
		{
			DataTable maLopHocDataTable = lopHocService.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
			
			foreach (DataRow row in maLopHocDataTable.Rows)
			{
				cbMaLopHoc.Items.Add(row["MALOP"].ToString());
			}

			if (cbMaLopHoc.Items.Count > 0)
			{
				cbMaLopHoc.SelectedIndex = 0;
			}
			
		}

		private void InitializeService()
		{
			lopHocService = new BusinessLogicLayer.service.LopHoc();
			CT_LopHocService = new BusinessLogicLayer.service.CT_LopHoc();
		}

		private void PopulateResulteDataTable()
		{
			resultDataTable = lopHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
			DataTable dt = CT_LopHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			if (cbMaLopHoc.Items.Count > 0)
			{
				foreach (DataRow row in resultDataTable.Rows)
				{
					if (row["MALOP"].ToString().Equals(cbMaLopHoc.SelectedItem.ToString()))
					{
						tbMaHocPhi.Text = row["MAHP"].ToString();
						tbMaKhoaHoc.Text = row["MAKH"].ToString();
						tbNgayBD.Text = row["NGAYBD"].ToString();
						tbNgayKT.Text = row["NGAYKT"].ToString();
						tbSiSo.Text = row["SISO"].ToString();
						break;
					}
				}
			}
		}
	}
}