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

        public Export_PDF(DataTable data, string _Name)
        {
            InitializeComponent();

            name = _Name;
            InitCustom(data);
        }

        void InitCustom(DataTable data)
        {
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
    }
}
