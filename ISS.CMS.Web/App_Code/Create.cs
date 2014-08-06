using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using ISS.CMS.BLL;
using ISS.CMS.Model;
using System.Text;

/// <summary>
/// Summary description for Create
/// </summary>
public class Create
{

    public Create()
    {

    }
    public static int dir(string id)
    {
        try
        {
            string filename;
            //sql = "select * from [tsys_newsView] where id in (" + id + ")";
            //DataTable dt = DbHelperSQL.Query(sql).Tables[0];

            DataSet ds = NewsViewBLL.GetListById(id);
            if (ds == null) return 0;
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string year = Convert.ToDateTime(dt.Rows[0]["addtime"].ToString()).Year.ToString();
                string date = Convert.ToDateTime(dt.Rows[0]["addtime"]).Month.ToString() + Convert.ToDateTime(dt.Rows[0]["addtime"]).Day.ToString();
                string src = Path.GetDirectoryName(System.Web.HttpContext.Current.Server.MapPath("~" + dt.Rows[0]["FilePath"].ToString()));

                if (Directory.Exists(src))
                {
                    if (Directory.Exists(src + "/" + year))
                    {
                        if (Directory.Exists(src + "/" + year + "/" + date))
                        {
                            File.Create(src + "/" + year + "/" + date + "/" + dt.Rows[i]["id"].ToString() + site.FileExtension).Dispose();
                        }
                        else
                        {
                            Directory.CreateDirectory(src + "/" + year + "/" + date);
                            File.Create(src + "/" + year + "/" + date + "/" + dt.Rows[i]["id"].ToString() + site.FileExtension).Dispose();
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(src + "/" + year);
                        Directory.CreateDirectory(src + "/" + year + "/" + date);
                        File.Create(src + "/" + year + "/" + date + "/" + dt.Rows[i]["id"].ToString() + site.FileExtension).Dispose();
                    }
                }
                else
                {
                    //self.alertend("无此目录，请创建后再生成资源！");
                }
                filename = src + "/" + year + "/" + date + "/" + dt.Rows[i]["id"].ToString() + site.FileExtension;
                content(dt.Rows[i]["id"].ToString(), filename, dt.Rows[i]["FilePath"].ToString() + "/" + year + "/" + date + "/" + dt.Rows[i]["id"].ToString() + site.FileExtension);
            }
            return dt.Rows.Count;
        }
        catch (Exception e)
        {
            self.alert("生成资源页面出错！ -- " + e.Message);
            return 0;
        }
    }

