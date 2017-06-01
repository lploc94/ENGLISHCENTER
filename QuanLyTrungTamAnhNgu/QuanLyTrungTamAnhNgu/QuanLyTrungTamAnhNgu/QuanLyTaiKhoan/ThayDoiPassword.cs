using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamAnhNgu.Helper;

namespace QuanLyTrungTamAnhNgu.QuanLyTaiKhoan
{
    public partial class ThayDoiPassword : Form
    {
        private string username;
        public ThayDoiPassword()
        {
            InitializeComponent();
            this.InitializeCustomInterface();
        }
        

        public ThayDoiPassword(string username)
        {
            InitializeComponent();

            this.InitializeCustomInterface();

            this.username = username;
        }

        private void InitializeCustomInterface()
        {
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.txtNewPassword.PasswordChar = '*';
            this.txtOldPassword.PasswordChar = '*';
            this.txtVerifyPassword.PasswordChar = '*';

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BusinessLogicLayer.service.Login.CheckPassword(username, this.txtOldPassword.Text))
            {
                //DialogHelper.ShowErrorDialog("Xin hãy nhập đúng password của bạn");
                DialogHelper.ExtendedShowErrorDialog("Xin hãy nhập đúng password của bạn", "Password Incorrect", 3, 1);
                return;
            }

            if (this.txtNewPassword.Text == "")
            {
                DialogHelper.ExtendedShowErrorDialog("Mời bạn nhập password mới", "New Password Error", 3, 4);
                return;
            }

            if (this.txtNewPassword.Text != this.txtVerifyPassword.Text)
            {
                //DialogHelper.ShowErrorDialog("Xin hãy xác nhận đúng password bạn thay đổi");
                DialogHelper.ExtendedShowErrorDialog("Xin hãy xác nhận đúng password bạn thay đổi", "Verify Password Incorrect", 3, 1);
                return;
            }

            //Todo Change password using username
        }
    }
}
