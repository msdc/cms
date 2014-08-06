using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
///site 的摘要说明
/// </summary>
public class site
{
    private static XmlDocument xmldoc;
    public site()
    {
        xmldoc = new XmlDocument();
        xmldoc.Load(System.Web.HttpContext.Current.Server.MapPath("~/siteset/setting.xml"));
    }

    private static void init()
    {
        xmldoc = new XmlDocument();
        xmldoc.Load(System.Web.HttpContext.Current.Server.MapPath("~/siteset/setting.xml"));
    }
    public static void upxml(string FileExtension, string DubleOnlineUser, string PageSize, string ShowFolderError, string SiteTitle, string SysTitle, string SoftCopyright, string IsAutoRemberLoginName, string AutoRemberLoginName, string ShowNewsContorlPlane, string ReCheckAfterModify, string ConfirmWhenExitNewsSystem, string UseLoginPolliceMan, string EnableLoginWrong, string LoginWrongLockTimeRange, string DirectoryRoot, string EnableFileExt, string ConnStr)
    {
        init();
        XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("FileExtension");
        xn.InnerText = FileExtension;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("DubleOnlineUser");
        xn.InnerText = DubleOnlineUser;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("PageSize");
        xn.InnerText = PageSize;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("ShowFolderError");
        xn.InnerText = ShowFolderError;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SiteTitle");
        xn.InnerText = SiteTitle;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SysTitle");
        xn.InnerText = SysTitle;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SoftCopyright");
        xn.InnerText = SoftCopyright;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("IsAutoRemberLoginName");
        xn.InnerText = IsAutoRemberLoginName;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("AutoRemberLoginName");
        xn.InnerText = AutoRemberLoginName;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ShowNewsContorlPlane");
        xn.InnerText = ShowNewsContorlPlane;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ReCheckAfterModify");
        xn.InnerText = ReCheckAfterModify;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ConfirmWhenExitNewsSystem");
        xn.InnerText = ConfirmWhenExitNewsSystem;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("UseLoginPolliceMan");
        xn.InnerText = UseLoginPolliceMan;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("EnableLoginWrong");
        xn.InnerText = EnableLoginWrong;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("LoginWrongLockTimeRange");
        xn.InnerText = LoginWrongLockTimeRange;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("dir").SelectSingleNode("DirectoryRoot");
        xn.InnerText = DirectoryRoot;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("dir").SelectSingleNode("EnableFileExt");
        xn.InnerText = EnableFileExt;

        xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("data").SelectSingleNode("ConnStr");
        xn.InnerText = ConnStr;
        xmldoc.Save(System.Web.HttpContext.Current.Server.MapPath("~/siteset/setting.xml"));
    }
    public static string FileExtension
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("FileExtension");
            return xn.InnerText;
        }
    }
    public static string DubleOnlineUser
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("DubleOnlineUser");
            return xn.InnerText;
        }
    }
    public static int PageSize
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("PageSize");
            return int.Parse(xn.InnerText);
        }
    }
    public static string ShowFolderError
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("ShowFolderError");
            return xn.InnerText;
        }
    }
    public static string NewsKeyWordListNum
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("imp").SelectSingleNode("NewsKeyWordListNum");
            return xn.InnerText;
        }
    }
    public static string SiteTitle
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SiteTitle");
            return xn.InnerText;
        }
    }
    public static string SysTitle
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SysTitle");
            return xn.InnerText;
        }
    }
    public static string SoftCopyright
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("SoftCopyright");
            return xn.InnerText;
        }
    }
    public static string IsAutoRemberLoginName
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("IsAutoRemberLoginName");
            return xn.InnerText;
        }
    }
    public static string AutoRemberLoginName
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("AutoRemberLoginName");
            return xn.InnerText;
        }
    }
    public static string ShowNewsContorlPlane
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ShowNewsContorlPlane");
            return xn.InnerText;
        }
    }
    public static string ReCheckAfterModify
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ReCheckAfterModify");
            return xn.InnerText;
        }
    }
    public static string ConfirmWhenExitNewsSystem
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("ConfirmWhenExitNewsSystem");
            return xn.InnerText;
        }
    }
    public static string UseLoginPolliceMan
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("UseLoginPolliceMan");
            return xn.InnerText;
        }
    }
    public static string EnableLoginWrong
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("EnableLoginWrong");
            return xn.InnerText;
        }
    }
    public static string LoginWrongLockTimeRange
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("other").SelectSingleNode("LoginWrongLockTimeRange");
            return xn.InnerText;
        }
    }
    public static string DirectoryRoot
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("dir").SelectSingleNode("DirectoryRoot");
            return xn.InnerText;
        }
    }
    public static string EnableFileExt
    {
        get
        {
            XmlNode xn = xmldoc.SelectSingleNode("configuration").SelectSingleNode("site").SelectSingleNode("dir").SelectSingleNode("DirectoryRoot");
            return xn.InnerText;
        }
    }
}