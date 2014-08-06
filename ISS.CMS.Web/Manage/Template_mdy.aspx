<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Template_mdy.aspx.cs" ValidateRequest="false" Inherits="Manage_Template_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        function tellPoint() {
            var rng = event.srcElement.createTextRange();
            rng.moveToPoint(event.x, event.y);
            rng.moveStart("character", -event.srcElement.value.length);
            document.getElementById("content_ce").value = "fdsfds";
        }
        function insertField() {
            alert(navigator.appName);
            alert(navigator.appVersion);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="99%">
                <tr>
                    <td align="center" class="BarTitleBg" colspan="2">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label></td>
                </tr>
                <tr id="id_tr" runat="server">
                    <td width="25%">ID：</td>
                    <td width="75%">
                        <asp:TextBox ID="id_tb" runat="server" Width="39px" Enabled="False" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="25%">模板名称：</td>
                    <td width="75%">
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr id="oldtag_tr" bgcolor="#ffffff">
                    <td colspan="2">
                        <font color="#0000ff">系统关键替换词:</font> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ID$')"
                            style="cursor: hand">[资源记录号]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Title$')"
                                style="cursor: hand">[资源标题]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Content$')"
                                    style="cursor: hand">[资源内容]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Url$')"
                                        style="cursor: hand">[资源地址]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Author$')"
                                            style="cursor: hand">[作者]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$From$')"
                                                style="cursor: hand">[资源来源]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$KeyWord$')"
                                                    style="cursor: hand">[关键词]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Editor$')"
                                                        style="cursor: hand">[责任编辑]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$SmallImg$')"
                                                            style="cursor: hand">[资源小图]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$BigImg$')"
                                                                style="cursor: hand">[资源大图]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ShortContent$')"
                                                                    style="cursor: hand">[资源内容摘要]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$AddTime$')"
                                                                        style="cursor: hand">[添加时间]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Year$')"
                                                                            style="cursor: hand">[年]</span>
                        <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Month$')" style="cursor: hand">[月]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Day$')" style="cursor: hand">[日]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$UpTime$')" style="cursor: hand">[修改时间]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassId$')"
                            style="cursor: hand">[分类ID]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassTitle$')"
                                style="cursor: hand">[分类名称]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassTitle2$')"
                                    style="cursor: hand">[分类别名]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$ClassUrl$')"
                                        style="cursor: hand">[分类主页地址]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field1$')"
                                            style="cursor: hand">[备注一]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field2$')"
                                                style="cursor: hand">[备注二]</span> <span onclick="prompt('系统将自动替换以下关键词为相应的内容,\n请复制到模板当中','$Field3$')"
                                                    style="cursor: hand">[备注三]</span> <span onclick='prompt("系统将自动替换以下关键词为相应的内容,\n请复制到模板当中","<script src=\"/SiteManage/show.aspx?id=$Id$\"></script>")'
                                                        style="cursor: hand">[点击量]</span> <span onclick='prompt("系统将自动替换以下关键词为相应的内容,\n请复制到模板当中","<script src=\"/SiteManage/count.aspx?id=$Id$\" ></script>")'
                                                            style="cursor: hand">[点击量统计]</span>
                    </td>
                </tr>
                <tr valign="top">
                    <td id="trHtmlEditContent" align="center" colspan="2" height="400">
                        <asp:TextBox ID="content_ce" runat="server" Height="400px" TextMode="MultiLine" Width="99%"
                            CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td class="EditInput">
                        <asp:LinkButton ID="LinkButton1" OnClick="Button1_Click" runat="server">确 定</asp:LinkButton>
                        <a href="javascript:history.back()">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" OnClick="Button2_Click"
                            runat="server">删 除</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
