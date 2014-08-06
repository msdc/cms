using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ISS.CMS.Model;
using ISS.CMS.BLL;
public partial class Manage_speciality_list : System.Web.UI.Page
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
        string sqlwhere = "";
        if (Request["parent"] != null && Request["parent"] != "")
        {
            sqlwhere = "parent=" + Request["parent"];
        }
        else
        {
            sqlwhere = "parent=-1";
        }
        PageView page = ISS.CMS.BLL.PageBLL.GetSpecialityPageView(Request["page"], sqlwhere);
        this.rptSpec.DataSource = page.DataContent;
        this.rptSpec.DataBind();
        lbl_pageindex.Text = page.PageCount.ToString();
        lbl_pagecount.Text = page.PageCount.ToString();
        page = null;
        hidQuerystr.Value = sqlwhere;
    }
    #endregion
    #region 详细位子递规
    protected void node(int id)
    {
        //SpecialityBll speciality = new SpecialityBll();
        Speciality model = SpecialityBll.GetModel(id);
        content = " ＞ <a href='Speciality_list.aspx?parent=" + model.Id.ToString() + "'>" + model.Title + "</a>" + content;
        if (model.Parent.ToString() != "-1")
        {
            node(Convert.ToInt32(model.Parent));
        }
    }
    #endregion
    #region 详细位子数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "")
        {
            if (Request["parent"] != "-1")
                node(Convert.ToInt32(Request["parent"]));
        }
        TD1.InnerHtml = "<a href='Speciality_list.aspx'>根类别</a>" + content + " 的子分类列表";
    }
    #endregion



    protected void lbFirst_Click(object sender, EventArgs e)
    {
        Response.Redirect("Speciality_list.aspx?page=1&" + hidQuerystr.Value);
    }
    protected void lbPre_Click(object sender, EventArgs e)
    {
        Response.Redirect("Speciality_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) - 1) + "&" + hidQuerystr.Value);
    }
    protected void lbNext_Click(object sender, EventArgs e)
    {
        Response.Redirect("Speciality_list.aspx?page=" + (int.Parse(lbl_pageindex.Text) + 1) + "&" + hidQuerystr.Value);
    }
    protected void lbLast_Click(object sender, EventArgs e)
    {
        Response.Redirect("Speciality_list.aspx?page=" + lbl_pagecount.Text + "&" + hidQuerystr.Value);
    }
    protected void lbTo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Speciality_list.aspx?page=" + page_tb.Value + "&" + hidQuerystr.Value);
    }
}