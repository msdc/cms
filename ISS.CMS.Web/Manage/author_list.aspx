<%@ Page Language="C#" AutoEventWireup="true" CodeFile="author_list.aspx.cs" Inherits="Manage_author_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="EditInput">
                        <a href="Author_mdy.aspx?Page=<%= Request["Page"] %>">添加作者</a>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td style="width: 50px">记录ID
                    </td>
                    <td style="width: 150px">资源作者</td>
                    <td>简介
                    </td>
                    <td style="width: 80px"></td>
                </tr>
                <asp:Repeater ID="rptAuthor" runat="server">
                    <ItemTemplate>
                        <tr align="center" style="background-color: White">
                            <td>
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <%# Eval("title") %>
                            </td>
                            <td align="left">
                                <%# Eval("content") %>
                            </td>
                            <td class="EditInput">
                                <a href="Author_mdy.aspx?id=<%# Eval("id") %>&page=<%# Request["page"] %>">编 辑</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div style="padding: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr style="background-color: White">
                    <td align="right">
                        <span id="Span2"></span><span id="Span3">当前页：<asp:Label ID="lbl_pageindex" runat="server"></asp:Label>/<asp:Label
                            ID="lbl_pagecount" runat="server"></asp:Label></span> &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:LinkButton ID="lbFirst" OnClick="lbFirst_Click" runat="server">首页</asp:LinkButton>
                        <asp:LinkButton ID="lbPrev" OnClick="lbPrev_Click" runat="server">上一页</asp:LinkButton>
                        <asp:LinkButton ID="lbNext" OnClick="lbNext_Click" runat="server">下一页</asp:LinkButton>
                        <asp:LinkButton ID="lbLast" OnClick="lbLast_Click" runat="server">尾页</asp:LinkButton>
                        <input id="page_tb" runat="server" class="Input" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;"
                            style="width: 34px" type="text" />
                        <asp:LinkButton ID="lbTo" OnClick="lbTo_Click" runat="server">G O</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
