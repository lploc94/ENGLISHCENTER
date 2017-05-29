using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class KhoaHocService : IService
    {
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                KHOAHOC data = qltt.KHOAHOCs.Where(p => p.MAKH == code).FirstOrDefault();
                if (data != null)
                {
                    qltt.KHOAHOCs.Remove(data);
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
                KHOAHOC data = qltt.KHOAHOCs.Where(p => p.MAKH == code).FirstOrDefault();
                if (data != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAKH", typeof(string));
                    rtnTable.Columns.Add("TENKH", typeof(string));
                    rtnTable.Columns.Add("MOTA", typeof(string));
                    rtnTable.Columns.Add("TAILIEU", typeof(string));
                    rtnTable.Columns.Add("THOIGIAN", typeof(int));

                    rtnTable.Rows.Add(data.MAKH, data.TENKH, data.MOTA, data.TAILIEU, data.THOIGIAN);
                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.KHOAHOCs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAKH", typeof(string));
                rtnTable.Columns.Add("TENKH", typeof(string));
                rtnTable.Columns.Add("MOTA", typeof(string));
                rtnTable.Columns.Add("TAILIEU", typeof(string));
                rtnTable.Columns.Add("THOIGIAN", typeof(int));

             
                foreach (KHOAHOC data in dataList)
                {
                    rtnTable.Rows.Add(data.MAKH, data.TENKH, data.MOTA, data.TAILIEU, data.THOIGIAN);
                }

                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;


            }
        }
        public int insert(string makh,string tenkh,string mota,string tailieu,int thoigian)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    KHOAHOC data = new KHOAHOC()
                    {
                        MAKH = makh,
                        TENKH = tenkh,
                        MOTA = mota,
                        TAILIEU = tailieu,
                        THOIGIAN = thoigian
                    };
                    qltt.KHOAHOCs.Add(data);
                    qltt.SaveChanges();

                    return 1;
                }
            }
            catch
            {
                return 0;
            }
            
           
        }
        public int update(string makh, string tenkh, string mota, string tailieu, int thoigian)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    KHOAHOC data = qltt.KHOAHOCs.Where(p => p.MAKH == makh).FirstOrDefault();
                    if (data!=null)
                    {
                        data.TENKH = tenkh;
                        data.MOTA = mota;
                        data.TAILIEU = tailieu;
                        data.THOIGIAN = thoigian;
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
