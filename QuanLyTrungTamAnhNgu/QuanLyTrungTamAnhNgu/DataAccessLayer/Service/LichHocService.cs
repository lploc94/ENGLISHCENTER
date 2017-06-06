using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class LichHocService
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
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALH", typeof(string));
            rtnTable.Columns.Add("NGAYHOC", typeof(string));
            rtnTable.Columns.Add("GIOHOC", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                LICHHOC lh = qltt.LICHHOCs.Where(p => p.MALH == code).FirstOrDefault();
                if (lh != null)
                {
                   
                    rtnTable.Rows.Add(lh.MALH,lh.NGAYHOC,lh.GIOHOC);
                    
                }
            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALH", typeof(string));
            rtnTable.Columns.Add("NGAYHOC", typeof(string));
            rtnTable.Columns.Add("GIOHOC", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var lhList = from r in qltt.LICHHOCs select r;
                foreach ( LICHHOC lh in lhList)
                {
                    rtnTable.Rows.Add(lh.MALH, lh.NGAYHOC, lh.GIOHOC);
                }
            }
            return rtnTable;
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
