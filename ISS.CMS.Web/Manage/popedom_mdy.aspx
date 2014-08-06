<%@ Page Language="C#" AutoEventWireup="true" CodeFile="popedom_mdy.aspx.cs" Inherits="Manage_popedom_mdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../manage/style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script>
        function page() {
            if (document.getElementById("S1").value == "1") {
                document.getElementById("page1").style.display = "";
                document.getElementById("page2").style.display = "";
                document.getElementById("page3").style.display = "";
            }
            else {
                document.getElementById("page1").style.display = "none";
                document.getElementById("page2").style.display = "none";
                document.getElementById("page3").style.display = "none";
            }
        }
    </script>

</head>
<body>
    <form id="form1" on runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td colspan="2" class="BarTitleBg" align="center">
                        <asp:Label ID="state_lbl" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px">
                        详细位置：</td>
                    <td id="TD1" runat="server">
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px">
                        页面名称：</td>
                    <td>
                        <asp:TextBox ID="pagename_tb" class="Input" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="pagename_tb"
                            ErrorMessage="请填写页面名称"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="width: 167px">
                        是否对应页面：</td>
                    <td>
                        <select id="S1" onchange="page()" runat="server" class="Input">
                            <option selected="selected" value="0">否</option>
                            <option value="1">是</option>
                        </select>
                    </td>
                </tr>
                <tr id="page1" runat="server" style="display: none;">
                    <td style="width: 167px">
                        页面路径：<br />
                        （从根目录开始计算）</td>
                    <td>
                        <asp:TextBox ID="pagepath_tb" runat="server" Width="230px" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr id="page2" runat="server" style="display: none;">
                    <td style="width: 167px">
                        文件名称：<br />
                        例：index.asp,index.aspx</td>
                    <td>
                        <asp:TextBox ID="pagetitle_tb" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr id="page3" runat="server" style="display: none;">
                    <td style="width: 167px">
                        包含子页面：<br />
                        （以逗号分割开，例：<br />
                        aaa.aspx,bbb.asps）</td>
                    <td>
                        <asp:TextBox ID="subpage_tb" runat="server" Width="350px" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 24px;" valign="top">
                        描述：</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="des_tb" runat="server" Height="80px" TextMode="MultiLine" Width="215px" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 24px" valign="top">
                    </td>
                    <td style="height: 24px" class="EditInput">
                        <asp:LinkButton ID="lbSumit" OnClick="Button1_Click" runat="server">确 定</asp:LinkButton>
                        <a href="###" onclick="history.back()">返 回</a>
                        <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" OnClick="Button3_Click"
                            runat="server">删 除</asp:LinkButton></td>
                </tr>
            </table>

            <script>
                if (document.getElementById("S1").value == "1") {
                    document.getElementById("page1").style.display = "";
                    document.getElementById("page2").style.display = "";
                    document.getElementById("page3").style.display = "";
                }
                else {
                    document.getElementById("page1").style.display = "none";
                    document.getElementById("page2").style.display = "none";
                    document.getElementById("page3").style.display = "none";
                }
            </script>

        </div>
    </form>
</body>
</html>
