using ISS.CMS.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manage_role_mdy : System.Web.UI.Page
{
    string iddata_str = "";
    string id_str = "";
    string classid_str = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            menumove(-1, "");
        }
    }

    #region 页面初始化
    protected void dsbind()
    {
        nag_tv.Nodes.Clear();
        class_tree.Nodes.Clear();

        DataTable dt;
        dt = MenuBLL.GetMenu().Tables[0];
        if (dt.Rows.Count > 0)
        {
            tree("-1", "-1");
        }

        dt = MenuBLL.GetClass().Tables[0];
        if (dt.Rows.Count > 0)
        {
            classtree("-1", "-1");
        }
        //--------------------------------------------------------------
        if (Request["id"] != null)
        {
            iddata_str = "," + RoleBLL.GetRolePageIdById(Request["id"]).ToString() + ",";
            treedata("-1");

            dt = RoleBLL.GetRoleById(Request["id"]).Tables[0];
            name_tb.Text = dt.Rows[0]["name"].ToString();
            des_tb.Text = dt.Rows[0]["description"].ToString();
            iddata_str = "," + RoleBLL.GetRoleClassIdById(Request["id"]).ToString() + ",";
            classdata("-1");
            state_lbl.Text = "修改角色";
        }
        else
        {
            state_lbl.Text = "添加角色";
            lbDel.Visible = false;
        }
        //--------------------------------------------------------------
        for (int i = 0; i < nag_tv.Nodes.Count; i++)
        {
            nag_tv.Nodes[i].ExpandAll();
        }
        for (int j = 0; j < class_tree.Nodes.Count; j++)
        {
            class_tree.Nodes[j].ExpandAll();
        }

        // this.del_btn.Attributes.Add("onclick", "if(confirm('确认删除？')){return true}else{return false}");
    }
    #endregion

    #region nag_tv初始
    protected void tree(string id, string path)
    {
        DataTable dt, dt2;
        dt = MenuBLL.GetMenuByParentId(id).Tables[0];
        TreeNode tn;
        if (path == "-1")
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn = new TreeNode();
                tn.Text = dt.Rows[i]["pagename"].ToString();
                tn.Value = dt.Rows[i]["id"].ToString();
                tn.ShowCheckBox = true;

                nag_tv.Nodes.Add(tn);

                dt2 = MenuBLL.GetMenuByParentId(dt.Rows[i]["id"].ToString()).Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    tree(dt.Rows[i]["id"].ToString(), dt.Rows[i]["id"].ToString());
                }
                else
                {
                    tree(dt.Rows[i]["id"].ToString(), "-1");
                }
            }
        }
        else
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn = new TreeNode();
                tn.Text = dt.Rows[i]["pagename"].ToString();
                tn.Value = dt.Rows[i]["id"].ToString();
                tn.ShowCheckBox = true;

                nag_tv.FindNode(path).ChildNodes.Add(tn);

                dt2 = MenuBLL.GetMenuByParentId(dt.Rows[i]["id"].ToString()).Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    tree(dt.Rows[i]["id"].ToString(), path + "/" + dt.Rows[i]["id"].ToString());
                }
                else
                {
                    int index = path.LastIndexOf('/');
                    if (index != -1)
                    {
                        tree(dt.Rows[i]["id"].ToString(), path.Remove(index, path.Length - index));
                    }
                }
            }
        }
    }
    #endregion

    #region class_tree初始
    protected void classtree(string id, string path)
    {
        DataTable dt, dt2;
        dt = MenuBLL.GetClassByParentId(id).Tables[0];
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

                dt2 = MenuBLL.GetClassByParentId(dt.Rows[i]["id"].ToString()).Tables[0];
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

                dt2 = MenuBLL.GetClassByParentId(dt.Rows[i]["id"].ToString()).Tables[0];
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

    #region class_tree数据绑定
    protected void classdata(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < class_tree.Nodes.Count; i++)
            {
                if (iddata_str.Contains("," + class_tree.Nodes[i].Value + ","))
                {
                    class_tree.Nodes[i].Checked = true;
                }
                if (class_tree.Nodes[i].ChildNodes.Count > 0)
                {
                    classdata(class_tree.Nodes[i].Value);
                }
            }
        }
        else
        {
            for (int i = 0; i < class_tree.FindNode(path).ChildNodes.Count; i++)
            {
                if (iddata_str.Contains("," + class_tree.FindNode(path).ChildNodes[i].Value + ","))
                {
                    class_tree.FindNode(path).ChildNodes[i].Checked = true;
                }
                classdata(path + "/" + class_tree.FindNode(path).ChildNodes[i].Value);
            }
        }
    }
    #endregion

    #region nag_tv数据绑定
    protected void treedata(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < nag_tv.Nodes.Count; i++)
            {
                if (iddata_str.Contains("," + nag_tv.Nodes[i].Value + ","))
                {
                    nag_tv.Nodes[i].Checked = true;
                }
                if (nag_tv.Nodes[i].ChildNodes.Count > 0)
                {
                    treedata(nag_tv.Nodes[i].Value);
                }
            }
        }
        else
        {
            for (int i = 0; i < nag_tv.FindNode(path).ChildNodes.Count; i++)
            {
                if (iddata_str.Contains("," + nag_tv.FindNode(path).ChildNodes[i].Value + ","))
                {
                    nag_tv.FindNode(path).ChildNodes[i].Checked = true;
                }
                treedata(path + "/" + nag_tv.FindNode(path).ChildNodes[i].Value);
            }
        }
    }
    #endregion

    protected void Button1_Click(object sender, EventArgs e)
    {
        id_str = null;

        int yon = RoleBLL.RoleEdit(name_tb.Text, popid("-1").TrimEnd(','), classid("-1").TrimEnd(','), des_tb.Text, Request["id"]);
        if (yon > 0)
        {
            self.alert("执行成功！");
            self.href("role_list.aspx");
        }
    }

    #region 提交数据时，获取popdomID值
    protected string popid(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < nag_tv.Nodes.Count; i++)
            {
                if (nag_tv.Nodes[i].Checked)
                {
                    id_str = id_str + nag_tv.Nodes[i].Value + ",";
                }
                popid(nag_tv.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < nag_tv.FindNode(path).ChildNodes.Count; i++)
            {
                if (nag_tv.FindNode(path).ChildNodes[i].Checked)
                {
                    id_str = id_str + nag_tv.FindNode(path).ChildNodes[i].Value + ",";
                }
                popid(path + "/" + nag_tv.FindNode(path).ChildNodes[i].Value);
            }
        }
        return id_str;
    }
    #endregion

    #region 提交数据时，获取classID值
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
                if (class_tree.Nodes[i].ChildNodes.Count > 0)
                {
                    classid(class_tree.Nodes[i].Value);
                }
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
        return classid_str;
    }
    #endregion

    #region 全选
    protected string funCheckAllMenu(string path)
    {
        if (path == "-1")
        {
            for (int i = 0; i < nag_tv.Nodes.Count; i++)
            {
                nag_tv.Nodes[i].Checked = true;
                funCheckAllMenu(nag_tv.Nodes[i].Value);
            }
        }
        else
        {
            for (int i = 0; i < nag_tv.FindNode(path).ChildNodes.Count; i++)
            {
                nag_tv.FindNode(path).ChildNodes[i].Checked = true;
                funCheckAllMenu(path + "/" + nag_tv.FindNode(path).ChildNodes[i].Value);
            }
        }
        return "";
    }
    #endregion

    protected void del_btn_Click(object sender, EventArgs e)
    {
        int yon = RoleBLL.DeleteRole(Request["id"]);
        if (yon > 0)
        {
            self.alert("删除成功！");
            self.href("role_list.aspx");
        }
        else
        {
            self.alert("数据有约束，无法删除！");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        menumove(-1, "");
    }
    #region menu数据绑定
    protected void menumove(int parent, string parent1)
    {
        parent_hid.Value = parent.ToString();
        parent_hid1.Value = parent1.ToString();
        if (parent1 == "")
        {
            Label1.Text = "";
        }
        else
        {
            Label1.Text = "→　" + parent1;
        }

        menu_lb.DataSource = MenuBLL.GetMenuByParentId(parent.ToString()).Tables[0];
        menu_lb.DataTextField = "pagename";
        menu_lb.DataValueField = "id";
        menu_lb.DataBind();
    }
    #endregion
    protected void menu_btn_Click(object sender, EventArgs e)
    {

    }
    protected void nag_tv_SelectedNodeChanged(object sender, EventArgs e)
    {
        menumove(int.Parse(nag_tv.SelectedValue), nag_tv.SelectedNode.Text);
        Label1.Text = "→　" + nag_tv.SelectedNode.Text;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //string sql;
        //int upindex, downindex;
        //int uplv, downlv;

        //upindex = menu_lb.SelectedIndex - 1;
        //downindex = menu_lb.SelectedIndex;

        //sql = "select lv from tsys_menu where id = " + menu_lb.Items[upindex].Value;
        //uplv = int.Parse(DbHelperSQL.GetSingle(sql).ToString());
        //sql = "select lv from tsys_menu where id = " + menu_lb.Items[downindex].Value;
        //downlv = int.Parse(DbHelperSQL.GetSingle(sql).ToString());

        //sql = "update tsys_menu set lv = " + downlv + " where id = " + menu_lb.Items[upindex].Value;
        //DbHelperSQL.ExecuteSql(sql);
        //sql = "update tsys_menu set lv = " + uplv + " where id = " + menu_lb.Items[downindex].Value;
        //DbHelperSQL.ExecuteSql(sql);

        //if (parent_hid.Value == "")
        //{
        //    dsbind();
        //    menumove(-1, "");
        //}
        //else
        //{
        //    dsbind();
        //    menumove(int.Parse(parent_hid.Value), parent_hid1.Value);
        //}
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        //string sql;
        //int upindex, downindex;
        //int uplv, downlv;

        //upindex = menu_lb.SelectedIndex;
        //downindex = menu_lb.SelectedIndex + 1;

        //sql = "select lv from tsys_menu where id = " + menu_lb.Items[upindex].Value;
        //uplv = int.Parse(DbHelperSQL.GetSingle(sql).ToString());
        //sql = "select lv from tsys_menu where id = " + menu_lb.Items[downindex].Value;
        //downlv = int.Parse(DbHelperSQL.GetSingle(sql).ToString());

        //sql = "update tsys_menu set lv = " + downlv + " where id = " + menu_lb.Items[upindex].Value;
        //DbHelperSQL.ExecuteSql(sql);
        //sql = "update tsys_menu set lv = " + uplv + " where id = " + menu_lb.Items[downindex].Value;
        //DbHelperSQL.ExecuteSql(sql);

        //if (parent_hid.Value == "")
        //{
        //    dsbind();
        //    menumove(-1, "");
        //}
        //else
        //{
        //    dsbind();
        //    menumove(int.Parse(parent_hid.Value), parent_hid1.Value);
        //}
    }
    protected void lbAllMenu_Click(object sender, EventArgs e)
    {
        funCheckAllMenu("-1");
    }
}