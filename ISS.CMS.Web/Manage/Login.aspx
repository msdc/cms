<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Manage_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script>
        function usernameSub() {
            if (event.keyCode == 13) {
                document.getElementById("lbLogin").focus();
                document.getElementById("lbLogin").click();
            }
        }
        function passwordSub() {
            if (event.keyCode == 13) {
                document.getElementById("lbLogin").focus();
                document.getElementById("lbLogin").click();
            }
        }

    </script>
    <style>
    #box p {
	font-size: 12px;
	text-align: left;
	line-height: 15px;
	text-indent: 26px;
	padding:0px;
	margin:0px;
}
    </style>

</head>
<body>
    <form id="Form1" runat="server">
        <div style="width: 100%;" align="center">
            &nbsp;<br />
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="60%">
                <tr style="background-color: White" align="center">
                    <td colspan="2" class="BarTitleBg">
                        管理员登录</td>
                </tr>
                <tr>
                    <td width="25%" align="center" valign="middle" style="background-color: White">
                        <img src="Images/Skin/Logo.png"/></td>
                    <td width="75%" bgcolor="#FFFFFF" valign="top" align="center">
                        <table style="background-color: #cccccc; margin-bottom:30px; margin-top:20px" border="0" cellpadding="2" cellspacing="1"
                            width="90%">
                            <tr style="background-color: White">
                                <td width="27%" align="center">
                                    帐户：</td>
                                <td width="73%" align="left">
                                    <asp:TextBox ID="name_tb" runat="server" Text="admin" Width="128px" CssClass="Input"></asp:TextBox></td>
                            </tr>
                            <tr style="background-color: White">
                                <td width="27%" align="center">
                                    密码：</td>
                                <td width="73%" align="left">
                                    <asp:TextBox ID="pwd_tb" runat="server" CssClass="Input" Width="128px" TextMode="Password"></asp:TextBox>&nbsp;</td>
                            </tr>
                            <tr style="background-color: White">
                                <td width="27%">
                                </td>
                                <td align="left" class="EditInput">
                                    <table border="0" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <asp:LinkButton ID="lbLogin" runat="server" OnClick="lbLogin_Click">登 陆</asp:LinkButton>
                                            </td>
                                            <td>
                                                <a href="javascript:document.Form1.reset();" class="test">还 原</a>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr style="background-color: White">
                                <td bgcolor="#FFFFFF">
                                </td>
                                <td bgcolor="#FFFFFF" class="BarText" align="left">
                                    <label for="AutoRemberLoginName">
                                        <asp:CheckBox ID="cookie_cb" runat="server" Text="记住登录名" /></label>
                                </td>
                            </tr>
                            <tr style="background-color: White;">
                                <td colspan="2" valign="top" align="left" style="line-height: 15px;">
                                    <div id="box">
                                        <p style="text-indent: 0px;">
                                            注：</p>
                                        <p>
                                            1.退出本系统前请先注销用户,否则在系统默认的帐号超时时间内，同名的管理员帐号无法从另一IP登录,同时也防止管理员权限贮留，产生安全瘾患！</p>
                                        <p>
                                            2.本系统要求服务器端及客户端均安装有<strong>IE5.5</strong>以上版本，否则将无法正常使用核心功能。</p>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
