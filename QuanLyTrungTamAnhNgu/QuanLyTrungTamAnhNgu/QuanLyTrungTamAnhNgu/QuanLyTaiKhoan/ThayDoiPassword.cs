using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.service;
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
            switch (Login.ChangePassword(username, this.txtOldPassword.Text, this.txtNewPassword.Text, this.txtVerifyPassword.Text))
            {
                case 0:
                    DialogHelper.ExtendedShowErrorDialog("Bạn đã thay đổi Password thành công", "Change Password Success", 1, 2);
                    resetTextField();
                    break;
                case 1:
                    DialogHelper.ExtendedShowErrorDialog("Xin hãy nhập đúng password của bạn", "Password Incorrect", 3, 1);
                    resetTextField();
                    break;
                case 2:
                    DialogHelper.ExtendedShowErrorDialog("Mời bạn nhập password mới", "New Password Error", 3, 4);
                    resetTextField();
                    break;
                case 3:
                    DialogHelper.ExtendedShowErrorDialog("Xin hãy xác nhận đúng password bạn thay đổi", "Verify Password Incorrect", 3, 1);
                    resetTextField();
                    break;
            }
        }

        private void resetTextField()
        {
            this.txtNewPassword.Text = "";
            this.txtOldPassword.Text = "";
            this.txtVerifyPassword.Text = "";
        }
    }
}
