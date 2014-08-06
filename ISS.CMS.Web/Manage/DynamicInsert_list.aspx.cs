using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ISS.CMS.Model;
using ISS.CMS.BLL;

public partial class manage_insertSYSnew_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            init();
            
        }
    }
    #region 页面初始
    protected void init()
    {
        string strSqlWhere = "";
        DataSet ds = DynamicInsertBLL.GetList(strSqlWhere);
        //rptData.DataSource = ds.Tables[0];
        //rptData.DataBind();

        int pageindex;
        try
        {
            pageindex = int.Parse(Request["page"]);
        }
        catch
        {
            pageindex = 0;
        }
        PagedDataSource pds = PageBLL.GetPageDataSoureView(ds.Tables[0], 2, pageindex);
        rptData.DataSource = pds;
        rptData.DataBind();

        //lbl_datacount.Text = "资源数：" + pds.Count.ToString() + "条";
        //lbl_pagecount.Text = "总共：" + pds.PageCount.ToString() + "页";
        //lbl_pageindex.Text = "当前页面：" + (pds.CurrentPageIndex + 1).ToString() + "/" + pds.PageCount.ToString();
        //hidPageindex.Value = pds.CurrentPageIndex.ToString();
        //pagecount = pds.PageCount;
        lblPageIndex.Text = (pds.CurrentPageIndex + 1).ToString();
        lblPageCount.Text = pds.PageCount.ToString();
        PageNumberBind(pds.CurrentPageIndex, pds.PageCount-1);
       

    }
    protected void PageNumberBind(int parPageIndex, int parPageCount)
    {
        hlFirst.NavigateUrl = Request.Url.AbsolutePath + "?page=0" + hidQuery.Value;
        hlPre.NavigateUrl = Request.Url.AbsolutePath + "?page=" + (parPageIndex - 1) + hidQuery.Value;
        hlNext.NavigateUrl = Request.Url.AbsolutePath + "?page=" + (parPageIndex + 1) + hidQuery.Value;
        hlLast.NavigateUrl = Request.Url.AbsolutePath + "?page=" + parPageCount + hidQuery.Value;
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
    protected void lbGoPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("DynamicInsert_mdy.aspx?page=" + Request["page"] + hidQuery.Value);
    }
}
