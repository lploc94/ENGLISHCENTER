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

        public int delete_malop(string malop)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THI t = qltt.THIs
                        .Where(p => p.MALOP == malop)
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
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MAKT", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAPHONG", typeof(int));
            rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
            rtnTable.Columns.Add("DIEMTHI", typeof(int));
            rtnTable.Columns.Add("KETQUA", typeof(int));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THI t = qltt.THIs.Where(p => p.MAKT == code).FirstOrDefault();
                if (t != null)
                {
                    
                    rtnTable.Rows.Add(t.MAHV, t.MAKT, t.MALOP, t.MAPHONG, t.NGAYTHI, t.DIEMTHI, t.KETQUA);
                    
                }

            }
            return rtnTable;
        }

        public DataTable findDiemThiByMaHV(string maHv)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("HOTEN", typeof(string));
            rtnTable.Columns.Add("DIEMGK", typeof(int));
            rtnTable.Columns.Add("DIEMCK", typeof(int));
            rtnTable.Columns.Add("TONGDIEM", typeof(float));
            rtnTable.Columns.Add("KETQUA", typeof(int));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    var gk = from x in qltt.THIs where x.MAHV == maHv && x.MAKT == "KTGK" select x;
                    var ck = from x in qltt.THIs where x.MAHV == maHv && x.MAKT == "KTCK" select x;
                    var info = gk.FullOuterJoin(ck, g => g.MALOP, c => c.MALOP, (g, c, MALOP) => new { MALOP = g.MALOP, DIEMGK = g.DIEMTHI, DIEMCK = c.DIEMTHI });

                    string hoten = qltt.HOCVIENs.Where(p => p.MAHV == maHv).FirstOrDefault().HOTEN;

                    foreach (var i in info)
                    {
                        rtnTable.Rows.Add(maHv, i.MALOP, hoten, i.DIEMGK, i.DIEMCK, (i.DIEMGK + i.DIEMCK), (float)(i.DIEMGK + i.DIEMCK) / 2 >= 5 ? 1 : 0);
                    }
                }
            }

            catch
            { }
            
            return rtnTable;

        }
        public DataTable findDiemThiByMaLop(string maLop)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("HOTEN", typeof(string));
            rtnTable.Columns.Add("DIEMGK", typeof(int));
            rtnTable.Columns.Add("DIEMCK", typeof(int));
            rtnTable.Columns.Add("TONGDIEM", typeof(float));
            rtnTable.Columns.Add("KETQUA", typeof(int));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    var gk = from x in qltt.THIs where x.MALOP == maLop && x.MAKT == "KTGK" select x;
                    var ck = from x in qltt.THIs where x.MALOP == maLop && x.MAKT == "KTCK" select x;
                    var info = gk.FullOuterJoin(ck, g => g.MAHV, c => c.MAHV, (g, c, MAHV) => new { MAHV = g.MAHV, DIEMGK = g.DIEMTHI, DIEMCK = c.DIEMTHI });

                    foreach (var i in info)
                    {
                        rtnTable.Rows.Add(i.MAHV, maLop, qltt.HOCVIENs.Where(p => p.MAHV == i.MAHV).FirstOrDefault().HOTEN, i.DIEMGK, i.DIEMCK, (i.DIEMGK + i.DIEMCK) / 2, (float)(i.DIEMGK + i.DIEMCK) / 2 >= 5 ? 1 : 0);
                    }

                }
            }
            catch { }
            
            return rtnTable;
        }
        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MAKT", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAPHONG", typeof(int));
            rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
            rtnTable.Columns.Add("DIEMTHI", typeof(int));
            rtnTable.Columns.Add("KETQUA", typeof(int));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var tList = from r in qltt.THIs select r;
                
                foreach (THI t in tList)
                {
                    rtnTable.Rows.Add(t.MAHV, t.MAKT, t.MALOP, t.MAPHONG, t.NGAYTHI, t.DIEMTHI, t.KETQUA);
                }
            }
            return rtnTable;
        }
        public DataTable getAllWithTenHocVien()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("HOTEN", typeof(string));
            rtnTable.Columns.Add("MAKT", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAPHONG", typeof(int));
            rtnTable.Columns.Add("NGAYTHI", typeof(DateTime));
            rtnTable.Columns.Add("DIEMTHI", typeof(int));
            rtnTable.Columns.Add("KETQUA", typeof(int));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var tList = from r in qltt.THIs
                            join hv in qltt.HOCVIENs
                            on r.MAHV equals hv.MAHV
                            select new { THI = r, HOTEN = hv.HOTEN };
               
                foreach (var t in tList)
                {
                    rtnTable.Rows.Add(t.THI.MAHV,
                        t.HOTEN,
                        t.THI.MAKT,
                        t.THI.MALOP, 
                        t.THI.MAPHONG, 
                        t.THI.NGAYTHI, 
                        t.THI.DIEMTHI, 
                        t.THI.KETQUA);
                }
            }
            return rtnTable;
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
        public int deleteMaHV(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                THI t = qltt.THIs.Where(p => p.MAHV == code).FirstOrDefault();
                if (t != null)
                {
                    qltt.THIs.Remove(t);
                    qltt.SaveChanges();

                    return 1;
                }

            }
            return 0;
        }


    }
}

internal static class MyExtensions
{

    internal static IList<TR> FullOuterGroupJoin<TA, TB, TK, TR>(
        this IEnumerable<TA> a,
        IEnumerable<TB> b,
        Func<TA, TK> selectKeyA,
        Func<TB, TK> selectKeyB,
        Func<IEnumerable<TA>, IEnumerable<TB>, TK, TR> projection,
        IEqualityComparer<TK> cmp = null)
    {
        cmp = cmp ?? EqualityComparer<TK>.Default;
        var alookup = a.ToLookup(selectKeyA, cmp);
        var blookup = b.ToLookup(selectKeyB, cmp);

        var keys = new HashSet<TK>(alookup.Select(p => p.Key), cmp);
        keys.UnionWith(blookup.Select(p => p.Key));

        var join = from key in keys
                   let xa = alookup[key]
                   let xb = blookup[key]
                   select projection(xa, xb, key);

        return join.ToList();
    }

    internal static IList<TR> FullOuterJoin<TA, TB, TK, TR>(
        this IEnumerable<TA> a,
        IEnumerable<TB> b,
        Func<TA, TK> selectKeyA,
        Func<TB, TK> selectKeyB,
        Func<TA, TB, TK, TR> projection,
        TA defaultA = default(TA),
        TB defaultB = default(TB),
        IEqualityComparer<TK> cmp = null)
    {
        cmp = cmp ?? EqualityComparer<TK>.Default;
        var alookup = a.ToLookup(selectKeyA, cmp);
        var blookup = b.ToLookup(selectKeyB, cmp);

        var keys = new HashSet<TK>(alookup.Select(p => p.Key), cmp);
        keys.UnionWith(blookup.Select(p => p.Key));

        var join = from key in keys
                   from xa in alookup[key].DefaultIfEmpty(defaultA)
                   from xb in blookup[key].DefaultIfEmpty(defaultB)
                   select projection(xa, xb, key);

        return join.ToList();
    }
}