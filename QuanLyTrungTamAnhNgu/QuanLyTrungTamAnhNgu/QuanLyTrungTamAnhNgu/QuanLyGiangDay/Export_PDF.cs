using BusinessLogicLayer.service;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyTrungTamAnhNgu.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu.QuanLyGiangDay
{
    public partial class Export_PDF : Form
    {
        string name = "";

        public Export_PDF()
        {
            InitializeComponent();
        }

        ThongTinHocPhi hocphi = null;
        Thi thi = null;
		

		// nhét d
        public void ShowTable(DataTable data)
        {
            lbName.Text = name;

            GridView view = gridControl1.MainView as GridView;

            DataColumnCollection dataColumns = data.Columns;

            for (int i = 0; i < dataColumns.Count; i++)
            {
                view.Columns.Add();
                view.Columns[i].Visible = true;
                view.Columns[i].FieldName = dataColumns[i].ColumnName;
                view.Columns[i].Caption = Kdict.Get(dataColumns[i].ColumnName);
            }

            gridControl1.DataSource = data;

            view.BestFitColumns();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            GridView view = gridControl1.MainView as GridView;

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = name;
                saveDialog.DefaultExt = "pdf";
                saveDialog.Filter = ".pdf document|*.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    //PdfExportOptions option = new PdfExportOptions();
                    //option.Compressed = true;
                    view.ExportToPdf(saveDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                DialogHelper.ShowErrorDialog("Lỗi khi xuất .pdf!");
                return;
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

		// Xuất bảng export ra thông qua DataTable
		public void PopExport(DataTable dt)
		{

			DateTime today = DateTime.Today;
			name = today.Month + "-" + today.Day + "-" + today.Year + "_Luong";

			ShowTable(dt);

			lbMain.Hide();
			cbMain.Hide();
		}


		public void NoHocPhi()
        {
            hocphi = new ThongTinHocPhi();
            DataTable dt = hocphi.getDsNoHocPhi(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

            DateTime today = DateTime.Today;
            name = today.Month + "-" + today.Day + "-" + today.Year + "_NoHocPhi";

            ShowTable(dt);

            lbMain.Hide();
            cbMain.Hide();
        }

        #region Ket qua hoc tap -------
        public void KetQuaHocTap()
        {
            lbMain.Text = "Chọn mã lớp";
            PopulateMaLop();

            cbMain.SelectedIndexChanged += maLop_SelectedIndexChanged;

        }

        // đổi mã lớp
        private void maLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cbMain.Text;

            if (thi == null)
                thi = new Thi();

            DataTable dt = thi.findDiemThiByMaLop(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword(), maLop);

            // sửa cột kết quả

            int endColumn = dt.Columns.Count - 1;
            //dt.Columns[endColumn].DataType = typeof(string);
            dt.Columns.Add("Kết quả", typeof(string));

            DataRowCollection rows = dt.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                if (rows[i].Field<int>(endColumn).Equals(0))
                {
                    rows[i].SetField(endColumn + 1, "rớt");
                }
                else
                {
                    rows[i].SetField(endColumn + 1, "đậu");
                }
            }

            dt.Columns.RemoveAt(endColumn);

            DateTime today = DateTime.Today;
            name = today.Month + "-" + today.Day + "-" + today.Year + "_KetQuaHocTap_" + maLop;

            ShowTable(dt);

        }

        private int PopulateMaLop()
        {
            LopHoc lophoc = new LopHoc();

            DataTable dataTable = lophoc.getAllId(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());
            UIHelper.PopulateComboBoxWithDataTable(dataTable, cbMain);
            return 0;
        }

        #endregion
    }
}
