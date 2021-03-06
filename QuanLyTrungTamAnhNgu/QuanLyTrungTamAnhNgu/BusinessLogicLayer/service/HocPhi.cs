﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class HocPhi
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                HocPhiService hpsv = new HocPhiService();

                return hpsv.getAll();

            }
            return null;
        }
        public int insert(string id, string pass, string mahp, string tenhp, string sotien)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1)//kiểm tra id này có quyền insert không... 
                {
                    HocPhiService hpsv = new HocPhiService();
                    return hpsv.insert(mahp, tenhp, sotien);
                }
            }

            return 0;
        }

        public int delete(string id, string pass, string mahp) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    HocPhiService hpsv = new HocPhiService();
                    return hpsv.delete(mahp);
                }
            }
            return 0;
        }
        public DataTable get(string id, string pass, string mahp) // Ý nghĩa của hàm này ???
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                HocPhiService hpsv = new HocPhiService();
                return hpsv.get(mahp);

            }
            return null;

        }
        public int update(string id, string pass, string mahp, string tenhp, string sotien)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    HocPhiService hpsv = new HocPhiService();
                    return hpsv.update(mahp, tenhp, sotien);
                }
            }
            return 0;
        }
        public DataTable getjoin(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                HocPhiService hpsv = new HocPhiService();
                return hpsv.joinhocphi();

            }
            return null;
        }

        public string joinsotien(string id, string pass, string malop)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                HocPhiService hpsv = new HocPhiService();
                return hpsv.joinsotien(malop);
            }
            return "";
        }
        public DataTable getjoin_hv(string id, string pass, string mahv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                HocPhiService hpsv = new HocPhiService();
                return hpsv.joinhocphi_mahv(mahv);

            }
            return null;
        }
    }
}
