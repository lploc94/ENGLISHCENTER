using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamAnhNgu.Helper
{
    public static class DialogHelper
    {
        public static void ShowCannotModifiyPrimaryKey()
        {
            DialogHelper.ShowErrorDialog("Bạn không được phép chỉnh sửa khóa chính");
        }
        public static void ShowMissingField()
        {
            DialogHelper.ShowErrorDialog("Bạn không được để các giá trị bị trống");
        }
        public static void ShowMissingSelectedRow()
        {
            DialogHelper.ShowErrorDialog("Bạn phải chọn 1 dòng để sửa");
        }
        public static void ShowErrorOnUpdate()
        {
            DialogHelper.ShowErrorDialog("Có lỗi xảy ra khi cập nhật dữ liệu");
        }
        public static void ShowErrorDialog(string body)
        {
            MessageBox.Show(body, "Found Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
