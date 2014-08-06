using ISS.CMS.BLL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_DelNews_list : System.Web.UI.Page
{
    string content;
    string classStr;
    int pageindex;
    int pagecount = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            
        }
    }

    #region 页面初始
    protected void dsbind()
    {
        string sqlwhere="[IsDel] <> 0";        
        PageView page = PageBLL.GetNewsPageView(Request["page"], sqlwhere);
        rptData.DataSource = page.DataContent;//page.pageView("[tsys_newsView]", "*", "id", 10, pageindex, sqlwhere, "AddTime DESC");
        rptData.DataBind();
        lbl_datacount.Text = "记录数：" + page.DataCount.ToString() + "条";
        lbl_pagecount.Text = "总共：" + page.PageCount.ToString() + "页";
        lbl_pageindex.Text = "当前页面：" + page.PageIndex.ToString() + "/" + page.PageCount.ToString();
        pagecount = page.PageCount;
        hidPageindex.Value = page.PageIndex.ToString();


        
        //DataTable dt = ClassBLL.GetSubCategory(Request["parent"], ClassBLL.GetClassIdByRoleName(validate.cookiestr)).Tables[0];
        //if (dt.Rows.Count > 0)
        //{
        //    class_dl.DataSource = dt;
        //    class_dl.DataBind();
        //}
        //else
        //{
        //    class_td.InnerText = "无子类别";
        //}
    }
    #endregion
   
   
    protected void Button7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("news_list.aspx?page=" + page_tb.Value + "&parent=" + Request["parent"]);
    }
    protected void dl1_RowCommand(object sender, RepeaterCommandEventArgs e)
    {
        string sql;
        NewsViewBLL newsView = new NewsViewBLL();
        if (e.CommandName == "救回")
        {
            newsView.UpdateNewsViewIsDelById(int.Parse(e.CommandArgument.ToString()), false);
            Response.Redirect(Request.Url.AbsolutePath + "?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
        else if (e.CommandName == "浏览")
        {
            string path = e.CommandArgument.ToString();
            self.openwin(".." + path.Replace("\\", "/"));
        }
        else if (e.CommandName == "删除")
        {
            if (NewsViewBLL.Delete(int.Parse(e.CommandArgument.ToString())))
            {
                Response.Redirect(Request.Url.AbsolutePath + "?page=" + Request["page"] + "&parent=" + Request["parent"]);
            }
        }
    }
    //protected void Button4_Click(object sender, EventArgs e)
    //{
    //    //string sql, newsid = "";
    //    //sql = "";
    //    //for (int i = 0; i < rptData.Items.Count; i++)
    //    //{
    //    //    if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
    //    //    {
    //    //        newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
    //    //    }
    //    //}
    //    //sql = "UPDATE [tsys_news] set IsCheck = 1 where id in (" + newsid.TrimEnd(',') + ")";
    //    //int yon = DbHelperSQL.ExecuteSql(sql);
    //    //if (yon > 0)
    //    //{
    //    //    self.alert("成功审核资源（" + yon + "）条！");
    //    //    self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
    //    //}
    //}
    //protected void Button3_Click(object sender, EventArgs e)
    //{
    //    //string newsid = "";
    //    //for (int i = 0; i < rptData.Items.Count; i++)
    //    //{
    //    //    if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
    //    //    {
    //    //        newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
    //    //    }
    //    //}
    //    //int yon = create.dir(newsid.TrimEnd(','));
    //    //if (yon > 0)
    //    //{
    //    //    self.alert("成功生成资源（" + yon + "）条！");
    //    //    self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
    //    //}
    //}
    //protected void Button2_Click(object sender, EventArgs e)
    //{

    //}
    //protected void Button6_Click(object sender, EventArgs e)
    //{
    //    //string sql, newsid = "";
    //    //for (int i = 0; i < rptData.Items.Count; i++)
    //    //{
    //    //    if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
    //    //    {
    //    //        newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
    //    //    }
    //    //}
    //    //sql = "select * from [tsys_news] where id in (" + newsid.TrimEnd(',') + ")";
    //    //DataTable dt = DbHelperSQL.Query(sql).Tables[0];
    //    //for (int i = 0; i < dt.Rows.Count; i++)
    //    //{
    //    //    try
    //    //    {
    //    //        File.Delete(MapPath("../" + dt.Rows[i]["filepath"].ToString()));
    //    //    }
    //    //    catch { }
    //    //}
    //    //sql = "delete from [tsys_news] where id in(" + newsid.TrimEnd(',') + ")";
    //    //int yon = DbHelperSQL.ExecuteSql(sql);
    //    //{
    //    //    self.alert("成功删除资源（" + yon + "）条！");
    //    //    self.href("?page=" + Request["page"] + "&parent=" + Request["parent"]);
    //    //}
    //}
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        NewsViewBLL newView = new NewsViewBLL();
        newView.ClearNewsView();
        self.alert("资源回收站已清空！");
        self.href("delnews_list.aspx");
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        //string sql, newsid = "";
        //for (int i = 0; i < rptData.Items.Count; i++)
        //{
        //    if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
        //    {
        //        newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
        //    }
        //}
        //sql = "update [tsys_news] set [IsDel] = 0 where id in (" + newsid.TrimEnd(',') + ")";
        //int yon = DbHelperSQL.ExecuteSql(sql);
        //self.alert("成功救回资源（" + yon + "）条！");
        //self.href("delnews_list.aspx?page=" + Request["page"] + "&parent=" + Request["parent"]);
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("delnews_list.aspx?page=1");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("delnews_list.aspx?page=1" + "&parent=" + Request["parent"]);
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("delnews_list.aspx?page=" + (int.Parse(hidPageindex.Value) - 1) + "&parent=" + Request["parent"]);
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("delnews_list.aspx?page=" + (int.Parse(hidPageindex.Value) + 1) + "&parent=" + Request["parent"]);
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("delnews_list.aspx?page=" + pagecount + "&parent=" + Request["parent"]);
    }
    protected void lbReturn_Click(object sender, EventArgs e)
    {
        string sql, newsid = "";
        NewsViewBLL newsView = new NewsViewBLL();
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        int yon = newsView.UpdateNewsViewIsDelInScope(newsid.TrimEnd(','));
        if (yon > 0)
        {
            self.alert("救回资源（" + yon + "）条！");
            self.href("delnews_list.aspx?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
    protected void lbDel_Click(object sender, EventArgs e)
    {
        string sql, newsid = "";
        NewsViewBLL newsView = new NewsViewBLL();
        for (int i = 0; i < rptData.Items.Count; i++)
        {
            if (((CheckBox)rptData.Items[i].FindControl("cb1")).Checked)
            {
                newsid += ((HiddenField)rptData.Items[i].FindControl("hidId")).Value + ",";
            }
        }
        int yon = newsView.DeleteInScope(newsid.TrimEnd(','));
        if (yon > 0)
        {
            self.alert("彻底删除资源（" + yon + "）条！");
            self.href("delnews_list.aspx?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
    }
    protected void lbSearch_Click(object sender, EventArgs e)
    {

    }
}