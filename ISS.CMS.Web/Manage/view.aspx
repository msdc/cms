<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="Manage_view" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script language="javascript">
        function FileYon() {
            var str = document.getElementById("FileUpload1").value;
            var idx = str.lastIndexOf("\\") + 1;
            var file = str.substring(idx);
            if (document.getElementById(file) != null) {
                if (confirm("已存在此文件，是否将现有文件覆盖？")) {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return true;
            }
        }
        function FolderYon() {
            var str = document.getElementById("tb_folder").value;
            if (document.getElementById(str) != null) {
                alert("已存在此文件夹");
                return false;
            }
            else {
                return true;
            }
        }
        function show(img) {
            var str;
            var obj;
            str = img;
            ojb = window.open('upfile.aspx?src=' + str.value, 'newwindow', 'top=250,left=300,width=500,height=230,menubar=no,toolbar=no,location=no,directories=no,scrollbars=no,status=no,resizable=no');

        }
        function CreateFolder() {
            if (create_div.style.display == "none") {
                create_div.style.display = "";
            }
            else {
                create_div.style.display = "none";
            }
        }
        function showurl(url) {
            obj = url;
            prompt("文件的URL", obj.value);
        }
        function back() {
            history.back();
        }
        function go() {
            history.go();
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">
            <table style="width: 100%;">
                <tr>
                    <td style="width: 30%">
                        <asp:Label ID="lblFolder" runat="server" Text="文件夹名称："></asp:Label>
                        <asp:TextBox ID="tbFolder" CssClass="Input" runat="server"></asp:TextBox>
                    </td>
                    <td class="EditInput2">
                        <asp:LinkButton ID="lbCreateFolder" OnClientClick="return FolderYon()" OnClick="lbCreateFolder_Click"
                            runat="server">创建文件夹</asp:LinkButton>
                    </td>
                    <td style="width: 38%">
                        <asp:Label ID="lblFile" runat="server" Text="文件名称："></asp:Label>
                        <asp:FileUpload ID="fuFile" CssClass="Input" runat="server" />
                    </td>
                    <td class="EditInput">
                        <asp:LinkButton ID="lbUpFile" OnClientClick="return FileYon()" OnClick="lbUpFile_Click"
                            runat="server">上 传</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding: 10px">
            <div id="tdPathInfo" runat="server" style="padding-bottom: 10px; font-size:12px">
            </div>
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="BarTitleBg" style="width: 5%">
                    </td>
                    <td style="width: 467px" class="BarTitleBg">
                        标题</td>
                    <td style="width: 10%" class="BarTitleBg" align="center">
                        大小</td>
                    <td class="BarTitleBg" style="width: 15%" align="center">
                        创建时间</td>
                    <td class="BarTitleBg" style="width: 10%" align="center">
                        操作</td>
                </tr>
                <tr bgcolor="#FFFFFF">
                    <td style="width: 5%" align="center">
                        <img src="FileSystem/images/Folder_Root.gif" /></td>
                    <td style="width: 467px">
                        <asp:HyperLink ID="hlGoRoot" runat="server" NavigateUrl="~/manage/view.aspx">回到主目录</asp:HyperLink></td>
                    <td style="color: #000000">
                    </td>
                    <td style="color: #000000">
                    </td>
                    <td style="color: #000000">
                    </td>
                </tr>
                <tr style="color: #000000">
                    <td style="width: 5%" align="center">
                        <img src="FileSystem/images/Folder_Parent.gif" /></td>
                    <td style="width: 467px">
                        <asp:LinkButton ID="lbGoParent" runat="server" OnClick="lbGoParent_Click">回到父目录</asp:LinkButton></td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <asp:Repeater OnItemCommand="rptFolder_Command" ID="rptFolder" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td width="5%" align="center" valign="middle">
                                <img height="16" src="FileSystem/images/Folder.gif" width="16" />
                            </td>
                            <td>
                                <a href="View.aspx?path=<%# Eval("FolderPath")%>">
                                    <%#Eval("FolderName") %>
                                </a>
                            </td>
                            <td align="center" width="10%">
                                <%#Eval("FolderSize") %>
                                &nbsp;KB
                            </td>
                            <td align="center" style="width: 10%">
                                <%#Eval("FolderCreateTime") %>
                            </td>
                            <td align="center" style="width: 5%" id="TD2">
                                <asp:ImageButton ID="ibtnRptDelFile" OnClientClick="return confirm('确定删除所有子文件？')" ImageUrl="images/delete.gif"
                                    CommandArgument='<%# Eval("FolderPath") %>' runat="server" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:Repeater ID="rptFile" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="width: 5%" align="center" valign="middle">
                                <img style="height: 16" src="FileSystem/images/f_dbx.gif" width="16" />
                            </td>
                            <td>
                                <a id="A1" runat="server" href='<%# Eval("FilePath")%>'
                                    target="_blank" style="color: Black">
                                    <%# Eval("FileName") %>
                                </a>[<a onclick='showurl(this)' style="color: Blue; cursor: hand;" value="<%# Eval("FilePath") %>">取得URL</a>]
                            </td>
                            <td align="center" style="width: 10%">
                                <%# Eval("FileSize") %>
                                &nbsp;KB
                            </td>
                            <td align="center" style="width: 10%">
                                <%# Eval("FileCreateTime") %>
                            </td>
                            <td id="tb" align="center" style="width: 5%">
                                <input id="file_cb" runat="server" type="checkbox" value='<%# Eval("FilePath") %>'
                                    name="cb" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td align="right" valign="top" colspan="5">
                        <asp:ImageButton ID="ibtnDel" runat="server" ImageUrl="images/DelFile.gif" OnClick="ibtnDel_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
