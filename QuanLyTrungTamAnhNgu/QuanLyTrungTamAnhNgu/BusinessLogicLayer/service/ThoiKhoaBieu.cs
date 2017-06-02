using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class ThoiKhoaBieu
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThoiKhoaBieuService tkbsv = new ThoiKhoaBieuService();

                return tkbsv.getAll();

            }
            return null;
        }
        public int insert(string id, string pass, string malop, int maphong, string malh)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {

                    ThoiKhoaBieuService tkbsv = new ThoiKhoaBieuService();
                    return tkbsv.insert(malop, maphong, malh);
                }
            }
            return 0;
        }


        public int delete(string id, string pass, string matkb) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    ThoiKhoaBieuService tkbsv = new ThoiKhoaBieuService();
                    return tkbsv.delete(matkb);
                }
            }
            return 0;
        }

        public DataTable get(string id, string pass, string matkb)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                ThoiKhoaBieuService tkbsv = new ThoiKhoaBieuService();
                return tkbsv.get(matkb);
            }
            return null;

        }
        public int update(string id, string pass, string malop, int maphong, string malh)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {

                    ThoiKhoaBieuService tkbsv = new ThoiKhoaBieuService();
                    return tkbsv.update(malop, maphong, malh);
                }
            }
            return 0;
        }
    }
}
