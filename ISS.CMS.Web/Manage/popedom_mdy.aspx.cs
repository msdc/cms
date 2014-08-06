using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_popedom_mdy : System.Web.UI.Page
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
        if (Request.QueryString["id"] != null)
        {
            int pageyon;
            DataTable dt = MenuBLL.GetMenuById(Request.QueryString["id"]).Tables[0];
            pagename_tb.Text = dt.Rows[0]["pagename"].ToString();
            pagepath_tb.Text = dt.Rows[0]["pagefiledir"].ToString();
            pagetitle_tb.Text = dt.Rows[0]["pagetitle"].ToString();
            S1.SelectedIndex = Convert.ToInt32(dt.Rows[0]["haspage"]);
            des_tb.Text = dt.Rows[0]["description"].ToString();
            pageyon = Convert.ToInt32(dt.Rows[0]["haspage"]);
            subpage_tb.Text = dt.Rows[0]["subpagetitle"].ToString();
            state_lbl.Text = "修改权限";
        }
        else
        {
            state_lbl.Text = "添加权限";
            lbDel.Visible = false;
        }
    }
    #endregion
    #region 详细位子数据递规
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
    #region 详细位子数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "")
        {
            node(Convert.ToInt32(Request.QueryString["parent"]));
        }
        TD1.InnerHtml = "<a href='popedom_list.aspx'>根类别</a>" + content + " 的子分类";
    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strParentId;
        if (Request["parent"] != null && Request["parent"] != "")
        {
            strParentId = Request["parent"];
        }
        else
        {
            strParentId = "-1";
        }
        
        int yon = MenuBLL.EditMenu(pagename_tb.Text, pagepath_tb.Text, pagetitle_tb.Text, subpage_tb.Text, strParentId, S1.SelectedIndex.ToString(), des_tb.Text, Request["id"], S1.SelectedIndex == 1);
        if (yon > 0)
        {
            self.alert("执行成功！");
            self.href("popedom_list.aspx?parent=" + strParentId);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int yon = MenuBLL.DeleteMenu(Request["id"]);
        if (yon > 0)
        {
            Response.Redirect("popedom_list.aspx?parent=" + Request["parent"]);
        }
    }
}