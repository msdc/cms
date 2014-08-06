<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sys_config.aspx.cs" Inherits="Manage_sys_config" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%">
        <tr> 
      <td align="center" class="BarTitleBg">系统参数设置（请慎用）</td>
    </tr>
            <tr>
                <td>
                    <table style="width: 100%; border-right: gainsboro 1px solid; border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid; border-collapse: collapse;" cellpadding="0" cellspacing="0" border="1">
                        <tr>
                            <td class="BarTitleBg" colspan="2">
                                主要配置信息</td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                文件创建将使用的扩展名:<br />
                                如：“.htm”</td>
                            <td>
                                <asp:TextBox ID="FileExtension_tb" runat="server" CssClass="Input" Width="201px"></asp:TextBox></td>
                        </tr>
                        <tr style="display:none">
                            <td>
                                一个管理员帐户是否允许同时多个不同IP使用:
                            </td>
                            <td>
                                <asp:RadioButtonList ID="DubleOnlineUser_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td>
                                后台资源列表的每页显示数目:</td>
                            <td>
                                <input id="Sys_PageSize_tb" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;" runat="server" class="Input" style="width: 38px" type="text" /></td>
                        </tr>
                        <tr style="display:none">
                            <td>
                                生成资源中当路径不存在时是否提示:</td>
                            <td>
                                <asp:RadioButtonList ID="ShowFolderError_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" style="width: 100%; border-right: gainsboro 1px solid; border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid; border-collapse: collapse;" border="1">
                        <tr>
                            <td class="BarTitleBg" colspan="2">
                                其他配置信息</td>
                        </tr>
                        <tr>
                            <td>
                                站点名称:</td>
                            <td>
                                <asp:TextBox ID="SiteTitle_tb" runat="server" CssClass="Input" Width="201px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                系统标题:</td>
                            <td>
                                <asp:TextBox ID="SysTitle_tb" runat="server" CssClass="Input" Width="201px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                版权信息:</td>
                            <td>
                                <asp:TextBox ID="SoftCopyright_tb" runat="server" CssClass="Input" Width="201px"></asp:TextBox></td>
                        </tr>
                        <tr style="display:none">
                            <td style="width: 50%">
                                是否为下次登录自动记录管理员帐户:</td>
                            <td>
                                <asp:RadioButtonList ID="IsAutoRemberLoginName_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr style="display:none">
                            <td style="width: 50%">
                                自动记录管理员帐户名Cookie的超时时间（天）:</td>
                            <td>
                                <input id="AutoRemberLoginName_tb" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;" runat="server" class="Input" style="width: 38px" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                默认资源操作面板是否展开:</td>
                            <td>
                                <asp:RadioButtonList ID="ShowNewsContorlPlane_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                资源是否需审核:</td>
                            <td>
                                <asp:RadioButtonList ID="ReCheckAfterModify_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr style="display:none">
                            <td style="width: 50%">
                                退出Tsys信息发布系统时是否提示:</td>
                            <td>
                                <asp:RadioButtonList ID="ConfirmWhenExitNewsSystem_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr style="display:none">
                            <td style="width: 50%">
                                是否启用管理员登录安全登记:</td>
                            <td>
                                <asp:RadioButtonList ID="UseLoginPolliceMan_rbl" runat="server" RepeatColumns="2">
                                    <asp:ListItem Value="0">开启</asp:ListItem>
                                    <asp:ListItem Value="1">关闭</asp:ListItem>
                                </asp:RadioButtonList></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                允许登录错误的次数 :</td>
                            <td>
                                <input id="EnableLoginWrong_Number_tb" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;" runat="server" class="Input" style="width: 38px" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                被封时间（秒）:</td>
                            <td>
                                <input id="LoginWrongLockTimeRange_tb" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;" runat="server" class="Input" style="width: 38px" type="text" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table cellpadding="0" cellspacing="0" style="width: 100%; border-right: gainsboro 1px solid; border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid; border-collapse: collapse;" border="1">
                        <tr>
                            <td class="BarTitleBg" colspan="2">
                                文件系统配制</td>
                        </tr>
                        <tr>
                            <td style="width: 50%">
                                虚拟文件目录:<br />
                                结尾请不要加“/”
                            </td>
                            <td>
                                <asp:TextBox ID="DirectoryRoot_tb" runat="server" CssClass="Input" Width="201px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                允许上传的文件类型:</td>
                            <td>
                                <asp:TextBox ID="EnableFileExt_tb" runat="server" CssClass="Input" Width="282px"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <table style="width: 100%; border-right: gainsboro 1px solid; border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid; border-collapse: collapse;" border="1" cellpadding="0" cellspacing="0">
                        <tr>
                            <td class="BarTitleBg" colspan="2" align="left">
                                数据库配制</td>
                        </tr>
                        <tr>
                            <td style="width: 50%" align="left">
                                数据库链接:</td>
                            <td align="left">
                                <asp:TextBox ID="ConnStr_tb" runat="server" CssClass="Input" Width="282px"></asp:TextBox></td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" CssClass="button01-out" Text="确 定" OnClick="Button1_Click" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <input id="Button2" type="button" value="返 回" onclick ="javascript: history.back()" class="button01-out" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
