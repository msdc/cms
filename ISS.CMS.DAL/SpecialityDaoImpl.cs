using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
using ISS.CMS.IDAL;
using System.Data;
using System.Data.SqlClient;
namespace ISS.CMS.DAL
{
    class SpecialityDaoImpl : ISpeciality
    {
        public int Add(Speciality model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tsys_Speciality(title,parent,explain) values(@title,@parent,@explain)");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "parent", "explain" }, new object[] { model.Title, model.Parent, model.Explain });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
        }

        public bool Update(Speciality model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tsys_Speciality set title=@title,parent=@parent,explain=@explain where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(model, new string[] { "title", "parent", "explain", "id" }, new object[] { model.Title, model.Parent, model.Explain, model.Id });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;

        }

        public bool Delete([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tsys_Speciality where id=@id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            return SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters) > 0 ? true : false;
        }

        public bool DeleteList(string Idlist)
        {
            throw new NotImplementedException();
        }

        public Speciality GetModel([DataFiled("id", SqlDbType.Int)]int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,title,parent,explain from tsys_Speciality ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = DbParameterGenerator.GetParameterGenerator(System.Reflection.MethodInfo.GetCurrentMethod() as System.Reflection.MethodInfo, new object[] { Id });

            Model.Speciality model = new Model.Speciality();
            DataSet ds = SqlHelper.Query(System.Data.CommandType.Text, strSql.ToString(), parameters);
            List<Model.Speciality> list = ModelHandler<Model.Speciality>.DataTable2Model(ds.Tables[0]);
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

        public DataSet GetSpeciality()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM tsys_Speciality");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }
    }
}
