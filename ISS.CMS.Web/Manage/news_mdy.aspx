<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news_mdy.aspx.cs" Inherits="Manage_news_mdy" %>

<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />
</head>

<script language="javascript" type="text/jscript">
    function scrollImg() {
        var posX, posY;
        if (window.innerHeight) {
            posX = window.pageXOffset;
            posY = window.pageYOffset;

        }
        else if (document.documentElement && document.documentElement.scrollTop) {
            posX = document.documentElement.scrollLeft;
            posY = document.documentElement.scrollTop;
        }
        else if (document.body) {
            posX = document.body.scrollLeft;
            posY = document.body.scrollTop;
        }

        var ad = document.getElementById("ad");
        ad.style.top = (posY) + "px";
        ad.style.left = (posX + 470) + "px";
        setTimeout("scrollImg()", 10);
    }
    function TreeSingleSelect(treeID, checkNode) {
        if (!treeID)
            return;
        var objs = document.getElementsByTagName("input");
        for (var i = 0; i < objs.length; i++) {
            if (objs[i].type == 'checkbox') {
                var obj = objs[i];
                if (obj.id.indexOf(treeID) != -1) {
                    if (obj != checkNode) {
                        obj.checked = false;
                    }
                }
            }
        }
    }
    function TreeSingleSelect1(treeID, checkNode) {
        var kkc = -1;
        if (!treeID)
            return;
        var objs = document.getElementsByTagName("input");
        for (var i = 0; i < objs.length; i++) {
            if (objs[i].type == 'checkbox') {
                var obj = objs[i];
                if (obj.name.indexOf(treeID) != -1) {
                    if (obj.checked) {
                        kkc = 0;
                        break;
                    }
                    else {
                        kkc = 1;
                    }
                }

            }
        }
        if (kkc == 1) {
            alert("请选择类别");
            return false;
        }
        else {
            return true;
        }
    }

    function SetTreeNodeClickHander(treeID) {
        var objs = document.getElementsByTagName("input");
        for (var i = 0; i < objs.length; i++) {
            if (objs[i].type == 'checkbox') {
                var obj = objs[i];
                if (obj.id.indexOf(treeID) != -1) {
                    objs[i].onclick = function () { TreeSingleSelect(treeID, this); };
                }
            }
        }
    }

</script>

