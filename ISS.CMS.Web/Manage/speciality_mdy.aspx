<%@ Page Language="C#" AutoEventWireup="true" CodeFile="speciality_mdy.aspx.cs" Inherits="Manage_speciality_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr class="BarTitleBg">
                    <td colspan="2">
                        <asp:Label ID="state_lbl" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        详细位置：</td>
                    <td>
                        <div id="TD1" runat="server" style="margin: 5px">
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        特性名称：</td>
                    <td bgcolor="#ffffff">
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input" Width="380px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td valign="top">
                        <p>
                            特性简介：</p>
                    </td>
                    <td bgcolor="#ffffff" style="height: 131px">
                        <asp:TextBox ID="explain_tb" runat="server" Height="124px" TextMode="MultiLine" Width="473px"
                            CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr bgcolor="#ffffff">
                    <td>
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbSubmit" runat="server" OnClick="lbSubmit_Click">确 定</asp:LinkButton>
                        <a href="javascript:history.back();">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server"
                            OnClick="lbDel_Click">删 除</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

