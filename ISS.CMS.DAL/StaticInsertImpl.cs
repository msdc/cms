using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    /// <summary>
    /// 数据访问类:tsys_StaticInsert
    /// </summary>
    public partial class StaticInsertImpl : IStaticInsertDao
    {
        public StaticInsertImpl()
        { }
        #region  Method



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ISS.CMS.Model.StaticInsert model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsys_StaticInsert(");
            strSql.Append("title,startelement,endelement,content,Encoding,filelist)");
            strSql.Append(" values (");
            strSql.Append("@title,@startelement,@endelement,@content,@Encoding,@filelist)");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "id" }, false);
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ISS.CMS.Model.StaticInsert model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_StaticInsert set ");
            strSql.Append("Title=@Title,");
            strSql.Append("Content=@Content,");
            strSql.Append("FileList=@FileList,");
            strSql.Append("Encoding=@Encoding,");
            strSql.Append("StartElement=@StartElement,");
            strSql.Append("EndElement=@EndElement");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model);
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0;            
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_StaticInsert ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = { new SqlParameter("@Id", SqlDbType.Int,4) };
            parameters[0].Value = Id;
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0;            
        }

        public DataSet GetStaticInsert(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_staticinsert ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = { new SqlParameter("@Id", SqlDbType.Int, 4) };
            parameters[0].Value = Id;
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), parameters);
        }

        public DataSet GetStaticInsertList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_StaticInsert order by title");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        public DataSet GetStaticInsertInScope(string scope)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_staticinsert where id in (" + scope + ")");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        #endregion  Method
    }
}
