<%@ Page Language="C#" AutoEventWireup="true" CodeFile="author_mdy.aspx.cs" Inherits="Manage_author_mdy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr align="center">
                    <td class="BarTitleBg" colspan="2">
                        <asp:Label ID="state_lbl" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr id="id_tr" runat="server">
                    <td width="25%">ID：</td>
                    <td width="75%">
                        <asp:TextBox ID="id_tb" runat="server" CssClass="Input" Enabled="False" Width="48px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>标题:作者姓名（笔名）：</td>
                    <td>
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input" Width="280px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">性别：</td>
                    <td width="75%">
                        <asp:RadioButtonList ID="sex_rbl" runat="server" RepeatColumns="3" Width="95px" CssClass="Input">
                            <asp:ListItem Value="男">男</asp:ListItem>
                            <asp:ListItem Value="女">女</asp:ListItem>
                        </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td width="25%">Email：</td>
                    <td width="75%">
                        <asp:TextBox ID="email_tb" runat="server" CssClass="Input" Width="280px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%" valign="top">作者简介：</td>
                    <td width="75%">
                        <asp:TextBox ID="content_tb" runat="server" CssClass="Input" Width="408px" Height="118px"
                            TextMode="MultiLine"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbOk" OnClick="lbOk_Click" runat="server" >确 定</asp:LinkButton>
                        <a href="javascript:window.history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClick="lbDel_Click" OnClientClick="return confirm('确认删除？')"  runat="server">删 除</asp:LinkButton></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
