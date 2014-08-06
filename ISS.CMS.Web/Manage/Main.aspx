<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Manage_Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="f1" runat="server">
        <div align="center" style="margin: 10px">
            <table width="85%" style="background-color: #ebebeb" border="0" cellpadding="2" cellspacing="1">
                <tr align="center">
                    <td height="13" colspan="2" class="BarTitleBg">
                        帐户信息</td>
                </tr>
                <tr>
                    <td width="23%" height="284" align="center" valign="middle">
                        <img src="Images/Skin/Logo.png"></td>
                    <td width="77%" valign="top" align="left">
                        <table style="margin-top: 5px; font-size: 14px; background-color: #ebebeb" border="0"
                            cellpadding="2" cellspacing="1" width="100%">
                            <tr>
                                <td width="32%">
                                    帐户：</td>
                                <td width="68%">
                                    <font color="#0000FF">
                                        <asp:Label ID="title_lbl" runat="server"></asp:Label></font></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                    帐户昵称：</td>
                                <td width="68%">
                                    <asp:Label ID="nickname_lbl" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                    账户角色：</td>
                                <td width="68%">
                                    <span>
                                        <asp:Label ID="rtitle_lbl" runat="server"></asp:Label></span></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                    创建时间：</td>
                                <td width="68%">
                                    <asp:Label ID="addtime_lbl" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                    最后登录：</td>
                                <td width="68%">
                                    <asp:Label ID="lasttime_lbl" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                    登录次数：</td>
                                <td width="68%">
                                    <asp:Label ID="count_lbl" runat="server"></asp:Label></td>
                            </tr>
                            <tr>
                                <td width="32%">
                                </td>
                                <td width="68%" class="EditInput">
                                    <asp:LinkButton ID="LinkButton1" OnClick="Button1_Click" runat="server">注 销</asp:LinkButton>
                                    <a href="javascript:history.back()">返 回</a>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size: 12px;" colspan="2">
                                    注：<br>
                                    &nbsp; 1.退出本系统前请先注销用户,否则在系统默认的帐号超时时间内，同名的管理员帐号无法从另一IP登录,同时也防止管理员权限贮留，产生安全瘾患！<br>
                                    &nbsp; 2.本系统要求服务器端及客户端均安装有<strong>IE5.5</strong>以上版本，否则将无法正常使用核心功能。</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
