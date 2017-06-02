using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyTrungTamAnhNgu.QuanLyHocVien;
using QuanLyTrungTamAnhNgu.QuanLyGiangDay;
using QuanLyTrungTamAnhNgu.QuanLyTaiKhoan;
using BusinessLogicLayer.service;
using QuanLyTrungTamAnhNgu.Helper;

namespace QuanLyTrungTamAnhNgu
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm(string quyen)
        {
            InitializeComponent();
            Show_Menu(quyen);
            InitCustom();
            HocVien hv = new HocVien();
            
           
        }

        private void Show_Menu(string quyen)
        {
            if (quyen == "1")
            {
                ribbonPageGroup3.Enabled = false;
               
                ribbonPageGroup5.Enabled = false;
                ribbonPageGroup6.Enabled = false;
                ribbonPageGroup7.Enabled = false;
                ribbonPageGroup8.Enabled = false;
            }
            if (quyen == "2")
            {
                //KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI
                ribbonPageGroup1.Enabled = false;
                ribbonPageGroup2.Enabled = false;
                ribbonPageGroup5.Enabled = false;
            }
            if (quyen == "3")
            {
                //GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN
                ribbonPageGroup1.Enabled = false;
                ribbonPageGroup3.Enabled = false;
              
                ribbonPageGroup6.Enabled = false;
                ribbonPageGroup7.Enabled = false;

            }
        }

        #region variable Quan Ly Giang Day
        DevExpress.XtraEditors.XtraForm subFrmQuanLyGiangDay;

        #endregion

        void InitCustom()
        {

            
            Kdict DICT_INSTANCE = new Kdict();

            subFrmQuanLyGiangDay = null;
        }



        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapHocVien form = new NhapHocVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuHocVien form = new TraCuuHocVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            LapBienLaiThuHocPhi form = new LapBienLaiThuHocPhi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuThongTinHocPhi form = new TraCuuThongTinHocPhi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapDiemThi form = new NhapDiemThi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuDiemThiCaNhan form = new TraCuuDiemThiCaNhan();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuDiemThiMotLop form = new TraCuuDiemThiMotLop();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        #region --------------------- Quan Ly Giang Day click -----------------

        // Nhap giang vien
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Close();

            subFrmQuanLyGiangDay = new NhapGiangVien();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // Tra cuu giang vien
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new TraCuuGiangVien();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // Danh sach luong giang vien
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new DanhSachLuongGiangVien();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }


        // nhap lop hoc moi
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new NhapLopHocMoi();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // Tra cuu lop hoc
        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new TraCuuLopHoc();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // Nhap khoa hoc
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new NhapKhoaHoc();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // Tra cuu khoa hoc
        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = new TraCuuKhoaHoc();
            subFrmQuanLyGiangDay.MdiParent = this;
            subFrmQuanLyGiangDay.Show();
        }

        // nợ học phí
        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Export_PDF exporter = new Export_PDF();
            exporter.NoHocPhi();

            exporter.MdiParent = this;
            exporter.Show();
        }

        // kết quả học tập
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            Export_PDF exporter = new Export_PDF();
            exporter.KetQuaHocTap();

            exporter.MdiParent = this;
            exporter.Show();
        }

        #endregion


        #region --------------------- Quan Ly Tai Khoan click -----------------
        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            string username = "admin";
            ThayDoiPassword form = new ThayDoiPassword(username);
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}