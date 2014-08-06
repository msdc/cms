

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
using System.Reflection;

namespace ISS.CMS.DAL
{
    public class AuthorDaoImpl : IAuthor
    {
        public int GetMaxId()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(id) from tsys_author");
            return (int)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
        }
        public bool Exists([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(id) from tsys_author where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });
            bool tf = (bool)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), null);
            return tf;
        }
        public int Add(Model.Author model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsys_author(title,content,sex,email) values(@title,@content,@sex,@email)");
            // SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "content", "sex", "email" }, new object[] { model.Title, model.Content, model.Sex, model.Email });
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "content", "sex", "email" }, true);
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);

        }
        public bool Update(Model.Author model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_author set title=@title,content=@content,sex=@sex,email=@email where id=@id");
            //SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "content", "sex", "email", "id" }, new object[] { model.Title, model.Content, model.Sex, model.Email, model.Id });
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model);



            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        public bool Delete([DataFiled("id", SqlDbType.Int)] int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_author where id=@id");
            //SqlParameter[] parameters = new SqlParameter[]{           
            //new SqlParameter("@id",Id)
            //};
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_author where id in (@list)");
            SqlParameter[] parameters = new SqlParameter[]{
            new SqlParameter("@list",Idlist)
            };
            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }
        public Model.Author GetModel([DataFiled("id", SqlDbType.Int)] int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Title,Content,Email,Sex from tsys_Author ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            Model.Author model = new Model.Author();
            DataSet ds = SqlHelper.Query(System.Data.CommandType.Text, strSql.ToString(), parameters);
            List<Model.Author> list = ModelHandler<Model.Author>.DataTable2Model(ds.Tables[0]);
            return list.Count > 0 ? list[0] : null;

        }
        public System.Data.DataSet GetList(string strWhere)
        {
            throw new NotImplementedException();
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

        public System.Data.DataSet GetAuthor()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_author order by ID asc");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }
    }
}
