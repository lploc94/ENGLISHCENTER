using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class LopHocService : IService
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
            using (QLTTEntities qltt = new QLTTEntities())
            {
                LOPHOC data = qltt.LOPHOCs.Where(p => p.MALOP == code).FirstOrDefault();
                if (data != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAKH", typeof(string));
                    rtnTable.Columns.Add("NGAYBD", typeof(DateTime));
                    rtnTable.Columns.Add("NGAYKT", typeof(DateTime));
                    rtnTable.Columns.Add("SISO", typeof(int));
                    rtnTable.Columns.Add("MAHP", typeof(string));

                    rtnTable.Rows.Add(data.MALOP, data.MAKH, data.NGAYBD, data.NGAYKT, data.SISO, data.MAHP);
                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.LOPHOCs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MALOP", typeof(string));
                rtnTable.Columns.Add("MAKH", typeof(string));
                rtnTable.Columns.Add("NGAYBD", typeof(DateTime));
                rtnTable.Columns.Add("NGAYKT", typeof(DateTime));
                rtnTable.Columns.Add("SISO", typeof(int));
                rtnTable.Columns.Add("MAHP", typeof(string));

                foreach (LOPHOC data in dataList)
                {
                    rtnTable.Rows.Add(data.MALOP, data.MAKH, data.NGAYBD, data.NGAYKT, data.SISO, data.MAHP);
                }

                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;


            }
        }
        public DataTable getAllId()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.LOPHOCs select r.MALOP;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MALOP", typeof(string));

                foreach (string data in dataList)
                {
                    rtnTable.Rows.Add(data);
                }

                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;


            }
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

        public DataTable getAllMaLop()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var malop = from ml in qltt.LOPHOCs select new { MALOP = ml.MALOP };
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MALOP", typeof(String));
                foreach (var ml in malop)
                {
                    rtnTable.Rows.Add(ml.MALOP);
                }
                return rtnTable;
            }
        }
    }
}
