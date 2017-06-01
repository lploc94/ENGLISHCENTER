using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.service
{
    public class Login
    {
        public static int CheckAccount(string id, string pass)
        {
            return DataAccessLayer.Service.CheckService.checkID(id, pass);
        }
        public static bool CheckPassword(string id, string pass)
        {
            return DataAccessLayer.Service.CheckService.getPasswordByUserName(id) == pass;
        }
        public static int ChangePassword(string id, string oldPass, string newPass, string verifyPass)
        {
            return DataAccessLayer.Service.CheckService.changePassword(id,oldPass,newPass, verifyPass);
        }
        public static string getRoleInfo(string id)
        {
            if (DataAccessLayer.Service.CheckService.checkRole(id, 0) == 1)
                return "admin";
            if (DataAccessLayer.Service.CheckService.checkRole(id, 1) == 1)
                return "tiep tan";
            if (DataAccessLayer.Service.CheckService.checkRole(id, 2) == 1)
                return "hoc vu";
            return "ke toan";
        }
    }
}
