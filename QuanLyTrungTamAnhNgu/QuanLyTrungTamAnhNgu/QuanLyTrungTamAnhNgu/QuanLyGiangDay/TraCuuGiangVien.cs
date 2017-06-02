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
    public partial class TraCuuGiangVien : DevExpress.XtraEditors.XtraForm
    {
		private BusinessLogicLayer.service.GiangVien giangVienService;


        public TraCuuGiangVien()
        {
            InitializeComponent();
			InitializeService();
			PopulateMaGiaoVienComboBox();
        }

		
		// Dua tat ca ma giao vien vao combo box
		private void PopulateMaGiaoVienComboBox()
		{
			// Lay du lieu cua tat ca cac hang roi truyen vao rows
			var rows = giangVienService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword()).Rows;

			// Voi moi row
			foreach (DataRow row in rows)
			{
				cbMaGiaoVien.Items.Add(row["MAGV"]);
			}

			// Neu cb co gia tri 
			if (cbMaGiaoVien.Items.Count > 0)
			{
				// Dua cb vao vi tri dau tien
				cbMaGiaoVien.SelectedIndex = 0;
			}
		}
		

		// Khoi tao cac service de lay du lieu
		private void InitializeService()
		{
			giangVienService = new BusinessLogicLayer.service.GiangVien();
		}

		
		// Tra cuu theo ma giao vien
		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			// Truyen du lieu lay duoc tu co so du lieu vao datatable
			DataTable dataTable = giangVienService.get(AccountHelper.getAccountId(),
				AccountHelper.getAccoutPassword(), cbMaGiaoVien.Text);

			// Lay thong tin tu dataTable gan vao dgvTraCuu
			dgvTraCuu.DataSource = dataTable;
		}
	}
}