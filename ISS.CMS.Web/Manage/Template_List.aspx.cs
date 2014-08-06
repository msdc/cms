using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Template_List : System.Web.UI.Page
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
        PageView page = ISS.CMS.BLL.PageBLL.GetTemplatePageView(Request["page"]);

        rptInfo.DataSource = page.DataContent;
        rptInfo.DataBind();
        lbl_pageindex.Text = page.PageIndex.ToString();
        lbl_pagecount.Text = page.PageCount.ToString();
        page = null;
    }
    #endregion
    protected void lblAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx");
    }
    protected void lbFirst_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx?page=1");
    }
    protected void lbPre_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) - 1));
    }
    protected void lbNext_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) + 1));
    }
    protected void lbLast_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx?page=" + lbl_pagecount.Text);
    }
    protected void lbTo_Click(object sender, EventArgs e)
    {
        Response.Redirect("template_list.aspx?page=" + page_tb.Value);
    }
}