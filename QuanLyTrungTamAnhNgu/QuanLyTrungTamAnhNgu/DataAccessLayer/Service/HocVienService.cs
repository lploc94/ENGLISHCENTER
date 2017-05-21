using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace DataAccessLayer
{
    public class HocVienService : IService
    {
        /// <summary>
        /// delete học viên với code = mã học viên
        /// </summary>
        /// <param name="code">mã học viên</param>
        /// <returns>0 là faile 1 là success</returns>
        public int delete(string code)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// trả lại bảng chứa thông tin của học viên (chỉ chứa 1 record)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable get(string code)
        {
            throw new NotImplementedException();
        }

        public DataTable getAll()
        {
            throw new NotImplementedException();
        }

        public int insert(string mahv,string hoten,string gioitinh,string diachi,string sdt,string email,DateTime ngaydk,int tinhtrang)
        {
            throw new NotImplementedException();
        }
    }
}
