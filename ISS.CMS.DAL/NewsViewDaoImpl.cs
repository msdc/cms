using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
namespace ISS.CMS.DAL
{
    public class NewsViewDaoImpl : INewsView
    {

        /// <summary>
        /// 获取最大的id
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(id) from tsys_NewsView");
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
            strSql.Append("select count(id) from tsys_NewsView where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            bool tf = (bool)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
            return tf;
        }
        /// <summary>
        /// 添加一条新数据
        /// </summary>
        /// <param name="model">实体对像</param>
        /// <returns></returns>
        public int Add(NewsView model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsys_NewsView(IsCheck,templateid,title,url,author,[from],editor,keyword,[count],speciality,content,smallimg,bigimg,shortcontent,Field1,Field2,Field3,addtime,uptime) values(@IsCheck,@templateid,@Title,@Url,@Author,@From,@Editor,@KeyWord,@Count,@Speciality,@Content,@SmallImg,@BigImg,@ShortContent,@Field1,@Field2,@Field3,@AddTime,@UpTime);select SCOPE_IDENTITY();");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "id", "TitleTab", "Template", "IsCreate", "IsDel", "IsCommend", "PageCount", "FilePath" }, false);
            //return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
            return Convert.ToInt32(SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), parameters));
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对像</param>
        /// <returns></returns>
        public bool Update(NewsView model)
        {
            string[] paraArray = new string[] { "IsCheck", "Template", "TitleTab", "IsCreate", "IsDel", "IsCommend", "PageCount", "FilePath", "AddTime" };
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_NewsView set ");
            strSql.Append("TemplateId=@TemplateId,");
            strSql.Append("Title=@Title,");
            strSql.Append("Url=@Url,");
            strSql.Append("Author=@Author,");
            strSql.Append("[From]=@From,");
            strSql.Append("Editor=@Editor,");
            strSql.Append("KeyWord=@KeyWord,");
            strSql.Append("Count=@Count,");
            strSql.Append("Speciality=@Speciality,");
            strSql.Append("Content=@Content,");
            strSql.Append("SmallImg=@SmallImg,");
            strSql.Append("BigImg=@BigImg,");
            strSql.Append("ShortContent=@ShortContent,");
            strSql.Append("Field1=@Field1,");
            strSql.Append("Field2=@Field2,");
            strSql.Append("Field3=@Field3,");
            if (model.AddTime != null)
            {
                strSql.Append("AddTime=@AddTime,");
                paraArray = new string[] { "IsCheck", "Template", "TitleTab", "IsCreate", "IsDel", "IsCommend", "PageCount", "FilePath" };
            }
            strSql.Append("UpTime=@UpTime");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, paraArray, false);
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        /// <summary>
        /// 更新指定的字段
        /// </summary>
        /// <param name="fieldNames">更新的字段列表</param>
        /// <param name="fieldValues">更新的字段值列表</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns></returns>
        public bool Update(string[] fieldNames, string[] fieldValues, string strWhere)
        {
            if (fieldNames.Length != fieldValues.Length) return false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_NewsView set ");
            SqlParameter[] parameters = new SqlParameter[fieldNames.Length];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                strSql.Append(fieldNames[i] + "=@" + fieldNames[i]);
                if (i < fieldNames.Length - 1)
                {
                    strSql.Append(",");
                }
                SqlParameter param = new SqlParameter("@" + fieldNames[i], fieldValues[i]);
                parameters[i] = param;
            }
            if (!strWhere.StartsWith("where", StringComparison.CurrentCultureIgnoreCase))
            {
                strSql.Append(" where ");
            }
            strSql.Append(strWhere);
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;

        }

        public int UpdateNewsViewIsDelById([DataFiled("id", SqlDbType.Int)]int Id, [DataFiled("IsDel", System.Data.SqlDbType.Bit)]bool IsDel)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE [tsys_NewsView] SET [IsDel] = @isDel WHERE [ID] = @id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id, IsDel });
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
        }

        public int UpdateNewsViewIsDelInScope(string scopeStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [tsys_NewsView] set [IsDel] = 0 where id in (" + scopeStr + ")");
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), null);
        }

        public int DeleteInScope(string scopeStr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tsys_NewsView] where id in (" + scopeStr + ")");
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 根据id,删除一条数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_NewsView where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            bool tf = (bool)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), parameters);
            return tf;
        }

        

        public int ClearNewsView()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [tsys_NewsView] where IsDel <> 0");
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), null);
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
            strSql.Append("delete from tsys_NewsView where id in (" + Idlist + ")");
            bool tf = SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), null) > 0;
            return tf;
        }
        /// <summary>
        /// 根据id获取数据的实体对像
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public NewsView GetModel([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_NewsView");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            Model.NewsView model = new Model.NewsView();
            DataSet ds = SqlHelper.Query(System.Data.CommandType.Text, strSql.ToString(), parameters);
            List<Model.NewsView> models = ModelHandler<Model.NewsView>.DataTable2Model(ds.Tables[0]);
            return models.Count > 0 ? models[0] : null;
        }
        /// <summary>
        /// 自定义条件获取数据
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="fieldOperator">字段运算符</param>
        /// <param name="whereOperator">where条件运算符</param>
        /// <returns></returns>
        public System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            if (fieldNames.Length != fieldValues.Length) return null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from V_NewsView where ");
            int count = fieldOperator.Count(delegate(string v)
             {
                 if (v.Equals("in", StringComparison.CurrentCultureIgnoreCase)) { return true; }
                 else
                 {
                     return false;
                 }
             });
            int temp = 0;
            SqlParameter[] parameters = new SqlParameter[fieldNames.Length - count];
            for (int i = 0; i < fieldNames.Length; i++)
            {
                strSql.Append(" [" + fieldNames[i] + "] ");
                if (fieldOperator[i].Equals("in", StringComparison.CurrentCultureIgnoreCase))
                {
                    strSql.Append(fieldOperator[i] + " (" + fieldValues[i] + ") ");
                }
                else
                {

                    strSql.Append(fieldOperator[i] + " @" + fieldNames[i]);
                    string tmp = "";
                    if (fieldOperator[i].Equals("like", StringComparison.CurrentCultureIgnoreCase))
                    {
                        tmp = "%" + fieldValues[i] + "%";
                    }
                    else
                    {
                        tmp = fieldValues[i];
                    }
                    SqlParameter param = new SqlParameter("@" + fieldNames[i], tmp);
                    parameters[temp] = param;
                    temp++;
                }
                if (i < fieldNames.Length - 1)
                {
                    strSql.Append(" " + whereOperator[i] + " ");
                }

            }
            if (string.IsNullOrEmpty(orderField))
            {
                orderField = " id ";
            }
            if (isAsc)
            {
                strSql.Append(" order by " + orderField + " asc ");
            }
            else
            {
                strSql.Append(" order by " + orderField + " desc ");
            }
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), parameters);

        }
        /// <summary>
        /// 自定义条件获取数据
        /// </summary>
        public System.Data.DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [tsys_NewsView]");
            if (!string.IsNullOrEmpty(strWhere))
            {
                if (!strWhere.StartsWith("where"))
                {
                    strSql.Append(" where ");
                }
            }
            strSql.Append(strWhere);

            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }
        /// <summary>
        /// 根据id获取数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public System.Data.DataSet GetNewsViewById([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [tsys_NewsView] where id = @id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), parameters);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top {0} * from [tsys_NewsView]");
            if (!string.IsNullOrEmpty(strWhere))
            {
                if (!strWhere.StartsWith("where", StringComparison.CurrentCultureIgnoreCase))
                {
                    strSql.Append(" where ");
                }
            }
            strSql.Append(strWhere);
            if (!string.IsNullOrEmpty(filedOrder))
            {
                if (!filedOrder.StartsWith("order by", StringComparison.CurrentCultureIgnoreCase))
                {
                    strSql.Append(" order by");
                }
            }
            strSql.Append(filedOrder);

            return SqlHelper.Query(CommandType.Text, string.Format(strSql.ToString(), Top.ToString()), null);
        }
        public int GetRecordCount(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return ds.Tables[0].Rows.Count;
        }

        public DataSet GetNewsViewListByAddTimeOrUpTime(string strTmp, string isCheck, string time, string startTime, string endTime, string templateId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + strTmp + " * from [tsys_NewsView] where Isdel = 0");
            if (Convert.ToBoolean(isCheck)) strSql.Append(" AND IsCheck =0");
            //strSql.Append(" AND @time between @starttime and @endtime");
            strSql.Append(" AND " + time + "  between '" + startTime + "' and '" + endTime + "'");
            strSql.Append(" AND templateid in (" + templateId + ") order by ID desc");
            // SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@isCheck", Convert.ToInt32(isCheck)) };
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        public DataSet GetNewsViewListInTemplateId(string strTmp, string isCheck, string templateId, string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + strTmp + " * from [tsys_NewsView] where Isdel = 0");
            if (Convert.ToBoolean(isCheck)) strSql.Append(" AND IsCheck =0");
            strSql.Append(" AND templateid in (" + templateId + ")");
            strSql.Append(" order by ID");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                if (orderby.Trim().StartsWith("order by", StringComparison.CurrentCultureIgnoreCase))
                {
                    strSql.Append(orderby.Replace("order by", "order by T."));
                }
                strSql.Append(orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from tsys_NewsView T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                if (!strWhere.StartsWith("where", StringComparison.CurrentCultureIgnoreCase))
                {
                    strSql.Append(" where ");
                }
                strSql.Append(strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        /// <summary>
        /// 新闻发布
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public int PublishNewsView(string speciality)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@speciality", SqlDbType.VarChar, 50)					
					};
            parameters[0].Value = speciality;
            return SqlHelper.ExecuteSql(CommandType.StoredProcedure, "proc_publishnewsview", parameters);
        }

        /// <summary>
        /// 删除远程服务器数据
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public int DelRemoteNews(string speciality)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@speciality", SqlDbType.VarChar, 50)					
					};
            parameters[0].Value = speciality;
            return SqlHelper.ExecuteSql(CommandType.StoredProcedure, "delRemoteNews", parameters);
        }
    }
}
