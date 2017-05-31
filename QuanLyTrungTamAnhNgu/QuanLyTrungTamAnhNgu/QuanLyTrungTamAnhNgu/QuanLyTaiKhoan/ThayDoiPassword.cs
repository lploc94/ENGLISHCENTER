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
        private String username;
        public ThayDoiPassword()
        {
            InitializeComponent();

            this.InitializeCustomInterface();
        }

        public ThayDoiPassword(String username)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtNewPassword.Text != this.txtVerifyPassword.Text)
            {
                DialogHelper.ShowErrorDialog("Hello world");
                return;
            }

            //Todo Change password using username
        }
    }
}