<body>
    <form id="form1" runat="server">
        <div style="margin: 10px;">
            <table style="background-color: #cccccc" border="0" cellpadding="2" cellspacing="1"
                width="100%">
                <tr>
                    <td class="BarTitleBg" align="center" colspan="2">
                        <asp:Label ID="state_lbl" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        资源类型：</td>
                    <td>
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                            <tr>
                                <td style="width: 366px; height: 19px">
                                    <asp:TreeView ID="tvTemplate" runat="server" ShowLines="True">
                                    </asp:TreeView>
                                </td>
                                <td align="right" valign="top" style="height: 19px">
                                    <asp:CheckBox ID="class_memory" runat="server" Text="记忆" />
                                </td>
                            </tr>
                        </table>

                        <script type="text/javascript" language="javascript">
                            SetTreeNodeClickHander("tvClass");
                        </script>

                    </td>
                </tr>
                <tr>
                    <td style="width: 30%">
                        资源标题：</td>
                    <td>
                        <asp:TextBox ID="title_tb" runat="server" CssClass="Input" Width="375px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        跳转链接：</td>
                    <td>
                        <asp:TextBox ID="url_tb" runat="server" CssClass="Input" Width="375px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        资源作者：</td>
                    <td>
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%;">
                            <tr>
                                <td>
                                    <asp:DropDownList ID="author_ddl" CssClass="Input" runat="server">
                                    </asp:DropDownList></td>
                                <td align="right" valign="top">
                                    <asp:CheckBox ID="author_memory" runat="server" Text="记忆" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        来源：</td>
                    <td>
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%;">
                            <tr>
                                <td>
                                    <asp:DropDownList ID="from_ddl" CssClass="Input" runat="server">
                                    </asp:DropDownList></td>
                                <td align="right" valign="top">
                                    <asp:CheckBox ID="from_memory" runat="server" Text="记忆" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        责任编辑：</td>
                    <td>
                        <asp:TextBox ID="edit_tb" runat="server" CssClass="Input" Width="136px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        关键字：</td>
                    <td>
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                            <tr>
                                <td>
                                    <asp:TextBox ID="keyword_tb" runat="server" CssClass="Input" Width="250px"></asp:TextBox></td>
                                <td align="right" valign="top">
                                    <asp:CheckBox ID="keyword_memory" runat="server" Text="记忆" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        点击量：</td>
                    <td>
                        <input id="count_tb" runat="server" class="Input" type="text" style="width: 70px"
                            value="0" /></td>
                </tr>
                <tr>
                    <td valign="top">
                        资源特性：</td>
                    <td>
                        <asp:TreeView ID="tvSpeciality" runat="server" ShowLines="True">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>资源内容：</span></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <CE:Editor ID="content_cute" runat="server" AutoConfigure="Full" FilesPath="~/CuteSoft_Client/CuteEditor/" EditorWysiwygModeCss="style/example.css" ThemeType="Office2007" CustomCulture="zh-cn" >
                        </CE:Editor>
                        <%--<CE:Editor ID="content_cute" runat="server" Height="400px" Width="100%" BreakElement="P"
                            AutoConfigure="Simple" FilesPath="~/wedcvgu1k5k/CuteEditor">
                            <FrameStyle BackColor="White" BorderStyle="Solid" Width="100%" Height="100%" CssClass="CuteEditorFrame"
                                BorderWidth="1px" BorderColor="#DDDDDD"></FrameStyle>
                        </CE:Editor>--%>
                        </td>
                </tr>
                <tr>
                    <td>
                        小图：</td>
                    <td>
                        <asp:TextBox ID="smallimg_tb" runat="server" CssClass="Input" Width="338px"></asp:TextBox>&nbsp;
                        <input id="Button7" type="button" onclick="window.open('view.aspx', 'newwindoe', 'width=700,height=400,top=1,left=1, toolbar=no,menubar=no,scrollbars=yes,resizable=no,location=no,status=no')"
                            value="..." /></td>
                </tr>
                <tr>
                    <td>
                        大图：</td>
                    <td>
                        <asp:TextBox ID="bigimg_tb" runat="server" CssClass="Input" Width="338px"></asp:TextBox>&nbsp;
                        <input type="button" onclick="window.open('view.aspx', 'newwindoe', 'width=600,height=300,top=1,left=1, toolbar=no,menubar=no,scrollbars=yes,resizable=no,location=no,status=no')"
                            value="..." /></td>
                </tr>
                <tr>
                    <td>
                        附属信息一：</td>
                    <td>
                        <asp:TextBox ID="tbField1" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        附属信息二：</td>
                    <td>
                        <asp:TextBox ID="tbField2" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        特性名称：</td>
                    <td>
                        <asp:TextBox ID="tbField3" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        添加时间：</td>
                    <td>
                        <asp:TextBox ID="tbAddtime" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        更新时间：</td>
                    <td>
                        <asp:TextBox ID="tbUptime" runat="server" CssClass="Input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <span>资源摘要：</span></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <CE:Editor ID="shortcontent_tb" runat="server" AutoConfigure="Minimal" Height="127px" EditorOnPaste="ConfirmWord" FilesPath="~/CuteSoft_Client/CuteEditor/" EditorWysiwygModeCss="style/example.css" ThemeType="Office2007" CustomCulture="zh-cn" >
                        </CE:Editor>
                        <%--<CE:Editor ID="shortcontent_tb" runat="server" Height="127px" Width="100%" BreakElement="P"
                            AutoConfigure="Minimal" EditorOnPaste="ConfirmWord" FilesPath="~/wedcvgu1k5k/CuteEditor">
                            <FrameStyle BackColor="White" BorderColor="#DDDDDD" BorderStyle="Solid" BorderWidth="1px"
                                CssClass="CuteEditorFrame" Height="100%" Width="100%" />
                        </CE:Editor>--%>
                    </td>
                </tr>
                <tr id="trCreate" runat="server">
                    <td>
                        生成资源：</td>
                    <td>
                        <asp:CheckBox ID="create_cb" runat="server" Text="生成资源" TextAlign="Left" />&nbsp;</td>
                </tr>
            </table>
        </div>
        <div style="margin: 10px;">
            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td bgcolor="#f6f6f6" colspan="2" onclick="if(HelpTab.style.display=='none'){HelpTab.style.display='';window.scrollTo(window.pageXOffset,2000);}else{HelpTab.style.display='none'}"
                        style="cursor: hand">
                        &nbsp;<img height="14" src="Images/Manage/why.gif" width="14" />
                        ::Help::</td>
                </tr>
                <tr id="HelpTab" style="display: none">
                    <td width="2%">
                        &nbsp;</td>
                    <td valign="top" width="98%">
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td>
                                    ·生成/更新静态文件:</td>
                            </tr>
                            <tr>
                                <td>
                                    未审核的资源不能执行此操作</td>
                            </tr>
                            <tr>
                                <td>
                                    ·'删除'、'求回'、'彻底删除'</td>
                            </tr>
                            <tr>
                                <td>
                                    1.'删除':保将记录在逻辑标记为'已删除',可通过'回收站'中救回该记录。'删除'的同时系统也将相对应的静态资源文件进行删除</td>
                            </tr>
                            <tr>
                                <td>
                                    2.'彻底删除':将无法挽回被'彻底删除'的资源记录</td>
                            </tr>
                            <tr>
                                <td>
                                    ·自动分页标签:</td>
                            </tr>
                            <tr>
                                <td>
                                    将该标签放入相应的Html源码位置当中,系统就以该分页标签所在位置将资源内容分割成多个页面进行生成</td>
                            </tr>
                            <tr>
                                <td>
                                    ·跳转链接:</td>
                            </tr>
                            <tr>
                                <td>
                                    允许资源在被点击后直接跳转到指定的[跳转链接]地址，若不使用此功能请置空。</td>
                            </tr>
                            <tr>
                                <td>
                                    ·资源标题样式:</td>
                            </tr>
                            <tr>
                                <td>
                                    资源标题允许使用Html标签进行色彩、风格的设定，如：“&lt;font color='red'&gt;××××新闻标题&lt;/font&gt;”，但注意，所有的双引号必须改成单引号。</td>
                            </tr>
                        </table>
                        <a name="Help"></a>
                    </td>
                </tr>
            </table>
        </div>
        <div id="ad" style="position: absolute; width: 400px; height: 30px; text-align: center;
            background: transparence;">
            <ul>
                <li class="EditInput" style="float: left">
                    <asp:LinkButton ID="lbSubmit" OnClick="Button1_Click" OnClientClick="return TreeSingleSelect1('tvClass')"
                        runat="server">确 定</asp:LinkButton></li>
                <li class="EditInput" style="float: left"><a href="javascript:history.back()">返 回</a></li>
                <li class="EditInput" style="float: left">
                    <asp:CheckBox ID="del_cb" runat="server" Text="彻底删除" Font-Size="Small" />
                </li>
                <li class="EditInput" style="float: left">
                    <asp:LinkButton ID="lbDel" OnClientClick="return confirm('确认删除？')" runat="server" OnClick="lbDel_Click">删 除</asp:LinkButton>
                </li>
            </ul>
        </div>

        <script type="text/javascript">
            scrollImg();
        </script>

    </form>
</body>
</html>
