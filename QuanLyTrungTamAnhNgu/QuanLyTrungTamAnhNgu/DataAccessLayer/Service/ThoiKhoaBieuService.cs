using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThoiKhoaBieuService : IService
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

        public DataTable get(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TKB data = qltt.TKBs.Where(p => p.MALH == code).FirstOrDefault();
                if (data != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAPHONG", typeof(int));
                    rtnTable.Columns.Add("MALH", typeof(string));

                    rtnTable.Rows.Add(data.MALOP, data.MAPHONG, data.MALH);
                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.TKBs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MALOP", typeof(string));
                rtnTable.Columns.Add("MAPHONG", typeof(int));
                rtnTable.Columns.Add("MALH", typeof(string));

                foreach (TKB data in dataList)
                {
                    rtnTable.Rows.Add(data.MALOP, data.MAPHONG, data.MALH);
                }

                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;


            }
        }
        public int insert(string malop,int maphong,string malh)
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


            }
            return 0;
        }
    }
}
