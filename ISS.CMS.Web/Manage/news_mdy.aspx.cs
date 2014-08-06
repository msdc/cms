using ISS.CMS.BLL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_news_mdy : System.Web.UI.Page
{
    string templateid_str = "", specialityid_str = "", specialityiddata_str = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
        }
    }

    #region 页面初始
    protected void dsbind()
    {
        string sql;
        SpecialityBll specialityBll = new SpecialityBll();
        AuthorBll authorBll = new AuthorBll();
        FromBll fromBll = new FromBll();
        NewsViewBLL newsViewBLL = new NewsViewBLL();
        //类别
        DataTable dt = TemplateBLL.GetTemplate(validate.cookiestr).Tables[0];
            //ClassBLL.GetClass(validate.cookiestr).Tables[0];
        DataRow[] dtRow = dt.Select("");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = false;
            tvTemplate.Nodes.Add(tn);
        }
        //for (int i = 0; i < tvTemplate.Nodes.Count; i++)
        //{
        //    TemplateBind(tvTemplate.Nodes[i], tvTemplate.Nodes[i].Value, dt);
        //}
        //for (int i = 0; i < tvClass.Nodes.Count; i++)
        //{
        //    ClassBind(tvClass.Nodes[i], tvClass.Nodes[i].Value, dt);
        //}
        //特性
        dt = specialityBll.GetSpeciality().Tables[0];
        dtRow = dt.Select("[Parent]=-1");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = false;
            tvSpeciality.Nodes.Add(tn);
        }
        for (int i = 0; i < tvSpeciality.Nodes.Count; i++)
        {
            SpecialityBind(tvSpeciality.Nodes[i], tvSpeciality.Nodes[i].Value, dt);
        }
        //作者
        author_ddl.DataSource = authorBll.GetAuthor();
        author_ddl.DataTextField = "title";
        author_ddl.DataValueField = "id";
        author_ddl.DataBind();
        //来源
        from_ddl.DataSource = fromBll.GetFrom();
        from_ddl.DataTextField = "title";
        from_ddl.DataValueField = "id";
        from_ddl.DataBind();

        if (Request["id"] != null && Request["id"] != "")
        {
            state_lbl.Text = "修改资源";
            dt = newsViewBLL.GetNewsViewById(int.Parse(Request["id"])).Tables[0];
            title_tb.Text = dt.Rows[0]["title"].ToString();
            url_tb.Text = dt.Rows[0]["url"].ToString();
            author_ddl.SelectedValue = dt.Rows[0]["author"].ToString();
            from_ddl.SelectedValue = dt.Rows[0]["from"].ToString();
            edit_tb.Text = dt.Rows[0]["editor"].ToString();
            count_tb.Value = dt.Rows[0]["count"].ToString();
            //classdata("-1", dt.Rows[0]["class"].ToString());
            templatedata("-1", dt.Rows[0]["TemplateID"].ToString());
            specialityiddata_str = "," + dt.Rows[0]["speciality"].ToString() + ",";
            specialitydata("-1");
            content_cute.Text = dt.Rows[0]["content"].ToString();
            smallimg_tb.Text = dt.Rows[0]["smallimg"].ToString();
            bigimg_tb.Text = dt.Rows[0]["bigimg"].ToString();
            shortcontent_tb.Text = dt.Rows[0]["shortcontent"].ToString();
            keyword_tb.Text = dt.Rows[0]["keyword"].ToString();
            tbField1.Text = dt.Rows[0]["field1"].ToString();
            tbField2.Text = dt.Rows[0]["field2"].ToString();
            tbField3.Text = dt.Rows[0]["field3"].ToString();
            tbAddtime.Text = dt.Rows[0]["addtime"].ToString();
            tbUptime.Text = DateTime.Now.ToString();
        }
        else
        {
            state_lbl.Text = "添加资源";
            del_cb.Visible = false;
            lbDel.Visible = false;
            trCreate.Visible = false;
            tbAddtime.Text = DateTime.Now.ToString();
            tbUptime.Text = tbAddtime.Text;
        }
        //if (Session["class"] != null)
        //{
        //    class_memory.Checked = true;
        //    classdata("-1", Session["class"].ToString());
        //}
        if (Session["author"] != null)
        {
            author_memory.Checked = true;
            author_ddl.SelectedValue = Session["author"].ToString();
        }
        if (Session["from"] != null)
        {
            from_memory.Checked = true;
            from_ddl.SelectedValue = Session["from"].ToString();
        }
        if (Session["keyword"] != null)
        {
            keyword_memory.Checked = true;
            keyword_tb.Text = Session["keyword"].ToString();
        }
    }
    #endregion

    #region 类别ID数据绑定
    //protected void classdata(string path, string id)
    //{
    //    if (path == "-1")
    //    {
    //        for (int i = 0; i < tvClass.Nodes.Count; i++)
    //        {
    //            if (tvClass.Nodes[i].Value == id)
    //            {
    //                tvClass.Nodes[i].Checked = true;
    //                if (tvClass.Nodes[i].Parent != null)
    //                    ClassNodeShow(tvClass.Nodes[i].Parent);
    //            }
    //            classdata(tvClass.Nodes[i].Value, id);
    //        }
    //    }
    //    else
    //    {
    //        for (int i = 0; i < tvClass.FindNode(path).ChildNodes.Count; i++)
    //        {
    //            if (tvClass.FindNode(path).ChildNodes[i].Value == id)
    //            {
    //                tvClass.FindNode(path).ChildNodes[i].Checked = true;
    //                if (tvClass.FindNode(path).ChildNodes[i].Parent != null)
    //                    ClassNodeShow(tvClass.FindNode(path).ChildNodes[i].Parent);
    //            }
    //            classdata(path + "/" + tvClass.FindNode(path).ChildNodes[i].Value, id);
    //        }
    //    }
    //}
    #endregion
    #region 类别被选中节点展开
    protected void ClassNodeShow(TreeNode tn)
    {
        tn.Expanded = true;
        if (tn.Parent != null)
        {
            ClassNodeShow(tn.Parent);
        }
    }
    #endregion
    #region 类别控件初始
    protected void ClassBind(TreeNode parTn, string parId, DataTable dt)
    {
        DataRow[] dtRow = dt.Select("[Parent]=" + parId + "");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = false;
            parTn.ChildNodes.Add(tn);
        }
        for (int i = 0; i < parTn.ChildNodes.Count; i++)
        {
            if (dt.Select("[Parent] = " + parTn.ChildNodes[i].Value + "").Length > 0)
            {
                ClassBind(parTn.ChildNodes[i], parTn.ChildNodes[i].Value, dt);
            }
        }
    }
    #endregion

    #region 模版控件初始
    protected void TemplateBind(TreeNode parTn, string parId, DataTable dt)
    {
        DataRow[] dtRow = dt.Select("");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = false;
            parTn.ChildNodes.Add(tn);
        }        
    }
    #endregion

    #region 模版ID数据绑定
    protected void templatedata(string path, string id)
    {
        if (path == "-1")
        {
            for (int i = 0; i < tvTemplate.Nodes.Count; i++)
            {
                if (tvTemplate.Nodes[i].Value == id)
                {
                    tvTemplate.Nodes[i].Checked = true;
                    if (tvTemplate.Nodes[i].Parent != null)
                        ClassNodeShow(tvTemplate.Nodes[i].Parent);
                }
                templatedata(tvTemplate.Nodes[i].Value, id);
            }
        }
        else
        {
            for (int i = 0; i < tvTemplate.FindNode(path).ChildNodes.Count; i++)
            {
                if (tvTemplate.FindNode(path).ChildNodes[i].Value == id)
                {
                    tvTemplate.FindNode(path).ChildNodes[i].Checked = true;
                    if (tvTemplate.FindNode(path).ChildNodes[i].Parent != null)
                        ClassNodeShow(tvTemplate.FindNode(path).ChildNodes[i].Parent);
                }
                templatedata(path + "/" + tvTemplate.FindNode(path).ChildNodes[i].Value, id);
            }
        }
    }
    #endregion

    #region 特性ID数据绑定
    protected void specialitydata(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < tvSpeciality.Nodes.Count; i++)
            {
                if (specialityiddata_str.Contains("," + tvSpeciality.Nodes[i].Value + ","))
                {
                    tvSpeciality.Nodes[i].Checked = true;
                    if (tvSpeciality.Nodes[i].Parent != null)
                        SpecialityNodeShow(tvSpeciality.Nodes[i].Parent);
                }
                specialitydata(tvSpeciality.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < tvSpeciality.FindNode(path).ChildNodes.Count; i++)
            {
                if (specialityiddata_str.Contains("," + tvSpeciality.FindNode(path).ChildNodes[i].Value + ","))
                {
                    tvSpeciality.FindNode(path).ChildNodes[i].Checked = true;
                }
                specialitydata(path + "/" + tvSpeciality.FindNode(path).ChildNodes[i].Value);
            }
        }
    }
    #endregion
    #region 特性被选中节点展开
    protected void SpecialityNodeShow(TreeNode tn)
    {
        if (tn.Parent != null)
        {
            tn.Parent.Expanded = true;
            SpecialityNodeShow(tn.Parent);
        }
    }
    #endregion
    #region 特性控件初始
    protected void SpecialityBind(TreeNode parTn, string parId, DataTable dt)
    {
        DataRow[] dtRow = dt.Select("[Parent]=" + parId + "");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            parTn.ChildNodes.Add(tn);
        }
        for (int i = 0; i < parTn.ChildNodes.Count; i++)
        {
            if (dt.Select("[Parent] = " + parTn.ChildNodes[i].Value + "").Length > 0)
            {
                SpecialityBind(parTn.ChildNodes[i], parTn.ChildNodes[i].Value, dt);
            }
        }
    }
    #endregion
    #region 获取类别ID值
    //protected string classid(string path)
    //{
    //    if (path == "-1")
    //    {
    //        for (int i = 0; i < tvClass.Nodes.Count; i++)
    //        {
    //            if (tvClass.Nodes[i].Checked)
    //            {
    //                classid_str = tvClass.Nodes[i].Value;
    //            }
    //            classid(tvClass.Nodes[i].Value);
    //        }
    //    }
    //    else
    //    {
    //        for (int i = 0; i < tvClass.FindNode(path).ChildNodes.Count; i++)
    //        {
    //            if (tvClass.FindNode(path).ChildNodes[i].Checked)
    //            {
    //                classid_str = tvClass.FindNode(path).ChildNodes[i].Value;
    //            }
    //            classid(path + "/" + tvClass.FindNode(path).ChildNodes[i].Value);
    //        }
    //    }
    //    return classid_str;
    //}
    #endregion
    #region 获取模版ID
    protected string templateid(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < tvTemplate.Nodes.Count; i++)
            {
                if (tvTemplate.Nodes[i].Checked)
                {
                    templateid_str = tvTemplate.Nodes[i].Value;
                }
                templateid(tvTemplate.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < tvTemplate.FindNode(path).ChildNodes.Count; i++)
            {
                if (tvTemplate.FindNode(path).ChildNodes[i].Checked)
                {
                    templateid_str = tvTemplate.FindNode(path).ChildNodes[i].Value;
                }
                templateid(path + "/" + tvTemplate.FindNode(path).ChildNodes[i].Value);
            }
        }
        return templateid_str;
    }
    #endregion
    #region 获取特性ID值
    protected string specialityid(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < tvSpeciality.Nodes.Count; i++)
            {
                if (tvSpeciality.Nodes[i].Checked)
                {
                    specialityid_str += tvSpeciality.Nodes[i].Value + ",";
                }
                specialityid(tvSpeciality.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < tvSpeciality.FindNode(path).ChildNodes.Count; i++)
            {
                if (tvSpeciality.FindNode(path).ChildNodes[i].Checked)
                {
                    specialityid_str += tvSpeciality.FindNode(path).ChildNodes[i].Value + ",";
                }
                specialityid(path + "/" + tvSpeciality.FindNode(path).ChildNodes[i].Value);
            }
        }
        return specialityid_str;
    }
    #endregion
    #region 记忆
    private void memory()
    {
        //if (class_memory.Checked)
        //{
        //    Session["newsClass"] = classid("-1");
        //}
        //else
        //{
        //    Session["newsClass"] = null;
        //}
        if (author_memory.Checked)
        {
            Session["newsAuthor"] = author_ddl.SelectedValue;
        }
        else
        {
            Session["newsAuthor"] = null;
        }
        if (from_memory.Checked)
        {
            Session["newsFrom"] = from_ddl.SelectedValue;
        }
        else
        {
            Session["newsFrom"] = null;
        }
        if (keyword_memory.Checked)
        {
            Session["newsKeyword"] = keyword_tb.Text;
        }
        else
        {
            Session["newsKeyword"] = null;
        }
    }
    #endregion
    protected void Button1_Click(object sender, EventArgs e)
    {
        memory();
        bool addMode = true;
        NewsView newsView = new NewsView();
        NewsViewBLL newsViewBLL = new NewsViewBLL();

        newsView.TemplateId = int.Parse(templateid("-1"));//int.Parse(classid("-1"));
        newsView.Title = title_tb.Text;
        newsView.Url = url_tb.Text;
        newsView.Author = author_ddl.SelectedValue;
        newsView.From = from_ddl.SelectedValue;
        newsView.Editor = edit_tb.Text;
        newsView.KeyWord = keyword_tb.Text;
        newsView.Count = int.Parse(count_tb.Value);
        newsView.Speciality = specialityid("-1").TrimEnd(',');
        newsView.Content = content_cute.Text.Replace("'", "''");
        newsView.SmallImg = smallimg_tb.Text;
        newsView.BigImg = bigimg_tb.Text;
        newsView.ShortContent = shortcontent_tb.Text;
        newsView.Field1 = tbField1.Text;
        newsView.Field2 = tbField2.Text;
        newsView.Field3 = tbField3.Text;
        newsView.AddTime = Convert.ToDateTime(tbAddtime.Text);
        newsView.UpTime = Convert.ToDateTime(tbUptime.Text);

        if (Request["id"] == null)
        {            
            //if (class_memory.Checked)
            //{
            //    class_memory.Checked = true;
            //    //Session["class"] = classid("-1");
            //}
            if (author_memory.Checked)
            {
                author_memory.Checked = true;
                Session["author"] = author_ddl.SelectedValue;
            }
            if (from_memory.Checked)
            {
                Session["from"] = from_ddl.SelectedValue;
            }
            if (keyword_memory.Checked)
            {
                keyword_memory.Checked = true;
                keyword_tb.Text = Session["keyword"].ToString();
            }
        }
        else
        {
            addMode = false;
            newsView.Id = int.Parse(Request["id"]);
        }

        if (newsViewBLL.EditNewsView(newsView, addMode))
        {
            if (create_cb.Checked)
            {
                Create.dir(Request["id"]);
            }
            string strUrl = "news_list.aspx?parent=" + Request["parent"] + "&page=" + Request["page"];
            if (Request["id"] != null)
            {
                Response.Redirect(strUrl);
            }
            else
            {
                Response.Write("<script>if(confirm('是否继续添加？')){location.href='news_mdy.aspx'}else{location.href='" + strUrl + "'}</script>");
            }

        }
        else
        {
            self.alert("操作失败！");
        }
    }

    protected void lbDel_Click(object sender, EventArgs e)
    {
        NewsViewBLL newsViewBLL = new NewsViewBLL();
        int yon = newsViewBLL.DeleteNewsView(del_cb.Checked, int.Parse(Request["id"]));
        if (yon > 0)
        {
            Response.Redirect("news_list.aspx?parent=" + Request["parent"] + "&page=" + Request["page"]);
        }
    }
}