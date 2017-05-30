using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class DangKyService 
    {
        public int delete(string mahv,string malop)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    DANGKY dk = qltt.DANGKies.Where(p => p.MALOP == malop && p.MAHV == mahv).FirstOrDefault();
                    if (dk != null)
                    {
                        qltt.DANGKies.Remove(dk);
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

        public DataTable getByMaLop(string malop)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies where r.MALOP == malop select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHV", typeof(string));
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    
                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV,dk.MALOP);
                    }
                    return rtnTable;
                }
            }
            catch
            {
                return null;
            }
        }
        public DataTable getByMaHV(string mahv)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies where r.MAHV == mahv select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHV", typeof(string));
                    rtnTable.Columns.Add("MALOP", typeof(string));

                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV, dk.MALOP);
                    }
                    return rtnTable;
                }
            }
            catch
            {
                return null;
            }
        }
        public DataTable getAll()
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAHV", typeof(string));
                    rtnTable.Columns.Add("MALOP", typeof(string));

                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV, dk.MALOP);
                    }
                    return rtnTable;
                }
            }
            catch
            {
                return null;
            }
        }
        public int insert(string mahv, string malop)
        {

            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                   DANGKY dk = new DANGKY()
                    {
                        STT = qltt.CT_LOPHOC.Count() + 1,
                        MAHV = mahv,
                        MALOP = malop,
                        
                    };
                    qltt.DANGKies.Add(dk);
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
