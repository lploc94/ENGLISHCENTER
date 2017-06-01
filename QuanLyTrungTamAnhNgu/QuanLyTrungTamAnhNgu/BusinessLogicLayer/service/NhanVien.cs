using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Service;
namespace BusinessLogicLayer.service
{
    class NhanVien
    {
        public int delete(string id, string pass, string manv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    return new NhanVienService().delete(manv);
                }
            }
            return 0;
        }
        public DataTable get(string id, string pass, string manv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
               return new NhanVienService().get(manv);
                
            }
            return null;
            
        }
        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                return new NhanVienService().getAll();

            }
            return null;
        }
        public int insert(string id, string password ,string manv, string hoten, int gioitinh, DateTime ngsinh, string diachi, string sdt, string email, double hesoluong, string username, string pass, short phanquyen, bool active)
        {
            if (CheckService.checkID(id, password) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    return new NhanVienService().insert(manv,hoten,gioitinh,ngsinh,diachi,sdt,email,hesoluong,username,pass,phanquyen,active);
                }
            }
            return 0;
        }
        public int update(string id, string password, string manv, string hoten, int gioitinh, DateTime ngsinh, string diachi, string sdt, string email, double hesoluong, string username, string pass, short phanquyen, bool active)
        {
            if (CheckService.checkID(id, password) == 1)
            {
                if (CheckService.checkRole(id, 3) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    return new NhanVienService().update(manv, hoten, gioitinh, ngsinh, diachi, sdt, email, hesoluong, username, pass, phanquyen, active);
                }
            }
            return 0;
        }



    }
}
