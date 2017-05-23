using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class ThongTinLuongGiangVien
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public static DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                ThongTinLuongGVService lsv = new ThongTinLuongGVService();

                return lsv.getAll();

            }
            return null;
        }
        public static int insert(string id, string pass, string matt, string magv, DateTime ngaynhan, int tinhtrang)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {

                    ThongTinLuongGVService lsv = new ThongTinLuongGVService();
                    return lsv.insert(matt, magv, ngaynhan, tinhtrang);
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
                    ThongTinLuongGVService lsv = new ThongTinLuongGVService();
                    return lsv.delete(matt);
                }
            }
            return 0;
        }
        public static DataTable get(string id, string pass, string malh)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    ThongTinLuongGVService lsv = new ThongTinLuongGVService();
                    return lsv.get(malh);

                }
            }
            return null;

        }
    }
}
