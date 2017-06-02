using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;
using System.Text.RegularExpressions;
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
        public int insert(string id, string pass, string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang,DateTime ngaysinh)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1 )//kiểm tra id này có quyền insert không... 
                {
                    
                    if(TruongRong(hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang, ngaysinh) == true)
                    {
                        if (gioitinh != 1 && gioitinh != 0)
                            return 0;
                        if (sdt.Length > 13)
                            return 0;
                   //   Console.WriteLine(TruongRong(hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang, ngaysinh));
                        HocVienService hvsv = new HocVienService();

                        int k= hvsv.insert(mahv, hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang, ngaysinh);
                  //    Console.WriteLine(k);
                        return k;
                    }
                    
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
        public DataTable get(string id, string pass, string mahv) 
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                HocVienService hvsv = new HocVienService();
                return hvsv.get(mahv);

            }
            return null;

        }
        public int update(string id, string pass, string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang,DateTime ngaysinh)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1  )
                {
                    if(TruongRong(hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang, ngaysinh) == true)
                    {
                        HocVienService hvsv = new HocVienService();
                        return hvsv.update(mahv, hoten, gioitinh, diachi, sdt, email, ngaydk, tinhtrang, ngaysinh);
                    }
                    

                }
            }
            return 0;
        }


        public DataTable join(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                HocVienService hvsv = new HocVienService();
                return hvsv.join();
            }
            return null;
        }

        public DataTable getjoin(string id, string pass, string mahv)
        {
            if (CheckService.checkID(id, pass) == 1)//kiểm tra id,pass này có đúng không.
            {
                HocVienService hvsv = new HocVienService();
                return hvsv.getjoin(mahv);
            }
            return null;
        }

        public bool TruongRong(string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang, DateTime ngaysinh)
        {
            if (hoten == "" || gioitinh.ToString() == "" || diachi == "" || sdt == "" || email == "" || ngaydk.ToString() == "" || tinhtrang.ToString() == "" || ngaysinh.ToString() == "" || isNum(sdt) == 0 || isEmail(email) == 0)
                return false;
            else
                return true;
        }

        private int isNum(string sdt)
        {
            Regex regex = new Regex("[0-9]*");
            Match match = regex.Match(sdt);
            if (match.Success)
            {
                return 1;
            }
            else
                return 0;
        }

        private int isEmail(string email)
        {
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                    + "@"
                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
