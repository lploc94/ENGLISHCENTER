﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class ThongTinHocPhi
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public static DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThongTinHocPhiService tthpsv = new ThongTinHocPhiService();

                return tthpsv.getAll();

            }
            return null;
        }
        public static int insert(string id, string pass, string mahv, string malop, string sotiendadong, string sotienconno, DateTime ngaydong)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {

                    ThongTinHocPhiService tthpsv = new ThongTinHocPhiService();
                    return tthpsv.insert(mahv, malop, sotiendadong, sotienconno, ngaydong);
                }
            }
            return 0;
        }


        public static int delete(string id, string pass, string matt) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    ThongTinHocPhiService tthpsv = new ThongTinHocPhiService();
                    return tthpsv.delete(matt);
                }
            }
            return 0;
        }
        public static DataTable get(string id, string pass, string matt)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    ThongTinHocPhiService tthpsv = new ThongTinHocPhiService();
                    return tthpsv.get(matt);

                }
            }
            return null;

        }
    }
}
