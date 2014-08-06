using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Manage_Navigation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.loginYon();
            dsbind();
        }
    }

    #region 页面初始
    protected void dsbind()
    {
        DataTable dt = new DataTable();
        //if (validate.cookiestr != "admin")
        //{
        //    sql = "select * from tsys_menu where id in (" + validate.nav() + ") ORDER BY lv ASC";
        //}
        //else
        //{
        //    sql = "SELECT * FROM tsys_menu ORDER BY Id ASC";//lv ASC";//by han
        //}
        dt = ISS.CMS.BLL.UserBLL.GetRolePermission(validate.cookiestr).Tables[0]; ;//DbHelperSQL.Query(sql).Tables[0];
        DataRow[] dtRow = dt.Select("[ParentID]=-1");//by han
        for (int i = 0; i < dtRow.Length; i++)
        {
            if (!Convert.ToBoolean(dtRow[i]["HasPage"]))//by han
            {
                TreeNode tn = new TreeNode();
                tn.Text = dtRow[i]["PageName"].ToString();
                tn.Value = dtRow[i]["Id"].ToString();
                tn.SelectAction = TreeNodeSelectAction.None;
                tn.Collapse();
                treeMenu.Nodes.Add(tn);
            }
            else
            {
                TreeNode tn = new TreeNode();
                tn.Text = dtRow[i]["PageName"].ToString();
                tn.Value = dtRow[i]["id"].ToString();
                tn.Target = "right";
                string strPagePath = dtRow[i]["PageFileDir"].ToString();//by han
                if (strPagePath.PadRight(4, ' ').Substring(0, 4).ToLower() == "http")
                {
                    tn.NavigateUrl = strPagePath + dtRow[i]["pagetitle"].ToString();
                }
                else
                {
                    tn.NavigateUrl = "~/" + strPagePath + dtRow[i]["pagetitle"].ToString();
                }
                treeMenu.Nodes.Add(tn);
            }
            dt.Rows.Remove(dtRow[i]);
        }
        for (int i = 0; i < treeMenu.Nodes.Count; i++)
        {
            TreeBind(treeMenu.Nodes[i], treeMenu.Nodes[i].Value, dt);
        }
    }
    #endregion
    protected void TreeBind(TreeNode parTn, string parId, DataTable dt)
    {
        DataRow[] dtRow = dt.Select("[ParentID]=" + parId + "");//by han
        for (int i = 0; i < dtRow.Length; i++)
        {
            if (!Convert.ToBoolean(dtRow[i]["HasPage"]))//by han
            {
                TreeNode tn = new TreeNode();
                tn.Text = dtRow[i]["PageName"].ToString();
                tn.Value = dtRow[i]["id"].ToString();
                tn.SelectAction = TreeNodeSelectAction.None;
                parTn.ChildNodes.Add(tn);
            }
            else
            {
                TreeNode tn = new TreeNode();
                tn.Text = dtRow[i]["PageName"].ToString();
                tn.Value = dtRow[i]["id"].ToString();
                tn.Target = "right";
                string strPagePath = dtRow[i]["PageFileDir"].ToString();//by han
                if (strPagePath.PadRight(4, ' ').Substring(0, 4).ToLower() == "http")
                {
                    tn.NavigateUrl = strPagePath + dtRow[i]["pagetitle"].ToString();
                }
                else
                {
                    tn.NavigateUrl = "~/" + strPagePath + dtRow[i]["pagetitle"].ToString();
                }
                parTn.ChildNodes.Add(tn);
            }
            dt.Rows.Remove(dtRow[i]);

        }
        for (int i = 0; i < parTn.ChildNodes.Count; i++)
        {
            if (dt.Select("[ParentID] = " + parTn.ChildNodes[i].Value + "").Length > 0)//by han
            {
                TreeBind(parTn.ChildNodes[i], parTn.ChildNodes[i].Value, dt);
            }
        }
    }
}