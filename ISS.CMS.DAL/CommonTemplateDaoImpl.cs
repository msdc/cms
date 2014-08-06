using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class CommonTemplateDaoImpl : ICommonTemplateDao
    {
        public DataSet GetTemplateById(string id)
        {
            string sql = "select * from tsys_CommonTemplate where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetTemplateOrderById()
        {
            string sql = "SELECT * FROM tsys_CommonTemplate ORDER BY ID ASC";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public DataSet GetTemplateId()
        {
            string sql = "select id from [tsys_CommonTemplate]";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public DataSet GetTemplate()
        {
            string sql = "select * from [tsys_CommonTemplate] order by id";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public DataSet GetTemplateInScope(string scopeStr)
        {
            string sql = "select * from [tsys_CommonTemplate] where id in (" + scopeStr + ") order by id";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public int DeleteTemplate(string id)
        {
            string sql = "delete from tsys_CommonTemplate where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int UpdateTemplate(string title, string content, string id)
        {
            string sql = "update tsys_CommonTemplate set title = @title, content = @content, Modified = @Modified where id = @id";
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter("@title", title), 
                new SqlParameter("@content", content), 
                new SqlParameter("@Modified", DateTime.Now.ToString()), 
                new SqlParameter("@id", id) 
            };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int AddTemplate(string title, string content)
        {
            string sql = "insert into tsys_CommonTemplate(title,content, Created, Modified) values(@title, @content, @Created, @Modified)";
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter("@title", title),
                new SqlParameter("@content", content),
                new SqlParameter("@Created", DateTime.Now.ToString()),
                new SqlParameter("@Modified", DateTime.Now.ToString())
            };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }
    }
}
