<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staticinsert_mdy.aspx.cs" Inherits="Manage_Staticinsert_mdy" %>

<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="96%"">
                <tr>
                    <td align="center" class="BarTitleBg" colspan="2">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="25%">
                        标题：</td>
                    <td bgcolor="#ffffff" width="75%">
                        <asp:TextBox ID="tbTitle" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        编码格式：</td>
                    <td bgcolor="#ffffff" width="75%">
                        <asp:DropDownList ID="ddlEncoding" runat="server" CssClass="Input">
                            <asp:ListItem Value="0">默认</asp:ListItem>
                            <asp:ListItem Value="UTF">UTF-8</asp:ListItem>
                            <asp:ListItem>GB2312</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td width="25%">
                        起始标签：</td>
                    <td bgcolor="#ffffff">
                        <asp:TextBox ID="tbStartelement" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        结束标签：</td>
                    <td bgcolor="#ffffff">
                        <asp:TextBox ID="tbEndelement" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" height="300" valign="top">
                        <CE:Editor ID="tbContent" runat="server" Height="400px" Width="100%" AutoConfigure="Simple" FilesPath="~/wedcvgu1k5k/CuteEditor">
                            <%--<FrameStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
                                CssClass="CuteEditorFrame" Height="100%" Width="100%" />--%>
                        </CE:Editor>
                    </td>
                </tr>
                <tr>
                    <td height="85" valign="top">
                        应用文件：<br />
                        <font color="#999999">一行一个文件地址</font>
                    </td>
                    <td bgcolor="#ffffff" valign="top">
                        <asp:TextBox ID="tbFileList" runat="server" CssClass="Input" Height="107px" TextMode="MultiLine"
                            Width="401px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="LinkButton1" OnClick="Button1_Click" runat="server">确 定</asp:LinkButton>
                        <a href="javascript:history.back()">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" OnClick="Button2_Click"
                            runat="server">删 除</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
