using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThongTinHocPhiService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THONGTINHOCPHI data = qltt.THONGTINHOCPHIs.Where(p => p.MAHV == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.THONGTINHOCPHIs.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public int delete_malop(string malop)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THONGTINHOCPHI data = qltt.THONGTINHOCPHIs.Where(p => p.MALOP == malop).FirstOrDefault();
                if (data != null)
                {
                    qltt.THONGTINHOCPHIs.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public DataTable get(string code)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("SOTIENDADONG", typeof(string));
            rtnTable.Columns.Add("SOTIENCONNO", typeof(string));
            rtnTable.Columns.Add("NGAYDONG", typeof(DateTime));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THONGTINHOCPHI data = qltt.THONGTINHOCPHIs.Where(p => p.MAHV == code).FirstOrDefault();
                if (data != null)
                {
                    rtnTable.Rows.Add(data.MAHV, data.MALOP, data.SOTIENDADONG,data.SOTIENCONNO,data.NGAYDONG);
                }
            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("SOTIENDADONG", typeof(string));
            rtnTable.Columns.Add("SOTIENCONNO", typeof(string));
            rtnTable.Columns.Add("NGAYDONG", typeof(DateTime));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.THONGTINHOCPHIs select r;
               

                foreach (THONGTINHOCPHI data in dataList)
                {
                    rtnTable.Rows.Add(data.MAHV, data.MALOP, data.SOTIENDADONG, data.SOTIENCONNO, data.NGAYDONG);
                }
            }
            return rtnTable;
        }
        public int insert(string mahv,string malop,string sotiendadong,string sotienconno,DateTime ngaydong)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    THONGTINHOCPHI data = new THONGTINHOCPHI()
                    {
                        MAHV = mahv,
                        MALOP = malop,
                        SOTIENDADONG = sotiendadong,
                        SOTIENCONNO = sotienconno,
                        NGAYDONG = ngaydong
                    };
                    qltt.THONGTINHOCPHIs.Add(data);
                    qltt.SaveChanges();

                    return 1;
                }

            }
            catch
            {
                return 0;

            }
        }
        public int update(string mahv, string malop, string sotiendadong, string sotienconno, DateTime ngaydong)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    THONGTINHOCPHI tt = qltt.THONGTINHOCPHIs.Where(p => p.MAHV == mahv).FirstOrDefault();
                    if(tt!=null)
                    {
                        
                        tt.SOTIENDADONG = sotiendadong;
                        tt.SOTIENCONNO = sotienconno;
                        tt.NGAYDONG = ngaydong;
                        qltt.SaveChanges();
                        return 1;
                    };
                    return 0;

                }

            }
            catch
            {
                return 0;

            }
        }
    }
}
