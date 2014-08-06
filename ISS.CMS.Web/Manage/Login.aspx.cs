using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ISS.CMS.BLL;

public partial class Manage_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
            Session["user"] = null;
        }
        name_tb.Attributes.Add("onkeydown", "usernameSub()");
        pwd_tb.Attributes.Add("onkeydown", "passwordSub()");
    }

    protected void lbLogin_Click(object sender, EventArgs e)
    {
        string tmpstr = UserBLL.Login(SiteFun.cutechar(name_tb.Text), pwd_tb.Text);//validate.loginsql(Request.UserHostAddress, SiteFun.cutechar(name_tb.Text), pwd_tb.Text, 15); //by han
        if (tmpstr == "登陆成功")
        {
            site siteconfig = new site();
            HttpCookie ck = new HttpCookie("admin");
            ck.Value = name_tb.Text;
            ck.Expires = System.DateTime.Now + new TimeSpan(Convert.ToInt32(site.AutoRemberLoginName), 0, 0, 0);
            Session["user"] = SiteFun.cutechar(name_tb.Text);
            syslog.login("登陆成功");
            Response.Redirect("Default.aspx");
        }
        else if (tmpstr == "非法登陆")
        {
            syslog.login("登陆失败");
            self.alert("<系统信息>\\n登陆失败，你的IP由于登陆错误次数过多，已被禁止。请与管理员联系");
        }
        else if (tmpstr == "帐户密码错误")
        {
            syslog.login("登陆失败");
            self.alert("登陆失败，你的帐户密码有误，请重新输入。");
        }
        else if (tmpstr == "帐户被锁定")
        {
            syslog.login("登陆失败");
            self.alert("你的帐户已被锁定，请与管理员联系再登陆。");
        }
        else
        {
            syslog.login("登陆失败");
            self.alert("意外错误。" + tmpstr + "@@@");
        }
        self.href("Login.aspx");
    }
}