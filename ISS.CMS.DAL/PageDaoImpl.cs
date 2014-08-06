using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
using System.Data.SqlClient;
using System.Data;
using ISS.CMS.IDAL;

namespace ISS.CMS.DAL
{
    public class PageDaoImpl : IPageDao
    {
        public PageView GetPageView(string tablename_p, string column_p, string primarykey_p, int pagesize_p, int pageindex_p, string where_p, string order_p)
        {
            SqlCommand scd = new SqlCommand("procPaging");
            scd.Parameters.Add("@tablename", SqlDbType.VarChar, 50);
            scd.Parameters["@tablename"].Value = tablename_p;
            scd.Parameters.Add("@column", SqlDbType.VarChar, 500);
            scd.Parameters["@column"].Value = column_p;
            scd.Parameters.Add("@primarykey", SqlDbType.VarChar, 20);
            scd.Parameters["@primarykey"].Value = primarykey_p;
            scd.Parameters.Add("@pagesize", SqlDbType.Int);
            scd.Parameters["@pagesize"].Value = pagesize_p;
            scd.Parameters.Add("@pageindex", SqlDbType.Int);
            scd.Parameters["@pageindex"].Value = pageindex_p;
            scd.Parameters.Add("@where", SqlDbType.VarChar, 2000);
            scd.Parameters["@where"].Value = where_p;
            scd.Parameters.Add("@order", SqlDbType.VarChar, 1000);
            scd.Parameters["@order"].Value = order_p;
            SqlParameter sp = new SqlParameter("@datacount", SqlDbType.Int);
            sp.Direction = ParameterDirection.Output;
            scd.Parameters.Add(sp);
            SqlParameter sp1 = new SqlParameter("@pagecount", SqlDbType.Int);
            sp1.Direction = ParameterDirection.Output;
            scd.Parameters.Add(sp1);
            SqlParameter sp2 = new SqlParameter("@pageindex_p", SqlDbType.Int);
            sp2.Direction = ParameterDirection.Output;
            scd.Parameters.Add(sp2);

            PageView pageView = new PageView(SqlHelper.GetStoredProcedureData(scd).Tables[0]);
            pageView.DataCount = Convert.ToInt32(sp.Value);
            pageView.PageCount = Convert.ToInt32(sp1.Value);
            pageView.PageIndex = Convert.ToInt32(sp2.Value);

            return pageView;
        }
    }
}
