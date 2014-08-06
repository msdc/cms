using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_class_mdy : System.Web.UI.Page
{
    string gClassMap = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            init();
        }
    }
    #region 页面初始
    protected void init()
    {
        dlTemplate.DataSource = TemplateBLL.GetTemplateOrderById().Tables[0];
        dlTemplate.DataTextField = "title";
        dlTemplate.DataValueField = "id";
        dlTemplate.DataBind();
        if (Request["id"] != null)
        {
            DataTable dt;
            dt = ClassBLL.GetClassById(Request["id"]).Tables[0];
            tbTitle.Text = dt.Rows[0]["title"].ToString();
            tbTitle2.Text = dt.Rows[0]["title2"].ToString();
            tbDir.Text = dt.Rows[0]["directory"].ToString();
            tbOrderID.Text = dt.Rows[0]["orderid"].ToString();
            dlTemplate.SelectedValue = dt.Rows[0]["template"].ToString();
            lblState.Text = "修改资源类别";
        }
        else
        {
            lblState.Text = "添加资源类别";
            lbDel.Visible = false;
            trMoveID.Visible = false;
        }
        if (dlTemplate.Items.Count < 1)
        {
            lblState.Text = "无资源模板，请添加模板后再添加分类。";
            lbDel.Visible = false;
        }
        tdShow();
    }
    protected void tdShow()
    {
        string strMap = "";
        if (Request["id"] != null && Request["id"] != "")
        {
            object obj = ClassBLL.GetClassMapById(Request["id"]);
            if (obj != null && obj.ToString() != "")
            {
                string[] arrMap = obj.ToString().Split('|');
                for (int i = 0; i < arrMap.Length; i++)
                {
                    strMap += " ＞ <a href='class_list.aspx?parent=" + arrMap[i].ToString().Split(',')[0] + "'>" + arrMap[i].ToString().Split(',')[1] + "</a>";
                }
            }
        }
        TD1.InnerHtml = "<a href='class_list.aspx'>根类别</a>" + strMap + " 的子分类列表";
    }
    protected string getClassMap(string parParentID)
    {
        if (Request["parent"] != null && Request["parent"] != "" && Request["parent"] != "-1")
        {
            funClassMap(Request["parent"]);
        }
        return gClassMap.TrimEnd('|');
    }
    protected void funClassMap(string parParentID)
    {
        DataTable dt = ClassBLL.GetClassById(parParentID).Tables[0];
        gClassMap = dt.Rows[0]["id"].ToString() + "," + dt.Rows[0]["title"].ToString() + "|" + gClassMap;
        if (dt.Rows[0]["parent"].ToString() != "-1")
        {
            funClassMap(dt.Rows[0]["parent"].ToString());
        }
    }
    #endregion
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        bool updateParent = false;
        string parent = string.Empty ;
        if (Request["id"] != null && tbMoveID.Text != "" && tbMoveID.Text != Request["id"])
        {
            string strTmp = ClassBLL.GetClassCount().ToString();
            if (strTmp == "0")
            {
                lblResult.Text = "没有此栏目可以移动。";
                return;
            }
            else
            {
                updateParent = true;
                parent = tbMoveID.Text;
            }
        }

        parent = Request["id"] != null ? parent : (Request["parent"] != "" ? Request["parent"] : "-1");
        int yon = ClassBLL.EditClass(tbTitle.Text, tbTitle2.Text, tbDir.Text, dlTemplate.SelectedValue, (tbOrderID.Text != "" ? tbOrderID.Text : "1"), getClassMap(Request["parent"]), parent, Request["id"], updateParent);
        if (yon > 0)
        {
            Response.Redirect("class_list.aspx?parent=" + Request["parent"] + "&page=" + Request["page"]);
        }
        else
        {
            lblResult.Text = "分类更新失败。";
        }
    }
    protected void lbDel_Click(object sender, EventArgs e)
    {
        int yon = ClassBLL.DeleteClass(Request["id"]);
        if (yon > 0)
        {
            Response.Redirect("class_list.aspx?parent=" + Request["parent"] + "&page=" + Request["page"]);
        }
    }
}