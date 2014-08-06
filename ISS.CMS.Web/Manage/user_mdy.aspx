<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_mdy.aspx.cs" Inherits="Manage_user_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />
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
                <tr id="id_tr" runat="server">
                    <td style="width: 30%">
                        ID：</td>
                    <td>
                        <asp:TextBox ID="id_tb" runat="server" CssClass="Input" Enabled="False" Width="50px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 30%">
                        帐户：</td>
                    <td>
                        <asp:TextBox ID="name_tb" runat="server" CssClass="Input"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name_tb"
                            ErrorMessage="请填写帐户"></asp:RequiredFieldValidator></td>
                </tr>
                <tr style="color: #000000">
                    <td>
                        昵称（笔名）：</td>
                    <td>
                        <asp:TextBox ID="nickname_tb" runat="server" CssClass="Input"></asp:TextBox>
                    </td>
                </tr>
                <tr id="password_tr" runat="server" style="color: #000000">
                    <td>
                        密码：</td>
                    <td>
                        <asp:TextBox ID="pwd_tb" runat="server" CssClass="Input" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="pwd_tb"
                            ErrorMessage="请填写密码"></asp:RequiredFieldValidator></td>
                </tr>
                <tr id="password_tr1" runat="server" style="color: #000000">
                    <td>
                        确认密码：</td>
                    <td>
                        <asp:TextBox ID="pwdag_pwd" runat="server" CssClass="Input" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pwd_tb"
                            ControlToValidate="pwdag_pwd" ErrorMessage="两次密码不一致" Display="Dynamic"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="pwdag_pwd"
                            ErrorMessage="请填写密码"></asp:RequiredFieldValidator></td>
                </tr>
                <tr style="color: #000000">
                    <td>
                        角色：</td>
                    <td>
                        <asp:DropDownList ID="role_ddl" runat="server" CssClass="Input">
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        锁定：</td>
                    <td>
                        <asp:RadioButtonList ID="lock_rbl" runat="server" RepeatColumns="2" Width="124px" CssClass="Input">
                            <asp:ListItem Value="0">解锁</asp:ListItem>
                            <asp:ListItem Selected="True" Value="1">锁定</asp:ListItem>
                        </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="lbSubmit_Click">确 定</asp:LinkButton>
                        <a href="javascript:history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server"
                            OnClick="Button4_Click">删 除</asp:LinkButton>
                        <asp:LinkButton ID="lbPwdMdy" runat="server" OnClick="Button3_Click">修改密码</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
