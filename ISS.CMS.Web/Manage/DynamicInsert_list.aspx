<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DynamicInsert_list.aspx.cs"
    Inherits="manage_insertSYSnew_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="EditInput">
                        <a href="DynamicInsert_mdy.aspx?page=<%=Request["page"] %>">添加嵌入</a> <a href="DynamicPageUp.aspx">
                            执行嵌入</a>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding:10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td style="width: 50px">
                        ID
                    </td>
                    <td>
                        标题
                    </td>
                    <td>
                        起始标签
                    </td>
                    <td>
                        结束标签
                    </td>
                    <td style="width: 80px">
                    </td>
                </tr>
                <asp:Repeater ID="rptData" runat="server">
                    <ItemTemplate>
                        <tr align="center">
                            <td>
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <%# Eval("Title") %>
                            </td>
                            <td>
                                <%# Eval("startelement").ToString().Replace("<!--", "").Replace("-->", "")%>
                            </td>
                            <td>
                                <%# Eval("endelement").ToString().Replace("<!--", "").Replace("-->", "")%>
                            </td>
                            <td class="EditInput">
                                <a href="DynamicInsert_mdy.aspx?id=<%# Eval("id") %>&page=<%# Request["page"] %>">编
                                    辑</a>
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
                        <span id="Span2"></span><span id="Span3">
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
