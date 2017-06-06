using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.service
{
    public class CT_LopHoc
    {
        public int delete(string id, string pass, string malop, string magv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    CT_LopHocService ctlhsv = new CT_LopHocService();
                    return ctlhsv.delete(malop, magv);
                }
            }
            return 0;
        }

        public int delete_malop(string id, string pass, string malop)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    CT_LopHocService ctlhsv = new CT_LopHocService();
                    return ctlhsv.delete_malop(malop);
                }
            }
            return 0;
        }

        public DataTable getAll(string id, string pass)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                CT_LopHocService ctlhsv = new CT_LopHocService();

                return ctlhsv.getAll();

            }
            return null;
        }
        public DataTable getByMaLop(string id, string pass,string malop)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                CT_LopHocService ctlhsv = new CT_LopHocService();
                return ctlhsv.getByMaLop(malop);
            }
            return null;
        }
        public DataTable getByMaGV(string id, string pass, string magv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                CT_LopHocService ctlhsv = new CT_LopHocService();
                return ctlhsv.getByMaGV(magv);
            }
            return null;
        }
        public int insert(string id, string pass, string malop, string magv)
        {
            if (CheckService.checkID(id, pass) == 1)
            {
                if (CheckService.checkRole(id, 2) == 1 || CheckService.checkRole(id, 0) == 1)
                {
                    CT_LopHocService ctlhsv = new CT_LopHocService();
                    return ctlhsv.insert(malop,magv);
                }
            }
            return 0;
        }
    }
}
