using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamAnhNgu.Helper
{
    public static class AccountHelper
    {
        public static String getAccountId()
        {
            return "admin";
        }
        public static String getAccoutPassword()
        {
            return "mKFTdTmAshTS";
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
    }
}
