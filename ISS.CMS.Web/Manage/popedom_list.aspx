<%@ Page Language="C#" AutoEventWireup="true" CodeFile="popedom_list.aspx.cs" Inherits="Manage_popedom_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="margin: 10px">
                <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                    width="100%">
                    <tr>
                        <td class="EditInput">
                            <a href="popedom_mdy.aspx?parent=<%= Request["parent"] %>">添加权限</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="TD1" runat="server" style="margin: 5px">
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
            <div style="margin: 10px">
                <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                    width="100%">
                    <tr class="BarTitleBg">
                        <td style="width: 50px">
                            记录ID
                        </td>
                        <td style="width: 100px">
                            权限名称</td>
                        <td>
                            页面路径
                        </td>
                        <td width="15%">
                            页面名称
                        </td>
                        <td style="width: 80px">
                        </td>
                    </tr>
                    <asp:Repeater ID="rptInfo" runat="server">
                        <ItemTemplate>
                            <tr align="center" style="background-color: White">
                                <td>
                                    <%# Eval("id") %>
                                </td>
                                <td>
                                    <a href='popedom_list.aspx?parent=<%# Eval("id") %>'>
                                        <%# Eval("pageName") %>
                                    </a>
                                </td>
                                <td align="left"><!--by han pagePath-->
                                    <%# Eval("PageFileDir").ToString() == "" ? "/manage/" : Eval("PageFileDir")%>
                                </td>
                                <td>
                                    <%# Eval("pageTitle") %>
                                </td>
                                <td class="EditInput">
                                    <a href="popedom_mdy.aspx?id=<%# Eval("id") %>&parent=<%# Request["parent"] %>">编 辑</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
    </form>
</body>
</html>
