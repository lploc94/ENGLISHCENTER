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

                        // Cập nhật sĩ số
                        LopHocService lhsv = new LopHocService();
                        lhsv.updateSiSo(malop, -1);

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

                    DANGKY dk;
                    while (true)
                    {
                        dk  = qltt.DANGKies.Where(p => p.MALOP == malop).FirstOrDefault();
                        if (dk != null)
                        {
                            qltt.DANGKies.Remove(dk);
                            qltt.SaveChanges();
                            return 1;
                        }

                        else break;
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
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies where r.MALOP == malop select r;
                    
                    
                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV,dk.MALOP);
                    }
                    
                }
            }
            catch
            {
                
            }
            return rtnTable;
        }
        public DataTable getByMaHV(string mahv)
        {
            DataTable rtnTable = new DataTable();
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies where r.MAHV == mahv select r;
                    

                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV, dk.MALOP);
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
            rtnTable.Columns.Add("MAHV", typeof(string));
            rtnTable.Columns.Add("MALOP", typeof(string));
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                    var dkList = from r in qltt.DANGKies select r;
                    

                    foreach (DANGKY dk in dkList)
                    {
                        rtnTable.Rows.Add(dk.MAHV, dk.MALOP);
                    }
                    
                }
            }
            catch
            {
            }
            return rtnTable;
        }
        public int insert(string mahv, string malop)
        {

            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {

                   DANGKY dk = new DANGKY()
                    {
                        STT = qltt.DANGKies.Count() + 1,
                        MAHV = mahv,
                        MALOP = malop,
                        
                    };
                    qltt.DANGKies.Add(dk);
                    qltt.SaveChanges();
                    
                    // Cập nhật sĩ số
                    LopHocService lhsv = new LopHocService();
                    lhsv.updateSiSo(malop, 1);

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
