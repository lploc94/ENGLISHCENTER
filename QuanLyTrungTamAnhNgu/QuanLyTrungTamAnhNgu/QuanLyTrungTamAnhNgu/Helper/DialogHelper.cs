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
            //DialogHelper.ShowErrorDialog("Bạn không được phép chỉnh sửa khóa chính");
            DialogHelper.ExtendedShowErrorDialog("Bạn không được phép chỉnh sửa thông tin này", "Modify Error", 2, 5);
        }
        public static void ShowMissingField()
        {
            //DialogHelper.ShowErrorDialog("Bạn không được để các giá trị bị trống");
            DialogHelper.ExtendedShowErrorDialog("Bạn không được để các giá trị bị trống", "Input Error", 1, 4);
        }
        public static void ShowMissingSelectedRow()
        {
            //DialogHelper.ShowErrorDialog("Bạn phải chọn 1 dòng để sửa");
            DialogHelper.ExtendedShowErrorDialog("Bạn phải chọn 1 dòng để sửa", "Row Error", 3, 4);
        }
        public static void ShowErrorOnUpdate()
        {
            //DialogHelper.ShowErrorDialog("Có lỗi xảy ra khi cập nhật dữ liệu");
            DialogHelper.ExtendedShowErrorDialog("Có lỗi xảy ra khi cập nhật dữ liệu", "Update Error", 3, 1);
        }
        public static void ShowErrorDialog(string body)
        {
            MessageBox.Show(body, "Found Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ExtendedShowErrorDialog(string strContent, string strCaption, int iTypeButton, int iTypeIcon)
        {
            MessageBoxButtons button = new MessageBoxButtons();
            switch (iTypeButton)
            {
                case 1:
                    button = MessageBoxButtons.OK;
                    break;
                case 2:
                    button = MessageBoxButtons.OKCancel;
                    break;
                case 3:
                    button = MessageBoxButtons.RetryCancel;
                    break;
                case 4:
                    button = MessageBoxButtons.YesNo;
                    break;
                case 5:
                    button = MessageBoxButtons.YesNoCancel;
                    break;
                default:
                    button = MessageBoxButtons.OK;
                    break;
            }

            MessageBoxIcon icon = new MessageBoxIcon();
            switch (iTypeIcon)
            {
                case 1:
                    icon = MessageBoxIcon.Error;
                    break;
                case 2:
                    icon = MessageBoxIcon.Information;
                    break;
                case 3:
                    icon = MessageBoxIcon.Question;
                    break;
                case 4:
                    icon = MessageBoxIcon.Warning;
                    break;
                case 5:
                    icon = MessageBoxIcon.Stop;
                    break;
                default:
                    icon = MessageBoxIcon.Information;
                    break;
            }

            MessageBox.Show(strContent, strCaption, button, icon);
        }
    }
}
