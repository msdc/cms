<%@ Page Language="C#" AutoEventWireup="true" CodeFile="speciality_list.aspx.cs" Inherits="Manage_speciality_list" %>

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
                        <a href='speciality_mdy.aspx?parent=<%=Request["parent"] %>'>添加特性</a>
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
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td style="width: 50px">
                        ID
                    </td>
                    <td>
                        特性名称
                    </td>
                    <td style="width: 80px">
                    </td>
                </tr>
                <asp:Repeater ID="rptSpec" runat="server">
                    <ItemTemplate>
                        <tr align="center">
                            <td>
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <a href="Speciality_list.aspx?parent=<%# Eval("id") %>">
                                    <%# Eval("title") %>
                                </a>
                            </td>
                            <td class="EditInput">
                                <a href="Speciality_mdy.aspx?id=<%# Eval("id") %>&parent=<%# Request["parent"] %>">编
                                    辑</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td align="right">
                        <asp:HiddenField ID="hidQuerystr" runat="server" />
                        <span id="Span3">当前页：<asp:Label ID="lbl_pageindex" runat="server"></asp:Label>/<asp:Label
                            ID="lbl_pagecount" runat="server"></asp:Label></span> &nbsp; &nbsp; &nbsp;&nbsp;
                        <asp:LinkButton ID="lbFirst" runat="server" OnClick="lbFirst_Click">首页</asp:LinkButton>
                        <asp:LinkButton ID="lbPre" runat="server" OnClick="lbPre_Click">上一页</asp:LinkButton>
                        <asp:LinkButton ID="lbNext" runat="server" OnClick="lbNext_Click">下一页</asp:LinkButton>
                        <asp:LinkButton ID="lbLast" runat="server" OnClick="lbLast_Click">尾页</asp:LinkButton>
                        <input id="page_tb" runat="server" class="Input" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;"
                            style="width: 34px" type="text" />
                        <asp:LinkButton ID="lbTo" runat="server" OnClick="lbTo_Click">G O</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
