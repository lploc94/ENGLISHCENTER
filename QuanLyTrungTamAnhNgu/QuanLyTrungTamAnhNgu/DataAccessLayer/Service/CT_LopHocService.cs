using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class CT_LopHocService
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

        public int delete_malop(string malop)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    CT_LOPHOC ctlh = qltt.CT_LOPHOC.Where(p => p.MALOP == malop).FirstOrDefault();
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

        public int updateByMaGV(string old_magv, string new_magv)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    string old_malop;

                    CT_LOPHOC ctlh;
                    while(true)
                    {
                        ctlh = qltt.CT_LOPHOC.Where(p => p.MAGV == old_magv).FirstOrDefault();

                        if (ctlh == null)
                            break;

                        old_malop = ctlh.MALOP;

                        qltt.CT_LOPHOC.Remove(ctlh);

                        // tạo cái mới
                        CT_LOPHOC new_chitiet = new CT_LOPHOC()
                        {
                            MALOP = old_malop,
                            MAGV = new_magv
                        };
                        qltt.CT_LOPHOC.Add(new_chitiet);

                        qltt.SaveChanges();
                    }

                    return 1;
                }

            }
            catch
            {
                return 0;

            }

        }

        public DataTable getByMaLop(string malop)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAGV", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    var ctlhList = from r in qltt.CT_LOPHOC where r.MALOP == malop select r;
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
                    }   
                }  
            }
            catch{}
            return rtnTable;
        }
        public DataTable getByMaGV(string magv)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAGV", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    var ctlhList = from r in qltt.CT_LOPHOC where r.MAGV == magv select r;
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
                    }
                }
            }
            catch
            {

            }
            return rtnTable;
        }

        public DataTable getAll()
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MALOP", typeof(string));
            rtnTable.Columns.Add("MAGV", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var ctlhList = from r in qltt.CT_LOPHOC select r;
                    
                    foreach (CT_LOPHOC ctlh in ctlhList)
                    {
                        rtnTable.Rows.Add(ctlh.MALOP, ctlh.MAGV);
                    }
                    
                }
            }
            catch
            {
                
            }
            return rtnTable;
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
