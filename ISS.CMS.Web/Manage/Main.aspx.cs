using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ISS.CMS.BLL;

public partial class Manage_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.loginYon();
            dsbind();
        }
    }

    #region 页面初始
    private void dsbind()
    {
        DataTable dt;
        //string sql;
        //sql = "select * from tsys_user where name='" + validate.cookiestr + "'";
        dt = UserBLL.GetUserByName(validate.cookiestr).Tables[0];//DbHelperSQL.Query(sql).Tables[0];
        title_lbl.Text = dt.Rows[0]["name"].ToString();
        nickname_lbl.Text = dt.Rows[0]["nickname"].ToString();
        rtitle_lbl.Text = dt.Rows[0]["name"].ToString();
        addtime_lbl.Text = Convert.ToDateTime(dt.Rows[0]["addtime"].ToString()).ToString();
        lasttime_lbl.Text = Convert.ToDateTime(dt.Rows[0]["lastlogtime"]).ToString();
        count_lbl.Text = dt.Rows[0]["logcount"].ToString();

    }
    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        validate.cookiestr = null;
        self.open("login.aspx");
    }
}