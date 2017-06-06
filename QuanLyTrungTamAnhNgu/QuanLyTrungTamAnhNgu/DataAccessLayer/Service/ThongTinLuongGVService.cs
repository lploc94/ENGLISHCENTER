using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThongTinLuongGVService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TT_LUONGGV data = qltt.TT_LUONGGV.Where(p => p.MATT == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.TT_LUONGGV.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public int deleteByMaGV(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TT_LUONGGV data = qltt.TT_LUONGGV.Where(p => p.MAGV == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.TT_LUONGGV.Remove(data);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }

        public DataTable get(string code)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MATT", typeof(string));
            rtnTable.Columns.Add("MAGV", typeof(string));
            rtnTable.Columns.Add("NGAYNHAN", typeof(DateTime));
            rtnTable.Columns.Add("TINHTRANG", typeof(int));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TT_LUONGGV data = qltt.TT_LUONGGV.Where(p => p.MATT == code).FirstOrDefault();
                if (data != null)
                {
                    rtnTable.Rows.Add(data.MATT, data.MAGV, data.NGAYNHAN, data.TINHTRANG);
                    
                }

            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MATT", typeof(string));
            rtnTable.Columns.Add("MAGV", typeof(string));
            rtnTable.Columns.Add("NGAYNHAN", typeof(DateTime));
            rtnTable.Columns.Add("TINHTRANG", typeof(int));
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.TT_LUONGGV select r;
                

                foreach (TT_LUONGGV data in dataList)
                {
                    rtnTable.Rows.Add(data.MATT, data.MAGV, data.NGAYNHAN, data.TINHTRANG);
                }
            }
            return rtnTable;
        }
        public int insert(string matt,string magv,DateTime ngaynhan,int tinhtrang)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    TT_LUONGGV data = new TT_LUONGGV()
                    {
                        MATT = matt,
                        MAGV = magv,
                        NGAYNHAN = ngaynhan,
                        TINHTRANG = tinhtrang
                    };
                    qltt.TT_LUONGGV.Add(data);
                    qltt.SaveChanges();

                    return 1;
                }

            }
            catch
            {

                return 0;
            }

        }
        public int update(string matt, string magv, DateTime ngaynhan, int tinhtrang)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    TT_LUONGGV data = qltt.TT_LUONGGV.Where(p => p.MATT == matt).FirstOrDefault();
                    if(data!=null)
                    {
                        data.MATT = matt;
                        data.MAGV = magv;
                        data.NGAYNHAN = ngaynhan;
                        data.TINHTRANG = tinhtrang;
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
