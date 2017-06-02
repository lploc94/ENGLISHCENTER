using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class ThamSo
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public string getLuongCB(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                ThamsoService tssv = new ThamsoService();
                return tssv.getLuongCB();
            }
            return null;
        }

        public int getSiSoToiDa(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                ThamsoService tssv = new ThamsoService();
                return tssv.getSiSoToiDa();
            }
            return 0;
        }
        public int getSiSoToiThieu(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                ThamsoService tssv = new ThamsoService();
                return tssv.getSiSoToiThieu();
            }
            return 0;
        }
    }
}
