using ISS.CMS.BLL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_Staticinsert_mdy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StaticInsert staticInsert = new StaticInsert();
        staticInsert.Title = tbTitle.Text;
        staticInsert.StartElement = tbStartelement.Text;
        staticInsert.EndElement = tbEndelement.Text;
        staticInsert.Content = tbContent.Text.Replace("'", "''");
        staticInsert.Encoding = ddlEncoding.SelectedValue;
        staticInsert.FileList = tbFileList.Text;
        if (Request["id"] != null)
        {
            staticInsert.Id = int.Parse(Request["id"]);            
        }

        bool yon = StaticInsertBLL.EditStaticInsert(staticInsert, Request["id"]);
        if (yon)
        {
            Response.Redirect("staticinsert_list.aspx"); ;
        }
    }
    #region 页面初始
    protected void dsbind()
    {
        if (Request.QueryString["id"] != null)
        {
            DataTable dt;
            dt = StaticInsertBLL.GetStaticInsert(int.Parse(Request.QueryString["id"])).Tables[0];
            tbTitle.Text = dt.Rows[0]["title"].ToString();
            tbStartelement.Text = dt.Rows[0]["startelement"].ToString();
            tbEndelement.Text = dt.Rows[0]["endelement"].ToString();
            tbContent.Text = dt.Rows[0]["content"].ToString();
            tbFileList.Text = dt.Rows[0]["filelist"].ToString();
            state_lbl.Text = "修改页面静态模板";
        }
        else
        {
            state_lbl.Text = "修改页面静态模板";
            lbDel.Visible = false;
        }
    }
    #endregion
    protected void Button2_Click(object sender, EventArgs e)
    {
        bool yon = StaticInsertBLL.Delete(int.Parse(Request["id"]));
        if (yon)
        {
            Response.Redirect("staticinsert_list.aspx");
        }
    }
}