<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DynamicPageUp.aspx.cs" Inherits="manage_DynamicPageUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px; float: left">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="96%">
                <tr class="BarTitleBg">
                    <td align="center" colspan="2">
                        &nbsp;网站内容更新</td>
                </tr>
                <tr>
                    <td valign="top">
                        网站栏目：<br />
                        <asp:TreeView ID="tvClass" runat="server" ShowLines="True">
                        </asp:TreeView>
                    </td>
                    <td valign="top">
                        指定更新页面：<br />
                        <asp:ListBox ID="lbData" runat="server" Width="276px" Height="291px" SelectionMode="Multiple"></asp:ListBox>
                        <asp:LinkButton ID="lbSubmit" runat="server" CssClass="Button" ForeColor="Black" OnClick="lbSubmit_Click">更 新</asp:LinkButton><br />
                        <asp:Label ID="lblResult" runat="server" Text=""> </asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
