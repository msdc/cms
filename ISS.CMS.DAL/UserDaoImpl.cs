using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using System.Data.SqlClient;
using System.Data;
using ISS.CMS.Model;

namespace ISS.CMS.DAL
{
    public class UserDaoImpl : IUserDao
    {
        public String GetLoginStats(string username, string pwd)
        {
            try
            {
                SqlCommand scd = new SqlCommand("procManagerLogin");
                scd.Parameters.Add("@name", SqlDbType.VarChar, 50);
                scd.Parameters["@name"].Value = username;
                scd.Parameters.Add("@password", SqlDbType.VarChar, 50);
                scd.Parameters["@password"].Value = pwd;
                SqlParameter sp = new SqlParameter("@returnvalue", SqlDbType.VarChar, 50);
                sp.Direction = ParameterDirection.Output;
                scd.Parameters.Add(sp);

                String stats = SqlHelper.GetStoredProcedureReturn(scd).Value.ToString();
                return stats;
            }
            catch (Exception e)
            {
                string errorMessage = e.Message;
                return null;
            }
        }

        public DataSet GetUserByName(string username)
        {
            string sql = "select * from tsys_user where name = @username";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@username", username) };

            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetUserById(string id)
        {
            string sql = "select * from tsys_user where id= @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };

            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public int UpdateUser(string nickname, string roleid, string islock, string id)
        {
            string sql = "update tsys_user set nickname = @nickname, roleid = @roleid, islock = @islock where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@nickname", nickname), new SqlParameter("@roleid", roleid), new SqlParameter("@islock", islock), new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int AddUser(string username, string pwd, string nickname, string roleid, string islock)
        {
            string sql = "insert into tsys_user(name,password,nickname,roleid,islock) values(@name, @password, @nickname, @roleid, @islock)";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@name", username), new SqlParameter("@password", pwd), new SqlParameter("@nickname", nickname), new SqlParameter("@roleid", roleid), new SqlParameter("@islock", islock) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int DeleteUserById(string id)
        {
            string sql = "delete from tsys_user where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int GetUserCountByIdAndName(string id, string username)
        {
            string sql = "select count(*) from tsys_user where id = @id and name = @username";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id), new SqlParameter("@username", username) };
            return int.Parse(SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString());
        }

        public string GetUserRoleIdByName(string username)
        {
            string sql = "select roleid from tsys_user where [name] = @username";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@username", username) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        

        public DataSet GetRolePermission(string username)
        {
            string menuId = null;
            string sql = "select page from userinfo where name = @username";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@username", username) };
            menuId = SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();

            sql = "select * from tsys_menu where id in (@menuId) ORDER BY lv ASC";
            parm = new SqlParameter[] { new SqlParameter("@menuId", menuId) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }
    }
}
