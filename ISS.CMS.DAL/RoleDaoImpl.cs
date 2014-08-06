using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class RoleDaoImpl : IRoleDao
    {
        public DataSet GetRole()
        {
            string sql = "select * from tsys_role";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public string GetRolePageId(string roldId)
        {
            string sql = "select pageid from tsys_Role where [ID]= @roldId";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@roldId", roldId) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        public DataSet GetRolePageIdById(string id)
        {
            string sql = "select pageid from tsys_role where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetRoleClassIdById(string id)
        {
            string sql = "select classid from tsys_role where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public string GetRoleClassIdByName(string name)
        {
            string sql = "select classid from userinfo where name = @name";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@name", name) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        public DataSet GetRoleTemplateById(string id)
        {
            string sql = "select TemplateID from tsys_role where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public string GetRoleTemplateIdByName(string name)
        {
            string sql = "select TemplateID from userinfo where name = @name";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@name", name) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        public DataSet GetRoleById(string id)
        {
            string sql = "select * from tsys_role where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public int UpdateRole(string name, string pageId, string classId, string description, string id)
        {
            string sql = "update tsys_role set name = @name, pageid = @pageId, classid = @classId, description = @description where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@name", name), new SqlParameter("@pageId", pageId), new SqlParameter("@classId", classId), new SqlParameter("@description", description), new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int AddRole(string name, string pageId, string classId, string description)
        {
            string sql = "insert into tsys_role(name,pageid,classid,description) values(@name, @pageId, @classId, @description)";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@name", name), new SqlParameter("@pageId", pageId), new SqlParameter("@classId", classId), new SqlParameter("@description", description) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int DeleteRole(string id)
        {
            string sql = "delete from tsys_role where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }
    }
}
