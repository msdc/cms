using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Staticinsert_list : System.Web.UI.Page
{
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
        PageView pageView = ISS.CMS.BLL.PageBLL.GetStaticinsertPageView(Request["page"]);
        infoRpt.DataSource = pageView.DataContent;
        infoRpt.DataBind();
        lbl_pageindex.Text = pageView.PageIndex.ToString();
        lbl_pagecount.Text = pageView.PageCount.ToString();
        pageView = null;
    }
    #endregion

    protected void Button7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=" + page_tb.Value);
    }
    protected void dl1_RowCommand(object sender, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "编辑")
        {
            Response.Redirect("Staticinsert_list.aspx?id=" + e.CommandArgument.ToString() + "&page=" + Request["page"]);
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=1");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) - 1));
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) + 1));
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=" + lbl_pagecount.Text);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staticinsert_list.aspx?page=" + Request["page"]);
    }
}