using ISS.CMS.BLL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_class_list : System.Web.UI.Page
{
    string content;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            td();
        }
    }

    #region 页面初始
    protected void dsbind()
    {
        string sqlwhere;        
        if (Request["parent"] != null && Request["parent"] != "")
        {
            sqlwhere = "parent=" + Request["parent"];
        }
        else
        {
            sqlwhere = "parent=-1";
        }

        PageView page = PageBLL.GetClassPageView(Request["page"], site.PageSize, sqlwhere);
        rptData.DataSource = page.DataContent;
        rptData.DataBind();
        lblPageIndex.Text = page.PageIndex.ToString();
        lblPageCount.Text = page.PageCount.ToString();
        PageNumberBind(page.PageIndex, page.PageCount);
        hidQuery.Value = sqlwhere;
        page = null;
    }
    protected void PageNumberBind(int parPageIndex, int parPageCount)
    {
        hlFirst.NavigateUrl = Request.Url.AbsolutePath + "page=1" + hidQuery.Value;
        hlPre.NavigateUrl = Request.Url.AbsolutePath + "page=" + (parPageIndex - 1) + hidQuery.Value;
        hlNext.NavigateUrl = Request.Url.AbsolutePath + "page=" + (parPageIndex + 1) + hidQuery.Value;
        hlLast.NavigateUrl = Request.Url.AbsolutePath + "page=" + parPageCount + hidQuery.Value;
        if (parPageCount <= 1)
        {
            hlFirst.Visible = false;
            hlPre.Visible = false;
            hlNext.Visible = false;
            hlLast.Visible = false;
        }
        else if (parPageIndex == 1)
        {
            hlFirst.Visible = false;
            hlPre.Visible = false;
            hlNext.Visible = true;
            hlLast.Visible = true;
        }
        else if (parPageIndex == parPageCount)
        {
            hlFirst.Visible = true;
            hlPre.Visible = true;
            hlNext.Visible = false;
            hlLast.Visible = false;
        }
        else
        {
            hlFirst.Visible = true;
            hlPre.Visible = true;
            hlNext.Visible = true;
            hlLast.Visible = true;
        }
    }
    #endregion

    #region 横向导航数据递规
    protected void node(int id)
    {
        DataTable dt; ;
        dt = ClassBLL.GetClassById(id.ToString()).Tables[0];
        content = " ＞ <a href='class_list.aspx?parent=" + dt.Rows[0]["id"].ToString() + "'>" + dt.Rows[0]["title"].ToString() + "</a>" + content;
        if (dt.Rows[0]["parent"].ToString() != "-1")
        {
            node(Convert.ToInt32(dt.Rows[0]["parent"]));
        }
    }
    #endregion

    #region 横向导航数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "-1" && Request["parent"] != "")
        {
            node(Convert.ToInt32(Request["parent"]));
        }
        TD1.InnerHtml = "<a href='class_list.aspx'>根类别</a>" + content + " 的子分类列表";
    }
    #endregion

    protected void lbGoPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("DynamicInsert_mdy.aspx?page=" + Request["page"] + hidQuery.Value);
    }
}