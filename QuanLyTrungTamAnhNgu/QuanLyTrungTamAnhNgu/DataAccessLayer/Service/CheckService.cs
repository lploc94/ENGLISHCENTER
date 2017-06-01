using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Service
{
    public class CheckService
    {
        public static int checkID(string id, string pass)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                NHANVIEN nv = qltt.NHANVIENs.Where(p => p.USERNAME == id && p.PASS == pass).FirstOrDefault();
                if (nv != null)
                {
                    return 1;
                }
                else
                    return 0;
            }
        }
        public static int checkRole(string id, int roleid)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                NHANVIEN nv = qltt.NHANVIENs.Where(p => p.USERNAME == id).FirstOrDefault();
                if (nv != null)
                {
                    if (nv.PHANQUYEN == roleid)
                        return 1;
                    else
                        return 0;
                }
                else
                    return 0;
            }

        }
        public static String getPasswordByUserName(string username)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                NHANVIEN data = qltt.NHANVIENs.Where(p => p.USERNAME == username).FirstOrDefault();
                if (data == null) return null;
                else
                {
                    return data.PASS;
                }
            }
        }
        public static int changePassword(string username, string oldPass, string newPass, string verifyPass)
        {
            using (QLTTEntities qltt = new QLTTEntities())
            {
                NHANVIEN data = qltt.NHANVIENs.Where(p => p.USERNAME == username).FirstOrDefault();
                if (data == null) return -1;
                else
                {
                    if (oldPass != data.PASS)
                    {
                        return 1;
                    }
                    if (newPass == "") return 2;
                    if (newPass != verifyPass) return 3;
                    data.PASS = newPass;
                    qltt.SaveChanges();
                    return 0;
                }
            }
        }
    }
}
