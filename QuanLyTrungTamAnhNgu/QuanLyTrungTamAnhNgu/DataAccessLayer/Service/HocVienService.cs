using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Service;

namespace DataAccessLayer.Service
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
            using (QLTTEntities qltt = new QLTTEntities())
            {
                HOCVIEN hv = qltt.HOCVIENs.Where(p => p.MAHV == code).FirstOrDefault();
                if (hv != null)
                {
                    qltt.HOCVIENs.Remove(hv);
                    qltt.SaveChanges();
                    return 1;
                }

            }
            return 0;
        }
        /// <summary>
        /// trả lại bảng chứa thông tin của học viên (chỉ chứa 1 record)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable get(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                HOCVIEN hv = qltt.HOCVIENs.Where(p => p.MAHV == code).FirstOrDefault();
                if (hv != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHV", typeof(string));
                    rtnTable.Columns.Add("HOTEN", typeof(string));
                    rtnTable.Columns.Add("GIOITINH", typeof(int));
                    rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                    rtnTable.Columns.Add("DIACHI", typeof(string));
                    rtnTable.Columns.Add("SDT", typeof(string));
                    rtnTable.Columns.Add("EMAIL", typeof(string));
                    rtnTable.Columns.Add("NGAYDK", typeof(DateTime));
                    rtnTable.Columns.Add("TINHTRANG", typeof(int));
                    rtnTable.Rows.Add(hv.MAHV, hv.HOTEN, hv.GIOITINH, hv.NGSINH, hv.DIACHI, hv.SDT, hv.EMAIL, hv.NGAYDK, hv.TINHTRANG);

                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var hvList = from r in qltt.HOCVIENs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAHV", typeof(string));
                rtnTable.Columns.Add("HOTEN", typeof(string));
                rtnTable.Columns.Add("GIOITINH", typeof(int));
                rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                rtnTable.Columns.Add("DIACHI", typeof(string));
                rtnTable.Columns.Add("SDT", typeof(string));
                rtnTable.Columns.Add("EMAIL", typeof(string));
                rtnTable.Columns.Add("NGAYDK", typeof(DateTime));
                rtnTable.Columns.Add("TINHTRANG", typeof(int));
                foreach (HOCVIEN hv in hvList)
                {
                    rtnTable.Rows.Add(hv.MAHV, hv.HOTEN, hv.GIOITINH, hv.NGSINH, hv.DIACHI, hv.SDT, hv.EMAIL, hv.NGAYDK, hv.TINHTRANG);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }

        }

        public int insert(string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang,DateTime ngaysinh)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    HOCVIEN hv = new HOCVIEN()
                    {
                        MAHV = mahv,
                        HOTEN = hoten,
                        GIOITINH = gioitinh,
                        NGSINH = ngaysinh,
                        DIACHI = diachi,
                        SDT = sdt,
                        EMAIL = email,
                        NGAYDK = ngaydk,
                        TINHTRANG = tinhtrang

                    };
                    qltt.HOCVIENs.Add(hv);
                    qltt.SaveChanges();
                }
                return 1;
            }
            catch
            {
                return 0;

            }
        }
        public int update(string mahv, string hoten, int gioitinh, string diachi, string sdt, string email, DateTime ngaydk, int tinhtrang,DateTime ngaysinh)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    HOCVIEN hv = qltt.HOCVIENs.Where(p => p.MAHV == mahv).FirstOrDefault();
                    if (hv != null)
                    {
                        hv.HOTEN = hoten;
                        hv.GIOITINH = gioitinh;
                        hv.DIACHI = diachi;
                        hv.NGSINH = ngaysinh;
                        hv.SDT = sdt;
                        hv.EMAIL = email;
                        hv.NGAYDK = ngaydk;
                        hv.TINHTRANG = tinhtrang;
                        qltt.SaveChanges();
                        return 1;
                    }
                    return 0;
                }
                
            }
            catch
            {
                return 0;

            }
        }

        public DataTable join()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MAHV", typeof(string));
            tb.Columns.Add("HOTEN", typeof(string));
            tb.Columns.Add("GIOITINH", typeof(int));
            tb.Columns.Add("NGSINH", typeof(DateTime));
            tb.Columns.Add("DIACHI", typeof(string));
            tb.Columns.Add("SDT", typeof(string));
            tb.Columns.Add("EMAIL", typeof(string));
            tb.Columns.Add("NGAYDK", typeof(DateTime));
            tb.Columns.Add("TINHTRANG", typeof(int));
            tb.Columns.Add("MALOP", typeof(string));

            QLTTEntities qltt = new QLTTEntities();
            var k = from dk in qltt.DANGKies
                    from hv in qltt.HOCVIENs
                    from lh in qltt.LOPHOCs
                    where dk.MAHV == hv.MAHV && dk.MALOP == lh.MALOP
                    select new
                    {
                        MAHV = hv.MAHV,
                        HOTEN = hv.HOTEN,
                        GIOITINH = hv.GIOITINH,
                        NGSINH = hv.NGSINH,
                        DIACHI = hv.DIACHI,
                        SDT = hv.SDT,
                        EMAIL = hv.EMAIL,
                        NGAYDK = hv.NGAYDK,
                        TINHTRANG = hv.TINHTRANG,
                        MALOP = lh.MALOP,

                    };

            foreach (var item in k)
            {
                tb.Rows.Add(item.MAHV, item.HOTEN, item.GIOITINH, item.NGSINH, item.DIACHI, item.SDT, item.EMAIL, item.NGAYDK, item.TINHTRANG, item.MALOP);
            }
            return tb;
        }

        public DataTable getjoin(string mahv)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("MAHV", typeof(string));
            tb.Columns.Add("HOTEN", typeof(string));
            tb.Columns.Add("GIOITINH", typeof(int));
            tb.Columns.Add("NGSINH", typeof(DateTime));
            tb.Columns.Add("DIACHI", typeof(string));
            tb.Columns.Add("SDT", typeof(string));
            tb.Columns.Add("EMAIL", typeof(string));
            tb.Columns.Add("NGAYDK", typeof(DateTime));
            tb.Columns.Add("TINHTRANG", typeof(int));
            tb.Columns.Add("MALOP", typeof(string));
            tb.Columns.Add("TENKH", typeof(string));
            QLTTEntities qltt = new QLTTEntities();
            var k = from dk in qltt.DANGKies
                    from hv in qltt.HOCVIENs
                    from lh in qltt.LOPHOCs
                    from kh in qltt.KHOAHOCs
                    where dk.MAHV == hv.MAHV && dk.MALOP == lh.MALOP && lh.MAKH == kh.MAKH && hv.MAHV == mahv
                    select new
                    {
                        MAHV = hv.MAHV,
                        HOTEN = hv.HOTEN,
                        GIOITINH = hv.GIOITINH,
                        NGSINH = hv.NGSINH,
                        DIACHI = hv.DIACHI,
                        SDT = hv.SDT,
                        EMAIL = hv.EMAIL,
                        NGAYDK = hv.NGAYDK,
                        TINHTRANG = hv.TINHTRANG,
                        MALOP = lh.MALOP,
                        TENKH = kh.TENKH

                    };

            foreach (var item in k)
            {
                tb.Rows.Add(item.MAHV, item.HOTEN, item.GIOITINH, item.NGSINH, item.DIACHI, item.SDT, item.EMAIL, item.NGAYDK, item.TINHTRANG, item.MALOP, item.TENKH);
            }
            return tb;
        }
    }
}
