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
		private BusinessLogicLayer.service.DangKy dangKyService;
		private BusinessLogicLayer.service.HocVien hocVienService;

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
			dangKyService = new BusinessLogicLayer.service.DangKy();
			hocVienService = new BusinessLogicLayer.service.HocVien();
		}

		private void PopulateResulteDataTable()
		{
			resultDataTable = lopHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
		}

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			if (cbMaLopHoc.Items.Count > 0)
			{
				DataTable dt = CT_LopHocService.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
				

				foreach (DataRow row in resultDataTable.Rows)
				{
					if (row["MALOP"].ToString().Equals(cbMaLopHoc.SelectedItem.ToString()))
					{
						tbMaHocPhi.Text = row["MAHP"].ToString();
						tbMaKhoaHoc.Text = row["MAKH"].ToString();
						tbNgayBD.Text = row["NGAYBD"].ToString();
						tbNgayKT.Text = row["NGAYKT"].ToString();
						tbSiSo.Text = row["SISO"].ToString();

						foreach (DataRow mRow in dt.Rows)
						{
							if (mRow["MALOP"].ToString().Equals(cbMaLopHoc.SelectedItem.ToString()))
							{
								tbMaGV.Text = mRow["MAGV"].ToString();
							}
						}

						DataTable dkDt = dangKyService.getByMaLop(AccountHelper.getAccountId(),
							AccountHelper.getAccoutPassword(), row["MALOP"].ToString());

						DataTable hvDt = hocVienService.getAll(AccountHelper.getAccountId(),
							AccountHelper.getAccoutPassword());


						/* --------------------------  DUNG LINQ */

						//DataTable clone1 = dkDt.Clone();
						//DataTable clone2 = hvDt.Clone();
						//clone1.Merge(clone2);

						//var result = from table1 in dkDt.AsEnumerable()
						//			 join table2 in hvDt.AsEnumerable()
						//			 on (string)table1["MAHV"] equals (string)table2["MAHV"]
						//			 select new
						//			 {
						//				 MALOP = (string)table1["MALOP"],
						//				 MAHV = (string)table2["MAHV"],
						//				 HOTEN = (string)table2["HOTEN"],
						//				 GIOITINH = (int)table2["GIOITINH"],
						//				 NGSINH = (DateTime)table2["NGSINH"],
						//				 DIACHI = (string)table2["DIACHI"],
						//				 SDT = (string)table2["SDT"],
						//				 EMAIL = (string)table2["EMAIL"],
						//				 NGAYDK = (DateTime)table2["NGAYDK"],
						//				 TINHTRANG = (int)table2["TINHTRANG"]
						//			 };

						//foreach (var item in result)
						//{
						//	clone1.Rows.Add(item.MALOP, item.MAHV, item.HOTEN, item.GIOITINH, item.NGSINH, item.DIACHI,
						//		item.SDT, item.EMAIL, item.NGAYDK, item.TINHTRANG);
						//}

						/* -------------------------- KHONG DUNG LINQ */

						hvDt.PrimaryKey = new DataColumn[] { hvDt.Columns["MAHV"] };

						dkDt.Merge(hvDt);

						DataTable clone = dkDt.Clone();

						foreach (DataRow dr in dkDt.Rows)
						{
							if (dr["MALOP"].ToString().Equals(row["MALOP"].ToString()))
							{
								clone.Rows.Add(dr.ItemArray);
							}
						}

						clone.Columns.Remove(clone.Columns["MALOP"]);

						dgvSinhVien.DataSource = clone;
						break;
					}
				}
			}
		}
	}
}