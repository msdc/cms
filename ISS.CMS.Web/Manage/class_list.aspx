<%@ Page Language="C#" AutoEventWireup="true" CodeFile="class_list.aspx.cs" Inherits="Manage_class_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="EditInput">
                    <a href="class_mdy.aspx?parent=<%= Request["parent"] %>&page=<%= Request["page"] %>">添加类别</a>
                        </td>
                </tr>
                <tr>
                    <td>
                        <div id="TD1" runat="server" style="padding: 5px">
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td style="width:50px">
                        ID
                    </td>
                    <td>
                        资源分类名称
                    </td>
                    <td style="width:80px">
                        生成目录
                    </td>
                    <td style="width:80px">
                        资源列表
                    </td>
                    <td style="width:80px">
                    </td>
                </tr>
                <asp:Repeater ID="rptData" runat="server">
                    <ItemTemplate>
                        <tr align="center">
                            <td>
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <a href="class_list.aspx?parent=<%# Eval("id") %>">
                                    <%# Eval("title") %>
                                </a>
                            </td>
                            <td>
                                <%# Eval("directory")%>
                            </td>
                            <td>
                                <a href="news_list.aspx?parent=<%# Eval("id") %>">资源列表</a>
                            </td>
                            <td class="EditInput">
                                <a href="class_mdy.aspx?id=<%# Eval("id") %>&page=<%# Request["page"] %>&parent=<%# Request["parent"] %>">编 辑</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div style="padding:10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr style="background-color: White">
                    <td colspan="4" align="right">
                        <span id="Span1"></span><span id="Span4">
                            <asp:HiddenField ID="hidQuery" runat="server" />
                            当前页：<asp:Label ID="lblPageIndex" runat="server"></asp:Label>/<asp:Label ID="lblPageCount"
                                runat="server"></asp:Label></span> &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:HyperLink ID="hlFirst" runat="server">首页</asp:HyperLink>
                        <asp:HyperLink ID="hlPre" runat="server">上一页</asp:HyperLink>
                        <asp:HyperLink ID="hlNext" runat="server">下一页</asp:HyperLink>
                        <asp:HyperLink ID="hlLast" runat="server">尾页</asp:HyperLink>
                        <input id="tbPageIndex" runat="server" class="Input" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;"
                            style="width: 34px" type="text" />
                        <asp:LinkButton ID="lbGoPage" runat="server" OnClick="lbGoPage_Click">G O</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
