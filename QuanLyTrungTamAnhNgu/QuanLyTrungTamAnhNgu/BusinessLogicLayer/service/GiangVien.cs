using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace BusinessLogicLayer.service
{
    public class GiangVien
    {
        //0 admin cho phép truy cập tất cả các quyền trong hệ thống.
        //1 quyền nhân viên tiếp tân được thêm xóa sửa các bảng HOCVIEN, THONGTINHOCPHI, DANGKY các bảng còn lại chỉ được xem.
        //2 quyền nhân viên học vụ được thêm xóa sửa các bảng KHOAHOC, PHONGHOC, LICHHOC, LOPHOC, CTLOPHOC, TKB, KIEMTRA, THI các bảng còn lại chỉ được xem
        //3 quyền nhân viên kế toán được thêm xóa sửa các bảng GIANGVIEN, HOCPHI, TT_LUONGGV, NHANVIEN, các bảng còn lại chỉ được xem
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                GiangVienService gvsv = new GiangVienService();

                return gvsv.getAll();

            }
            return null;
        }
        public int insert(string id, string pass, string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền insert không... 
                {
                    if (gioitinh != 1 && gioitinh != 0)
                        return 0;
                    if (DateTime.Compare(ngaysinh, ngayvaolam) > 0)
                        return 0;
                    if (sdt.Length > 13)
                        return 0;

                    GiangVienService gvsv = new GiangVienService();
                    return gvsv.insert(magv, tengv, gioitinh, ngaysinh, diachi, sdt, email, trinhdo, bangcap, ngayvaolam, heso); //ở giảng viên service có một hàm insert, Phuong Nguyên sau khi kiểm tra id và pass, role thì có thể dùng hàm này để thêm một giảng viên vào. nếu bên dưới trả lại 1, thì tức là đã thêm thành công, PN return luôn giá trị đó.
                }
            }
            return 0;
        }
        /// <summary>
        /// delete một giảng viên
        /// </summary>
        /// <returns>0 - failed, 1 is success</returns>
        public int delete(string id, string pass, string magv) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    int returner = 0;

                    GiangVienService gvsv = new GiangVienService();
                    returner = deleteAllGVRef(gvsv, magv);

                    if (returner == 0)
                        return 0;

                    return gvsv.delete(magv);
                }
            }
            return 0;
        }

        private int deleteAllGVRef(GiangVienService gvsv, string maGV)
        {
            ThongTinLuongGVService ttlgv_service = new ThongTinLuongGVService();
            ttlgv_service.deleteByMaGV(maGV);

            CT_LopHocService ctlh_service = new CT_LopHocService();
            return ctlh_service.updateByMaGV(maGV, "null");            
        }
                        

        public DataTable get(string id, string pass, string magv) // Ý nghĩa của hàm này ???
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                GiangVienService gvsv = new GiangVienService();
                return gvsv.get(magv);

            }
            return null;

        }
        public int update(string id, string pass, string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    GiangVienService gvsv = new GiangVienService();
                    return gvsv.update(magv, tengv, gioitinh, ngaysinh, diachi, sdt, email, trinhdo, bangcap, ngayvaolam, heso);
                }
            }
            return 0;
        }
    }
}
