﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class Thi
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable findDiemThiByMaHV(string id, string pass, string maHv)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThiService tsv = new ThiService();

                return tsv.findDiemThiByMaHV(maHv);

            }
            return null;
        }
        public DataTable findDiemThiByMaLop(string id, string pass, string malop)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThiService tsv = new ThiService();

                return tsv.findDiemThiByMaLop(malop);

            }
            return null;
        }

        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThiService tsv = new ThiService();

                return tsv.getAll();

            }
            return null;
        }
        public DataTable getAllWithTenHocVien(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThiService tsv = new ThiService();

                return tsv.getAllWithTenHocVien();

            }
            return null;
        }
        public int insert(string id, string pass, string mahv, string makt, string malop, int maphong, DateTime ngaythi, int diemthi, int ketqua)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {
                    if (diemthi > 1000)
                        return 0;
                    if (ketqua != 0 && ketqua != 1)
                        return 0;
                    
                    ThiService tsv = new ThiService();
                    return tsv.insert(mahv, makt, malop, maphong, ngaythi, diemthi, ketqua);
                }
            }
            return 0;
        }


        public int delete(string id, string pass, string maHV, string maKT, string maLop, int maPhong) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    ThiService tsv = new ThiService();
                    return tsv.delete(maHV, maKT, maLop, maPhong);
                }
            }
            return 0;
        }
        public DataTable get(string id, string pass, string mathi)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                ThiService tsv = new ThiService();
                return tsv.get(mathi);
            }
            return null;

        }
        public int update(string id, string pass, string mahv, string makt, string malop, int maphong, DateTime ngaythi, int diemthi, int ketqua)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {
                    if (diemthi > 1000)
                        return 0;
                    if (ketqua != 0 && ketqua != 1)
                        return 0;

                    ThiService tsv = new ThiService();
                    return tsv.update(mahv, makt, malop, maphong, ngaythi, diemthi, ketqua);
                }
            }
            return 0;
        }

        public int deleteMaHV(string id, string pass, string mahv) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    ThiService tsv = new ThiService();
                    return tsv.deleteMaHV(mahv);
                }
            }
            return 0;
        }
    }
}
