﻿using System;
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
        public MainForm()
        {
            InitializeComponent();

            InitCustom();
           
           
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
            GiangVien gv = new GiangVien();
            DataTable dt = gv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());

            //Exporter.TableToPDF(dt, "lol");

            DateTime today = DateTime.Today;

            Export_PDF exporting = new Export_PDF(dt, today.Month + "-" + today.Day + "-" + today.Year + "_NoHocPhi");
            exporting.MdiParent = this;
            exporting.Show();
        }

        // kết quả học tập
        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {

            //DataTable dt = gv.getAll(AccountHelper.getAccountId(), AccountHelper.getAccoutPassword());


            //Export_PDF exporting = new Export_PDF(dt, "LoL_LoL");
            //exporting.MdiParent = this;
            //exporting.Show();
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
    }
}