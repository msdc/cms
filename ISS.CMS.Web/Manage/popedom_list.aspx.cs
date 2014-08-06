using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_popedom_list : System.Web.UI.Page
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
        content = null;
        rptInfo.DataSource = MenuBLL.GetMenuByParentId(Request["parent"]);
        rptInfo.DataBind();
    }
    #endregion
    #region 横向导航数据递规
    protected void node(int parent)
    {
        DataTable ds;
        if (parent != -1)
        {
            ds = MenuBLL.GetMenuById(parent.ToString()).Tables[0];
            content = " ＞ <a href='popedom_list.aspx?parent=" + ds.Rows[0]["id"].ToString() + "'>" + ds.Rows[0]["pagename"].ToString() + "</a>" + content;
            if (ds.Rows[0]["parent"].ToString() != "-1")
            {
                node(Convert.ToInt32(ds.Rows[0]["parent"]));
            }
        }
    }
    #endregion
    #region 横向导航数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "")
        {
            node(Convert.ToInt32(Request.QueryString["parent"]));
        }
        TD1.InnerHtml = "<a href='popedom_list.aspx'>根类别</a>" + content + " 的子分类列表";
    }
    #endregion
}