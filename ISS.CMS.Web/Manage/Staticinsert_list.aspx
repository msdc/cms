<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staticinsert_list.aspx.cs" Inherits="Manage_Staticinsert_list" %>

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
                        <a href="Staticinsert_mdy.aspx?page=<%=Request["page"] %>">添加嵌入</a> <a href="syschange.aspx?old=1">
                            执行嵌入</a>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td style="width: 50px">
                        ID
                    </td>
                    <td>
                        标题
                    </td>
                    <td style="width: 80px">
                    </td>
                </tr>
                <asp:Repeater ID="infoRpt" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td align="center">
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <%# Eval("Title") %>
                            </td>
                            <td class="EditInput">
                                <a href="Staticinsert_mdy.aspx?id=<%# Eval("id") %>&page=<%# Request["page"] %>">编 辑</a>
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
                        <span id="Span2"></span><span id="Span3">&nbsp;当前页：<asp:Label ID="lbl_pageindex"
                            runat="server"></asp:Label>/<asp:Label ID="lbl_pagecount" runat="server"></asp:Label></span>
                        &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">首页</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">上一页</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">下一页</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">尾页</asp:LinkButton>
                        <input id="page_tb" runat="server" class="Input" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;"
                            style="width: 34px" type="text" />
                        <asp:LinkButton ID="LinkButton5" OnClick="Button7_Click1" runat="server">G O</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