    private static void content(string id, string filename, string filepath)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.GetEncoding("UTF-8")))//by han
            {
                sw.WriteLine(biaoji(id));
                sw.Flush();
                sw.Close();
                //string sql;
                //sql = "update [tsys_newsView] set IsCreate = 1,IsCheck = 1,filepath = '" + filepath + "' where id = " + id;
                //DbHelperSQL.ExecuteSql(sql);
                NewsViewBLL.Update(new string[] { "isCreate", "IsCheck", "filepath" }, new string[] { "1", "1", filepath }, "id=" + id);


            }
        }
        catch (Exception e)
        {
            self.alertend("向静态文件写入数据出错！ -- " + e.Message);
        }

    }

    private static string biaoji(string id)
    {
        string text;
        //string sql = "select * from [tsys_newsView] where id = " + id;
        //DataTable dt = DbHelperSQL.Query(sql).Tables[0];

        DataSet ds = NewsViewBLL.GetListById(id);
        if (ds == null) return "";
        DataTable dt = ds.Tables[0];
        DataRow dr = dt.Rows[0];
        //string templateSql = "select Content from [tsys_Template] where id = " + dt.Rows[0]["Class"].ToString();
        //text = DbHelperSQL.GetSingle(templateSql).ToString();//text = dr["templatecontent"].ToString();by han
        DataTable dt1 = TemplateBLL.GetTemplateById(dt.Rows[0]["Class"].ToString()).Tables[0];
        text = dt1.Rows[0]["Content"].ToString();
        if (text.Contains("$Id$"))
        {
            text = text.Replace("$Id$", dr["id"].ToString());
        }
        if (text.Contains("$Title$"))
        {
            text = text.Replace("$Title$", dr["title"].ToString());
        }
        if (text.Contains("$Content$"))
        {
            text = text.Replace("$Content$", dr["content"].ToString());
        }
        if (text.Contains("$Author$"))
        {
            text = text.Replace("$Author$", dr["authortitle"].ToString());
        }
        if (text.Contains("$From$"))
        {
            text = text.Replace("$From$", dr["fromtitle"].ToString());
        }
        if (text.Contains("$KeyWord$"))
        {
            text = text.Replace("$KeyWord$", dr["keyword"].ToString());
        }
        if (text.Contains("$Editor$"))
        {
            text = text.Replace("$Editor$", dr["editor"].ToString());
        }
        if (text.Contains("$SmallImg$"))
        {
            text = text.Replace("$SmallImg$", dr["smallimg"].ToString());
        }
        if (text.Contains("$BigImg$"))
        {
            text = text.Replace("$BigImg$", dr["bigimg"].ToString());
        }
        if (text.Contains("$ShortContent$"))
        {
            text = text.Replace("$ShortContent$", dr["shortcontent"].ToString());
        }
        if (text.Contains("$AddTime$"))
        {
            text = text.Replace("$AddTime$", Convert.ToDateTime(dr["addtime"]).ToShortDateString());
        }
        if (text.Contains("$Year$"))
        {
            string strYear = Convert.ToDateTime(dt.Rows[0]["addtime"]).Year.ToString().PadLeft(2, '0');
            text = text.Replace("$Year$", strYear);
        }
        if (text.Contains("$Month$"))
        {
            string strMonth = Convert.ToDateTime(dt.Rows[0]["addtime"]).Month.ToString().PadLeft(2, '0');
            text = text.Replace("$Month$", strMonth);
        }
        if (text.Contains("$Day$"))
        {
            string strDay = Convert.ToDateTime(dt.Rows[0]["addtime"]).Day.ToString().PadLeft(2, '0');
            text = text.Replace("$Day$", strDay);
        }
        if (text.Contains("$UpTime$"))
        {
            text = text.Replace("$UpTime$", Convert.ToDateTime(dt.Rows[0]["uptime"]).ToShortDateString());
        }
        if (text.Contains("$Count$"))
        {
            text = text.Replace("$Count$", dt.Rows[0]["count"].ToString());
        }
        if (text.Contains("$ClassTitle$"))
        {
            text = text.Replace("$ClassTitle$", dt.Rows[0]["classtitle"].ToString());
        }
        if (text.Contains("$ClassTitle2$"))
        {
            text = text.Replace("$ClassTitle2$", dt.Rows[0]["classtitle"].ToString());
        }
        if (text.Contains("$ClassId$"))
        {
            text = text.Replace("$ClassId$", dt.Rows[0]["Class"].ToString());
        }
        if (text.Contains("$Field1$"))
        {
            text = text.Replace("$Field1$", dt.Rows[0]["Field1"].ToString());
        }
        if (text.Contains("$Field2$"))
        {
            text = text.Replace("$Field2$", dt.Rows[0]["Field2"].ToString());
        }
        if (text.Contains("$Field3$"))
        {
            text = text.Replace("$Field3$", dt.Rows[0]["Field3"].ToString());
        }
        return text;
    }

    #region 动态模板生成
    public static void DynamicCreate(string id)
    {
        string[] id_arr;
        id_arr = id.Split(',');
        for (int i = 0; i < id_arr.Length; i++)
        {
            SqlCreate(Convert.ToInt32(id_arr[i]));
        }
    }
    #endregion
    #region 生成SQL语句
    private static void SqlCreate(int id)
    {
        string sql, datasql, datacount;
        string strSqlWhere = "[IsCheck] <> 0 AND [IsCreate] <> 0 AND IsDel = 0 ";
        string strSqlOrder = "";
        
        string[] fieldNames=new string[5];

        DynamicInsert di = DynamicInsertBLL.GetModel(id);
        if (di.speciality != "-1" && di.speciality != "")
        {
            string[] arrSpeciality = di.speciality.Split(',');
            for (int i = 0; i < arrSpeciality.Length; i++)
            {
                if (i == 0)
                {
                    strSqlWhere += "AND ','+speciality+',' LIKE '%," + arrSpeciality[i] + ",%' ";
                }
                else
                {
                    strSqlWhere += "OR ','+speciality+',' LIKE '%," + arrSpeciality[i] + ",%' ";
                }
            }
        }
        if (di.classw == "")
        {
            strSqlWhere += "AND [class] = 0 ";
        }
        else
        {
            strSqlWhere += "AND [class] IN (" + di.classw + ") ";
        }
        strSqlOrder += "ORDER BY " + di.bytime + " " + di.bysort;

        if (di.ispage)
        {
            
            DataSet dsNewsView = NewsViewBLL.GetList(strSqlWhere + strSqlOrder);
            PageOnCreate(dsNewsView.Tables[0], dsNewsView.Tables[0].Rows.Count, di.looptime.ToString(), di.content, di.pagecontent, 
                "", di.startelement, di.endelement, di.filelist, di.Encoding, Convert.ToInt32(di.Length), Convert.ToInt32(di.PageNumber));
        }
        else
        {
            //datasql = "SELECT TOP " + dt.Rows[0]["looptime"].ToString() + " * FROM [tsys_newsView] WHERE " + strSqlWhere + strSqlOrder;
            DataSet dsNewsView = NewsViewBLL.GetList(strSqlWhere + strSqlOrder);
            PageOffCreate(dsNewsView.Tables[0], di.content, di.startelement, di.endelement, di.filelist, di.Encoding, Convert.ToInt32(di.Length));
        }
    }
    #endregion
   
    #region 分页开启时生成模板
    private static void PageOnCreate(DataTable paraNewsView, int parDataCount, string parPageSize, string parLoopContent, string parPageContent, string pagepath_p, string parStart, string parEnd, string parFileList, string parEncoding, int parLength, int parPageNumber)
    {
        int DataCount = 0;// 资源总条数
        int PageSize; // 每页资源数
        int PageCount; // 分页数
        string loopcontent = parLoopContent; // 资源列表内容
        string PageContent = ""; // 分页内容
        string text = ""; // 模板内容 
        string strPageTagStart = "<!--page:start-->";
        string strPageTagEnd = "<!--page:end-->";
        string sql, line;
        string[] arrFileList = parFileList.Split('\n');
        DataCount = parDataCount;
        DataTable dt = new DataTable();
        if (DataCount > 0)
        {
            dt = paraNewsView;
        }
        for (int k = 0; k < arrFileList.Length; k++)
        {
            StringBuilder htmltext = new StringBuilder();
            try
            {
                using (StreamReader sr = new StreamReader(
                    HttpContext.Current.Server.MapPath("~/" + arrFileList[k].Trim()),
                    parEncoding == "UTF" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312"))
                    )
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        htmltext.Append(line + "\n");
                    }
                    text = htmltext.ToString();
                    sr.Close();
                }
            }
            catch
            {
                self.alertend("读取静态文件出错，可能由于文件路径错误造成的！");
                return;
            }

            PageSize = int.Parse(parPageSize);

            int numTag = text.IndexOf(parStart);
            int numTag2 = text.LastIndexOf(parStart);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parStart + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parStart + "  标签被重复使用！");
                return;
            }

            numTag = text.IndexOf(parEnd);
            numTag2 = text.LastIndexOf(parEnd);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parEnd + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parEnd + "  标签被重复使用！");
                return;
            }

            numTag = text.IndexOf(strPageTagStart);
            numTag2 = text.LastIndexOf(strPageTagStart);
            if (numTag == -1)
            {
                self.alertend("页面无 " + strPageTagStart + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(strPageTagStart + " 标签被重复使用！");
                return;
            }

            numTag = text.IndexOf(strPageTagEnd);
            numTag2 = text.LastIndexOf(strPageTagEnd);
            if (numTag == -1)
            {
                self.alertend("页面无 " + strPageTagEnd + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(strPageTagEnd + " 标签被重复使用！");
                return;
            }

            if (DataCount % PageSize == 0)
            {
                PageCount = DataCount / PageSize;
            }
            else
            {
                PageCount = DataCount / PageSize + 1;
            }
            for (int i = 0; i < PageCount; i++)
            {
                string filename = arrFileList[k].Trim().Remove(arrFileList[k].Trim().LastIndexOf('.'));
                filename = filename.Substring(filename.LastIndexOf("/") + 1, filename.Length - (filename.LastIndexOf("/") + 1));
                string filepath = arrFileList[k].Trim().Remove(arrFileList[k].Trim().LastIndexOf("/") + 1);

                loopcontent = tagchange(dt, i, PageSize, PageCount, parLoopContent, parLength);
                int numContentTagIndex = text.IndexOf(parStart) + parStart.Length;
                int numContentTagLastIndex = text.IndexOf(parEnd) - numContentTagIndex;
                text = text.Remove(numContentTagIndex, numContentTagLastIndex);
                text = text.Insert(numContentTagIndex, "\n" + loopcontent + "\n");

                PageContent = pagetagchange(DataCount, i + 1, PageSize, PageCount, parPageContent, filename, parPageNumber);
                int numPageTagIndex = text.IndexOf(strPageTagStart) + strPageTagStart.Length;
                int numPageTagLastIndex = text.IndexOf(strPageTagEnd) - numPageTagIndex;
                text = text.Remove(numPageTagIndex, numPageTagLastIndex);
                text = text.Insert(numPageTagIndex, "\n" + PageContent + "\n");
                try
                {


                    string strFullName = "";
                    if (i == 0)
                    {
                        strFullName = "~/" + arrFileList[k].Trim();
                    }
                    else
                    {
                        strFullName = "~/" + filepath + filename + "_" + (i + 1) + site.FileExtension;
                    }
                    using (
                            StreamWriter sw = new StreamWriter
                                                    (
                                                    HttpContext.Current.Server.MapPath(strFullName),
                                                    false,
                                                    parEncoding == "UTF" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312")
                                                    )
                            )
                    {
                        sw.WriteLine(text);
                        sw.Flush();
                        sw.Close();
                    }
                }
                catch
                {
                    self.alertend("写入静态文件出错！");
                    return;
                }
            }
        }

    }
    #endregion

    #region 分页页码标记替换
    private static string pagetagchange(int parDataCount, int parPageIndex, int parPageSize, int parPageCount, string parPageContent, string parFileName, int parPageNumber)
    {
        string strPageContent = parPageContent;
        int numPageIndex = parPageIndex;
        if (parPageContent.Contains("$PageNumber$") && parPageNumber > 0)
        {
            string strPageNumberContent = "";
            int numMidNumber;
            if (parPageNumber % 2 == 0)
            {
                numMidNumber = parPageNumber / 2;
            }
            else
            {
                numMidNumber = parPageNumber / 2 + 1;
            }

            if (parPageCount <= parPageNumber)
            {
                for (int i = 0, tmpPageIndex = parPageIndex; i < parPageNumber && i < parPageCount; i++, tmpPageIndex++)
                {
                    if (i != parPageIndex - 1)
                    {
                        if (i == 0)
                        {
                            strPageNumberContent += "<a href=\"" + parFileName + site.FileExtension + "\">" + (i + 1) + "</a>";
                        }
                        else
                        {
                            strPageNumberContent += "<a href=\"" + parFileName + "_" + (i + 1) + site.FileExtension + "\">" + (i + 1) + "</a>";
                        }
                    }
                    else
                    {
                        strPageNumberContent += "<span class=\"current\">" + (i + 1) + "</span>";

                    }
                }
            }
            else
            {
                if (parPageIndex <= numMidNumber)
                {
                    for (int i = 0; i < parPageNumber; i++)
                    {
                        if (i != numPageIndex - 1)
                        {
                            if (i == 0)
                            {
                                strPageNumberContent += "<a href=\"" + parFileName + site.FileExtension + "\">" + (i + 1) + "</a>";
                            }
                            else
                            {
                                strPageNumberContent += "<a href=\"" + parFileName + "_" + (i + 1) + site.FileExtension + "\">" + (i + 1) + "</a>";
                            }
                        }
                        else
                        {
                            strPageNumberContent += "<span class=\"current\">" + (i + 1) + "</span>";
                        }
                    }
                    strPageNumberContent += "<span>...</span>";
                }
                else if (parPageIndex > parPageCount - numMidNumber)
                {
                    strPageNumberContent += "<span>...</span>";
                    for (int i = parPageCount - parPageNumber; i < parPageCount; i++)
                    {
                        if (i != numPageIndex - 1)
                        {
                            strPageNumberContent += "<a href=\"" + parFileName + "_" + (i + 1) + site.FileExtension + "\">" + (i + 1) + "</a>";
                        }
                        else
                        {
                            strPageNumberContent += "<span class=\"current\">" + (i + 1) + "</span>";
                        }
                    }
                }
                else
                {
                    strPageNumberContent += "<span>...</span>";
                    for (int k = 0, i = parPageIndex - numMidNumber; i < parPageIndex + numMidNumber && k < parPageNumber; i++, k++)
                    {
                        if (i != numPageIndex - 1)
                        {
                            strPageNumberContent += "<a href=\"" + parFileName + "_" + (i + 1) + site.FileExtension + "\">" + (i + 1) + "</a>";
                        }
                        else if (i == 0)
                        {
                            strPageNumberContent += "<a href=\"" + parFileName + site.FileExtension + "\">" + (i + 1) + "</a>";
                        }
                        else
                        {
                            strPageNumberContent += "<span class=\"current\">" + (i + 1) + "</span>";
                        }
                    }
                    strPageNumberContent += "<span>...</span>";
                }
            }
            int start = strPageContent.IndexOf("$PageNumber$");
            strPageContent = strPageContent.Remove(start, 12).Insert(start, strPageNumberContent);
        }

        if (parPageCount > 1)
        {
            if (numPageIndex == 1)
            {
                int start = strPageContent.IndexOf("$First$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 7).Insert(start, "###");
                }
                start = strPageContent.IndexOf("$Pre$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 5).Insert(start, "###");
                }
                start = strPageContent.IndexOf("$Next$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, parFileName + "_" + (numPageIndex + 1) + site.FileExtension);
                }
                start = strPageContent.IndexOf("$Last$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, parFileName + "_" + (parPageCount) + site.FileExtension);
                }
            }
            else if (numPageIndex == parPageCount)
            {
                int start = strPageContent.IndexOf("$First$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 7).Insert(start, parFileName + site.FileExtension);
                }
                start = strPageContent.IndexOf("$Pre$");
                if (start != -1)
                {
                    if ((numPageIndex - 2) == 0)
                    {
                        strPageContent = strPageContent.Remove(start, 5).Insert(start, parFileName + site.FileExtension);
                    }
                    else
                    {
                        strPageContent = strPageContent.Remove(start, 5).Insert(start, parFileName + "_" + (numPageIndex - 1) + site.FileExtension);
                    }
                }
                start = strPageContent.IndexOf("$Next$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, "###");
                }
                start = strPageContent.IndexOf("$Last$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, "###");
                }
            }
            else
            {
                int start = strPageContent.IndexOf("$First$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 7).Insert(start, parFileName + site.FileExtension);
                }
                start = strPageContent.IndexOf("$Pre$");
                if (start != -1)
                {
                    if (numPageIndex == 2)
                    {
                        strPageContent = strPageContent.Remove(start, 5).Insert(start, parFileName + site.FileExtension);
                    }
                    else
                    {
                        strPageContent = strPageContent.Remove(start, 5).Insert(start, parFileName + "_" + (numPageIndex - 1) + site.FileExtension);
                    }
                }
                start = strPageContent.IndexOf("$Next$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, parFileName + "_" + (numPageIndex + 1) + site.FileExtension);
                }
                start = strPageContent.IndexOf("$Last$");
                if (start != -1)
                {
                    strPageContent = strPageContent.Remove(start, 6).Insert(start, parFileName + "_" + (parPageCount) + site.FileExtension);
                }
            }
        }
        else
        {
            int start = strPageContent.IndexOf("$First$");
            if (start != -1)
            {
                strPageContent = strPageContent.Remove(start, 7).Insert(start, "###");
            }
            start = strPageContent.IndexOf("$Pre$");
            if (start != -1)
            {
                strPageContent = strPageContent.Remove(start, 5).Insert(start, "###");
            }
            start = strPageContent.IndexOf("$Next$");
            if (start != -1)
            {
                strPageContent = strPageContent.Remove(start, 6).Insert(start, "###");
            }
            start = strPageContent.IndexOf("$Last$");
            if (start != -1)
            {
                strPageContent = strPageContent.Remove(start, 6).Insert(start, "###");
            }
            strPageContent = "";
        }

        for (int i = 0; i < 10; i++)
        {
            if (strPageContent.Contains("$DataCount$"))
            {
                int start = strPageContent.IndexOf("$DataCount$");
                strPageContent = strPageContent.Remove(start, 11).Insert(start, parDataCount.ToString());
            }
            else if (strPageContent.Contains("$PageSize$"))
            {
                int start = strPageContent.IndexOf("$PageSize$");
                strPageContent = strPageContent.Remove(start, 10).Insert(start, parPageSize.ToString());
            }
            else if (strPageContent.Contains("$PageCount$"))
            {
                int start = strPageContent.IndexOf("$PageCount$");
                strPageContent = strPageContent.Remove(start, 11).Insert(start, parPageCount.ToString());
            }
            else if (strPageContent.Contains("$PageIndex$"))
            {
                int start = strPageContent.IndexOf("$PageIndex$");
                strPageContent = strPageContent.Remove(start, 11).Insert(start, numPageIndex.ToString());
            }
        }
        return strPageContent;
    }
    #endregion
    #region 动态模板标记替换
    private static string tagchange(DataTable dt, int parPageIndex, int parPageSize, int parPageCount, string parContent, int parLength)
    {
        string content = "";
        string loopcontent = parContent;
        for (int i = 0, index = parPageSize * parPageIndex; i < parPageSize && index < dt.Rows.Count; i++, index++)
        {
            DataRow dr = dt.Rows[index];
            string strContent = parContent;
            if (strContent.Contains("$Id$"))
            {
                strContent = strContent.Replace("$Id$", dr["id"].ToString());
            }
            if (strContent.Contains("$Title$"))
            {
                string strTitle = dr["title"].ToString();
                int numLength = self.GetStrByteCount(strTitle);
                if (numLength > parLength * 2 && parLength > 0)
                {
                    strContent = strContent.Replace("$Title$", dr["title"].ToString().Substring(0, parLength) + "...");
                }
                else
                {
                    strContent = strContent.Replace("$Title$", dr["title"].ToString());
                }
            }
            if (strContent.Contains("$Content$"))
            {
                strContent = strContent.Replace("$Content$", dr["content"].ToString());
            }
            if (strContent.Contains("$Url$"))
            {
                if (dr["url"] != null && dr["url"].ToString().Trim() != "")
                {
                    strContent = strContent.Replace("$Url$", dr["url"].ToString());
                }
                else
                {
                    strContent = strContent.Replace("$Url$", dr["filepath"].ToString());
                }
            }
            if (strContent.Contains("$Author$"))
            {
                strContent = strContent.Replace("Author", dr["Authortitle"].ToString());
            }
            if (strContent.Contains("$From$"))
            {
                strContent = strContent.Replace("$From$", dr["FromTitle"].ToString());
            }
            if (strContent.Contains("$KeyWord$"))
            {
                strContent = strContent.Replace("$KeyWord$", dr["keyword"].ToString());
            }
            if (strContent.Contains("$Editor$"))
            {
                strContent = strContent.Replace("$Editor$", dr["editor"].ToString());
            }
            if (strContent.Contains("$SmallImg$"))
            {
                strContent = strContent.Replace("$SmallImg$", dr["smallimg"].ToString());
            }
            if (strContent.Contains("$BigImg$"))
            {
                strContent = strContent.Replace("$BigImg$", dr["bigimg"].ToString());
            }
            if (strContent.Contains("$ShortContent$"))
            {
                strContent = strContent.Replace("$ShortContent$", dr["shortcontent"].ToString());
            }
            if (strContent.Contains("$AddTime$"))
            {
                strContent = strContent.Replace("$AddTime$", Convert.ToDateTime(dr["addtime"]).ToShortDateString());
            }
            if (strContent.Contains("$FullAddTime$"))
            {
                strContent = strContent.Replace("$FullAddTime$", dr["addtime"].ToString());
            }
            if (strContent.Contains("$Year$"))
            {
                string strYear = Convert.ToDateTime(dr["addtime"]).Year.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Year$", strYear);
            }
            if (strContent.Contains("$Month$"))
            {
                string strMonth = Convert.ToDateTime(dr["addtime"]).Month.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Month$", strMonth);
            }
            if (strContent.Contains("$Day$"))
            {
                string strDay = Convert.ToDateTime(dr["addtime"]).Day.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Day$", strDay);
            }
            if (strContent.Contains("$UpTime$"))
            {
                strContent = strContent.Replace("$UpTime$", Convert.ToDateTime(dr["uptime"]).ToShortDateString());
            }
            if (strContent.Contains("$Count$"))
            {
                strContent = strContent.Replace("$Count$", dr["count"].ToString());
            }
            if (strContent.Contains("$ClassTitle$"))
            {
                strContent = strContent.Replace("$ClassTitle$", dr["classtitle"].ToString());
            }
            if (strContent.Contains("$Field1$"))
            {
                strContent = strContent.Replace("$Field1$", dr["Field1"].ToString());
            }
            if (strContent.Contains("$Field2$"))
            {
                strContent = strContent.Replace("$Field2$", dr["Field2"].ToString());
            }
            if (strContent.Contains("$Field3$"))
            {
                strContent = strContent.Replace("$Field3$", dr["Field3"].ToString());
            }
            content += strContent + "\n";
        }
        return content.TrimEnd('\n');
    }
    #endregion

    #region 分页关闭时生成模板
    private static void PageOffCreate(DataTable paraNewsView, string parLoopContent, string parStart, string parEnd, string parFileList, string parEncoding, int parLength)
    {
        string loopcontent = parLoopContent; // 资源列表内容
        string line, text = "";
        string[] arrFileList = parFileList.Split('\n');
        for (int k = 0; k < arrFileList.Length; k++)
        {
            //读取模版，验证标签。
            StringBuilder htmltext = new StringBuilder();
            try
            {
                using (
                    StreamReader sr = new StreamReader(
                        HttpContext.Current.Server.MapPath("~" + arrFileList[k].Trim()),
                        parEncoding == "UTF" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312"))
                        )
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        htmltext.Append(line + "\n");
                    }
                    text = htmltext.ToString();
                    sr.Close();
                }
            }
            catch
            {
                self.alertend("读取静态文件出错，可能由于文件路径错误造成的！");
                return;
            }

            int numTag = text.IndexOf(parStart);
            int numTag2 = text.LastIndexOf(parStart);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parStart + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parStart + "  标签被重复使用！");
                return;
            }


            numTag = text.IndexOf(parEnd);
            numTag2 = text.LastIndexOf(parEnd);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parEnd + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parEnd + "  标签被重复使用！");
                return;
            }

            //替换内容
            loopcontent = tagchange2(paraNewsView, parLoopContent, parLength);
            int numContentTagIndex = text.IndexOf(parStart) + parStart.Length;
            int numContentTagLastIndex = text.IndexOf(parEnd) - numContentTagIndex;
            text = text.Remove(numContentTagIndex, numContentTagLastIndex);
            text = text.Insert(numContentTagIndex, "\n" + loopcontent.TrimEnd('\n') + "\n");

            //写入静态文件。
            try
            {
                using (
                    StreamWriter sw = new StreamWriter(
                        HttpContext.Current.Server.MapPath("~" + arrFileList[k].Trim()),
                        false,
                        parEncoding == "UTF" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312"))
                        )
                {
                    sw.WriteLine(text.TrimEnd('\n'));
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                self.alertend("写入静态文件出错！");
                return;
            }
        }
    }
    #endregion
    #region 动态模板标记替换2
    private static string tagchange2(DataTable paraReplace, string parContent, int parLength)
    {
        DataTable dt = paraReplace;
        string content = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow dr = dt.Rows[i];
            string strContent = parContent;
            if (strContent.Contains("$Id$"))
            {
                strContent = strContent.Replace("$Id$", dr["id"].ToString());
            }
            if (strContent.Contains("$Title$"))
            {
                string strTitle = dr["title"].ToString();
                int numLength = self.GetStrByteCount(strTitle);
                if (numLength > parLength * 2 && parLength > 0)
                {
                    strContent = strContent.Replace("$Title$", dr["title"].ToString().Substring(0, parLength) + "...");
                }
                else
                {
                    strContent = strContent.Replace("$Title$", dr["title"].ToString());
                }
            }
            if (strContent.Contains("$Content$"))
            {
                strContent = strContent.Replace("$Content$", dr["content"].ToString());
            }
            if (strContent.Contains("$Url$"))
            {
                if (dr["url"] != null && dr["url"].ToString().Trim() != "")
                {
                    strContent = strContent.Replace("$Url$", dr["url"].ToString());
                }
                else
                {
                    strContent = strContent.Replace("$Url$", dr["filepath"].ToString());
                }
            }
            if (strContent.Contains("$Author$"))
            {
                strContent = strContent.Replace("Author", dr["Authortitle"].ToString());
            }
            if (strContent.Contains("$From$"))
            {
                strContent = strContent.Replace("$From$", dr["FromTitle"].ToString());
            }
            if (strContent.Contains("$KeyWord$"))
            {
                strContent = strContent.Replace("$KeyWord$", dr["keyword"].ToString());
            }
            if (strContent.Contains("$Editor$"))
            {
                strContent = strContent.Replace("$Editor$", dr["editor"].ToString());
            }
            if (strContent.Contains("$SmallImg$"))
            {
                strContent = strContent.Replace("$SmallImg$", dr["smallimg"].ToString());
            }
            if (strContent.Contains("$BigImg$"))
            {
                strContent = strContent.Replace("$BigImg$", dr["bigimg"].ToString());
            }
            if (strContent.Contains("$ShortContent$"))
            {
                strContent = strContent.Replace("$ShortContent$", dr["shortcontent"].ToString());
            }
            if (strContent.Contains("$AddTime$"))
            {
                strContent = strContent.Replace("$AddTime$", Convert.ToDateTime(dr["addtime"]).ToShortDateString());
            }
            if (strContent.Contains("$FullAddTime$"))
            {
                strContent = strContent.Replace("$FullAddTime$", dr["addtime"].ToString());
            }
            if (strContent.Contains("$Year$"))
            {
                string strYear = Convert.ToDateTime(dr["addtime"]).Year.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Year$", strYear);
            }
            if (strContent.Contains("$Month$"))
            {
                string strMonth = Convert.ToDateTime(dr["addtime"]).Month.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Month$", strMonth);
            }
            if (strContent.Contains("$Day$"))
            {
                string strDay = Convert.ToDateTime(dr["addtime"]).Day.ToString().PadLeft(2, '0');
                strContent = strContent.Replace("$Day$", strDay);
            }
            if (strContent.Contains("$UpTime$"))
            {
                strContent = strContent.Replace("$UpTime$", Convert.ToDateTime(dr["uptime"]).ToShortDateString());
            }
            if (strContent.Contains("$Count$"))
            {
                strContent = strContent.Replace("$Count$", dr["count"].ToString());
            }
            if (strContent.Contains("$ClassTitle$"))
            {
                strContent = strContent.Replace("$ClassTitle$", dr["classtitle"].ToString());
            }
            if (strContent.Contains("$Field1$"))
            {
                strContent = strContent.Replace("$Field1$", dr["Field1"].ToString());
            }
            if (strContent.Contains("$Field2$"))
            {
                strContent = strContent.Replace("$Field2$", dr["Field2"].ToString());
            }
            if (strContent.Contains("$Field3$"))
            {
                strContent = strContent.Replace("$Field3$", dr["Field3"].ToString());
            }
            content += strContent + "\n";
        }
        return content.TrimEnd('\n');
    }
    #endregion
   
    
    #region 静态模板生成
    public static void StaticCreate(string id)
    {
        DataTable dt = StaticInsertBLL.GetStaticInsertInScope(id).Tables[0];
        for (int j = 0; j < dt.Rows.Count; j++)
        {
            string[] arrFileList = dt.Rows[j]["FileList"].ToString().Split('\n');
            for (int i = 0; i < arrFileList.Length; i++)
            {
                StaticWrite(arrFileList[i], dt.Rows[j]["content"].ToString(), dt.Rows[j]["StartElement"].ToString(), dt.Rows[j]["EndElement"].ToString(), dt.Rows[j]["Encoding"].ToString());
            }
        }
    }
    #endregion
    #region 模板写入数据
    private static void StaticWrite(string filepath_p, string parContent, string parStart, string parEnd, string parEncoding)
    {
        string line, text = "";
        try
        {
            using (
                StreamReader sr = new StreamReader(
                    System.Web.HttpContext.Current.Server.MapPath("~/" + filepath_p),
                    parEncoding == "UTF-8" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312"))
                    )
            {
                while ((line = sr.ReadLine()) != null)
                {
                    text += line + "\n";
                }
                sr.Close();
            }
        }
        catch
        {
            self.alertend("读取静态文件出错，可能由于文件路径错误造成的！");
            return;
        }
        try
        {
            int numTag = text.IndexOf(parStart);
            int numTag2 = text.LastIndexOf(parStart);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parStart + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parStart + "  标签被重复使用！");
                return;
            }


            numTag = text.IndexOf(parEnd);
            numTag2 = text.LastIndexOf(parEnd);
            if (numTag == -1)
            {
                self.alertend("页面无 " + parEnd + " 标签！");
                return;
            }
            if (numTag != numTag2)
            {
                self.alertend(parEnd + "  标签被重复使用！");
                return;
            }
            int numContentTagIndex = text.IndexOf(parStart) + parStart.Length;
            int numContentTagLastIndex = text.IndexOf(parEnd) - numContentTagIndex;
            text = text.Remove(numContentTagIndex, numContentTagLastIndex);
            text = text.Insert(numContentTagIndex, "\n" + parContent + "\n");
        }
        catch
        {
            self.alertend("写入静态文件出错！");
            return;
        }
        try
        {
            using (StreamWriter sw = new StreamWriter(
                HttpContext.Current.Server.MapPath("~/" + filepath_p),
                false,
                parEncoding == "UTF-8" ? Encoding.GetEncoding("UTF-8") : Encoding.GetEncoding("GB2312"))
                )
            {
                sw.WriteLine(text);
                sw.Flush();
                sw.Close();
            }
        }
        catch
        {
            self.alertend("写入静态文件出错！");
            return;
        }
    }
    #endregion
}