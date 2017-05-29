using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.service
{
    class DangKy
    {
        public static int delete(string id, string pass, string malop, string magv)
        {
            return 1;
        }
        public static DataTable getAll(string id, string pass)
        {
            DataTable table = new DataTable();
            return table;
        }
        public static DataTable getByMaLop(string id, string pass, string malop)
        {
            DataTable table = new DataTable();
            return table;
        }
        public static DataTable getByMaHV(string id, string pass, string magv)
        {
            DataTable table = new DataTable();
            return table;
        }
        public static int insert(string id, string pass, string malop, string mahv)
        {
            return 1;
        }
    }
}
