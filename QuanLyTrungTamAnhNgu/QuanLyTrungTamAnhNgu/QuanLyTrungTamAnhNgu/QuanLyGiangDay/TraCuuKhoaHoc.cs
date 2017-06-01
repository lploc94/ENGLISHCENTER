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
    public partial class TraCuuKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
		private BusinessLogicLayer.service.KhoaHoc khoaHocService;

        public TraCuuKhoaHoc()
        {
			// Tao phan design
            InitializeComponent();

			// Khoi tao cac service de lay csdl
			InitializeService();

			// Khoi tao bang combo box
			PopulateMaKhoaHocComboBox();
        }


		// Dua tat ca ma khoa hoc vao combo box
		private void PopulateMaKhoaHocComboBox()
		{
			// Gan thong tin tu co so du lieu vao dataTable
			DataTable dataTable = khoaHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

			// Neu dataTable co gia tri
			if (dataTable != null)
			{
				// Lay du lieu cua tat ca cac hang roi truyen vao rows
				var rows = dataTable.Rows;

				// Voi moi row
				foreach (DataRow row in rows)
				{
					cbMaKhoaHoc.Items.Add(row["MAKH"]);
				}

				// Neu cb co gia tri 
				if (cbMaKhoaHoc.Items.Count > 0)
				{
					// Dua cb vao vi tri dau tien
					cbMaKhoaHoc.SelectedIndex = 0;
				}
			}
		}


		// Khoi tao cac service de lay du lieu
		private void InitializeService()
		{
			khoaHocService = new BusinessLogicLayer.service.KhoaHoc();
		}


		// Tra cuu theo ma giao vien
		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			// Truyen du lieu lay duoc tu co so du lieu vao datatable
			DataTable dataTable = khoaHocService.get(AccountHelper.getAccountId(),
				AccountHelper.getAccoutPassword(), cbMaKhoaHoc.Text);

			// Lay thong tin tu dataTable gan vao dgvTraCuu
			dgvTraCuu.DataSource = dataTable;
		}
	}
}