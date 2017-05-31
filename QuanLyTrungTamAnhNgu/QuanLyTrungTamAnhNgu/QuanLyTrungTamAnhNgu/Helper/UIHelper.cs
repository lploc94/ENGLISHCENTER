using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu.Helper
{
    public static class UIHelper
    {
        /// <summary>
        /// Populate các combo box bằng data table, có thể chỉ ra column sử dụng, nếu không sẽ lấy column đầu tiên
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="comboBox"></param>
        /// <param name="populateColumnName"></param>
        public static void  PopulateComboBoxWithDataTable(DataTable dataTable, ComboBox comboBox, String populateColumnName = "")
        {
           if(populateColumnName == "")
            {
                populateColumnName = dataTable.Columns[0].ToString();
            }
            comboBox.DisplayMember = populateColumnName;
            comboBox.DataSource = dataTable;
            comboBox.SelectedIndex = 0;
        }
        public static void SetComboBoxSelectedValueByString(ComboBox comboBox, String value)
        {
            int newIndex = 0;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                string cbValue = comboBox.GetItemText(comboBox.Items[i]);
                if(cbValue == value)
                {
                    newIndex = i;
                    break;
                }
            }
            comboBox.SelectedIndex = newIndex;
        }

    }
}
