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
                HOCPHI hp=qltt.HOCPHIs.Where(p => p.MAHP == code).FirstOrDefault();
                if (hp != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHP",typeof(string));
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
    }
}
