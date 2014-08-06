using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
namespace ISS.CMS.DAL
{
    public class FromDaoImpl : IFrom
    {
        /// <summary>
        /// 获取最大Id
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(id) from tsys_from");
            return (int)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 根据id,判断数据是否存在
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Exists([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(id) from tsys_from where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            bool tf = (bool)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
            return tf;
        }
        /// <summary>
        /// 添加一条新数据
        /// </summary>
        /// <param name="model">实体对像</param>
        /// <returns></returns>
        public int Add(From model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsys_from(title,content) values(@title,@content)");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "content" }, new object[] { model.Title, model.Content });
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对像</param>
        /// <returns></returns>
        public bool Update(From model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_from set title=@title,content=@content where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "content", "id" }, new object[] { model.Title, model.Content, model.Id });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        /// <summary>
        /// 根据id,删除一条数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_from where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        /// <summary>
        /// 根据指定的idlist，删除多条数据
        /// </summary>
        /// <param name="Idlist">格式如：1，2，3，4</param>
        /// <returns></returns>
        public bool DeleteList(string Idlist)
        {
            if (string.IsNullOrEmpty(Idlist))
            {
                return false;
            }
            if (Idlist.EndsWith(","))
            {
                Idlist = Idlist.TrimEnd(',');
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_from where id in (@list)");
            SqlParameter[] parameters = new SqlParameter[]{
            new SqlParameter("@list",Idlist)
            };
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        /// <summary>
        /// 根据id获取数据的实体对像
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public From GetModel([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Title,Content from tsys_from ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            Model.From model = new Model.From();
            DataSet ds = SqlHelper.Query(System.Data.CommandType.Text, strSql.ToString(), parameters);
            List<From> list = ModelHandler<From>.DataTable2Model(ds.Tables[0]);
            return list.Count > 0 ? list[0] : null;
        }
        /// <summary>
        /// 根据指定的条件获取实体列表。
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public List<From> GetModelList(string strWhere)
        {
            return ModelHandler<From>.DataTable2Model(GetList(strWhere).Tables[0]);
        }
        /// <summary>
        /// 根据指定的条件获取数据。
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [tsys_from]");
            if (!strWhere.StartsWith("where"))
            {
                strSql.Append(" where ");
            }
            strSql.Append(strWhere);

            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string strWhere)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetFrom()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_from order by ID asc");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }
    }
}
