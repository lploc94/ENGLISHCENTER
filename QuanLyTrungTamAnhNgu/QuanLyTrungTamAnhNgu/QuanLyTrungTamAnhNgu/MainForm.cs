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
using BusinessLogicLayer.service;
using DataAccessLayer.Service;
namespace QuanLyTrungTamAnhNgu
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            InitCustom();
        }

        #region variable Quan Ly Giang Day
        DevExpress.XtraEditors.XtraForm subFrmQuanLyGiangDay;

        NhapGiangVien frmNhapGiangVien;
        TraCuuGiangVien frmTraCuuGiangVien;
        DanhSachLuongGiangVien frmDanhSachLuongGiangVien;
        NhapLopHocMoi frmNhapLopHocMoi;
        TraCuuLopHoc frmTraCuuLopHoc;
        NhapKhoaHoc frmNhapKhoaHoc;
        TraCuuKhoaHoc frmTraCuuKhoaHoc;

        #endregion

        void InitCustom()
        {



            // Init Quan Ly Giang Day;
            subFrmQuanLyGiangDay = null;

            frmNhapGiangVien = new NhapGiangVien();
            frmNhapGiangVien.MdiParent = this;

            frmTraCuuGiangVien = new TraCuuGiangVien();
            frmTraCuuGiangVien.MdiParent = this;

            frmDanhSachLuongGiangVien = new DanhSachLuongGiangVien();
            frmDanhSachLuongGiangVien.MdiParent = this;

            frmNhapLopHocMoi = new NhapLopHocMoi();
            frmNhapLopHocMoi.MdiParent = this;

            frmTraCuuLopHoc = new TraCuuLopHoc();
            frmTraCuuLopHoc.MdiParent = this;

            frmNhapKhoaHoc = new NhapKhoaHoc();
            frmNhapKhoaHoc.MdiParent = this;

            frmTraCuuKhoaHoc = new TraCuuKhoaHoc();
            frmTraCuuKhoaHoc.MdiParent = this;
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
            CapNhatLichThi form = new CapNhatLichThi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuLichThi form = new TraCuuLichThi();
            form.MdiParent = this;
            form.Show();
        }

        #region --------------------- Quan Ly Giang Day click -----------------

        // Nhap giang vien
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmNhapGiangVien)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();


            subFrmQuanLyGiangDay = frmNhapGiangVien;
            subFrmQuanLyGiangDay.Show();

            //NhapGiangVien form = new NhapGiangVien();
            //form.MdiParent = this;
            //form.Show();
        }

        // Tra cuu giang vien
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmTraCuuGiangVien)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmTraCuuGiangVien;
            subFrmQuanLyGiangDay.Show();

            //TraCuuGiangVien form = new TraCuuGiangVien();
            //form.MdiParent = this;
            //form.Show();
        }

        // Danh sach luong giang vien
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmDanhSachLuongGiangVien)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmDanhSachLuongGiangVien;
            subFrmQuanLyGiangDay.Show();

            //DanhSachLuongGiangVien form = new DanhSachLuongGiangVien();
            //form.MdiParent = this;
            //form.Show();
        }


        // nhap lop hoc moi
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmNhapLopHocMoi)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmNhapLopHocMoi;
            subFrmQuanLyGiangDay.Show();

            //NhapLopHocMoi form = new NhapLopHocMoi();
            //form.MdiParent = this;
            //form.Show();
        }

        // Tra cuu lop hoc
        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmTraCuuLopHoc)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmTraCuuLopHoc;
            subFrmQuanLyGiangDay.Show();

            //TraCuuLopHoc form = new TraCuuLopHoc();
            //form.MdiParent = this;
            //form.Show();
        }

        // Nhap khoa hoc
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmNhapKhoaHoc)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmNhapKhoaHoc;
            subFrmQuanLyGiangDay.Show();

            //NhapKhoaHoc form = new NhapKhoaHoc();
            //form.MdiParent = this;
            //form.Show();
        }

        // Tra cuu khoa hoc
        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (subFrmQuanLyGiangDay == frmTraCuuKhoaHoc)
                return;

            if (subFrmQuanLyGiangDay != null)
                subFrmQuanLyGiangDay.Hide();

            subFrmQuanLyGiangDay = frmTraCuuKhoaHoc;
            subFrmQuanLyGiangDay.Show();

            //TraCuuKhoaHoc form = new TraCuuKhoaHoc();
            //form.MdiParent = this;
            //form.Show();
        }

        #endregion
    }
}