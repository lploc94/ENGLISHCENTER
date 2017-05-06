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

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapGiangVien form = new NhapGiangVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuGiangVien form = new TraCuuGiangVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachLuongGiangVien form = new DanhSachLuongGiangVien();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapLopHocMoi form = new NhapLopHocMoi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuLopHoc form = new TraCuuLopHoc();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhapKhoaHoc form = new NhapKhoaHoc();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            TraCuuKhoaHoc form = new TraCuuKhoaHoc();
            form.MdiParent = this;
            form.Show();
        }
    }
}