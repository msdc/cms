using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///self 的摘要说明
/// </summary>
public class self
{
    public self()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 弹出信息
    /// </summary>
    /// <param name="str"></param>
    public static void alert(string str)
    {
        System.Web.HttpContext.Current.Response.Write("<script>alert('" + str.Replace("\"", "").Replace("\'", "") + "')</script>");
    }
    /// <summary>
    /// 弹出信息后停止改页的执行
    /// </summary>
    /// <param name="str"></param>
    public static void alertend(string str)
    {
        System.Web.HttpContext.Current.Response.Write("<script>alert('" + str.Replace("\"", "").Replace("\'", "") + "')</script>");
        System.Web.HttpContext.Current.Response.End();
    }
    /// <summary>
    /// _top
    /// </summary>
    /// <param name="str"></param>
    public static void open(string str)
    {
        System.Web.HttpContext.Current.Response.Write("<script>window.open('" + str + "','_top')</script>");
        System.Web.HttpContext.Current.Response.End();
    }

    /// <summary>
    /// 框架跳转
    /// </summary>
    /// <param name="str"></param>
    public static void href(string str)
    {
        System.Web.HttpContext.Current.Response.Write("<script>location.href = '" + str + "'</script>");
        System.Web.HttpContext.Current.Response.End();
    }

    /// <summary>
    /// newwindow
    /// </summary>
    /// <param name="str"></param>
    public static void openwin(string str)
    {
        System.Web.HttpContext.Current.Response.Write("<script>window.open('" + str + "','window')</script>");
        System.Web.HttpContext.Current.Response.End();
    }

    public static int GetStrByteCount(string varStr)
    {
        int numRtn = 0;
        if (varStr != "")
        {
            numRtn = System.Text.Encoding.Default.GetByteCount(varStr);
        }
        return numRtn;
    }
}