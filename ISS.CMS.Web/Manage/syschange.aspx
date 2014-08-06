<%@ Page Language="C#" AutoEventWireup="true" CodeFile="syschange.aspx.cs" Inherits="Manage_syschange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script>
        function checkyon() {
            var obj = document.getElementById("ListBox1");
            var yon;
            for (i = 0; i < obj.options.length; i++) {
                if (obj.options[i].selected) {
                    yon = true;
                }
            }
            if (yon) {
                return true;
            }
            else {
                alert("请选择更新项！");
                return false;
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px" align="center">
            <table width="500" height="350" style="background-color: #cccccc" border="0" cellpadding="2"
                cellspacing="1">
                <tr>
                    <td height="21" align="center" class="BarTitleBg">
                        执行页面内容替换命令(请使用Ctrl\Shift组合键)</td>
                </tr>
                <tr>
                    <td align="center" valign="top" bgcolor="#FFFFFF" style="height: 92px">
                        <p>
                            &nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="250px" Width="90%" SelectionMode="Multiple">
                            </asp:ListBox></p>
                    </td>
                </tr>
                <tr>
                    <td align="center" bgcolor="#ffffff" style="height: 29px" valign="top">
                        <table>
                            <tr class="EditInput">
                                <td>
                                    <asp:LinkButton ID="lbSubmit" OnClientClick="return checkyon()" OnClick="Button1_Click"
                                        runat="server">确 定</asp:LinkButton>
                                </td>
                                <td>
                                    <a href="###" onclick="history.back();">返 回</a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <div align="center">
            <table width="500" style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1">
                <tr align="left">
                    <td bgcolor="#f6f6f6" colspan="2" onclick="if(HelpTab.style.display=='none'){HelpTab.style.display='';window.scrollTo(window.pageXOffset,2000);}else{HelpTab.style.display='none'}"
                        style="cursor: hand">
                        &nbsp;<img height="14" src="Images/Manage/why.gif" width="14" />
                        ::Help::</td>
                </tr>
                <tr id="HelpTab" style="display: none" align="left">
                    <td width="2%">
                        &nbsp;</td>
                    <td valign="top" width="98%">
                        <table border="0" cellpadding="3" cellspacing="0" width="100%">
                            <tr>
                                <td>
                                    页面内容嵌入功能介绍：</td>
                            </tr>
                            <tr>
                                <td>
                                    此功能模块可以帮助管理员对站点页面中的各小块内容进行在线管理及更新成静态文件。其适用的范围如：页面中的小广告、站点通告、版权内容及其它一些页面中的边角内容块<br />
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
