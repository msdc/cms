using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using ISS.CMS.BLL;
using System.Data;
public partial class Manage_news_list : System.Web.UI.Page
{


    string content;
    string classStr;
    static int pagecount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            //td();
        }
    }
    #region 页面初始
    protected void dsbind()
    {      
        int pageindex;
        string templateidStr="";
        try
        {
            pageindex = int.Parse(Request["page"]);
        }
        catch
        {
            pageindex = 0;
        }

        templateidStr = TemplateBLL.GetTemplateIdByRoleName(validate.cookiestr);
        System.Data.DataSet ds = null;
        if (Request["value"] != null && Request["value"] != "")
        {
            // sqlwhere += "and " + Request["type"] + " like '%" + Request["value"] + "%'";
            ds = NewsViewBLL.GetListByTemplateIdAndType(templateidStr, Request["type"], Request["value"], false, "addTime", true);

            hidQueryString.Value = hidQueryString.Value + "&type=" + Request["type"] + "&value=" + Request["value"];
        }
        else
        {
            ds = NewsViewBLL.GetListByTemplateId(templateidStr, false, "addTime", true);
        }
        if (ds == null) return;      
        PagedDataSource pds = PageBLL.GetPageDataSoureView(ds.Tables[0], 10, pageindex);
        rptData.DataSource = pds;
        rptData.DataBind();
        lbl_datacount.Text = "资源数：" + pds.Count.ToString() + "条";
        lbl_pagecount.Text = "总共：" + pds.PageCount.ToString() + "页";
        lbl_pageindex.Text = "当前页面：" + (pds.CurrentPageIndex + 1).ToString() + "/" + pds.PageCount.ToString();
        hidPageindex.Value = pds.CurrentPageIndex.ToString();
        pagecount = pds.PageCount;
        //DataTable dt = null;
        //string parent = "-1";
        //if (Request["parent"] != null && Request["parent"] != "")
        //{
        //    // sql = "select * from [tsys_class] where parent = " + Request["parent"] + " and id in (" + ClassBLL.GetClassIdByRoleName(validate.cookiestr) + ") order by ID asc";
        //    parent = Request["parent"];
        //}
        //else
        //{
        //    // sql = "select * from [tsys_class] where parent = -1 and id in (" + ClassBLL.GetClassIdByRoleName(validate.cookiestr) + ") order by ID asc";
        //    parent = "-1";
        //}
        //dt = ClassBLL.GetList(new string[] { "parent", "id" }, new string[] { parent, ClassBLL.GetClassIdByRoleName(validate.cookiestr) }, new string[] { "=", "in" }, new string[] { "and" }, "ID", true).Tables[0];

        //if (dt.Rows.Count > 0)
        //{
        //    class_dl.DataSource = dt;
        //    class_dl.DataBind();
        //}
        //else
        //{
        //    class_td.InnerHtml = "<div style=\"padding:5px;\">无子类别</div>";
        //}
    }
    #endregion
    #region 横向导航数据递规
    protected void node(int id)
    {
        string sql;
        DataTable dt; ;
        //sql = "select * from [tsys_class] where id=" + id;
        dt = ClassBLL.GetClassById(id.ToString()).Tables[0];
        //dt = DbHelperSQL.Query(sql).Tables[0];
        content = "＞<a href='news_list.aspx?parent=" + dt.Rows[0]["id"].ToString() + "'>" + dt.Rows[0]["title"].ToString() + "</a>" + content;
        if (dt.Rows[0]["parent"].ToString() != "-1")
        {
            node(Convert.ToInt32(dt.Rows[0]["parent"]));
        }
    }
    #endregion
    #region 横向导航数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "")
        {
            if (Request["parent"] != "-1")
                node(Convert.ToInt32(Request["parent"]));
        }
        //TD1.InnerHtml = "<a href='news_list.aspx'>根类别</a>" + content + " 的子分类列表";
    }
    #endregion
    #region 返回模版ID
    //protected string classid(string id)
    //{
    //    DataTable dt, dt2;
    //    //string sql = "select * from [tsys_class] where parent = " + id + " and id in (" + ClassBLL.GetClassIdByRoleName(validate.cookiestr) + ")";
    //    //dt = DbHelperSQL.Query(sql).Tables[0];
        
    //    dt = ClassBLL.GetClassByParentAndIdInClassId(id, ClassBLL.GetClassIdByRoleName(validate.cookiestr), "id").Tables[0];
    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        classStr += dt.Rows[i]["id"].ToString() + ",";

    //        //sql = "select * from [tsys_class] where parent =" + dt.Rows[i]["id"].ToString() + "";
    //        //dt2 = DbHelperSQL.Query(sql).Tables[0];
    //        dt2 = ClassBLL.GetClassByParent(dt.Rows[i]["id"].ToString()).Tables[0];
    //        if (dt2.Rows.Count > 0)
    //        {
    //            classid(dt.Rows[i]["id"].ToString());
    //        }
    //    }
    //    return classStr == null ? "" : classStr.TrimEnd(',');

    //}

    //protected string templateid(string id)
    //{
    //    string templateStr = TemplateBLL.GetTemplateById(id).Tables[0].Rows[0]["Title"].ToString();
    //    return templateStr;
    //}
    #endregion
    protected void lbGo_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=" + (int.Parse(page_tb.Value) - 1) + "&parent=" + Request["parent"]);
    }
    protected void dl1_RowCommand(object sender, RepeaterCommandEventArgs e)
    {

        if (e.CommandName == "生成")
        {
            Create.dir(e.CommandArgument.ToString());
            dsbind();
            ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "alert('资源已生成。')", true);
        }
        else if (e.CommandName == "浏览")
        {
            string path = e.CommandArgument.ToString();
            ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(), "updateScript", "window.open('" + ".." + path.Replace("\\", "/") + "','_blank')", true);
        }
        else if (e.CommandName == "删除")
        {

            //sql = "UPDATE [tsys_news] SET [IsDel] = 1 WHERE [ID] = " + e.CommandArgument.ToString();DbHelperSQL.ExecuteSql(sql);

            NewsViewBLL.LogicalDeleteById(e.CommandArgument.ToString());
            dsbind();
        }
        else if (e.CommandName == "审核")
        {
            string sql;
            //sql = "SELECT [IsCheck] FROM [tsys_news] WHERE [ID] = " + e.CommandArgument.ToString();
            //bool yoncheck = Convert.ToBoolean(DbHelperSQL.GetSingle(sql).ToString());
            ISS.CMS.Model.NewsView model = NewsViewBLL.GetModelById(Convert.ToInt32(e.CommandArgument));

            if (model.IsCheck)
            {
                //sql = "UPDATE [tsys_news] SET [IsCheck] = 0 WHERE [ID] = " + e.CommandArgument.ToString();
                NewsViewBLL.RestoreById(e.CommandArgument.ToString());
            }
            else
            {
                //sql = "UPDATE [tsys_news] SET [IsCheck] = 1 WHERE [ID] = " + e.CommandArgument.ToString();
                NewsViewBLL.LogicalDeleteById(e.CommandArgument.ToString());
            }

            dsbind();
        }
    }
    protected void lbFirst_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=0" + hidQueryString.Value);
    }
    protected void lbPrev_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=" + (int.Parse(hidPageindex.Value) - 1) + hidQueryString.Value);
    }
    protected void lbNext_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=" + Convert.ToString((int.Parse(hidPageindex.Value) + 1)) + hidQueryString.Value);
    }
    protected void lbLast_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=" + (pagecount - 1) + hidQueryString.Value);
    }
    protected void lbSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?type=" + sort_ddl.SelectedValue + "&value=" + sreach_tb.Text.Trim());
    }
    protected void lbCheck_Click(object sender, EventArgs e)
    {

        string sql, newsid = "0,";
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        //sql = "update [tsys_news] set IsCheck = 1 where id in (" + newsid.TrimEnd(',') + ")";
        //int yon = DbHelperSQL.ExecuteSql(sql);
        bool isCheck = NewsViewBLL.PassCheckedById(newsid.TrimEnd(','), true);
        if (isCheck)
        {
            self.alert("审核资源通过");
            self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
    protected void lbCreate_Click(object sender, EventArgs e)
    {
        string newsid = "";
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        int yon = Create.dir(newsid.TrimEnd(','));
        if (yon > 0)
        {
            self.alert("成功生成资源（" + yon + "）条！");
            self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
    protected void lbDel_Click(object sender, EventArgs e)
    {

        string sql, newsid = "";
        sql = "";
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        //sql = "update [tsys_news] set [IsDel] = 1 where id in (" + newsid.TrimEnd(',') + ")";
        //int yon = DbHelperSQL.ExecuteSql(sql);
        bool yon = NewsViewBLL.LogicalDeleteById(newsid.TrimEnd(','));
        if (yon)
        {
            self.alert("回收站放入资源");
            self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
    protected void lbDelData_Click(object sender, EventArgs e)
    {

        string sql, newsid = "";
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        //sql = "select * from [tsys_news] where id in (" + newsid.TrimEnd(',') + ")";
        //DataTable dt = DbHelperSQL.Query(sql).Tables[0];
        DataTable dt = NewsViewBLL.GetListByCustomQuery(new string[] { "id" }, new string[] { newsid.TrimEnd(',') }, new string[] { "in" }, new string[] { }, "id", true).Tables[0];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            try
            {
                File.Delete(MapPath(".." + dt.Rows[i]["filepath"].ToString()));
            }
            catch { }
        }
        //sql = "delete from [tsys_news] where id in(" + newsid.TrimEnd(',') + ")";
        //int yon = DbHelperSQL.ExecuteSql(sql);
        bool isOk = NewsViewBLL.DeleteList(newsid.TrimEnd(','));

        {
            self.alert("成功删除资源");
            self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
}