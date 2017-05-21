using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class PhongHocService : IService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                PHONGHOC ph = qltt.PHONGHOCs.Where(p => p.MAPHONG.ToString() == code).FirstOrDefault();
                if (ph != null)
                {
                    qltt.PHONGHOCs.Remove(ph);
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
                PHONGHOC ph = qltt.PHONGHOCs.Where(p => p.MAPHONG.ToString() == code).FirstOrDefault();
                if ( ph != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAPHONG", typeof(string));
                    rtnTable.Columns.Add("TANG", typeof(int));
                    rtnTable.Columns.Add("SOPHONG", typeof(int));
                    rtnTable.Rows.Add(ph.MAPHONG,ph.TANG,ph.SOPHONG);
                    return rtnTable;
                }
            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var phList = from r in qltt.PHONGHOCs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAPHONG", typeof(string));
                rtnTable.Columns.Add("TANG", typeof(int));
                rtnTable.Columns.Add("SOPHONG", typeof(int));
               
                foreach (PHONGHOC ph in phList)
                {
                    rtnTable.Rows.Add(ph.MAPHONG, ph.TANG, ph.SOPHONG);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }
            
        }
        public int insert(int maphong,int tang,int sophong)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    PHONGHOC ph = new PHONGHOC()
                    {
                        MAPHONG= maphong,
                        TANG = tang,
                        SOPHONG = sophong
                    };
                    qltt.PHONGHOCs.Add(ph);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
