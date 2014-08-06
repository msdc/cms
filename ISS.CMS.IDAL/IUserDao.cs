using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ISS.CMS.IDAL
{
    public interface IUserDao
    {
        String GetLoginStats(string username, string pwd);

        DataSet GetUserByName(string username);

        DataSet GetUserById(string id);

        int UpdateUser(string nickname, string roleid, string islock, string id);

        int AddUser(string username, string pwd, string nickname, string roleid, string islock);

        int DeleteUserById(string id);

        int GetUserCountByIdAndName(string id, string username);

        

        

        DataSet GetRolePermission(string username);

        string GetUserRoleIdByName(string username);

        

                
    }
}
