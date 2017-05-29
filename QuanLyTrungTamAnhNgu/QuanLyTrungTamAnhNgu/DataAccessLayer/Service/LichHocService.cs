using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class LichHocService : IService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                LICHHOC lh = qltt.LICHHOCs.Where(p => p.MALH == code).FirstOrDefault();
                if (lh != null)
                {
                    qltt.LICHHOCs.Remove(lh);
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
                LICHHOC lh = qltt.LICHHOCs.Where(p => p.MALH == code).FirstOrDefault();
                if (lh != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALH", typeof(string));
                    rtnTable.Columns.Add("NGAYHOC", typeof(string));
                    rtnTable.Columns.Add("GIOHOC", typeof(string));
                    rtnTable.Rows.Add(lh.MALH,lh.NGAYHOC,lh.GIOHOC);
                    return rtnTable;
                }
            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var lhList = from r in qltt.LICHHOCs select r;
                
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MALH", typeof(string));
                rtnTable.Columns.Add("NGAYHOC", typeof(string));
                rtnTable.Columns.Add("GIOHOC", typeof(string));
                foreach ( LICHHOC lh in lhList)
                {
                    rtnTable.Rows.Add(lh.MALH, lh.NGAYHOC, lh.GIOHOC);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }
        }
        public int insert(string malh,string ngayhoc,string giohoc)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    LICHHOC lh = new LICHHOC()
                    {
                        MALH = malh,
                        NGAYHOC = ngayhoc,
                        GIOHOC = giohoc
                    };
                    qltt.LICHHOCs.Add(lh);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int update(string malh, string ngayhoc, string giohoc)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    LICHHOC lh = qltt.LICHHOCs.Where(p => p.MALH == malh).FirstOrDefault();
                    if (lh!=null)
                    {

                        lh.NGAYHOC = ngayhoc;
                        lh.GIOHOC = giohoc;
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
