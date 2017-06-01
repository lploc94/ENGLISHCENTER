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
	/* DONE */
    public partial class DanhSachLuongGiangVien : DevExpress.XtraEditors.XtraForm
    {
		// Lay cac thong tin ve giang vien
		private BusinessLogicLayer.service.GiangVien giangVienService;

		// Lay thong tin ngay nhan luong
		private BusinessLogicLayer.service.ThongTinLuongGiangVien luongGiangVienService;

		// Lay thong tin ve luong co ban
		private BusinessLogicLayer.service.ThamSo thamSoService;


		// Constructor
        public DanhSachLuongGiangVien()
        {
			// Khoi tao cac thanh phan trong design
            InitializeComponent();

			// Khoi tao service
			InitializeService();

			// Xuat bang luong giao vien khi khoi dong
			PopulateLuongDataGridView();
        }


		// Khoi tao cac service de lay thong tin
		private void InitializeService()
		{
			giangVienService = new BusinessLogicLayer.service.GiangVien();
			luongGiangVienService = new BusinessLogicLayer.service.ThongTinLuongGiangVien();
			thamSoService = new BusinessLogicLayer.service.ThamSo();
		}


		// Cap nhat bang luong cua giao vien
		private void PopulateLuongDataGridView()
		{
			// Lay het cac thong tin trong giang vien
			DataTable resultDataTable = giangVienService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

			// Tao khoa chinh cho resultDataTable
			resultDataTable.PrimaryKey = new DataColumn[] { resultDataTable.Columns["MAGV"] };

			// Lay thong tin ve ngay nhan luong tu ThongTinLuongGiangVien service
			DataTable luongDataTable = luongGiangVienService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

			// Tao khoa chinh cho luongDataTable
			luongDataTable.PrimaryKey = new DataColumn[] { luongDataTable.Columns["MAGV"] };

			// Ket hai bang lai voi nhau
			resultDataTable.Merge(luongDataTable);

			// Xoa cac thong tin khong dung den
			resultDataTable.Columns.Remove("GIOITINH");
			resultDataTable.Columns.Remove("NGSINH");
			resultDataTable.Columns.Remove("DIACHI");
			resultDataTable.Columns.Remove("SDT");
			resultDataTable.Columns.Remove("EMAIL");
			resultDataTable.Columns.Remove("TRINHDO");
			resultDataTable.Columns.Remove("BANGCAP");
			resultDataTable.Columns.Remove("NGAYVL");
			resultDataTable.Columns.Remove("MATT");
			resultDataTable.Columns.Remove("TINHTRANG");

			// Them 2 cot Luong co ban, Luong vao resultDataTable
			resultDataTable.Columns.Add("LUONGCB", typeof(int));
			resultDataTable.Columns.Add("LUONG", typeof(int));

			// Lay luong co ban tu thamSoService
			string strluongCB = thamSoService.getLuongCB(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

			// Voi mỗi hàng trong trong bảng resultDataTable
			for (int i = 0; i < resultDataTable.Rows.Count; i++)
			{
				// Chuyen luong co ban sang int
				int luongCB;
				int.TryParse(strluongCB, out luongCB);

				// Gan luong co ban vao Luong co ban trong resultDataTable
				resultDataTable.Rows[i]["LUONGCB"] = luongCB;

				// Chuyen he so sang float
				float heSo;
				float.TryParse(resultDataTable.Rows[i]["HESO"].ToString(), out heSo);

				// Tinh toan luong co ban thong qua he so roi gan no vao LUONG trong resultDataTable
				resultDataTable.Rows[i]["LUONG"] = luongCB * heSo;
			}

			// Truyen thong tin tu resultDataTable vao dgvLuong
			dgvLuong.DataSource = resultDataTable;
		}
    }
}