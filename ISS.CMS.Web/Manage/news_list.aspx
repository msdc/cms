﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news_list.aspx.cs" Inherits="Manage_news_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #class_dl td {
            text-align: center;
            width: 14%;
        }
    </style>

    <script language="javascript" type="text/javascript">
        function show1(id1) {
            var obj = document.getElementById("bala" + id1);
            obj.style.display = obj.style.display == "" ? "none" : "";
        }
        function selectCheckBox() {
            var input = document.getElementsByTagName("input");
            for (var i = 0 ; i < input.length; i++) {
                if (input[i].getAttribute("type") == "checkbox") {
                    if (input[i].checked) {
                        input[i].checked = false;
                    }
                    else {
                        input[i].checked = true;
                    }
                }
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
               <%-- <tr>
                    <td style="width: 14%; height: 20px;">当前位子：</td>
                    <td id="TD1" style="width: 86%" runat="server"></td>
                </tr>
                <tr>
                    <td colspan="2" id="class_td" runat="server">
                        <div style="margin: 5px;">
                            <asp:DataList ID="class_dl" runat="server" RepeatColumns="7" Width="95%">
                                <ItemTemplate>
                                    <a href='news_list.aspx?parent=<%# Eval("id") %>'>
                                        <%# Eval("title") %>
                                    </a>
                                </ItemTemplate>
                                <ItemStyle Height="30px" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:DataList>
                        </div>
                    </td>
                </tr>--%>
                <tr style="background-color: White">
                    <td id="Td2" runat="server" align="center" colspan="2" style="color: red">
                        <p style="margin: 5px">
                            <a>常规资源列表</a>
                        </p>
                    </td>
                </tr>
            </table>
        </div>
        <div style="margin: 10px">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                        width="100%">
                        <tr class="BarTitleBg">
                            <td width="5%" align="center">ID</td>
                            <td width="50%">资源标题</td>  
                            <td width="10%" align="center">所属模版</td>                          
                            <td width="8%" align="center">生成</td>
                            <td width="6%" align="center">审核</td>
                            <td width="11%" align="center">添加时间</td>
                            <td width="10%" align="center">编辑</td>
                        </tr>
                        <asp:Repeater ID="rptData" runat="server" OnItemCommand="dl1_RowCommand">
                            <ItemTemplate>
                                <tr align="center" style="background-color: White">
                                    <td align="center" width="5%">
                                        <asp:CheckBox ID="cb1" runat="server" />
                                        <asp:HiddenField ID="hidId" Value='<%# Eval("id") %>' runat="server" />
                                        <td align="left" width="50%">
                                            <a href="javascript:show1('<%# Eval("id") %>')">
                                                <%# Eval("title") %>
                                            </a>
                                        </td>
                                        <td width="10%">
                                            <%# Eval("Template")%>
                                        </td>                                        
                                        <td width="8%">
                                            <%# Convert.ToBoolean(Eval("IsCreate")) ? "<a style='color:red'>已生成</a>" : "<a style='color:black'>未生成</a>"%>
                                        </td>
                                        <td width="6%">
                                            <asp:LinkButton ID="dlsc_lb" CommandArgument='<%# Eval("id")%>' CommandName="审核"
                                                ForeColor='<%# Convert.ToBoolean(Eval("IsCheck")) ? System.Drawing.Color.Red : System.Drawing.Color.Black  %>'
                                                Text='<%# Convert.ToBoolean(Eval("IsCheck")) ? "是" : "否" %>' runat="server"></asp:LinkButton>
                                        </td>
                                        <td align="center" width="11%">
                                            <%# Convert.ToDateTime(Eval("addtime")).ToShortDateString()%>
                                        </td>
                                        <td class="EditInput">
                                            <a href="news_mdy.aspx?id=<%# Eval("id") %>&parent=<%# Request["parent"] %>&page=<%# Request["page"] %>">编 辑</a>
                                        </td>
                                </tr>
                                <tr id='bala<%# Eval("id") %>' style="display: none; background-color: White;">
                                    <td colspan="8">
                                        <div style="margin-top: 3px; margin-left: 3px">
                                            <asp:LinkButton ID="sc_lb" CommandArgument='<%# Eval("id") %>' runat="server" Enabled='<%# Convert.ToBoolean(Eval("IsCheck")) ? true : false %>'
                                                CommandName="生成">生成资源</asp:LinkButton>
                                            <%# Convert.ToBoolean(Eval("IsCreate")) ? "<a href=.." + Eval("filepath").ToString().Replace("\\", "/") + " target='_blank'>浏览资源</a>" : ""%>
                                            <asp:LinkButton ID="LinkButton4" OnClientClick="return confirm('确认删除？')" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"id") %>'
                                                runat="server" CommandName='删除'>删除资源</asp:LinkButton>
                                        </div>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
            <table style="background-color: #cccccc; margin-top: 2px" border="0" cellpadding="2"
                cellspacing="1" width="100%">
                <tr style="background-color: White">
                    <td align="right" colspan="3">
                        <asp:HiddenField ID="hidPageindex" runat="server" />
                        <asp:Label ID="lbl_pagecount" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbl_datacount" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="lbl_pageindex" runat="server" Text="Label"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:LinkButton ID="lbFirst" runat="server" OnClick="lbFirst_Click">首页</asp:LinkButton>
                        <asp:LinkButton ID="lbPrev" runat="server" OnClick="lbPrev_Click">上一页</asp:LinkButton>
                        <asp:LinkButton ID="lbNext" runat="server" OnClick="lbNext_Click">下一页</asp:LinkButton>
                        <asp:LinkButton ID="lbLast" runat="server" OnClick="lbLast_Click">尾页</asp:LinkButton>
                        <input id="page_tb" runat="server" class="Input" onkeypress="if(window.event.keyCode > '9'.charCodeAt(0) || window.event.keyCode < '0'.charCodeAt(0))window.event.returnValue=false;"
                            style="width: 34px" type="text" />
                        <asp:LinkButton ID="lbGo" OnClick="lbGo_Click" runat="server">G O</asp:LinkButton>
                    </td>
                </tr>
                <tr style="background-color: White">
                    <td align="right" class="EditInput" colspan="3">
                        <asp:HiddenField ID="hidQueryString" runat="server" />
                        <table>
                            <tr>
                                <td>
                                    <a href="javascript:selectCheckBox()">反 选</a>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbCheck" runat="server" OnClick="lbCheck_Click">审 核</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbCreate" runat="server" OnClick="lbCreate_Click">生 成</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbDel" runat="server" OnClick="lbDel_Click">删 除</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbDelData" runat="server" OnClick="lbDelData_Click">彻底删除</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr style="background-color: white">
                    <td align="right" colspan="3">
                        <table>
                            <tr class="EditInput">
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="搜索："></asp:Label>
                                    <asp:DropDownList ID="sort_ddl" runat="server" CssClass="Input">
                                        <asp:ListItem Value="title">资源标题</asp:ListItem>                                        
                                        <asp:ListItem Value="content">资源内容</asp:ListItem>
                                        <asp:ListItem Value="atitle">资源作者</asp:ListItem>
                                        <asp:ListItem Value="ftitle">资源来源</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:TextBox ID="sreach_tb" runat="server" CssClass="Input"></asp:TextBox>
                                </td>
                                <td class="EditInput">
                                    <asp:LinkButton ID="lbSearch" OnClick="lbSearch_Click" runat="server">搜 索</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table style="background-color: #cccccc; margin-top: 2px" border="0" cellpadding="2"
                cellspacing="1" width="100%">
                <tr style="background-color: white">
                    <td bgcolor="#f6f6f6" colspan="2" onclick="if(HelpTab.style.display=='none'){HelpTab.style.display='';window.scrollTo(window.pageXOffset,2000);}else{HelpTab.style.display='none'}"
                        style="cursor: hand">&nbsp;<img height="14" src="Images/Manage/why.gif" width="14" />
                        ::Help::</td>
                </tr>
                <tr id="HelpTab" style="display: none; background-color: White">
                    <td width="2%" style="height: 100px">&nbsp;</td>
                    <td valign="top" width="98%" style="height: 100px">
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td>·名词说明：当前（搜索）</td>
                            </tr>
                            <tr>
                                <td>只搜索当前所在资源类别下的所有资源（含子类的所有资源）</td>
                            </tr>
                            <tr>
                                <td>·名词说明：生成</td>
                            </tr>
                            <tr>
                                <td>
                                    <p>
                                        标志某资源在被最后修改的同时是否也生成了相对应的静态文件,若生成了,则“<font color="red">是</font>”，反之“否”
                                    </p>
                                </td>
                            </tr>
                        </table>
                        <a name="Help"></a>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
