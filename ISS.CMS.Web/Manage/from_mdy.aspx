<%@ Page Language="C#" AutoEventWireup="true" CodeFile="from_mdy.aspx.cs" Inherits="Manage_from_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr align="center">
                    <td class="BarTitleBg" colspan="2">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr id="id_tr" runat="server">
                    <td width="25%">ID：</td>
                    <td width="75%">
                        <asp:TextBox ID="id_tb" runat="server" CssClass="Input" Enabled="False" Width="48px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>标题：</td>
                    <td>
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input" Width="281px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">显示代码：</td>
                    <td width="75%">
                        <asp:TextBox ID="content_tb" runat="server" CssClass="Input" Width="401px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right"></td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="lbSubmit_Click">确 定</asp:LinkButton>
                        <a href="javascript:history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server"
                            OnClick="lbDel_Click">删 除</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
