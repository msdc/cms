<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Template_List.aspx.cs" Inherits="Manage_Template_List" %>

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
                        <a href="Template_mdy.aspx">添加模板</a>
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
                        模板名称
                    </td>
                    <td style="width: 80px">
                    </td>
                </tr>
                <asp:Repeater ID="rptInfo" runat="server">
                    <ItemTemplate>
                        <tr align="center">
                            <td>
                                <%# Eval("id") %>
                            </td>
                            <td>
                                <%# Eval("title") %>
                            </td>
                            <td class="EditInput">
                                <a href="template_mdy.aspx?id=<%# Eval("id") %>">编 辑</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div style="padding:10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td colspan="3" align="right">
                        <span id="Span2"></span><span id="Span3">当前页：<asp:Label ID="lbl_pageindex" runat="server"></asp:Label>/<asp:Label
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
