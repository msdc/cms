<%@ Page Language="C#" AutoEventWireup="true" CodeFile="role_mdy.aspx.cs" Inherits="Manage_role_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script>
        function lv(str) {
            var obj = document.getElementById("menu_lb");
            var yon = 0;
            for (i = 0; i < obj.options.length; i++) {
                if (obj.options[i].selected) {
                    yon = 1;
                }
            }
            if (yon == 0) {
                alert("请选择需要移动的项！");
                return false;
            }
            else {
                if (obj.options[0].selected && str == "up") {
                    alert("已经为第一项！");
                    return false;
                }
                else if (obj.options[obj.options.length - 1].selected && str == "down") {
                    alert("已经为最后一项！");
                    return false;
                }
                else {
                    return true;
                }
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td align="center" class="BarTitleBg" colspan="2">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 98px">
                        角色名称：</td>
                    <td>
                        <asp:TextBox ID="name_tb" runat="server" CssClass="Input"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name_tb"
                            ErrorMessage="请填写角色名称"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 98px; height: 20px" valign="top">
                        权限设置：<br />
                        <br />
                        [说明：目录级别更新后需重新登陆才能生效。]</td>
                    <td style="height: 20px">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td valign="top" style="height: 200px">
                                    <asp:LinkButton ID="lbAllMenu" CssClass="Input" runat="server" OnClick="lbAllMenu_Click">全选</asp:LinkButton>
                                    <asp:TreeView ID="nag_tv" runat="server" OnSelectedNodeChanged="nag_tv_SelectedNodeChanged" CssClass="Input">
                                    </asp:TreeView>
                                </td>
                                <td valign="top" style="height: 168px">
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">根目录</asp:LinkButton>
                                    &nbsp;
                                    <asp:Label ID="Label1" runat="server"></asp:Label><br />
                                    <asp:ListBox ID="menu_lb" runat="server" Height="126px" Width="124px"></asp:ListBox>
                                    <br />
                                    <asp:LinkButton OnClientClick="return lv('up');" ID="LinkButton2" runat="server"
                                        OnClick="LinkButton2_Click">上移</asp:LinkButton>
                                    &nbsp;&nbsp;
                                    <asp:LinkButton ID="LinkButton3" OnClientClick="return lv('down');" runat="server"
                                        OnClick="LinkButton3_Click">下移</asp:LinkButton>
                                    <asp:HiddenField ID="parent_hid" runat="server" />
                                    <asp:HiddenField ID="parent_hid1" runat="server" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="width: 98px; height: 20px" valign="top">
                        可操作资源类别：</td>
                    <td style="height: 20px" valign="top">
                        <asp:TreeView ID="class_tree" runat="server" CssClass="Input">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td style="width: 98px" valign="top">
                        描述：</td>
                    <td>
                        <asp:TextBox ID="des_tb" runat="server" Height="79px" TextMode="MultiLine" Width="322px" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 98px" valign="top">
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="Button1_Click">确 定</asp:LinkButton>
                        <a href="javascript:history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server"
                            OnClick="del_btn_Click">删 除</asp:LinkButton></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
