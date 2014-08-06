using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_sys_config : System.Web.UI.Page
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
        site.upxml(FileExtension_tb.Text, DubleOnlineUser_rbl.SelectedValue, Sys_PageSize_tb.Value, ShowFolderError_rbl.SelectedValue, SiteTitle_tb.Text, SysTitle_tb.Text, SoftCopyright_tb.Text, IsAutoRemberLoginName_rbl.SelectedValue, AutoRemberLoginName_tb.Value, ShowNewsContorlPlane_rbl.SelectedValue, ReCheckAfterModify_rbl.SelectedValue, ConfirmWhenExitNewsSystem_rbl.SelectedValue, UseLoginPolliceMan_rbl.SelectedValue, EnableLoginWrong_Number_tb.Value, LoginWrongLockTimeRange_tb.Value, DirectoryRoot_tb.Text, EnableFileExt_tb.Text, ConnStr_tb.Text);
    }

    #region 页面初始
    protected void dsbind()
    {
        FileExtension_tb.Text = site.FileExtension;
        DubleOnlineUser_rbl.SelectedValue = site.DubleOnlineUser;
        Sys_PageSize_tb.Value = site.PageSize.ToString();
        ShowFolderError_rbl.SelectedValue = site.ShowFolderError;
        SiteTitle_tb.Text = site.SiteTitle;
        SysTitle_tb.Text = site.SysTitle;
        SoftCopyright_tb.Text = site.SoftCopyright;
        IsAutoRemberLoginName_rbl.SelectedValue = site.IsAutoRemberLoginName;
        AutoRemberLoginName_tb.Value = site.AutoRemberLoginName;
        ShowNewsContorlPlane_rbl.SelectedValue = site.ShowNewsContorlPlane;
        ReCheckAfterModify_rbl.SelectedValue = site.ReCheckAfterModify;
        ConfirmWhenExitNewsSystem_rbl.SelectedValue = site.ConfirmWhenExitNewsSystem;
        UseLoginPolliceMan_rbl.SelectedValue = site.UseLoginPolliceMan;
        EnableLoginWrong_Number_tb.Value = site.EnableLoginWrong;
        LoginWrongLockTimeRange_tb.Value = site.LoginWrongLockTimeRange;
        DirectoryRoot_tb.Text = site.DirectoryRoot;
        EnableFileExt_tb.Text = site.EnableFileExt;
    }
    #endregion
}