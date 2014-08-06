using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.ClassFactory;
using System.Data;

namespace ISS.CMS.BLL
{
    public class UserBLL
    {
        public static String Login(string username, string pwd)
        {
            return UserDaoFactory.Create().GetLoginStats(username, pwd);
        }

        public static DataSet GetUserByName(string username)
        {
            return UserDaoFactory.Create().GetUserByName(username);
        }

        public static int EditUser(string username, string pwd, string nickname, string roleid, string islock, string id)
        {
            if (id != null)
            {
                return UserDaoFactory.Create().UpdateUser(nickname, roleid, islock, id);
            }
            return UserDaoFactory.Create().AddUser(username, pwd, nickname, roleid, islock);
        }

        public static DataSet GetUserById(string id)
        {
            return UserDaoFactory.Create().GetUserById(id);
        }

        public static int GetUserCountByIdAndName(string id, string username)
        {
            return UserDaoFactory.Create().GetUserCountByIdAndName(id, username);
        }

        public static int DeleteUserById(string id)
        {
            return UserDaoFactory.Create().DeleteUserById(id);
        }

        public static DataSet GetRolePermission(string username)
        {
            if (username == "admin")
            {
                return MenuDaoFactory.Create().GetAdminPermission();
            }            
            return UserDaoFactory.Create().GetRolePermission(username);
        }

        public static DataSet GetRole()
        {
            return RoleDaoFactory.Create().GetRole();
        }

        public static string GetUserRoleIdByName(string username)
        {
            return UserDaoFactory.Create().GetUserRoleIdByName(username);
        }

        public static string GetRolePageId(string roldId)
        {
            return RoleDaoFactory.Create().GetRolePageId(roldId);
        }

        public static bool CheckPermission(string username, string filename)
        {
            string roldId = GetUserRoleIdByName(username);
            string rolePageId = GetRolePageId(roldId);

            return !rolePageId.Contains(pageid(filename));
        }

        private static string pageid(string filename)
        {
            if (filename.Contains("?"))
            {
                string strFullUrl = filename.Split('?')[0];
                filename = strFullUrl.Substring(strFullUrl.LastIndexOf('/') + 1);
            }
            else
            {
                filename = filename.Substring(filename.LastIndexOf('/') + 1);
            }

            if (MenuDaoFactory.Create().GetCountOfMenuIdByPageTitle(filename) > 0)
            {
                return MenuDaoFactory.Create().GetMenuIdByPageTite(filename);
            }
            else
            {
                return MenuDaoFactory.Create().GetMenuIdBySubPageTite(filename);
            }
        }
    }
}
