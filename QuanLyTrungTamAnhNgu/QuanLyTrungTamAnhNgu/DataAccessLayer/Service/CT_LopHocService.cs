using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    class CT_LopHocService
    {
        public int delete(string malop,string magv)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    CT_LOPHOC ctlh = qltt.CT_LOPHOC.Where(p => p.MALOP == malop && p.MAGV == magv).FirstOrDefault();
                    if (ctlh != null)
                    {
                        qltt.CT_LOPHOC.Remove(ctlh);
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

                    var ctlhList = from r in qltt.CT_LOPHOC where r.MALOP == malop select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAGV", typeof(string));
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
                    }
                    return rtnTable;
                }
            }
            catch
            {
                return null;
            }
        }
        public DataTable getByMaGV(string magv)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var ctlhList = from r in qltt.CT_LOPHOC where r.MAGV == magv select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAGV", typeof(string));
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
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

                    var ctlhList = from r in qltt.CT_LOPHOC select r;
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MALOP", typeof(string));
                    rtnTable.Columns.Add("MAGV", typeof(string));
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
                    }
                    return rtnTable;
                }
            }
            catch
            {
                return null;
            }
        }
        public int insert(string malop, string magv)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    CT_LOPHOC ctlh = new CT_LOPHOC()
                    {
                        STT=qltt.CT_LOPHOC.Count()+1,
                        MALOP=malop,
                        MAGV=magv
                    };
                    qltt.CT_LOPHOC.Add(ctlh);
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
