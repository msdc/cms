using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Template_mdy : System.Web.UI.Page
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
        if (Request["id"] != null)
        {
            DataTable dt;
            dt = TemplateBLL.GetTemplateById(Request["id"]).Tables[0];
            id_tb.Text = dt.Rows[0]["id"].ToString();
            title_tb.Text = dt.Rows[0]["title"].ToString();
            content_ce.Text = dt.Rows[0]["content"].ToString();
            state_lbl.Text = "修改模板";
        }
        else
        {
            state_lbl.Text = "添加模板";
            lbDel.Visible = false;
        }
    }
    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        int yon = TemplateBLL.TemplateEdit(title_tb.Text, content_ce.Text.Replace("'", "''"), Request["id"]);
        if (yon > 0)
        {
            Response.Redirect("Template_list.aspx?page=" + Request["page"]);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string sql;
        sql = "delete from tsys_template where id=" + Request["id"];
        int yon = TemplateBLL.DeleteTemplate(Request["id"]);
        if (yon > 0)
        {
            Response.Redirect("template_list.aspx?page=" + Request["page"]);
        }
        else
        {
            self.alert("模板被关联无法删除！");
        }
    }
}