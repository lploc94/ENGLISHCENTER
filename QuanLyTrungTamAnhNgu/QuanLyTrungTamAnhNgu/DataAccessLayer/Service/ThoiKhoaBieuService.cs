using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThoiKhoaBieuService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TKB data = qltt.TKBs.Where(p => p.MALH == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.TKBs.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public int delete_malop(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TKB data = qltt.TKBs.Where(p => p.MALOP == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.TKBs.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public DataTable get(string code)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAPHONG", typeof(int));
            rtnTable.Columns.Add("MALH", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TKB data = qltt.TKBs.Where(p => p.MALH == code).FirstOrDefault();
                if (data != null)
                {
                    

                    rtnTable.Rows.Add(data.MALOP, data.MAPHONG, data.MALH);
                   
                }

            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAPHONG", typeof(int));
            rtnTable.Columns.Add("MALH", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.TKBs select r;
                

                foreach (TKB data in dataList)
                {
                    rtnTable.Rows.Add(data.MALOP, data.MAPHONG, data.MALH);
                }

            }
            return rtnTable;
        }
        public int insert(string malop,int maphong,string malh)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    TKB data = new TKB()
                    {
                        MALOP = malop,
                        MAPHONG = maphong,
                        MALH = malh
                    };
                    qltt.TKBs.Add(data);
                    qltt.SaveChanges();

                    return 1;
                }

            }
            catch
            {
                return 0;
            }
            
        }
        public int update(string malop, int maphong, string malh)
        {
            try
            {

                using (QLTTEntities qltt = new QLTTEntities())
                {
                    TKB tkb = qltt.TKBs.Where(p => p.MALH == malop).FirstOrDefault();
                    if (tkb != null)
                    {
                        
                        tkb.MAPHONG = maphong;
                        tkb.MALH = malh;
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
