using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///validate 的摘要说明
/// </summary>
public class validate
{
    string name, password;
    public validate()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public validate(string name, string password)
    {
        this.name = name;
        this.password = password;
    }

    /// <summary>
    /// 判断是否登陆
    /// </summary>
    public static void loginYon()
    {
        if (cookiestr == null)
        {
            HttpContext.Current.Response.Write("<script language=\"javascript\">");
            HttpContext.Current.Response.Write("window.open('" +
                (HttpContext.Current.Request.ApplicationPath == "/" ? "" : HttpContext.Current.Request.ApplicationPath) +
                "/Manage/Login.aspx','_top')");
            HttpContext.Current.Response.Write("</script>");
            HttpContext.Current.Response.End();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static bool myself(int id)
    {
        if (UserBLL.GetUserCountByIdAndName(id.ToString(), cookiestr) > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// 权限验证
    /// </summary>
    public static void init()
    {
        if (cookiestr != null)
        {
            string filename = HttpContext.Current.Request.RawUrl;
            if (UserBLL.CheckPermission(cookiestr, filename))
            {
                self.alert("没有此权限！");
                HttpContext.Current.Response.Redirect("~/Manage/Login.aspx");
            }
        }
        else
        {
            HttpContext.Current.Response.Redirect("~/Manage/Login.aspx");
        }
    }

    /// <summary>
    /// 获取，设置COOKIE值
    /// </summary>
    public static string cookiestr
    {
        get
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                return HttpContext.Current.Session["user"].ToString();
            }
            else
            {
                return null;
            }
        }
        set
        {
            HttpContext.Current.Session["user"] = value;
        }
    }


    public static string classid()
    {
        //string sql, classid = "0";
        //if (cookiestr == "admin")
        //{
        //    sql = "select id from [tsys_class]";
        //    DataTable dt = .Query(sql).Tables[0];
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        classid += dt.Rows[i]["id"] + ",";
        //    }
        //    return classid.TrimEnd(',');
        //}
        //else
        //{
        //    sql = "select classid from userinfo where name = '" + cookiestr + "'";
        //    return DbHelperSQL.GetSingle(sql).ToString();
        //}
        return "";
    }
}