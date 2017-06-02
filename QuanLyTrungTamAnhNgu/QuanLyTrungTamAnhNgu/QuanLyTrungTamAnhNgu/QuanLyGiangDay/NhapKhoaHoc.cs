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
	public partial class NhapKhoaHoc : DevExpress.XtraEditors.XtraForm
	{
		// Lay thong tin tu KhoaHoc trong BusinessLogicLayer
		private BusinessLogicLayer.service.KhoaHoc khoaHocService;


		// Khoi tao bang nhap khoa hoc
		public NhapKhoaHoc()
		{
			InitializeComponent();
			InitializeService();

			// Truyen gia tri vao dataGridView
			PopulateKhoaHocGridView();

			// Khi bang vua tao, dua combo box ve gia tri dau tien trong list
			PopulateTongThoiGianComboBox(0);
		}


		// Khoi tao gia tri cho cac service
		public void InitializeService()
		{
			khoaHocService = new BusinessLogicLayer.service.KhoaHoc();
		}


		// Truyen gia tri cho combo box
		public void PopulateTongThoiGianComboBox(int index)
		{
			cbTongThoiGian.SelectedIndex = index;
		}


		// Them hoac sua cac gia tri trong khoa hoc vao database
		private int InsertOrUpdateCurrentValueToDatabase(bool isUpdate = false)
		{
			// Gan cac gia tri trong phan design vao
			string maKhoaHoc = tbMaKhoaHoc.Text;
			string tenKhoaHoc = tbTenKhoaHoc.Text;
			string taiLieuGiangDay = tbTaiLieuGiangDay.Text;
			string moTa = tbMoTa.Text;

			// Tong thoi gian tinh bang thang, co gia tri bang thoi gian trong comboBox + 1
			int tongThoiGian = cbTongThoiGian.SelectedIndex + 1;
			int resultHandle;	// tra ve ket qua khi update hoac insert

			// Neu ma khoa hoc hoac ten khoa hoc khong hop le
			if (maKhoaHoc.Equals("") || tenKhoaHoc.Equals(""))
			{
				// Thong bao chua dien vao o trong
				DialogHelper.ShowMissingField();

				// Khong them hoac update
				return 1;
			}
			
			// --------------------- Neu nguoi dung muon update
			if (isUpdate)
			{
				// Khoi tao row bang row ma nguoi dung chon trong dataGridView
				DataGridViewRow row = GetCurrentRow();

				// Neu row khong ton tai, tuc dataGridView khong co gia tri
				if (row == null)
				{
					// Hien ra bang thong bao chua chon row
					DialogHelper.ShowMissingSelectedRow();

					// Update that bai
					return 1;
				}

				// Neu row co ton tai thi kiem tra thay doi trong khoa chinh
				// Trong bang nay, khoa chinh la ma khoa hoc co cell o vi tri 0 trong row
				string maKhoaHocRowValue = row.Cells["MAKH"].Value.ToString(); 

				// Neu co thay doi trong khoa chinh
				if (!maKhoaHoc.Equals(maKhoaHocRowValue))
				{
					// Hien ra bang thong bao ve viec khong the thay doi khoa chinh
					DialogHelper.ShowCannotModifiyPrimaryKey();

					// Update that bai
					return 1;
				}

				// Toi day tuc la cac gia tri can update deu thoa yeu cau, nen bat dau update
				resultHandle = khoaHocService.update(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(),
									  maKhoaHoc, tenKhoaHoc, moTa, taiLieuGiangDay, tongThoiGian); 

				// Neu viec update that bai
				if (resultHandle == 0)
				{
					// Hien ra bang co loi trong luc update
					DialogHelper.ShowErrorOnUpdate();

					// That bai trong luc update
					return 0;
				}
			}

			// ---------------------- Neu nguoi dung muon them
			else
			{
				// Kiem tra xem ma khoa chinh (maKhoaHoc) da ton tai chua
				if (khoaHocService.get(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maKhoaHoc) != null)
				{
					// Neu maKhoaHoc da ton tai trong database thi khong cho them
					// Hien bang thong bao trung khoa chinh
					DialogHelper.ShowDuplicatePrimaryKey();

					// Them khoa hoc that bai
					return 1;
				}

				// Thoa man dieu kien them khoa hoc, bat dau them
				resultHandle = khoaHocService.insert(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(),
									  maKhoaHoc, tenKhoaHoc, moTa, taiLieuGiangDay, tongThoiGian);

				// Neu viec insert that bai
				if (resultHandle == 0)
				{
					// Hien ra bang co loi trong luc insert
					DialogHelper.ShowErrorOnInsert();

					// That bai trong luc insert
					return 0;
				}
			}

			// Cap nhat lai grid view
			PopulateKhoaHocGridView();

			// Ket thuc viec them hoac update
			return 1;
		}


		// Cap nhat lai dgvKhoaHoc
		private void PopulateKhoaHocGridView()
		{
			// Lấy tất cả dữ liệu của khóa học trong cơ sở dữ liệu
			DataTable dataTable = khoaHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

			// Truyền dữ liệu đó vào khóa học
			dgvKhoaHoc.DataSource = dataTable;
		}


		// Lay gia tri cua row duoc chon
		private DataGridViewRow GetCurrentRow()
		{
			// Neu dataGridView co ton tai gia tri
			if (dgvKhoaHoc.SelectedRows.Count != 0)
			{
				// Thi gan row bang row nguoi dung chon
				DataGridViewRow row = dgvKhoaHoc.SelectedRows[0];

				// Tra ve row do
				return row;

			}
			// Con neu dataGridView khong ton tai gia tri nao
			else
			{
				// Thi tra ve null
				return null;
			}
		}


		// Khi bam vao nut them, them mot khoa hoc chua cac thong tin trong bang
		private void btnThem_Click(object sender, EventArgs e)
		{
            this.Cursor = Cursors.WaitCursor;
            // Chon viec insert
            InsertOrUpdateCurrentValueToDatabase(false);
            this.Cursor = Cursors.Arrow;
        }


		// Khi bam vao nut sua, sua mot khoa hoc da ton tai trong dataGridView
		private void btnSua_Click(object sender, EventArgs e)
		{
            this.Cursor = Cursors.WaitCursor;
            // Chon viec sua
            InsertOrUpdateCurrentValueToDatabase(true);
            this.Cursor = Cursors.Arrow;
        }

		
		// Khi bam vao nut xoa
		private void btnXoa_Click(object sender, EventArgs e)
		{
            this.Cursor = Cursors.WaitCursor;
            // Xoa cac row duoc chon ra khoi bang
            foreach (DataGridViewRow row in dgvKhoaHoc.SelectedRows)
			{
				// Neu hang nao xoa khong duoc thi dung ngay tai hang do
				if (DeleteKhoaHocRow(row) == 0)
				{
					break;
				}
			}

			// Cap nhat gridview
			PopulateKhoaHocGridView();
            this.Cursor = Cursors.Arrow;
        }


		// Xoa toan bo row ra khoi bang
		private void btnXoaTrang_Click(object sender, EventArgs e)
		{
			//// Voi moi row trong bang, ta se delete tung cai mot
			//foreach (DataGridViewRow row in dgvKhoaHoc.Rows)
			//{
			//	// Neu delete row that bai
			//	if (DeleteKhoaHocRow(row) == 0)
			//	{
			//		// Ket thuc viec delete
			//		break;
			//	}
			//}

			//// Cap nhat gridview
			//PopulateKhoaHocGridView();

			// Dua tat ca cac thong tin ve mac dinh
			tbMaKhoaHoc.Clear();
			tbTenKhoaHoc.Clear();
			tbTaiLieuGiangDay.Clear();
			tbMoTa.Clear();
			cbTongThoiGian.SelectedIndex = 0;
		}


		// Khi nhan vao mot hang trong dataGridView
		private void dgvKhoaHoc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow row = dgvKhoaHoc.SelectedRows[0];
			tbMaKhoaHoc.Text = row.Cells["MAKH"].Value.ToString();
			tbTenKhoaHoc.Text = row.Cells["TENKH"].Value.ToString();
			tbTaiLieuGiangDay.Text = row.Cells["TAILIEU"].Value.ToString();
			tbMoTa.Text = row.Cells["MOTA"].Value.ToString();
			cbTongThoiGian.SelectedIndex = (int)row.Cells["THOIGIAN"].Value - 1;
		}


		// Xoa row khoi bang 
		private int DeleteKhoaHocRow(DataGridViewRow row)
		{
			// Xoa khoa hoc theo ma khoa hoc, va gan ket qua cho resultHandle
			int resultHandle = khoaHocService.delete(AccountHelper.getAccountId(),
				AccountHelper.getAccoutPassword(), row.Cells["MAKH"].Value.ToString());

			// Neu xoa that bai
			if (resultHandle == 0)
			{
				// Thong bao co loi khi xoa
				DialogHelper.ShowErrorOnDelete();
			}

			// Tra ve ket qua qua
			return resultHandle;
		}
	}
}