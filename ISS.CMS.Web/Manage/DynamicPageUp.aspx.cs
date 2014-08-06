using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ISS.CMS.Model;
using ISS.CMS.BLL;
using ISS.CMS.ClassFactory;

public partial class manage_DynamicPageUp : System.Web.UI.Page
{
    string gClassID = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            init();
        }
    }
    protected void init()
    {
        //类别
        DataSet ds = ClassBLL.GetClass(validate.cookiestr);
        DataTable dt = ds.Tables[0];
        DataRow[] dtRow = dt.Select("[Parent]=-1");
        for (int i = 0; i < dtRow.Length; i++)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dtRow[i]["Title"].ToString();
            tn.Value = dtRow[i]["Id"].ToString();
            tn.SelectAction = TreeNodeSelectAction.None;
            tn.ShowCheckBox = true;
            tn.Expanded = true;
            tvClass.Nodes.Add(tn);
            dt.Rows.Remove(dtRow[i]);
        }
        for (int i = 0; i < tvClass.Nodes.Count; i++)
        {
            ClassBind(tvClass.Nodes[i], tvClass.Nodes[i].Value, dt);
        }
        //动态更新       
        DataSet dsDynamic = DynamicInsertBLL.GetList("");
        lbData.DataSource = dsDynamic.Tables[0];
        lbData.DataTextField = "title";
        lbData.DataValueField = "id";
        lbData.DataBind();
    }
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
            tn.Expanded = true;
            parTn.ChildNodes.Add(tn);
            dt.Rows.Remove(dtRow[i]);
        }
        for (int i = 0; i < parTn.ChildNodes.Count; i++)
        {
            if (dt.Select("[Parent] = " + parTn.ChildNodes[i].Value + "").Length > 0)
            {
                ClassBind(parTn.ChildNodes[i], parTn.ChildNodes[i].Value, dt);
            }
        }
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        string[] arrClassID = getClassID().Split(',');
        string strSqlWhere = " 1=1 ";
        for (int i = 0; i < arrClassID.Length; i++)
        {
            if (i == 0)
                strSqlWhere += "AND [Class] LIKE '%" + arrClassID[i] + ",%' ";
            else
                strSqlWhere += "OR  [Class] LIKE '%" + arrClassID[i] + ",%' ";
        }

        string strDynamicInsertID = "";
        for (int i = 0; i < lbData.Items.Count; i++)
        {
            if (lbData.Items[i].Selected)
            {
                strDynamicInsertID += lbData.Items[i].Value + ",";
            }
        }

        DataSet ds = DynamicInsertBLL.GetList(strSqlWhere);
        //if (strDynamicInsertID != "")
        //{
        //    sql += " OR [ID] IN (" + strDynamicInsertID.TrimEnd(',') + ")";
        //}
        DataTable dt = ds.Tables[0];

        string strDynamicInsertID2 = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strDynamicInsertID2 += dt.Rows[i]["ID"].ToString() + ",";
        }
        if (dt.Rows.Count > 0)
        {
            lblResult.Text = "";
            Create.DynamicCreate(strDynamicInsertID2.TrimEnd(','));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lblResult.Text = lblResult.Text + "[<span style='color:red'>" + dt.Rows[i]["title"].ToString() + "</span>]已更新  地址：<a target='_blank' href='" + dt.Rows[i]["FileList"].ToString() + "'>" + dt.Rows[i]["FileList"].ToString() + "</a><br/>";
            }
        }
        else
        {
            lblResult.Text = "<span style='color:red'>没有需要更新的页面。</span>";
        }
    }
    #region 提交数据时，获取classID值
    protected string getClassID()
    {
        funClassID(tvClass.Nodes);
        return gClassID.TrimEnd(',');
    }
    protected void funClassID(TreeNodeCollection tnc)
    {
        for (int i = 0; i < tnc.Count; i++)
        {
            if (tnc[i].Checked)
            {
                gClassID = tnc[i].Value + ",";//gClassID = gClassID + tnc[i].Value + ",";by han
            }
            if (tnc[i].ChildNodes.Count > 0)
            {
                funClassID(tnc[i].ChildNodes);
            }
        }
    }
    #endregion
}
