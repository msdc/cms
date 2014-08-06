using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_syschange : System.Web.UI.Page
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
        string id_str = null;
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected)
            {
                id_str += ListBox1.Items[i].Value + ",";
            }
        }
        if (Request["old"] != null)
        {
            Create.StaticCreate(id_str.TrimEnd(','));
        }
        else if (Request["new"] != null)
        {
            Create.DynamicCreate(id_str.TrimEnd(','));
        }
        self.alert("更新成功！");
    }
    #region 页面初始
    protected void dsbind()
    {
        string sql = "";
        if (Request.QueryString["old"] != null)
        {
            if (validate.cookiestr == "admin")
            {
                ListBox1.DataSource = StaticInsertBLL.GetStaticInsertList().Tables[0];
            }
            else
            {
                ListBox1.DataSource = StaticInsertBLL.GetStaticInsertList().Tables[0];
            }
        }
        else if (Request.QueryString["new"] != null)
        {
            if (validate.cookiestr == "admin")
            {
                ListBox1.DataSource = DynamicInsertBLL.GetDynamicInsertList().Tables[0];
            }
            else
            {
                ListBox1.DataSource = DynamicInsertBLL.GetDynamicInsertList().Tables[0];
            }
        }
        //ListBox1.DataSource = DbHelperSQL.Query(sql).Tables[0];
        ListBox1.DataTextField = "title";
        ListBox1.DataValueField = "id";
        ListBox1.DataBind();
    }
    #endregion
}