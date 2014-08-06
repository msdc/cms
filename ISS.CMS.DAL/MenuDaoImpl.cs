using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class MenuDaoImpl : IMenuDao
    {
        public DataSet GetMenuByParentId(string parentId)
        {
            string sql = "select * from tsys_menu where parentid=@parentId order by id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@parentId", parentId) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetClassByParentId(string parentId)
        {
            string sql = "select * from [tsys_class] where parent = @parentId order by orderID";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@parentId", parentId) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetMenuById(string id)
        {
            string sql = "select * from tsys_menu where id=@id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.Query(CommandType.Text, sql, parm);
        }

        public DataSet GetMenu()
        {
            string sql = "select * from tsys_menu order by id";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }

        public int GetMenuMaxOrderIdByParentId(string parentid)
        {
            string sql = "select max(orderid) from tsys_menu where parentid = @parentid";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@parentid", parentid) };
            return int.Parse(SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString());
        }

        public DataSet GetClass()
        {
            string sql = "select * from [tsys_class] order by orderID";
            return SqlHelper.Query(CommandType.Text, sql, null);
        }
                
        public int DeleteMenu(string id)
        {
            string sql = "delete from tsys_menu where id = @id";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@id", id) };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int UpdateMenuCorrespondingPage(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string haspage, string description, string id)
        {
            string sql = "update tsys_menu set pagename = @pagename, pagefiledir = @pagefiledir, pagetitle = @pagetitle, subpagetitle = @subpagetitle, haspage = @haspage, description = @description where id = @id";
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter("@pagename", pagename), 
                new SqlParameter("@pagefiledir", pagefiledir), 
                new SqlParameter("@pagetitle", pagetitle), 
                new SqlParameter("@subpagetitle", subpagetitle), 
                new SqlParameter("@haspage", haspage), 
                new SqlParameter("@description", description), 
                new SqlParameter("@id", id) 
            };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int UpdateMenu(string pagename, string haspage, string description, string id)
        {
            string sql = "update tsys_menu set pagename = @pagename, pagefiledir = @pagefiledir, pagetitle = @pagetitle, haspage = @haspage, description = @description where id = @id";
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter("@pagename", pagename), 
                new SqlParameter("@pagefiledir", ""), 
                new SqlParameter("@pagetitle", ""), 
                new SqlParameter("@haspage", haspage), 
                new SqlParameter("@description", description), 
                new SqlParameter("@id", id) 
            };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int AddMenu(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string parentid, string haspage, string description, string orderid)
        {
            string sql = "insert into tsys_menu(pagename,pagefiledir,pagetitle,subpagetitle,parentid,haspage,description,orderid) values(@pagename, @pagefiledir, @pagetitle, @subpagetitle, @parentid, @haspage, @description, @orderid)";
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter("@pagename", pagename), 
                new SqlParameter("@pagefiledir", pagefiledir), 
                new SqlParameter("@pagetitle", pagetitle), 
                new SqlParameter("@subpagetitle", subpagetitle), 
                new SqlParameter("@parentid", parentid),
                new SqlParameter("@haspage", haspage), 
                new SqlParameter("@description", description), 
                new SqlParameter("@orderid", orderid)
            };
            return SqlHelper.ExecuteSql(CommandType.Text, sql, parm);
        }

        public int GetCountOfMenuIdByPageTitle(string filename)
        {
            string sql = "select count(id) from tsys_menu where pagetitle like @filename";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@filename", string.Format("{0}%", filename)) };
            return int.Parse(SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString());
        }

        public string GetMenuIdByPageTite(string filename)
        {
            string sql = "select id from tsys_menu where pagetitle like @filename";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@filename", string.Format("{0}%", filename)) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        public string GetMenuIdBySubPageTite(string filename)
        {
            string sql = "select id from tsys_menu where subpagetitle like @filename";
            SqlParameter[] parm = new SqlParameter[] { new SqlParameter("@filename", string.Format("%{0}%", filename)) };
            return SqlHelper.GetSingle(CommandType.Text, sql, parm).ToString();
        }

        public DataSet GetAdminPermission()
        {
            //string menuId = null;
            string sql = "SELECT * FROM tsys_menu ORDER BY Id ASC";//"select id from tsys_menu";
            //DataTable dt = SqlHelper.Query(CommandType.Text, sql, null).Tables[0];

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    menuId += dt.Rows[i]["id"] + ",";
            //}
            //return menuId.TrimEnd(',');
            return SqlHelper.Query(CommandType.Text, sql, null);
        }
    }
}
