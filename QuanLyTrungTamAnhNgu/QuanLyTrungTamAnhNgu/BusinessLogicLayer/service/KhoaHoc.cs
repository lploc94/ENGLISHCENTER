using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class KhoaHoc
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                KhoaHocService khsv = new KhoaHocService();

                return khsv.getAll();

            }
            return null;
        }
        public int insert(string id, string pass, string makh, string tenkh, string mota, string tailieu, int thoigian)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {
                    if (thoigian > 7)
                        return 0;
               
                    KhoaHocService khsv = new KhoaHocService();
                    return khsv.insert(makh, tenkh, mota, tailieu, thoigian); 
                }
            }
            return 0;
        }
        
        public int delete(string id, string pass, string makh) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    KhoaHocService khsv = new KhoaHocService();
                    return khsv.delete(makh);
                }
            }
            return 0;
        }
        public DataTable get(string id, string pass, string makh) // Ý nghĩa của hàm này ???
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1) //có thể Sinh và LA sẽ sửa các role ID này. trước mắt của get là 4.
                {
                    KhoaHocService khsv = new KhoaHocService();
                    return khsv.get(makh);

                }

            }
            return null;

        }
        public int update(string id, string pass, string makh, string tenkh, string mota, string tailieu, int thoigian)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    if (thoigian > 7)
                        return 0;

                    KhoaHocService khsv = new KhoaHocService();
                    return khsv.update(makh, tenkh, mota, tailieu, thoigian);
                }
            }
            return 0;
        }
    }
}
