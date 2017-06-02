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
        private static String loginUsername = null;
        private static String loginPssword = null;
        public static String getAccountId()
        {
            return loginUsername;
        }
        public static String getAccoutPassword()
        {
            return loginPssword;
        }

        public static void SetLoginUserNameAndPassword(string username, string password)
        {
            loginUsername = username;
            loginPssword = password;
        }
        
        public static void ResetLoginUsernameAndPassword()
        {
            loginUsername = null;
            loginPssword = null;
        }
    }
}
