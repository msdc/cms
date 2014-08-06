using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
namespace ISS.CMS.DAL
{
    public class ClassDaoImpl : IClassDao
    {
        public DataSet GetClassById(string id)
        {
            //string sql = "select * from [tsys_class] where id = @id";
            //SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            //return SqlHelper.Query(CommandType.Text, sql, parm);
            return GetClassById(Convert.ToInt32(id));
        }
        private DataSet GetClassById([DataFiled("id", SqlDbType.Int)]int Id)
        {
            string sql = "select * from [tsys_class] where id = @id";
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            return SqlHelper.Query(CommandType.Text, sql, parameters);
        }
        public string GetClassMapById(string id)
        {
            //string sql = "SELECT map FROM [tsys_class] WHERE id= @id";
            //SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            //return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
            return GetClassMapById(Convert.ToInt32(id));
        }

        public DataSet GetClass()
        {
            string sql = "SELECT * FROM [tsys_class] order by orderid";            
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public DataSet GetClassInScope(string scopeStr)
        {
            string sql = "select * from [tsys_class] where id in (" + scopeStr + ") order by orderid";            
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        private string GetClassMapById([DataFiled("id", SqlDbType.Int)]int Id)
        {
            string sql = "SELECT map FROM [tsys_class] WHERE id= @id";
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            return SqlHelper.GetSingle(CommandType.Text, sql, parameters).ToString();
        }
        public int DeleteClass(string id)
        {
            //string sql = "delete from [tsys_class] where id = @id";
            //SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            //return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
            return DeleteClass(Convert.ToInt32(id));
        }
        private int DeleteClass([DataFiled("id", SqlDbType.Int)]int Id)
        {
            string sql = "delete from [tsys_class] where id = @id";
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parameters);
        }
        public int AddClass(string title, string title2, string directory, string template, string parent, string orderid, string map)
        {
            //string sql = "INSERT INTO [tsys_class](title,title2,directory,template,parent,orderid,map) VALUES(@title, @title2, @directory, @template, @parent, @orderid, @map)";
            //SqlParameter[] parm = new SqlParameter[] 
            //{ 
            //    new SqlParameter("@title", title), 
            //    new SqlParameter("@title2", title2), 
            //    new SqlParameter("@directory", directory), 
            //    new SqlParameter("@template", template), 
            //    new SqlParameter("@parent", parent), 
            //    new SqlParameter("@orderid", orderid),
            //    new SqlParameter("@map", map)
            //};
            //return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
            ISS.CMS.Model.ClassModel model = new ClassModel();
            model.Title = title;
            model.Title2 = title2;
            model.Directory = directory;
            model.Template = Convert.ToInt32(template);
            model.Parent = Convert.ToInt32(parent);
            model.OrderID = Convert.ToInt32(orderid);
            model.Map = map;
            return Add(model);
        }

        public int UpdateClass(string parent, string title, string title2, string directory, string template, string orderid, string map, string id, bool updateParent)
        {
            //SqlParameter[] parm = new SqlParameter[] 
            //{ 
            //    new SqlParameter("@parent", parent), 
            //    new SqlParameter("@title", title), 
            //    new SqlParameter("@title2", title2), 
            //    new SqlParameter("@directory", directory), 
            //    new SqlParameter("@template", template), 
            //    new SqlParameter("@orderid", orderid), 
            //    new SqlParameter("@map", map), 
            //    new SqlParameter("@id", id) 
            //};

            //StringBuilder strSql = new StringBuilder();
            //strSql.Append("UPDATE [tsys_class] SET ");
            //if (updateParent)
            //{
            //    strSql.Append("parent = @parent,");
            //}
            //else
            //{
            //    parm = new SqlParameter[] 
            //    { 
            //        new SqlParameter("@title", title), 
            //        new SqlParameter("@title2", title2), 
            //        new SqlParameter("@directory", directory), 
            //        new SqlParameter("@template", template), 
            //        new SqlParameter("@orderid", orderid), 
            //        new SqlParameter("@map", map), 
            //        new SqlParameter("@id", id) 
            //    };
            //}
            //strSql.Append("title = @title,");
            //strSql.Append("title2 = @title2,");
            //strSql.Append("directory = @directory,");
            //strSql.Append("template = @template,");
            //strSql.Append("orderid = @orderid,");
            //strSql.Append("map = @map");
            //strSql.Append(" where id = @id");

            //return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parm);

            ISS.CMS.Model.ClassModel model = new ClassModel();
            model.Title = title;
            model.Title2 = title2;
            model.Directory = directory;
            model.Template = Convert.ToInt32(template);
            model.Parent = Convert.ToInt32(parent);
            model.OrderID = Convert.ToInt32(orderid);
            model.Map = map;
            return update(model, updateParent);
        }


        private int update(Model.ClassModel model, bool updateParent)
        {
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { }, false);

            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE [tsys_class] SET ");
            if (updateParent)
            {
                strSql.Append("parent = @parent,");
            }
            else
            {
                parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "parent" }, false);
            }
            strSql.Append("title = @title,");
            strSql.Append("title2 = @title2,");
            strSql.Append("directory = @directory,");
            strSql.Append("template = @template,");
            strSql.Append("orderid = @orderid,");
            strSql.Append("map = @map");
            strSql.Append(" where id = @id");

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
        }

        public int GetClassCount()
        {
            string sql = "SELECT COUNT(1) FROM [tsys_class]";
            return int.Parse(SqlHelper.GetSingle(CommandType.Text, sql, null).ToString());
        }


        public int GetMaxId()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(id) from tsys_class");
            return (int)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
        }

        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(id) from tsys_class where id=@id");
            return (int)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null) > 0 ? true : false;
        }

        public int Add(Model.ClassModel model)
        {
            string sql = "INSERT INTO [tsys_class](title,title2,directory,template,parent,orderid,map) VALUES(@title, @title2, @directory, @template, @parent, @orderid, @map)";
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "id" }, false);
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parameters);
        }

        public bool Update(Model.ClassModel model)
        {
            return update(model, true) > 0 ? true : false;
        }

        public bool Delete(int Id)
        {
            return DeleteClass(Id) > 0 ? true : false;
        }

        public bool DeleteList(string Idlist)
        {
            throw new NotImplementedException();
        }

        public Model.ClassModel GetModel(int Id)
        {
            Model.ClassModel model = new ClassModel();
            DataSet ds = GetClassById(Id);
            List<Model.ClassModel> list = ModelHandler<Model.ClassModel>.DataTable2Model(ds.Tables[0]);
            return list.Count > 0 ? list[0] : null;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [tsys_class]");
            if (!strWhere.StartsWith("where"))
            {
                strSql.Append(" where ");
            }
            strSql.Append(strWhere);

            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top {0} * from [tsys_class]");
            if (!strWhere.StartsWith("where", StringComparison.CurrentCultureIgnoreCase))
            {
                strSql.Append(" where ");
            }
            strSql.Append(strWhere);
            if (!filedOrder.StartsWith("order by", StringComparison.CurrentCultureIgnoreCase))
            {
                strSql.Append(" order by");
            }
            strSql.Append(filedOrder);

            return SqlHelper.Query(CommandType.Text, string.Format(strSql.ToString(), Top), null);
        }

        public int GetRecordCount(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            return ds.Tables[0].Rows.Count;
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
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
            strSql.Append(")AS Row, T.*  from tsys_class T ");
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


        public DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            if (fieldNames.Length != fieldValues.Length) return null;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from tsys_class where ");

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
                strSql.Append("[" + fieldNames[i] + "]");
                if (fieldOperator[i].Equals("in", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(fieldNames[i]))
                    {
                        strSql.Append(fieldOperator[i] + " (" + fieldValues[i] + ") ");
                    }
                    else
                    {
                        throw new Exception(fieldNames[i] + " Value is null or ''");
                    }
                }
                else
                {
                    strSql.Append(fieldOperator[i] + "@" + fieldNames[i]);
                    SqlParameter param = new SqlParameter("@" + fieldNames[i], fieldValues[i]);
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
                orderField = "id";
            }
            if (isAsc)
            {
                strSql.Append(" order by " + orderField + " asc");
            }
            else
            {
                strSql.Append(" order by " + orderField + " desc");
            }
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), parameters);
        }

        public DataSet GetClassId()
        {
            string sql = "select id from [tsys_class]";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public DataSet GetClassByParent(string parent)
        {
            string sql = "select * from [tsys_class] where parent = @parent order by id desc";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@parent", parent) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetClassByParentAndIdInClassId(string parent, string classId, string sqlOrder)
        {
            string sql = "select * from [tsys_class] where parent = @parent and id in (" + classId + ") order by " + sqlOrder;
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@parent", parent) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

    }
}
