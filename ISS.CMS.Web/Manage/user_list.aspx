<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_list.aspx.cs" Inherits="Manage_user_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="EditInput">
                        <a href="user_mdy.aspx?page=<%=Request["page"] %>">添加账户</a>
                    </td>
                </tr>
            </table>
        </div>
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td width="10%">
                        状态
                    </td>
                    <td>
                        帐户名称</td>
                    <td width="20%">
                        角色
                    </td>
                    <td width="15%">
                        添加时间
                    </td>
                    <td width="1%">
                    </td>
                </tr>
                <asp:Repeater ID="rptData" runat="server">
                    <ItemTemplate>
                        <tr align="center">
                            <td><!--by han lock-->
                                <img alt='<%# Convert.ToBoolean(DataBinder.Eval(Container.DataItem,"IsLock")) ? "已锁" : "未锁" %>'
                                    height="16" src='images/Manage/<%# Convert.ToBoolean(DataBinder.Eval(Container.DataItem,"IsLock")) ? "AdminLock" : "AdminUnLock" %>.gif'
                                    width="16" />
                            </td>
                            <td>
                                <%# Eval("Name") %>
                            </td>
                            <td>
                                <%# Eval("RoleID")%><!--by han rolename-->
                            </td>
                            <td>
                                <%# Convert.ToDateTime(Eval("addtime")).ToShortDateString()%>
                            </td>
                            <td class="EditInput">
                                <a href="user_mdy.aspx?id=<%# Eval("id") %>&page=<%# Request["page"] %>">编 辑</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td colspan="5" align="right">
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
