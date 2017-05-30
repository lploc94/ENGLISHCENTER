using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class HocVien
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                HocVienService hvsv = new HocVienService();
                return hvsv.getAll();
            }
            return null;
        }
        public int insert(string id, string pass, string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {
                    if (gioitinh != 1 && gioitinh != 0)
                        return 0;
                    if (sdt.Length > 13)
                        return 0;

                    HocVienService hvsv = new HocVienService();
                    return hvsv.insert(mahv, hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang);
                }
            }
            return 0;
        }
        
        public int delete(string id, string pass, string mahv) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    HocVienService hvsv = new HocVienService();
                    return hvsv.delete(mahv);
                }
            }
            return 0;
        }
        public DataTable get(string id, string pass, string mahv) // Ý nghĩa của hàm này ???
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1) 
                {
                    HocVienService hvsv = new HocVienService();
                    return hvsv.get(mahv);
                }

            }
            return null;

        }
        public int update(string id, string pass, string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    HocVienService hvsv = new HocVienService();
                    return hvsv.update(mahv, hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang);

                }
            }
            return 0;
        }
    }
}
