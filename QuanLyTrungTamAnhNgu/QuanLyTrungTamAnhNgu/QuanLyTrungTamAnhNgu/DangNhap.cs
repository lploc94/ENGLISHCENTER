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
using BusinessLogicLayer.service;
using QuanLyTrungTamAnhNgu.Helper;

namespace QuanLyTrungTamAnhNgu
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private DataRow CheckLogin()
        {
            string username = txtUser.Text;
            string userpass = txtPass.Text;
            DataTable userDataTable = (new NhanVien()).findUserByUsernameAndPass(username, userpass);
            if(userDataTable.Rows.Count == 1) {
                return userDataTable.Rows[0];
            }

            return null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        void Login()
        {
            var userData = CheckLogin();
            if (userData == null)
            {
                DialogHelper.ExtendedShowErrorDialog("Nhập User hoặc Password bị sai", "", 1, 2);
            }
            else
            {
                string quyen = userData["PHANQUYEN"].ToString();
                AccountHelper.SetLoginUserNameAndPassword(userData["USERNAME"].ToString(), userData["PASS"].ToString());
                MainForm form = new MainForm(quyen);
                form.Show();
                this.Hide();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}