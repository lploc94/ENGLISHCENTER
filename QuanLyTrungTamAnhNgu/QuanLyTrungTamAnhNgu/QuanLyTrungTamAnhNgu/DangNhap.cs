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
        private DataTable getNhanVien()
        {
            NhanVien nv = new NhanVien();
            return nv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

        }

        private string CheckLogin()
        {
            DataTable tb = getNhanVien();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (txtUser.Text == tb.Rows[i][8].ToString() && txtPass.Text == tb.Rows[i][9].ToString())
                {
                    return tb.Rows[i][10].ToString();
                }
            }

            return "-1";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        void Login()
        {
            if (CheckLogin() == "-1")
            {
                DialogHelper.ExtendedShowErrorDialog("Nhập User hoặc Password bị sai", "", 1, 2);
            }
            else
            {

                MainForm form = new MainForm(CheckLogin());
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