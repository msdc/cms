<%@ Page Language="C#" AutoEventWireup="true" CodeFile="class_mdy.aspx.cs" Inherits="Manage_class_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td align="center" colspan="2">
                        <asp:Label ID="lblState" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        详细位置：</td>
                    <td>
                        <div id="TD1" runat="server" style="margin: 5px">
                        </div>
                    </td>
                </tr>
                <tr id="trMoveID" runat="server">
                    <td style="width: 179px">
                        移动栏目ID：<br />
                        （默认空为不移动）</td>
                    <td>
                        <asp:TextBox ID="tbMoveID" runat="server" CssClass="Input" Width="29px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        分类名称：</td>
                    <td>
                        <asp:TextBox ID="tbTitle" runat="server" CssClass="Input"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbTitle"
                            ErrorMessage="名称不能为空!"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        分类别名：</td>
                    <td>
                        <asp:TextBox ID="tbTitle2" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        分类排序：</td>
                    <td>
                        <asp:TextBox ID="tbOrderID" runat="server" CssClass="Input" Width="29px">1</asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        指定目录：</td>
                    <td>
                        <asp:TextBox ID="tbDir" runat="server" CssClass="Input">/html</asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbDir"
                            ErrorMessage="目录不能为空!"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                        使用模板：</td>
                    <td>
                        <asp:DropDownList ID="dlTemplate" runat="server" CssClass="Input">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 179px">
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="lbSubmit_Click">确 定</asp:LinkButton>
                        <a href="javascript:window.history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" OnClick="lbDel_Click"
                            runat="server">删 除</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="lblResult" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td bgcolor="#f6f6f6" colspan="2" onclick="if(HelpTab.style.display=='none'){HelpTab.style.display='';window.scrollTo(window.pageXOffset,2000);}else{HelpTab.style.display='none'}"
                    style="cursor: hand">
                    &nbsp;<img alt="" height="14" src="Images/Manage/why.gif" width="14" />
                    ::Help::</td>
            </tr>
            <tr id="HelpTab" style="display: none">
                <td width="2%">
                    &nbsp;</td>
                <td valign="top" width="98%">
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td>
                                ·生成目录</td>
                        </tr>
                        <tr>
                            <td>
                                指定资源的生成目录（限于站点允许的目录操作范围内），生成目录必须以“/”站点根目录为起点设置，如：/new。</td>
                        </tr>
                    </table>
                    <a name="Help"></a>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
