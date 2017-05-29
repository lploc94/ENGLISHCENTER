using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class KiemTraService : IService
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
            using (QLTTEntities qltt = new QLTTEntities())
            {
                KIEMTRA kt = qltt.KIEMTRAs.Where(p => p.MAKT == code).FirstOrDefault();
                if (kt != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAKT", typeof(string));
                    rtnTable.Columns.Add("TENKT", typeof(string));

                    rtnTable.Rows.Add(kt.MAKT, kt.TENKT);
                    return rtnTable;
                }
            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var ktList = from r in qltt.KIEMTRAs select r;

                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAKT", typeof(string));
                rtnTable.Columns.Add("TENKT", typeof(string));
                foreach (KIEMTRA kt in ktList)
                {
                    rtnTable.Rows.Add(kt.MAKT, kt.TENKT);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }
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
