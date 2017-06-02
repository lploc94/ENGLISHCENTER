using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class NhanVienService
    {
        public int delete(string manv)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                NHANVIEN nv = qltt.NHANVIENs.Where(p => p.MANV == manv).FirstOrDefault();
                if (nv != null)
                {
                    qltt.NHANVIENs.Remove(nv);
                    qltt.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
        public DataTable findUserByUsernameAndPass(string username, string userpass)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                DataTable rtnTable = new DataTable();
                NHANVIEN nv = qltt.NHANVIENs
                    .Where(p => p.USERNAME == username)
                    .Where(p => p.PASS == userpass)
                    .FirstOrDefault();
                if (nv != null)
                {
                    rtnTable.Columns.Add("MANV", typeof(string));
                    rtnTable.Columns.Add("HOTEN", typeof(string));
                    rtnTable.Columns.Add("GIOITINH", typeof(int));
                    rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                    rtnTable.Columns.Add("DIACHI", typeof(string));
                    rtnTable.Columns.Add("SDT", typeof(string));
                    rtnTable.Columns.Add("EMAIL", typeof(string));
                    rtnTable.Columns.Add("HESOLUONG", typeof(double));
                    rtnTable.Columns.Add("USERNAME", typeof(string));
                    rtnTable.Columns.Add("PASS", typeof(string));
                    rtnTable.Columns.Add("PHANQUYEN", typeof(short));
                    rtnTable.Columns.Add("ACTIVE", typeof(bool));

                    rtnTable.Rows.Add(nv.MANV, nv.HOTEN, nv.GIOITINH, nv.NGSINH, nv.DIACHI, nv.SDT, nv.EMAIL, nv.HESOLUONG, nv.USERNAME, nv.PASS, nv.PHANQUYEN, nv.ACTIVE);


                }
                return rtnTable;
            }
        }
        public DataTable get(string manv)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                DataTable rtnTable = new DataTable();
                NHANVIEN nv = qltt.NHANVIENs.Where(p => p.MANV == manv).FirstOrDefault();
                if (nv != null)
                {
                    rtnTable.Columns.Add("MANV", typeof(string));
                    rtnTable.Columns.Add("HOTEN", typeof(string));
                    rtnTable.Columns.Add("GIOITINH", typeof(int));
                    rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                    rtnTable.Columns.Add("DIACHI", typeof(string));
                    rtnTable.Columns.Add("SDT", typeof(string));
                    rtnTable.Columns.Add("EMAIL", typeof(string));
                    rtnTable.Columns.Add("HESOLUONG", typeof(double));
                    rtnTable.Columns.Add("USERNAME", typeof(string));
                    rtnTable.Columns.Add("PASS", typeof(string));
                    rtnTable.Columns.Add("PHANQUYEN", typeof(short));
                    rtnTable.Columns.Add("ACTIVE", typeof(bool));

                    rtnTable.Rows.Add(nv.MANV, nv.HOTEN, nv.GIOITINH, nv.NGSINH, nv.DIACHI, nv.SDT, nv.EMAIL, nv.HESOLUONG, nv.USERNAME, nv.PASS, nv.PHANQUYEN, nv.ACTIVE);


                }
                return rtnTable;
            }
        }

        public DataTable getAll()
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                DataTable rtnTable = new DataTable();
                var nvList = from r in qltt.NHANVIENs select r;
                rtnTable.Columns.Add("MANV", typeof(string));
                rtnTable.Columns.Add("HOTEN", typeof(string));
                rtnTable.Columns.Add("GIOITINH", typeof(int));
                rtnTable.Columns.Add("NGSINH", typeof(DateTime));
                rtnTable.Columns.Add("DIACHI", typeof(string));
                rtnTable.Columns.Add("SDT", typeof(string));
                rtnTable.Columns.Add("EMAIL", typeof(string));
                rtnTable.Columns.Add("HESOLUONG", typeof(double));
                rtnTable.Columns.Add("USERNAME", typeof(string));
                rtnTable.Columns.Add("PASS", typeof(string));
                rtnTable.Columns.Add("PHANQUYEN", typeof(short));
                rtnTable.Columns.Add("ACTIVE", typeof(bool));
                foreach (var nv in nvList)
                {

                    rtnTable.Rows.Add(nv.MANV, nv.HOTEN, nv.GIOITINH, nv.NGSINH, nv.DIACHI, nv.SDT, nv.EMAIL, nv.HESOLUONG, nv.USERNAME, nv.PASS, nv.PHANQUYEN, nv.ACTIVE);

                }
                return rtnTable;
            }
        }
        public int insert(string manv, string hoten, int gioitinh, DateTime ngsinh, string diachi, string sdt, string email, double hesoluong, string username, string pass, short phanquyen, bool active)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    NHANVIEN nv = new NHANVIEN() { MANV = manv, HOTEN = hoten, GIOITINH = gioitinh, NGSINH = ngsinh, DIACHI = diachi, SDT = sdt, EMAIL = email, HESOLUONG = hesoluong, USERNAME = username, PASS = pass, PHANQUYEN = phanquyen, ACTIVE = active };
                    qltt.NHANVIENs.Add(nv);
                    return 1;

                }
            }
            catch
            {
                return 0;
            }

        }
        public int update(string manv, string hoten, int gioitinh, DateTime ngsinh, string diachi, string sdt, string email, double hesoluong, string username, string pass, short phanquyen, bool active)
        {
            try
            {
                using (QLTTEntities qltt = new QLTTEntities())
                {
                    NHANVIEN nv = qltt.NHANVIENs.Where(p => p.MANV == manv).FirstOrDefault();
                    if (nv != null)
                    {
                        nv.HOTEN = hoten;
                        nv.GIOITINH = gioitinh;
                        nv.NGSINH = ngsinh;
                        nv.DIACHI = diachi;
                        nv.SDT = sdt;
                        nv.EMAIL = email;
                        nv.HESOLUONG = hesoluong;
                        nv.USERNAME = username;
                        nv.PASS = pass;
                        nv.PHANQUYEN = phanquyen;
                        nv.ACTIVE = active;
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
