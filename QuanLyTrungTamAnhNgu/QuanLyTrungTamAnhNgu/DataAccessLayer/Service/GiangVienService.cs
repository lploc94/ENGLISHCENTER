using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class GiangVienService : IService
    {
        
        public int delete(string code)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
               
                GIANGVIEN gv = qltt.GIANGVIENs.Where(p => p.MAGV == code).FirstOrDefault();
                if (gv != null)
                {
                    qltt.GIANGVIENs.Remove(gv);
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
                GIANGVIEN gv = qltt.GIANGVIENs.Where(p => p.MAGV == code).FirstOrDefault();
                if (gv != null)
                {
                    DataTable rtnTable = new DataTable();
                    rtnTable.Columns.Add("MAGV", typeof(string));
                    rtnTable.Columns.Add("TENGV", typeof(string));
                    rtnTable.Columns.Add("GIOITINH", typeof(int));
                    rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                    rtnTable.Columns.Add("DIACHI", typeof(string));
                    rtnTable.Columns.Add("SDT", typeof(string));
                    rtnTable.Columns.Add("EMAIL", typeof(string));
                    rtnTable.Columns.Add("TRINHDO", typeof(string));
                    rtnTable.Columns.Add("BANGCAP", typeof(string));
                    rtnTable.Columns.Add("NGAYVL", typeof(DateTime));
                    rtnTable.Columns.Add("HESO", typeof(double));

                    rtnTable.Rows.Add(gv.MAGV, gv.TENGV, gv.GIOITINH, gv.NGSINH, gv.DIACHI, gv.SDT, gv.EMAIL, gv.TRINHDO, gv.BANGCAP, gv.NGAYVL, gv.HESO);
                    return rtnTable;
                }

            }
            return null;
        }
        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                var GvList =from r in qltt.GIANGVIENs select r;
                DataTable rtnTable = new DataTable();
                rtnTable.Columns.Add("MAGV", typeof(string));
                rtnTable.Columns.Add("TENGV", typeof(string));
                rtnTable.Columns.Add("GIOITINH", typeof(int));
                rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                rtnTable.Columns.Add("DIACHI", typeof(string));
                rtnTable.Columns.Add("SDT", typeof(string));
                rtnTable.Columns.Add("EMAIL", typeof(string));
                rtnTable.Columns.Add("TRINHDO", typeof(string));
                rtnTable.Columns.Add("BANGCAP", typeof(string));
                rtnTable.Columns.Add("NGAYVL", typeof(DateTime));
                rtnTable.Columns.Add("HESO", typeof(double));
                foreach (GIANGVIEN gv in GvList)
                {
                    rtnTable.Rows.Add(gv.MAGV, gv.TENGV, gv.GIOITINH, gv.NGSINH, gv.DIACHI, gv.SDT, gv.EMAIL, gv.TRINHDO, gv.BANGCAP, gv.NGAYVL, gv.HESO);
                }
                if (rtnTable.Rows[0][0] == DBNull.Value)
                    return null;
                else
                    return rtnTable;
            }
            
        }
        public int insert(string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    GIANGVIEN x = new GIANGVIEN()
                    {
                        MAGV = magv,
                        TENGV = tengv,
                        GIOITINH = gioitinh,
                        NGSINH = ngaysinh,
                        DIACHI = diachi,
                        SDT = sdt,
                        EMAIL = email,
                        TRINHDO = trinhdo,
                        BANGCAP = bangcap,
                        NGAYVL = ngayvaolam,
                        HESO = heso
                    };
                    qltt.GIANGVIENs.Add(x);
                    qltt.SaveChanges();
                }
                return 1;
            }
            catch
            {
                return 0;

            }
            
        }
        public int update(string magv, string tengv, int gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, string trinhdo, string bangcap, DateTime ngayvaolam, double heso)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    GIANGVIEN gv = qltt.GIANGVIENs.Where(p => p.MAGV == magv).FirstOrDefault();
                    if (gv != null)
                    {
                        gv.TENGV = tengv;
                        gv.GIOITINH = gioitinh;
                        gv.NGSINH = ngaysinh;
                        gv.DIACHI = diachi;
                        gv.SDT = sdt;
                        gv.EMAIL = email;
                        gv.TRINHDO = trinhdo;
                        gv.BANGCAP = bangcap;
                        gv.NGAYVL = ngayvaolam;
                        gv.HESO = heso;
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
