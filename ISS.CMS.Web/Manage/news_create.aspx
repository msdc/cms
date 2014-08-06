<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news_create.aspx.cs" Inherits="Manage_news_createhtml" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="style/ManageStyle.css" rel="stylesheet" type="text/css" />

    <script>
        function classrashow(i) {
            whichdiv = eval("classradiv" + i);
            if (whichdiv.style.display == "none") {
                whichdiv.style.display = "";
            }
            else if (whichdiv.style.display == "") {
                whichdiv.style.display = "none";
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 10px">
            <table width="100%" style="background-color: #cccccc" border="0" cellpadding="2"
                cellspacing="1">
                <tr>
                    <td height="16" colspan="2" align="center" class="BarTitleBg">
                        生成静态页面</td>
                </tr>
                <tr>
                    <td height="16" colspan="2">
                            &nbsp;<input id="time_ra" runat="server" name="ra" type="radio" checked="true" /><strong>生成一段时间内的所有资源</strong>
                    </td>
                </tr>
                <tr>
                    <td width="17%" align="right">
                        根据：</td>
                    <td width="83%">
                        <asp:DropDownList ID="time_dll" runat="server" CssClass="Input">
                            <asp:ListItem Value="uptime">最后更新时间</asp:ListItem>
                            <asp:ListItem Value="addtime">资源创建时间</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td align="right">
                        起始时间：</td>
                    <td width="83%">
                        <asp:DropDownList ID="startyear_dll" runat="server" CssClass="Input" Width="60px">
                            <asp:ListItem Value="2012">2012</asp:ListItem>
                            <asp:ListItem Value="2013">2013</asp:ListItem>
                        </asp:DropDownList>&nbsp;－&nbsp;<asp:DropDownList ID="startmonth_dll" runat="server"
                            CssClass="Input" Width="32px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                        </asp:DropDownList>
                        －&nbsp;<asp:DropDownList ID="startday_dll" runat="server" CssClass="Input">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                        </asp:DropDownList>
                        (&nbsp;<asp:DropDownList ID="starthour_dll" runat="server" CssClass="Input">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                        </asp:DropDownList>
                        时&nbsp;<asp:DropDownList ID="startminute_dll" runat="server" CssClass="Input">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="5"></asp:ListItem>
                            <asp:ListItem Value="6"></asp:ListItem>
                            <asp:ListItem Value="7"></asp:ListItem>
                            <asp:ListItem Value="8"></asp:ListItem>
                            <asp:ListItem Value="9"></asp:ListItem>
                            <asp:ListItem Value="10"></asp:ListItem>
                            <asp:ListItem Value="11"></asp:ListItem>
                            <asp:ListItem Value="12"></asp:ListItem>
                            <asp:ListItem Value="13"></asp:ListItem>
                            <asp:ListItem Value="14"></asp:ListItem>
                            <asp:ListItem Value="15"></asp:ListItem>
                            <asp:ListItem Value="16"></asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                            <asp:ListItem>32</asp:ListItem>
                            <asp:ListItem>33</asp:ListItem>
                            <asp:ListItem>34</asp:ListItem>
                            <asp:ListItem>35</asp:ListItem>
                            <asp:ListItem>36</asp:ListItem>
                            <asp:ListItem>37</asp:ListItem>
                            <asp:ListItem>38</asp:ListItem>
                            <asp:ListItem>39</asp:ListItem>
                            <asp:ListItem>40</asp:ListItem>
                            <asp:ListItem>41</asp:ListItem>
                            <asp:ListItem>42</asp:ListItem>
                            <asp:ListItem>43</asp:ListItem>
                            <asp:ListItem>44</asp:ListItem>
                            <asp:ListItem>45</asp:ListItem>
                            <asp:ListItem>46</asp:ListItem>
                            <asp:ListItem>47</asp:ListItem>
                            <asp:ListItem>48</asp:ListItem>
                            <asp:ListItem>49</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>51</asp:ListItem>
                            <asp:ListItem>52</asp:ListItem>
                            <asp:ListItem>53</asp:ListItem>
                            <asp:ListItem>54</asp:ListItem>
                            <asp:ListItem>55</asp:ListItem>
                            <asp:ListItem>56</asp:ListItem>
                            <asp:ListItem>57</asp:ListItem>
                            <asp:ListItem>58</asp:ListItem>
                            <asp:ListItem>59</asp:ListItem>
                        </asp:DropDownList>
                        分)</td>
                </tr>
                <tr>
                    <td align="right">
                        结束时间：</td>
                    <td>
                        <asp:DropDownList ID="endyear_dll" runat="server" CssClass="Input" Width="60px">
                            <asp:ListItem Value="2012">2012</asp:ListItem>
                            <asp:ListItem Value="2013">2013</asp:ListItem>
                        </asp:DropDownList>
                        －&nbsp;<asp:DropDownList ID="endmonth_dll" runat="server" CssClass="Input" Width="32px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                        </asp:DropDownList>
                        －&nbsp;<asp:DropDownList ID="endday_dll" runat="server" CssClass="Input">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                        </asp:DropDownList>
                        (&nbsp;<asp:DropDownList ID="endhour_dll" runat="server" CssClass="Input">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem Selected="True">23</asp:ListItem>
                        </asp:DropDownList>
                        时
                        <asp:DropDownList ID="endminute_dll" runat="server" CssClass="Input">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="5"></asp:ListItem>
                            <asp:ListItem Value="6"></asp:ListItem>
                            <asp:ListItem Value="7"></asp:ListItem>
                            <asp:ListItem Value="8"></asp:ListItem>
                            <asp:ListItem Value="9"></asp:ListItem>
                            <asp:ListItem Value="10"></asp:ListItem>
                            <asp:ListItem Value="11"></asp:ListItem>
                            <asp:ListItem Value="12"></asp:ListItem>
                            <asp:ListItem Value="13"></asp:ListItem>
                            <asp:ListItem Value="14"></asp:ListItem>
                            <asp:ListItem Value="15"></asp:ListItem>
                            <asp:ListItem Value="16"></asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>21</asp:ListItem>
                            <asp:ListItem>22</asp:ListItem>
                            <asp:ListItem>23</asp:ListItem>
                            <asp:ListItem>24</asp:ListItem>
                            <asp:ListItem>25</asp:ListItem>
                            <asp:ListItem>26</asp:ListItem>
                            <asp:ListItem>27</asp:ListItem>
                            <asp:ListItem>28</asp:ListItem>
                            <asp:ListItem>29</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>31</asp:ListItem>
                            <asp:ListItem>32</asp:ListItem>
                            <asp:ListItem>33</asp:ListItem>
                            <asp:ListItem>34</asp:ListItem>
                            <asp:ListItem>35</asp:ListItem>
                            <asp:ListItem>36</asp:ListItem>
                            <asp:ListItem>37</asp:ListItem>
                            <asp:ListItem>38</asp:ListItem>
                            <asp:ListItem>39</asp:ListItem>
                            <asp:ListItem>40</asp:ListItem>
                            <asp:ListItem>41</asp:ListItem>
                            <asp:ListItem>42</asp:ListItem>
                            <asp:ListItem>43</asp:ListItem>
                            <asp:ListItem>44</asp:ListItem>
                            <asp:ListItem>45</asp:ListItem>
                            <asp:ListItem>46</asp:ListItem>
                            <asp:ListItem>47</asp:ListItem>
                            <asp:ListItem>48</asp:ListItem>
                            <asp:ListItem>49</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>51</asp:ListItem>
                            <asp:ListItem>52</asp:ListItem>
                            <asp:ListItem>53</asp:ListItem>
                            <asp:ListItem>54</asp:ListItem>
                            <asp:ListItem>55</asp:ListItem>
                            <asp:ListItem>56</asp:ListItem>
                            <asp:ListItem>57</asp:ListItem>
                            <asp:ListItem>58</asp:ListItem>
                            <asp:ListItem Selected="True">59</asp:ListItem>
                        </asp:DropDownList>
                        分)</td>
                </tr>
                <tr>
                    <td colspan="2" id="td2">
                        &nbsp;<input id="class_ra" name="ra" runat="server" type="radio" /><strong>生成指定栏目的资源</strong>
                    </td>
                </tr>
                <tr>
                    <td align="right" valign="top">
                        请选择模板：</td>
                    <td>
                        <asp:TreeView ID="class_tree" runat="server" ShowLines="True">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <strong>公共选项：</strong></td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right">
                        资源范围：</td>
                    <td>
                        <asp:RadioButtonList ID="rblCreate" runat="server" CssClass="Input" RepeatColumns="2"
                            Width="313px">
                            <asp:ListItem Selected="true" Value="false">未生成与已生成的资源</asp:ListItem>
                            <asp:ListItem Value="true">仅未成生过的资源</asp:ListItem>
                        </asp:RadioButtonList></td>
                </tr>
                <tr>
                    <td align="right">
                        限定数目：</td>
                    <td>
                        <asp:TextBox ID="tbNum" runat="server" CssClass="Input" Width="60px">100</asp:TextBox>条资源
                        (为'0'则表示不限数目)
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" class="EditInput">
                        <table>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lbSubmit" OnClick="Button1_Click" runat="server">确 定</asp:LinkButton>
                                </td>
                                <td>
                                    <a href="###" onclick="window.history.back();">返 回</a>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
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
                                ·生成指定栏目的资源</td>
                        </tr>
                        <tr>
                            <td>
                                <p>
                                    系统只生成当前所选栏目的所有资源（不含子栏目）</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>
                                    ·<font color="#339900">系统规定以下情况的资源不被生成</font></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                1.“未审核”的资源 2.“回收站”内的资源</td>
                        </tr>
                        <tr>
                            <td>
                                ·生成建议</td>
                        </tr>
                        <tr>
                            <td>
                                由于资源生成将频繁对服务器硬盘进行I/0操作，并占用大量系统资源，因此请尽可能地缩小要生成的资源范围，从而提高生成速度，减轻服务器负担。</td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                    <a name="Help"></a>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

