using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class KiemTraService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                KIEMTRA kt = qltt.KIEMTRAs.Where(p => p.MAKT == code).FirstOrDefault();
                if (kt != null)
                {
                    qltt.KIEMTRAs.Remove(kt);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public DataTable get(string code)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAKT", typeof(string));
            rtnTable.Columns.Add("TENKT", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                KIEMTRA kt = qltt.KIEMTRAs.Where(p => p.MAKT == code).FirstOrDefault();
                if (kt != null)
                {
                    rtnTable.Rows.Add(kt.MAKT, kt.TENKT);
                }
            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAKT", typeof(string));
            rtnTable.Columns.Add("TENKT", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var ktList = from r in qltt.KIEMTRAs select r;

                
                foreach (KIEMTRA kt in ktList)
                {
                    rtnTable.Rows.Add(kt.MAKT, kt.TENKT);
                }
            }
            return rtnTable;
        }

        public DataTable getAllId()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAKT", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var maKiemTraList = from r in qltt.KIEMTRAs select r.MAKT;
                foreach (string maKt in maKiemTraList)
                {
                    rtnTable.Rows.Add(maKt);
                }
            }
            return rtnTable;
        }
        public int insert(string makt, string tenkt)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    KIEMTRA kt = new KIEMTRA()
                    {
                        MAKT = makt,
                        TENKT = tenkt
                    };
                    qltt.KIEMTRAs.Add(kt);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int update(string makt, string tenkt)
        {
            try
            {
                
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    KIEMTRA kt = qltt.KIEMTRAs.Where(p => p.MAKT == makt).FirstOrDefault();
                    if (kt!=null)
                    {
                        
                        kt.TENKT = tenkt;
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
