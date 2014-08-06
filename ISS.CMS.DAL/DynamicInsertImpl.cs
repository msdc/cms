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
    /// <summary>
	/// 数据访问类:tsys_DynamicInsert
	/// </summary>
	public partial class DynamicInsertImpl:IDynamicInsertDao
	{
        public DynamicInsertImpl()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return 0;//(int)SqlHelper.("id", "tsys_DynamicInsert"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) from tsys_DynamicInsert");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

            return (bool)SqlHelper.GetSingle(CommandType.Text, strSql.ToString(), parameters);
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
            strSql.Append(" select * from tsys_DynamicInsert where ");
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
		/// 增加一条数据
		/// </summary>
		public int Add(ISS.CMS.Model.DynamicInsert model)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("insert into tsys_DynamicInsert(");
			strSql.Append("title,Length,ShortContentLen,TitleOut,TitleOutType,startelement,endelement,content,pagecontent,PageNumber,bytime,bysort,isCommend,looptime,ispage,class,speciality,Encoding,filelist,NeedUpDate)");
			strSql.Append(" values (");
			strSql.Append("@title,@Length,@ShortContentLen,@TitleOut,@TitleOutType,@startelement,@endelement,@content,@pagecontent,@PageNumber,@bytime,@bysort,@isCommend,@looptime,@ispage,@class,@speciality,@Encoding,@filelist,@NeedUpDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@ShortContentLen", SqlDbType.Int,4),
					new SqlParameter("@TitleOut", SqlDbType.NVarChar,200),
					new SqlParameter("@TitleOutType", SqlDbType.NVarChar,50),
					new SqlParameter("@startelement", SqlDbType.VarChar,250),
					new SqlParameter("@endelement", SqlDbType.VarChar,250),
					new SqlParameter("@content", SqlDbType.VarChar,5000),
					new SqlParameter("@pagecontent", SqlDbType.VarChar,5000),
					new SqlParameter("@PageNumber", SqlDbType.Int,4),
					new SqlParameter("@bytime", SqlDbType.VarChar,50),
					new SqlParameter("@bysort", SqlDbType.VarChar,50),
					new SqlParameter("@isCommend", SqlDbType.Bit,1),
					new SqlParameter("@looptime", SqlDbType.Int,4),
					new SqlParameter("@ispage", SqlDbType.Bit,1),
					new SqlParameter("@class", SqlDbType.VarChar,500),
					new SqlParameter("@speciality", SqlDbType.VarChar,500),
					new SqlParameter("@Encoding", SqlDbType.VarChar,50),
					new SqlParameter("@filelist", SqlDbType.VarChar,2000),
					new SqlParameter("@NeedUpDate", SqlDbType.Bit,1)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.Length;
			parameters[2].Value = model.ShortContentLen;
			parameters[3].Value = model.TitleOut;
			parameters[4].Value = model.TitleOutType;
			parameters[5].Value = model.startelement;
			parameters[6].Value = model.endelement;
			parameters[7].Value = model.content;
			parameters[8].Value = model.pagecontent;
			parameters[9].Value = model.PageNumber;
			parameters[10].Value = model.bytime;
			parameters[11].Value = model.bysort;
			parameters[12].Value = model.isCommend;
			parameters[13].Value = model.looptime;
			parameters[14].Value = model.ispage;
			parameters[15].Value = model.classw;
			parameters[16].Value = model.speciality;
			parameters[17].Value = model.Encoding;
			parameters[18].Value = model.filelist;
			parameters[19].Value = model.NeedUpDate;

            object obj = SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ISS.CMS.Model.DynamicInsert model)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("update tsys_DynamicInsert set ");
			strSql.Append("title=@title,");
			strSql.Append("Length=@Length,");
			strSql.Append("ShortContentLen=@ShortContentLen,");
			strSql.Append("TitleOut=@TitleOut,");
			strSql.Append("TitleOutType=@TitleOutType,");
			strSql.Append("startelement=@startelement,");
			strSql.Append("endelement=@endelement,");
			strSql.Append("content=@content,");
			strSql.Append("pagecontent=@pagecontent,");
			strSql.Append("PageNumber=@PageNumber,");
			strSql.Append("bytime=@bytime,");
			strSql.Append("bysort=@bysort,");
			strSql.Append("isCommend=@isCommend,");
			strSql.Append("looptime=@looptime,");
			strSql.Append("ispage=@ispage,");
			strSql.Append("class=@class,");
			strSql.Append("speciality=@speciality,");
			strSql.Append("Encoding=@Encoding,");
			strSql.Append("filelist=@filelist,");
			strSql.Append("NeedUpDate=@NeedUpDate");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@ShortContentLen", SqlDbType.Int,4),
					new SqlParameter("@TitleOut", SqlDbType.NVarChar,200),
					new SqlParameter("@TitleOutType", SqlDbType.NVarChar,50),
					new SqlParameter("@startelement", SqlDbType.VarChar,250),
					new SqlParameter("@endelement", SqlDbType.VarChar,250),
					new SqlParameter("@content", SqlDbType.VarChar,5000),
					new SqlParameter("@pagecontent", SqlDbType.VarChar,5000),
					new SqlParameter("@PageNumber", SqlDbType.Int,4),
					new SqlParameter("@bytime", SqlDbType.VarChar,50),
					new SqlParameter("@bysort", SqlDbType.VarChar,50),
					new SqlParameter("@isCommend", SqlDbType.Bit,1),
					new SqlParameter("@looptime", SqlDbType.Int,4),
					new SqlParameter("@ispage", SqlDbType.Bit,1),
					new SqlParameter("@class", SqlDbType.VarChar,500),
					new SqlParameter("@speciality", SqlDbType.VarChar,500),
					new SqlParameter("@Encoding", SqlDbType.VarChar,50),
					new SqlParameter("@filelist", SqlDbType.VarChar,2000),
					new SqlParameter("@NeedUpDate", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.Length;
			parameters[2].Value = model.ShortContentLen;
			parameters[3].Value = model.TitleOut;
			parameters[4].Value = model.TitleOutType;
			parameters[5].Value = model.startelement;
			parameters[6].Value = model.endelement;
			parameters[7].Value = model.content;
			parameters[8].Value = model.pagecontent;
			parameters[9].Value = model.PageNumber;
			parameters[10].Value = model.bytime;
			parameters[11].Value = model.bysort;
			parameters[12].Value = model.isCommend;
			parameters[13].Value = model.looptime;
			parameters[14].Value = model.ispage;
			parameters[15].Value = model.classw;
			parameters[16].Value = model.speciality;
			parameters[17].Value = model.Encoding;
			parameters[18].Value = model.filelist;
			parameters[19].Value = model.NeedUpDate;
			parameters[20].Value = model.id;

            int rows = SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
            StringBuilder strSql = new StringBuilder();
			strSql.Append("delete from tsys_DynamicInsert ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

            int rows = SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
        public bool DeleteList(string idlist)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("delete from tsys_DynamicInsert ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = SqlHelper.ExecuteSql(CommandType.Text, strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ISS.CMS.Model.DynamicInsert GetModel(int id)
		{
			
            StringBuilder strSql = new StringBuilder();
			strSql.Append("select  top 1 id,title,Length,ShortContentLen,TitleOut,TitleOutType,startelement,endelement,content,pagecontent,PageNumber,bytime,bysort,isCommend,looptime,ispage,class,speciality,Encoding,filelist,NeedUpDate from tsys_DynamicInsert ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

            ISS.CMS.Model.DynamicInsert model = new ISS.CMS.Model.DynamicInsert();
            DataSet ds = SqlHelper.Query(CommandType.Text, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
			{
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
				{
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
                if (ds.Tables[0].Rows[0]["title"] != null && ds.Tables[0].Rows[0]["title"].ToString() != "")
				{
                    model.title = ds.Tables[0].Rows[0]["title"].ToString();
				}
                if (ds.Tables[0].Rows[0]["Length"] != null && ds.Tables[0].Rows[0]["Length"].ToString() != "")
				{
                    model.Length = int.Parse(ds.Tables[0].Rows[0]["Length"].ToString());
				}
                if (ds.Tables[0].Rows[0]["ShortContentLen"] != null && ds.Tables[0].Rows[0]["ShortContentLen"].ToString() != "")
				{
                    model.ShortContentLen = int.Parse(ds.Tables[0].Rows[0]["ShortContentLen"].ToString());
				}
                if (ds.Tables[0].Rows[0]["TitleOut"] != null && ds.Tables[0].Rows[0]["TitleOut"].ToString() != "")
				{
                    model.TitleOut = ds.Tables[0].Rows[0]["TitleOut"].ToString();
				}
                if (ds.Tables[0].Rows[0]["TitleOutType"] != null && ds.Tables[0].Rows[0]["TitleOutType"].ToString() != "")
				{
                    model.TitleOutType = ds.Tables[0].Rows[0]["TitleOutType"].ToString();
				}
                if (ds.Tables[0].Rows[0]["startelement"] != null && ds.Tables[0].Rows[0]["startelement"].ToString() != "")
				{
                    model.startelement = ds.Tables[0].Rows[0]["startelement"].ToString();
				}
                if (ds.Tables[0].Rows[0]["endelement"] != null && ds.Tables[0].Rows[0]["endelement"].ToString() != "")
				{
                    model.endelement = ds.Tables[0].Rows[0]["endelement"].ToString();
				}
                if (ds.Tables[0].Rows[0]["content"] != null && ds.Tables[0].Rows[0]["content"].ToString() != "")
				{
                    model.content = ds.Tables[0].Rows[0]["content"].ToString();
				}
                if (ds.Tables[0].Rows[0]["pagecontent"] != null && ds.Tables[0].Rows[0]["pagecontent"].ToString() != "")
				{
                    model.pagecontent = ds.Tables[0].Rows[0]["pagecontent"].ToString();
				}
                if (ds.Tables[0].Rows[0]["PageNumber"] != null && ds.Tables[0].Rows[0]["PageNumber"].ToString() != "")
				{
                    model.PageNumber = int.Parse(ds.Tables[0].Rows[0]["PageNumber"].ToString());
				}
                if (ds.Tables[0].Rows[0]["bytime"] != null && ds.Tables[0].Rows[0]["bytime"].ToString() != "")
				{
                    model.bytime = ds.Tables[0].Rows[0]["bytime"].ToString();
				}
                if (ds.Tables[0].Rows[0]["bysort"] != null && ds.Tables[0].Rows[0]["bysort"].ToString() != "")
				{
                    model.bysort = ds.Tables[0].Rows[0]["bysort"].ToString();
				}
                if (ds.Tables[0].Rows[0]["isCommend"] != null && ds.Tables[0].Rows[0]["isCommend"].ToString() != "")
				{
                    if ((ds.Tables[0].Rows[0]["isCommend"].ToString() == "1") || (ds.Tables[0].Rows[0]["isCommend"].ToString().ToLower() == "true"))
					{
                        model.isCommend = true;
					}
					else
					{
                        model.isCommend = false;
					}
				}
                if (ds.Tables[0].Rows[0]["looptime"] != null && ds.Tables[0].Rows[0]["looptime"].ToString() != "")
				{
                    model.looptime = int.Parse(ds.Tables[0].Rows[0]["looptime"].ToString());
				}
                if (ds.Tables[0].Rows[0]["ispage"] != null && ds.Tables[0].Rows[0]["ispage"].ToString() != "")
				{
                    if ((ds.Tables[0].Rows[0]["ispage"].ToString() == "1") || (ds.Tables[0].Rows[0]["ispage"].ToString().ToLower() == "true"))
					{
                        model.ispage = true;
					}
					else
					{
                        model.ispage = false;
					}
				}
                if (ds.Tables[0].Rows[0]["class"] != null && ds.Tables[0].Rows[0]["class"].ToString() != "")
				{
                    model.classw = ds.Tables[0].Rows[0]["class"].ToString();
				}
                if (ds.Tables[0].Rows[0]["speciality"] != null && ds.Tables[0].Rows[0]["speciality"].ToString() != "")
				{
                    model.speciality = ds.Tables[0].Rows[0]["speciality"].ToString();
				}
                if (ds.Tables[0].Rows[0]["Encoding"] != null && ds.Tables[0].Rows[0]["Encoding"].ToString() != "")
				{
                    model.Encoding = ds.Tables[0].Rows[0]["Encoding"].ToString();
				}
                if (ds.Tables[0].Rows[0]["filelist"] != null && ds.Tables[0].Rows[0]["filelist"].ToString() != "")
				{
                    model.filelist = ds.Tables[0].Rows[0]["filelist"].ToString();
				}
                if (ds.Tables[0].Rows[0]["NeedUpDate"] != null && ds.Tables[0].Rows[0]["NeedUpDate"].ToString() != "")
				{
                    if ((ds.Tables[0].Rows[0]["NeedUpDate"].ToString() == "1") || (ds.Tables[0].Rows[0]["NeedUpDate"].ToString().ToLower() == "true"))
					{
                        model.NeedUpDate = true;
					}
					else
					{
                        model.NeedUpDate = false;
					}
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("select id,title,Length,ShortContentLen,TitleOut,TitleOutType,startelement,endelement,content,pagecontent,PageNumber,bytime,bysort,isCommend,looptime,ispage,class,speciality,Encoding,filelist,NeedUpDate ");
			strSql.Append(" FROM tsys_DynamicInsert ");
            if (strWhere.Trim() != "")
			{
                strSql.Append(" where " + strWhere);
			}
            return SqlHelper.Query(CommandType.Text, strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("select ");
            if (Top > 0)
			{
                strSql.Append(" top " + Top.ToString());
			}
			strSql.Append(" id,title,Length,ShortContentLen,TitleOut,TitleOutType,startelement,endelement,content,pagecontent,PageNumber,bytime,bysort,isCommend,looptime,ispage,class,speciality,Encoding,filelist,NeedUpDate ");
			strSql.Append(" FROM tsys_DynamicInsert ");
            if (strWhere.Trim() != "")
			{
                strSql.Append(" where " + strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return SqlHelper.Query(CommandType.Text, strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) FROM tsys_DynamicInsert ");
            if (strWhere.Trim() != "")
			{
                strSql.Append(" where " + strWhere);
			}
            object obj = SqlHelper.GetSingle(CommandType.Text, strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
            StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
                strSql.Append("order by T." + orderby);
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from tsys_DynamicInsert T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return SqlHelper.Query(CommandType.Text, strSql.ToString());
		}

        public DataSet GetDynamicInsertList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tsys_DynamicInsert order by title");
            return SqlHelper.Query(CommandType.Text, strSql.ToString(), null);
        }

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "tsys_DynamicInsert";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return (int)SqlHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}
