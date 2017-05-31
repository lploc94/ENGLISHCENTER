using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThiService
    {
        public int delete(string mahv, string makt, string malop, int maphong)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THI t = qltt.THIs.Where(p => p.MAHV == mahv)
                        .Where(p => p.MAKT == makt)
                        .Where(p => p.MALOP == malop)
                        .Where(p => p.MAPHONG == maphong)
                    .FirstOrDefault();
                if (t != null)
                {
                    qltt.THIs.Remove(t);
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
                THI t = qltt.THIs.Where(p => p.MAKT == code).FirstOrDefault();
                if (t != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHV", typeof(string));
                    rtnTable.Columns.Add("MAKT", typeof(string));
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAPHONG", typeof(int));
                    rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
                    rtnTable.Columns.Add("DIEMTHI", typeof(int));
                    rtnTable.Columns.Add("KETQUA", typeof(int));
                    rtnTable.Rows.Add(t.MAHV, t.MAKT, t.MALOP, t.MAPHONG, t.NGAYTHI, t.DIEMTHI, t.KETQUA);
                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var tList = from r in qltt.THIs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAHV", typeof(string));
                rtnTable.Columns.Add("MAKT", typeof(string));
                rtnTable.Columns.Add("MALOP", typeof(string));
                rtnTable.Columns.Add("MAPHONG", typeof(int));
                rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
                rtnTable.Columns.Add("DIEMTHI", typeof(int));
                rtnTable.Columns.Add("KETQUA", typeof(int));
                foreach (THI t in tList)
                {
                    rtnTable.Rows.Add(t.MAHV, t.MAKT, t.MALOP, t.MAPHONG, t.NGAYTHI, t.DIEMTHI, t.KETQUA);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;

            }
           
        }
        public DataTable getAllWithTenHocVien()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var tList = from r in qltt.THIs
                            join hv in qltt.HOCVIENs
                            on r.MAHV equals hv.MAHV
                            select new { THI = r, HOCTEN = hv.HOTEN };
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAHV", typeof(string));
                rtnTable.Columns.Add("HOTEN", typeof(string));
                rtnTable.Columns.Add("MAKT", typeof(string));
                rtnTable.Columns.Add("MALOP", typeof(string));
                rtnTable.Columns.Add("MAPHONG", typeof(int));
                rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
                rtnTable.Columns.Add("DIEMTHI", typeof(int));
                rtnTable.Columns.Add("KETQUA", typeof(int));
                foreach (var t in tList)
                {
                    rtnTable.Rows.Add(t.THI.MAHV,
                        t.HOCTEN,
                        t.THI.MAKT,
                        t.THI.MALOP, 
                        t.THI.MAPHONG, 
                        t.THI.NGAYTHI, 
                        t.THI.DIEMTHI, 
                        t.THI.KETQUA);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;

            }

        }
        public int insert(string mahv,string makt,string malop,int maphong,DateTime ngaythi,int diemthi,int ketqua)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    THI t = new THI()
                    {
                        MAHV = mahv,
                        MAKT = makt,
                        MALOP = malop,
                        MAPHONG = maphong,
                        NGAYTHI = ngaythi,
                        DIEMTHI = diemthi,
                        KETQUA = ketqua
                    };
                    qltt.THIs.Add(t);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int update(string mahv, string makt, string malop, int maphong, DateTime ngaythi, int diemthi, int ketqua)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    THI t = qltt.THIs
                        .Where(p => p.MAHV == mahv)
                        .Where(p => p.MAKT == makt)
                        .Where(p => p.MALOP == malop)
                        .Where(p => p.MAPHONG == maphong)
                        .FirstOrDefault();
                    if(t!=null)
                    {
                     
                        t.NGAYTHI = ngaythi;
                        t.DIEMTHI = diemthi;
                        t.KETQUA = ketqua;
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
    }
}
