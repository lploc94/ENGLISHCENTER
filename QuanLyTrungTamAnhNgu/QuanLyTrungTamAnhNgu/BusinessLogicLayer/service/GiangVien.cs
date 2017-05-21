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
        public static DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {

                if (CheckService.checkRole(id, 1) == 1)//kiểm tra id này có quyền getall không... getall có roleID là 1.delete là 2.insert là 3... vâng vâng
                {
                    GiangVienService gvsv = new GiangVienService();

                    return gvsv.getAll();

                }


            }
            return null;
        }
        public static int insert(string id, string pass, string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1)//kiểm tra id này có quyền insert không... 
                {
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
        public static int delete(string id, string pass, string magv) //id và pass của nhân viên không phải id và pass của giảng viên
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1)//kiểm tra id này có quyền delete giảng viên không... 
                {
                    GiangVienService gvsv = new GiangVienService();
                    return gvsv.delete(magv);
                }
            }
            return 0;
        }
        public static DataTable get(string id, string pass, string magv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 4)==1) //có thể Sinh và LA sẽ sửa các role ID này. trước mắt của get là 4.
                {
                    GiangVienService gvsv = new GiangVienService();
                    return gvsv.get(magv);
                }

            }
            return null;

        }
    }
}
