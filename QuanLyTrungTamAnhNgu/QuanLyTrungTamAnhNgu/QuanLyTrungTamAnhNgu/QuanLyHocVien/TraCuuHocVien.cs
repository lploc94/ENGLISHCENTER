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

namespace QuanLyTrungTamAnhNgu.QuanLyHocVien
{
    public partial class TraCuuHocVien : DevExpress.XtraEditors.XtraForm
    {
        public TraCuuHocVien()
        {
            InitializeComponent();
        }

        private void TraCuuHocVien_Load(object sender, EventArgs e)
        {

            HocVien hv = new HocVien();
            DataTable tb = new DataTable();
            tb = hv.getAll("admin", "mKFTdTmAshTS");
            cbxMaHV.DataSource = tb;
            cbxMaHV.ValueMember = tb.Columns[0].ToString();
            cbxMaHV.DisplayMember = tb.Columns[0].ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable table_temp = new DataTable();
            table_temp.Columns.Add("Mã học viên");
            table_temp.Columns.Add("Tên học viên");
            table_temp.Columns.Add("Giới Tính");
            table_temp.Columns.Add("Ngày Sinh");
            table_temp.Columns.Add("Địa chỉ");
            table_temp.Columns.Add("Số điện thoại");
            table_temp.Columns.Add("Email");
            table_temp.Columns.Add("Ngày đăng ký");
            table_temp.Columns.Add("Tình trạng");
            table_temp.Columns.Add("Mã lớp");
            table_temp.Columns.Add("Tên khóa học");
            HocVien hv = new HocVien();
            DataTable tb = new DataTable();
            tb = hv.getjoin("admin", "mKFTdTmAshTS", cbxMaHV.Text);
            int l = tb.Rows.Count;
            for (int i = 0; i < l; i++)
            {
                string mahv = tb.Rows[i][0].ToString();
                string tenhv = tb.Rows[i][1].ToString();
                string ngaysinh = tb.Rows[i][3].ToString();
                string diachi = tb.Rows[i][4].ToString();
                string sdt = tb.Rows[i][5].ToString();
                string email = tb.Rows[i][6].ToString();
                string ngaydangky = tb.Rows[i][7].ToString();
                string malop = tb.Rows[i][9].ToString();
                string khoahoc = tb.Rows[i][10].ToString();
                if (tb.Rows[i][2].ToString() == "1")
                {
                    if (tb.Rows[i][8].ToString() == "1")
                    {
                        string gioitinh = "Nam";
                        string tinhtrang = "Còn Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop, khoahoc);
                    }
                    else
                    {
                        string gioitinh = "Nam";
                        string tinhtrang = "Thôi Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop, khoahoc);
                    }
                }
                else
                {
                    if (tb.Rows[i][8].ToString() == "1")
                    {
                        string gioitinh = "Nữ";
                        string tinhtrang = "Còn Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop, khoahoc);
                    }
                    else
                    {

                        string gioitinh = "Nữ";
                        string tinhtrang = "Thôi Học";
                        table_temp.Rows.Add(mahv, tenhv, gioitinh, ngaysinh, diachi, sdt, email, ngaydangky, tinhtrang, malop, khoahoc);
                    }
                }
            }

             dgvTraCuuHocVien.DataSource = table_temp;
        }
    }
}