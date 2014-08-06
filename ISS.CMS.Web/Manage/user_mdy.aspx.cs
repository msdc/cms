using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_user_mdy : System.Web.UI.Page
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
        role_ddl.DataSource = UserBLL.GetRole();
        role_ddl.DataTextField = "name";
        role_ddl.DataValueField = "id";
        role_ddl.DataBind();
        if (Request["id"] != null)
        {
            DataTable dt;
            name_tb.Enabled = false;
            password_tr.Visible = false;
            password_tr1.Visible = false;
            dt = UserBLL.GetUserById(Request["id"]).Tables[0];
            id_tb.Text = dt.Rows[0]["id"].ToString();
            name_tb.Text = dt.Rows[0]["name"].ToString();
            nickname_tb.Text = dt.Rows[0]["nickname"].ToString();
            role_ddl.SelectedValue = dt.Rows[0]["roleid"].ToString();
            lock_rbl.SelectedValue = Convert.ToInt32(dt.Rows[0]["islock"]).ToString();
            if (validate.myself(int.Parse(Request["id"])))
            {
                role_ddl.Enabled = false;
                lock_rbl.Enabled = false;
            }
            state_lbl.Text = "修改账户";
        }
        else
        {
            state_lbl.Text = "添加账户";
            id_tr.Visible = false;
            lbDel.Visible = false;
            lbPwdMdy.Visible = false;
        }
    }
    #endregion
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        int yon = UserBLL.EditUser(name_tb.Text, pwd_tb.Text, nickname_tb.Text, role_ddl.SelectedValue, lock_rbl.SelectedValue, Request["id"]);
        if (yon > 0)
        {
            self.alert("执行成功！");
            self.href("user_list.aspx");
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (UserBLL.DeleteUserById(Request["id"]) > 0)
        {
            self.alert("帐户已经删除！");
            if (Request["page"] != null)
            {
                self.href("user_list.aspx?page=" + Request["page"]);
            }
            else
            {
                self.href("user_list.aspx");
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("pwd_mdy.aspx?id=" + Request["id"]);
    }
}