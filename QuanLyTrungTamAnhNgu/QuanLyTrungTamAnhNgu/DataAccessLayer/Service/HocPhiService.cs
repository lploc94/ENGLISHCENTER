using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class HocPhiService : IService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                HOCPHI hp = qltt.HOCPHIs.Where(p => p.MAHP == code).FirstOrDefault();
                if (hp != null)
                {
                    qltt.HOCPHIs.Remove(hp);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public DataTable get(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                HOCPHI hp = qltt.HOCPHIs.Where(p => p.MAHP == code).FirstOrDefault();
                if (hp != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHP", typeof(string));
                    rtnTable.Columns.Add("TENHP", typeof(string));
                    rtnTable.Columns.Add("SOTIEN", typeof(string));
                    rtnTable.Rows.Add(hp.MAHP, hp.TENHP, hp.SOTIEN);
                    return rtnTable;
                }
            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var hpList = from r in qltt.HOCPHIs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAHP", typeof(string));
                rtnTable.Columns.Add("TENHP", typeof(string));
                rtnTable.Columns.Add("SOTIEN", typeof(string));
                foreach (HOCPHI hp in hpList)
                {
                    rtnTable.Rows.Add(hp.MAHP, hp.TENHP, hp.SOTIEN);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }

        }
        public int insert(string mahp, string tenhp, string sotien)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    HOCPHI hp = new HOCPHI()
                    {
                        MAHP = mahp,
                        TENHP = tenhp,
                        SOTIEN = sotien
                    };
                    qltt.HOCPHIs.Add(hp);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }

        }
        public int update(string mahp, string tenhp, string sotien)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    HOCPHI hp = qltt.HOCPHIs.Where(p => p.MAHP == mahp).FirstOrDefault();
                    if (hp != null)
                    {
                        hp.TENHP = tenhp;
                        hp.SOTIEN = sotien;
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
        public DataTable joinhocphi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã học viên", typeof(string));
            table.Columns.Add("Tên học viên", typeof(string));
            table.Columns.Add("Mã lớp", typeof(string));
            table.Columns.Add("Số tiền", typeof(string));
            table.Columns.Add("Ngày thanh toán", typeof(DateTime));
            table.Columns.Add("Tiền thu", typeof(string));
            table.Columns.Add("Tiền nợ", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var k = from hv in qltt.HOCVIENs
                        from hp in qltt.HOCPHIs
                        from tt in qltt.THONGTINHOCPHIs
                        from lh in qltt.LOPHOCs
                        where hv.MAHV == tt.MAHV && lh.MAHP == hp.MAHP && tt.MALOP == lh.MALOP
                        select new
                        {
                            MAHV = hv.MAHV,
                            HOTEN = hv.HOTEN,
                            MALOP = lh.MALOP,
                            SOTIEN = hp.SOTIEN,
                            NGTT = tt.NGAYDONG,
                            TIENTHU = tt.SOTIENDADONG,
                            TIENNO = tt.SOTIENCONNO,
                        };
                foreach (var item in k)
                {
                    table.Rows.Add(item.MAHV, item.HOTEN, item.MALOP, item.SOTIEN, item.NGTT, item.TIENTHU, item.TIENNO);
                }

                return table;
            }
        }

        public string joinsotien(string malop)
        {
            string chuoi = "";
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var k = from lh in qltt.LOPHOCs
                        from hp in qltt.HOCPHIs
                        where lh.MAHP == hp.MAHP && lh.MALOP == malop
                        select new
                        {
                            SOTIEN = hp.SOTIEN
                        };
                foreach (var iten in k)
                {
                    chuoi = iten.SOTIEN;
                }
                return chuoi;
            }
        }

        public DataTable joinhocphi_mahv(string mahv)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã học viên", typeof(string));
            table.Columns.Add("Tên học viên", typeof(string));
            table.Columns.Add("Mã lớp", typeof(string));
            table.Columns.Add("Số tiền", typeof(string));
            table.Columns.Add("Ngày thanh toán", typeof(DateTime));
            table.Columns.Add("Tiền thu", typeof(string));
            table.Columns.Add("Tiền nợ", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var k = from hv in qltt.HOCVIENs
                        from hp in qltt.HOCPHIs
                        from tt in qltt.THONGTINHOCPHIs
                        from lh in qltt.LOPHOCs
                        where hv.MAHV == tt.MAHV && lh.MAHP == hp.MAHP && tt.MALOP == lh.MALOP && hv.MAHV == mahv
                        select new
                        {
                            MAHV = hv.MAHV,
                            HOTEN = hv.HOTEN,
                            MALOP = lh.MALOP,
                            SOTIEN = hp.SOTIEN,
                            NGTT = tt.NGAYDONG,
                            TIENTHU = tt.SOTIENDADONG,
                            TIENNO = tt.SOTIENCONNO,
                        };
                foreach (var item in k)
                {
                    table.Rows.Add(item.MAHV, item.HOTEN, item.MALOP, item.SOTIEN, item.NGTT, item.TIENTHU, item.TIENNO);
                }

                return table;
            }
        }
    }
}
