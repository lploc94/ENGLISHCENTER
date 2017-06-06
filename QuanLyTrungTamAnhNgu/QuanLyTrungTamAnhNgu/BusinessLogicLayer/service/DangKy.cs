using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.service
{
   public class DangKy
    {
        public int delete(string id, string pass, string mahv, string malop)
        {
            if(CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    DangKyService dksv = new DangKyService();
                    return dksv.delete(mahv, malop);
                }
            }
            return 0;
        }
        public int delete_malop(string id, string pass, string malop)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    DangKyService dksv = new DangKyService();
                    return dksv.delete_malop(malop);
                }
            }
            return 0;
        }

        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                DangKyService dk = new DangKyService();


                return dk.getAll();

            }
            return null;
        }
        public DataTable getByMaLop(string id, string pass, string malop)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                DangKyService dk = new DangKyService();


                return dk.getByMaLop(malop);

            }
            return null;
        }
        public DataTable getByMaHV(string id, string pass, string mahv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                DangKyService dk = new DangKyService();


                return dk.getByMaHV(mahv);

            }
            return null;
        }
        public int insert(string id, string pass, string malop, string mahv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 1) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    DangKyService dksv = new DangKyService();
                    return dksv.insert(mahv, malop);
                }
            }
            return 0;
        }
        

    }
}
