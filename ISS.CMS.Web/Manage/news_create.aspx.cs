using ISS.CMS.BLL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_news_createhtml : System.Web.UI.Page
{
    string classid_str = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
        }
    }
    #region 页面初始
    private void dsbind()
    {
        classtree();
        startyear_dll.SelectedValue = System.DateTime.Now.Year.ToString();
        endyear_dll.SelectedValue = System.DateTime.Now.Year.ToString();
        startmonth_dll.SelectedValue = System.DateTime.Now.Month.ToString();
        endmonth_dll.SelectedValue = System.DateTime.Now.Month.ToString();
        startday_dll.SelectedValue = System.DateTime.Now.Day.ToString();
        endday_dll.SelectedValue = System.DateTime.Now.Day.ToString();
    }
    #endregion
    #region class_tree初始
    protected void classtree()
    {
        //模板类别
        DataTable dt = TemplateBLL.GetTemplate(validate.cookiestr).Tables[0];
        DataRow[] dtRow = dt.Select("");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = false;
            class_tree.Nodes.Add(tn);
        }
    }
    protected void classtree(string id, string path)
    {
        DataTable dt, dt2;

        //string sql = "select * from [tsys_class] where id in (" + validate.classid() + ") and parent = " + id + " order by ID desc";
        //dt = DbHelperSQL.Query(sql).Tables[0];


        dt = ClassBLL.GetClassByParentAndIdInClassId(id, ClassBLL.GetClassIdByRoleName(validate.cookiestr), "id desc").Tables[0];

        TreeNode tn;
        if (path == "-1")
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn = new TreeNode();
                tn.Text = dt.Rows[i]["title"].ToString();
                tn.Value = dt.Rows[i]["id"].ToString();
                tn.SelectAction = TreeNodeSelectAction.None;
                tn.ShowCheckBox = true;
                class_tree.Nodes.Add(tn);

                //sql = "select * from [tsys_class] where id in (" + validate.classid() + ") and parent =" + dt.Rows[i]["id"].ToString() + " order by ID desc";
               // dt2 = DbHelperSQL.Query(sql).Tables[0];

                dt2 = ClassBLL.GetClassByParentAndIdInClassId(dt.Rows[i]["id"].ToString(), ClassBLL.GetClassIdByRoleName(validate.cookiestr), "id desc").Tables[0];

                if (dt2.Rows.Count > 0)
                {
                    classtree(dt.Rows[i]["id"].ToString(), dt.Rows[i]["id"].ToString());
                }
                else
                {
                    classtree(dt.Rows[i]["id"].ToString(), "-1");
                }
            }
        }
        else
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn = new TreeNode();
                tn.Text = dt.Rows[i]["title"].ToString();
                tn.Value = dt.Rows[i]["id"].ToString();
                tn.SelectAction = TreeNodeSelectAction.None;
                tn.ShowCheckBox = true;
                class_tree.FindNode(path).ChildNodes.Add(tn);

                //sql = "select * from [tsys_class] where id in (" + validate.classid() + ") and parent =" + dt.Rows[i]["id"].ToString() + " order by ID desc";
                //dt2 = DbHelperSQL.Query(sql).Tables[0];

                dt2 = ClassBLL.GetClassByParentAndIdInClassId(dt.Rows[i]["id"].ToString(), ClassBLL.GetClassIdByRoleName(validate.cookiestr), "desc").Tables[0];

                if (dt2.Rows.Count > 0)
                {
                    classtree(dt.Rows[i]["id"].ToString(), path + "/" + dt.Rows[i]["id"].ToString());
                }
                else
                {
                    int index = path.LastIndexOf('/');
                    if (index != -1)
                    {
                        classtree(dt.Rows[i]["id"].ToString(), path.Remove(index, path.Length - index));
                    }
                }
            }
        }
    }
    #endregion
    #region 获取classID值
    protected string classid(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < class_tree.Nodes.Count; i++)
            {
                if (class_tree.Nodes[i].Checked)
                {
                    classid_str = classid_str + class_tree.Nodes[i].Value + ",";
                }
                classid(class_tree.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < class_tree.FindNode(path).ChildNodes.Count; i++)
            {
                if (class_tree.FindNode(path).ChildNodes[i].Checked)
                {
                    classid_str = classid_str + class_tree.FindNode(path).ChildNodes[i].Value + ",";
                }
                classid(path + "/" + class_tree.FindNode(path).ChildNodes[i].Value);
            }
        }
        if (classid_str == "")
        {
            return "0";
        }
        else
        {
            return classid_str.TrimEnd(',');
        }
    }
    #endregion



    protected void Button1_Click(object sender, EventArgs e)
    {
        string idstr = "";
        if (time_ra.Checked)
        {
            string starttime = startyear_dll.SelectedValue + "-" + startmonth_dll.SelectedValue + "-" + startday_dll.SelectedValue + " " + starthour_dll.SelectedValue + ":" + starthour_dll.SelectedValue + ":" + startminute_dll.SelectedValue;
            string endtime = endyear_dll.SelectedValue + "-" + endmonth_dll.SelectedValue + "-" + endday_dll.SelectedValue + " " + endhour_dll.SelectedValue + ":" + endhour_dll.SelectedValue + ":" + endminute_dll.SelectedValue;
           
            string strTmp = "";
            if (tbNum.Text != "0")
            {
                strTmp = "top " + tbNum.Text;
            }
           // sql = "select " + strTmp + " * from [tsys_news] where IsDel = 0 AND IsCheck = " + rblCreate.SelectedValue + " AND " + time_dll.SelectedValue + " between '" + starttime + "' and '" + endtime + "' and class in(" + validate.classid() + ") order by ID desc";
           // DataTable dt = DbHelperSQL.Query(sql).Tables[0];
            //string isCheck = rblCreate.SelectedValue.ToString();
            DataTable dt = NewsViewBLL.GetNewsViewListByAddTimeOrUpTime(strTmp, rblCreate.SelectedValue, time_dll.SelectedValue, starttime, endtime, ClassBLL.GetClassIdByRoleName(validate.cookiestr)).Tables[0];
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idstr += dt.Rows[i]["id"].ToString() + ",";
            }
            if (idstr == "")
            {
                self.alert("生成资源（0）条");
            }
            else
            {
                int yon = Create.dir(idstr.TrimEnd(','));
                self.alert("生成资源（" + yon + "）条");
            }
        }
        else if (class_ra.Checked)
        {
            string strTmp = "";
            if (tbNum.Text != "0")
            {
                strTmp = "top " + tbNum.Text;
            }
            //sql = "select " + strTmp + " * from [tsys_news] where Isdel = 0 AND IsCheck = " + rblCreate.SelectedValue + " AND class in (" + classid("-1") + ") order by ID";
           // DataTable dt = DbHelperSQL.Query(sql).Tables[0];
            //string classid = classid("-1");
            DataTable dt = NewsViewBLL.GetNewsViewListInTemplateId(strTmp, rblCreate.SelectedValue, classid("-1"), ID).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idstr += dt.Rows[i]["id"].ToString() + ",";
            }
            if (idstr == "")
            {
                self.alert("生成资源（0）条");
            }
            else
            {
                int yon = Create.dir(idstr.TrimEnd(','));
                self.alert("生成资源（" + yon + "）条");
            }
        }
    }
}
