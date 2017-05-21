using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class GiangVienService : IService
    {
        public int delete(string code)
        {
            throw new NotImplementedException();
        }

        public DataTable get(string code)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            throw new NotImplementedException();
        }
        public int insert(string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            return 1;
        }
    }
}
