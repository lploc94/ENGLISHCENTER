using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class LopHocService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                LOPHOC data = qltt.LOPHOCs.Where(p => p.MALOP == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.LOPHOCs.Remove(data);
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
            rtnTable.Columns.Add("MAKH", typeof(string));
            rtnTable.Columns.Add("NGAYBD", typeof(DateTime));
            rtnTable.Columns.Add("NGAYKT", typeof(DateTime));
            rtnTable.Columns.Add("SISO", typeof(int));
            rtnTable.Columns.Add("MAHP", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                LOPHOC data = qltt.LOPHOCs.Where(p => p.MALOP == code).FirstOrDefault();
                if (data != null)
                {
                    

                    rtnTable.Rows.Add(data.MALOP, data.MAKH, data.NGAYBD, data.NGAYKT, data.SISO, data.MAHP);
                    
                }

            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAKH", typeof(string));
            rtnTable.Columns.Add("NGAYBD", typeof(DateTime));
            rtnTable.Columns.Add("NGAYKT", typeof(DateTime));
            rtnTable.Columns.Add("SISO", typeof(int));
            rtnTable.Columns.Add("MAHP", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.LOPHOCs select r;
               

                foreach (LOPHOC data in dataList)
                {
                    rtnTable.Rows.Add(data.MALOP, data.MAKH, data.NGAYBD, data.NGAYKT, data.SISO, data.MAHP);
                }
            }
            return rtnTable;
        }
        public DataTable getAllId()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.LOPHOCs select r.MALOP;
               

                foreach (string data in dataList)
                {
                    rtnTable.Rows.Add(data);
                }
            }
            return rtnTable;
        }
        public int insert(string malop,string makh,DateTime ngaybd,DateTime ngaykt,int siso,string mahp)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    LOPHOC data = new LOPHOC()
                    {
                        MALOP = malop,
                        MAKH = makh,
                        NGAYBD = ngaybd,
                        NGAYKT = ngaykt,
                        SISO = siso,
                        MAHP = mahp
                    };
                    qltt.LOPHOCs.Add(data);
                    qltt.SaveChanges();

                    return 1;
                }
            }
            catch
            {
                return 0;
            }
            
        }
        public int update(string malop, string makh, DateTime ngaybd, DateTime ngaykt, int siso, string mahp)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    LOPHOC lh = qltt.LOPHOCs.Where(p => p.MALOP == malop).FirstOrDefault();
                    if(lh!=null)
                    {

                        lh.MAKH = makh;
                        lh.NGAYBD = ngaybd;
                        lh.NGAYKT = ngaykt;
                        lh.SISO = siso;
                        lh.MAHP = mahp;
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

        public int updateSiSo(string malop, int number)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    LOPHOC lh = qltt.LOPHOCs.Where(p => p.MALOP == malop).FirstOrDefault();
                    if (lh != null)
                    {
                        lh.SISO = lh.SISO + number;
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

        public DataTable getAllMaLop()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(String));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var malop = from ml in qltt.LOPHOCs select new { MALOP = ml.MALOP };
                
                foreach (var ml in malop)
                {
                    rtnTable.Rows.Add(ml.MALOP);
                }
                
            }
            return rtnTable;
        }
    }
}
