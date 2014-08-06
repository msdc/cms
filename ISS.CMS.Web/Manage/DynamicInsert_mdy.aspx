<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="DynamicInsert_mdy.aspx.cs"
    Inherits="manage_insertSYSnew_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
    function ispage()
    {
        if(document.getElementById("ispage_ddl").value == "1")
        {
            document.getElementById("ispage1_tr").style.display = "";
            document.getElementById("ispage2_tr").style.display = "";
        }
        else
        {
            document.getElementById("ispage1_tr").style.display = "none";
            document.getElementById("ispage2_tr").style.display = "none";
        }
    }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="96%">
                <tr class="BarTitleBg">
                    <td align="center" colspan="2">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="25%">
                        标题：</td>
                    <td width="75%">
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        标题截取长度：</td>
                    <td width="75%">
                        <asp:TextBox ID="tbLength" runat="server" CssClass="Input" Width="30px">0</asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        起始标签：</td>
                    <td bgcolor="#ffffff">
                        <asp:TextBox ID="startelement_tb" runat="server" CssClass="Input">&lt;!--list:start--&gt;</asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        结束标签：</td>
                    <td>
                        <asp:TextBox ID="endelement_tb" runat="server" CssClass="Input">&lt;!--list:end--&gt;</asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        循环次数：</td>
                    <td bgcolor="#ffffff">
                        <asp:TextBox ID="looptime_tb" runat="server" CssClass="Input" Width="40px">0</asp:TextBox></td>
                </tr>
                <tr id="sqloff1_tr" runat="server" style="">
                    <td width="25%">
                        时间：</td>
                    <td>
                        <asp:DropDownList ID="time_ddl" runat="server" CssClass="Input">
                            <asp:ListItem Value="addtime">创建时间</asp:ListItem>
                            <asp:ListItem Value="uptime">更新时间</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr id="sqloff2_tr" runat="server" style="">
                    <td width="25%">
                        排序方式：</td>
                    <td>
                        <asp:DropDownList ID="sort_ddl" runat="server" CssClass="Input">
                            <asp:ListItem Value="asc">升序</asp:ListItem>
                            <asp:ListItem Value="desc">降序</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td width="25%">
                        是否分页：</td>
                    <td>
                        <select id="ispage_ddl" onchange="ispage()" runat="server" class="Input">
                            <option selected="selected" value="0">否</option>
                            <option value="1">是</option>
                        </select>
                    </td>
                </tr>
                <tr id="ispage2_tr" runat="server" style="display: none">
                    <td width="25%">
                        页码数量：</td>
                    <td>
                        <asp:TextBox ID="tbPageNumber" runat="server" CssClass="Input" Width="30px">0</asp:TextBox></td>
                </tr>
                <tr id="ispage1_tr" runat="server" style="display: none">
                    <td valign="top" width="25%">
                        分页模版：</td>
                    <td>
                        <font color="#0000ff">分页关键替换词：</font><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$DataCount$')"
                            style="cursor: hand;">[资源总条数]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$PageSize$')"
                                style="cursor: hand">[每页资源数]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$PageIndex$')"
                                    style="cursor: hand">[当前页码]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$PageCount$')"
                                        style="cursor: hand">[总页数]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$First$')"
                                            style="cursor: hand">[首页]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Pre$')"
                                                style="cursor: hand">[上一页]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Next$')"
                                                    style="cursor: hand">[下一页]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Last$')"
                                                        style="cursor: hand">[尾页]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$PageNumber$')"
                                                            style="cursor: hand">[详细页码]</span>
                        <asp:TextBox ID="pageContent_tb" runat="server" CssClass="Input" Height="62px" TextMode="MultiLine"
                            Width="96%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">
                        编码格式：</td>
                    <td>
                        <asp:DropDownList ID="ddlEncoding" runat="server" CssClass="Input">
                            <asp:ListItem Value="0">默认</asp:ListItem>
                            <asp:ListItem Value="UTF">UTF-8</asp:ListItem>
                            <asp:ListItem>GB2312</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td width="25%" valign="top">
                        选择资源类别：</td>
                    <td>
                        <asp:TreeView ID="class_tree" runat="server" CssClass="Input">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td valign="top" width="25%">
                        选择资源特性：</td>
                    <td>
                        <asp:TreeView ID="speciality_tree" runat="server" CssClass="Input">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="2">
                        <font color="#0000ff">系统关键替换词：</font> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ID$')"
                            style="cursor: hand;">[资源记录号]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Title$')"
                                style="cursor: hand">[资源标题]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Content$')"
                                    style="cursor: hand">[资源内容]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Url$')"
                                        style="cursor: hand">[资源地址]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Author$')"
                                            style="cursor: hand">[作者]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$From$')"
                                                style="cursor: hand">[资源来源]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$KeyWord$')"
                                                    style="cursor: hand">[关键词]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Editor$')"
                                                        style="cursor: hand">[责任编辑]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$SmallImg$')"
                                                            style="cursor: hand">[资源小图]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$BigImg$')"
                                                                style="cursor: hand">[资源大图]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ShortContent$')"
                                                                    style="cursor: hand">[资源内容摘要]</span>
                        <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$AddTime$')" style="cursor: hand">
                            [添加时间]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Year$')" style="cursor: hand">
                                [年]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Month$')" style="cursor: hand">
                                    [月]</span><span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Day$')" style="cursor: hand">
                                        [日]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$UpTime$')" style="cursor: hand">
                                            [修改时间]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassTitle$')"
                                                style="cursor: hand">[分类名称]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassTitle2$')"
                                                    style="cursor: hand">[分类别名]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassUrl$')"
                                                        style="cursor: hand">[分类主页地址]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field1$')"
                                                            style="cursor: hand">[备注一]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field2$')"
                                                                style="cursor: hand">[备注二]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field3$')"
                                                                    style="cursor: hand">[备注三]</span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" height="300" valign="top">
                        <asp:TextBox ID="content_tb" runat="server" Height="338px" TextMode="MultiLine" Width="98%"
                            CssClass="Input" Font-Size="Small"></asp:TextBox></td>
                </tr>
                <tr>
                    <td height="85" valign="top">
                        应用文件：<br />
                        <font color="#999999">一行一个文件地址</font>
                    </td>
                    <td valign="top">
                        <asp:TextBox ID="filelist_tb" runat="server" CssClass="Input" Height="107px" TextMode="MultiLine"
                            Width="401px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right">
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="lbSubmit_Click">确 定</asp:LinkButton>
                        <a href="javascript:history.back()">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server"
                            OnClick="lbDel_Click">删 除</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
