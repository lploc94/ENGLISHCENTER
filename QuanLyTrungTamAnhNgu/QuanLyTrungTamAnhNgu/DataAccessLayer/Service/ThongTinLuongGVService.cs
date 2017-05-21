﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class ThongTinLuongGVService : IService
    {
        public int delete(string code)
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
            using (QLTTEntities qltt = new QLTTEntities())
            {
                TT_LUONGGV data = qltt.TT_LUONGGV.Where(p => p.MAGV == code).FirstOrDefault();
                if (data != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MATT", typeof(string));
                    rtnTable.Columns.Add("MAGV", typeof(string));
                    rtnTable.Columns.Add("NGAYNHAN", typeof(DateTime));
                    rtnTable.Columns.Add("TINHTRANG", typeof(int));

                    rtnTable.Rows.Add(data.MATT, data.MAGV, data.NGAYNHAN, data.TINHTRANG);
                    return rtnTable;
                }

            }
            return null;
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var dataList = from r in qltt.TT_LUONGGV select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MATT", typeof(string));
                rtnTable.Columns.Add("MAGV", typeof(string));
                rtnTable.Columns.Add("NGAYNHAN", typeof(DateTime));
                rtnTable.Columns.Add("TINHTRANG", typeof(int));

                foreach (TT_LUONGGV data in dataList)
                {
                    rtnTable.Rows.Add(data.MATT, data.MAGV, data.NGAYNHAN, data.TINHTRANG);
                }

                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;


            }
        }
        public int insert(string matt,string magv,DateTime ngaynhan,int tinhtrang)
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


            }
            return 0;
        }
    }
}
