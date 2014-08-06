using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Manage_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            nav();
        }
    }
    #region 页面初始
    private void dsbind()
    {
        rptFolder.DataSource = getFolders();
        rptFolder.DataBind();
        rptFile.DataSource = getFiles();
        rptFile.DataBind();
    }
    #endregion
    #region 返回目录所有子文件夹
    private DataTable getFolders()
    {
        string strDirPath;
        string strSysDirPath = site.DirectoryRoot;
        DataTable dtFolder = new DataTable();
        dtFolder.Columns.Add(new DataColumn("FolderName"));
        dtFolder.Columns.Add(new DataColumn("FolderSize"));
        dtFolder.Columns.Add(new DataColumn("FolderCreateTime"));
        dtFolder.Columns.Add(new DataColumn("FolderPath"));
        if (Request["path"] != null && Request["path"] != "")
        {
            strDirPath = Server.MapPath(strSysDirPath + Server.UrlDecode(Request["path"]));
        }
        else
        {
            strDirPath = Server.MapPath(strSysDirPath);
        }

        DirectoryInfo diFolder = new DirectoryInfo(strDirPath);
        DirectoryInfo[] ArrDiFolder = diFolder.GetDirectories();
        for (int i = 0; i < ArrDiFolder.Length; i++)
        {
            DataRow dr = dtFolder.NewRow();
            string strFullName = ArrDiFolder[i].FullName;
            string strFullSysDir = Server.MapPath(strSysDirPath);
            dr["FolderName"] = strFullName.Substring(strFullName.LastIndexOf('\\') + 1);
            dr["FolderSize"] = getFolderSize(strFullName) / 1024;
            dr["FolderCreateTime"] = getFolderCreatTime(strFullName);
            dr["FolderPath"] = Server.UrlEncode(strFullName.Replace(strFullSysDir, "").Replace('\\', '/'));
            dtFolder.Rows.Add(dr);
        }
        return dtFolder;
    }
    #endregion
    #region 返回目录所有文件
    private DataTable getFiles()
    {
        DataTable dtFile = new DataTable();
        string strDirPath;
        string strSysDirPath = site.DirectoryRoot;
        dtFile = new DataTable();
        dtFile.Columns.Add(new DataColumn("FileName"));
        dtFile.Columns.Add(new DataColumn("FileSize"));
        dtFile.Columns.Add(new DataColumn("FileCreateTime"));
        dtFile.Columns.Add(new DataColumn("FilePath"));

        if (Request["path"] != null && Request["path"] != "")
        {
            strDirPath = Server.MapPath(strSysDirPath + Server.UrlDecode(Request["path"]));
        }
        else
        {
            strDirPath = Server.MapPath(strSysDirPath);
        }

        DirectoryInfo diFile = new DirectoryInfo(strDirPath);
        FileInfo[] arrFiFile = diFile.GetFiles();
        for (int i = 0; i < arrFiFile.Length; i++)
        {
            DataRow dr = dtFile.NewRow();
            string strFullName = arrFiFile[i].FullName;
            dr["FileName"] = strFullName.Substring(strFullName.LastIndexOf('\\') + 1);
            dr["FileSize"] = arrFiFile[i].Length / 1024;
            dr["FileCreateTime"] = arrFiFile[i].CreationTime.ToShortDateString();
            dr["FilePath"] = strSysDirPath.TrimStart('~') + strFullName.Replace(Server.MapPath(strSysDirPath), "").Replace("\\", "/");
            dtFile.Rows.Add(dr);
        }
        return dtFile;
    }
    #endregion
    #region 返回文件夹大小
    long FolderSize = 0;
    private long getFolderSize(string FolderPath)
    {
        long tmpSize = 0;
        DirectoryInfo dirinfo = new DirectoryInfo(FolderPath);
        FileInfo[] fi = dirinfo.GetFiles();
        for (int i = 0; i < fi.Length; i++)
        {
            tmpSize += fi[i].Length;
        }
        DirectoryInfo[] di = dirinfo.GetDirectories();
        for (int k = 0; k < di.Length; k++)
        {
            FolderSize += getFolderSize(di[k].FullName);
        }
        return tmpSize;
    }
    #endregion
    #region 返回文件夹创建时间
    private string getFolderCreatTime(string FolderPath)
    {
        return Directory.GetCreationTime(FolderPath).ToShortDateString();
    }
    #endregion
    #region 导航
    private void nav()
    {
        if (Request["path"] != null)
        {
            string[] arrFolder = Request["path"].TrimStart('/').Split('/');
            string nav_str = "";
            nav_str = "<a href='view.aspx'>主目录</a>&nbsp;";
            for (int i = 0; i < arrFolder.Length && arrFolder[0] != ""; i++)
            {
                string tmp = "";
                for (int k = 0; k <= i; k++)
                {
                    tmp += "/" + arrFolder[k];
                }
                nav_str += ">&nbsp;<a href='view.aspx?path=" + Server.UrlEncode(tmp) + "'>" + arrFolder[i] + "</a>&nbsp;";
            }
            tdPathInfo.InnerHtml = nav_str;
        }
        else
        {
            tdPathInfo.InnerHtml = "<a href='view.aspx'>主目录</a>";
        }
    }
    #endregion
    protected void lbGoParent_Click(object sender, EventArgs e)
    {
        if (Request["path"] != null && Request["path"] != "")
        {
            if (Request["path"].Split('/').Length > 1)
            {
                string path = Request["path"];
                Response.Redirect("view.aspx?path=" + path.Remove(path.LastIndexOf('/')));
            }
        }
        else
        {
            Response.Redirect("view.aspx");
        }
    }
    protected void rptFolder_Command(object source, RepeaterCommandEventArgs e)
    {
        string path = null, folder = null;
        if (Request["path"] != null && Request["path"] != "")
        {
            path = Server.MapPath(site.DirectoryRoot + Server.UrlDecode(Request["path"]));
        }
        else
        {
            path = Server.MapPath(site.DirectoryRoot);
        }
        folder = Server.UrlDecode(e.CommandArgument.ToString());
        Directory.Delete(path + folder, true);
        Response.Redirect("view.aspx?path=" + Request["path"]);
    }
    protected void ibtnDel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            for (int i = 0; i < rptFile.Items.Count; i++)
            {
                if (((HtmlInputCheckBox)rptFile.Items[i].FindControl("file_cb")).Checked)
                {
                    string path = Server.MapPath(((HtmlInputCheckBox)rptFile.Items[i].FindControl("file_cb")).Value);
                    File.Delete(path);
                }
            }
            Response.Redirect("view.aspx?path=" + Request["path"]);
        }
        catch
        {
            self.alert("文件删除失败！");
        }
    }
    protected void lbCreateFolder_Click(object sender, EventArgs e)
    {
        string path = null, folder = null;
        if (Request["path"] != null && Request["path"] != "")
        {
            path = Server.MapPath(site.DirectoryRoot + Server.UrlDecode(Request["path"]));
        }
        else
        {
            path = Server.MapPath(site.DirectoryRoot);
        }
        folder = tbFolder.Text;
        Directory.CreateDirectory(path + "/" + folder);
        Response.Redirect("view.aspx?path=" + Request["path"]);
    }
    protected void lbUpFile_Click(object sender, EventArgs e)
    {
        string path = null;
        string FileName = fuFile.FileName;
        if (Request["path"] != null && Request["path"] != "")
        {
            path = Server.MapPath(site.DirectoryRoot + Server.UrlDecode(Request["path"]));
        }
        else
        {
            path = Server.MapPath(site.DirectoryRoot);
        }
        fuFile.SaveAs(path + "/" + FileName);
        Response.Redirect("view.aspx?path=" + Server.UrlEncode(Request["path"]));
    }
}