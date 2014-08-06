using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using System.Data;
using ISS.CMS.Model;

namespace ISS.CMS.DAL
{
    public class UserDaoProxy : IUserDao
    {
        private IUserDao dao;

        public UserDaoProxy()
        {
            this.dao = new UserDaoImpl();
        }

        public String GetLoginStats(string username, string pwd)
        {
            return this.dao.GetLoginStats(username, pwd);
        }

        public DataSet GetUserByName(string username)
        {
            return this.dao.GetUserByName(username);
        }

        public int UpdateUser(string nickname, string roleid, string islock, string id)
        {
            return this.dao.UpdateUser(nickname, roleid, islock, id);
        }

        public int AddUser(string username, string pwd, string nickname, string roleid, string islock)
        {
            return this.dao.AddUser(username, pwd, nickname, roleid, islock);
        }

        public int DeleteUserById(string id)
        {
            return this.dao.DeleteUserById(id);
        }

        public DataSet GetUserById(string id)
        {
            return this.dao.GetUserById(id);
        }

        public int GetUserCountByIdAndName(string id, string username)
        {
            return this.dao.GetUserCountByIdAndName(id, username);
        }

        

        

        public DataSet GetRolePermission(string username)
        {
            return this.dao.GetRolePermission(username);
        }

        public string GetUserRoleIdByName(string username)
        {
            return this.dao.GetUserRoleIdByName(username);
        }
        
        //public PageView GetPageView(string tablename_p, string column_p, string primarykey_p, int pagesize_p, int pageindex_p, string where_p, string order_p)
        //{
        //    return this.dao.GetPageView(tablename_p, column_p, primarykey_p, pagesize_p, pageindex_p, where_p, order_p);
        //}
    }
}
