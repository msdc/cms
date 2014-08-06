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

public partial class manage_insertSYSnew_mdy : System.Web.UI.Page
{
    string classid_ds;
    string classid_str = "";
    string specialityid_str = "";
    string speciality_ds = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dsbind();
        }
    }

    #region 页面初始
    protected void dsbind()
    {      
        if (Request["id"] != null && Request["id"] != "")
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DynamicInsert di = DynamicInsertBLL.GetModel(id);

            title_tb.Text = di.title;
            tbLength.Text = di.Length.ToString();
            startelement_tb.Text = di.startelement;
            endelement_tb.Text = di.endelement;
            time_ddl.SelectedValue = di.bytime;
            sort_ddl.SelectedValue = di.bysort;
            looptime_tb.Text = di.looptime.ToString();
            //ispage_ddl.SelectedIndex = Convert.ToInt32(di.ispage.ToString());
            if (ispage_ddl.SelectedIndex != 0)
            {
                ispage1_tr.Style["display"] = "";
                ispage2_tr.Style["display"] = "";
            }
            content_tb.Text = di.content;
            tbPageNumber.Text = di.PageNumber.ToString();
            pageContent_tb.Text = di.pagecontent;
            filelist_tb.Text = di.filelist;
            classid_ds = "," + di.classw + ",";
            //classdata("-1");
            speciality_ds = "," + di.speciality + ",";
            //specialitydata("-1");
            ddlEncoding.SelectedValue = di.Encoding;

            state_lbl.Text = "修改动态模板";
        }
        else
        {
            state_lbl.Text = "添加动态模板";
            lbDel.Visible = false;
        }
    }
    #endregion

    #region 提交数据时，获取classID值
    protected string getClassID()
    {
        funClassID(class_tree.Nodes);
        return classid_str.TrimEnd(',');
    }
    protected void funClassID(TreeNodeCollection tnc)
    {
        for (int i = 0; i < tnc.Count; i++)
        {
            if (tnc[i].Checked)
            {
                classid_str = classid_str + tnc[i].Value + ",";
            }
            if (tnc[i].ChildNodes.Count > 0)
            {
                funClassID(tnc[i].ChildNodes);
            }
        }
    }
    #endregion
    #region 提交数据时，获取specialityID值
    protected string getSpecialityID()
    {
        funSpecialityID(speciality_tree.Nodes);
        return specialityid_str.TrimEnd(',');
    }
    protected void funSpecialityID(TreeNodeCollection tnc)
    {
        for (int i = 0; i < tnc.Count; i++)
        {
            if (tnc[i].Checked)
            {
                specialityid_str = specialityid_str + tnc[i].Value + ",";
            }
            if (tnc[i].ChildNodes.Count > 0)
            {
                funSpecialityID(tnc[i].ChildNodes);
            }
        }
    }
    #endregion
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        if (Request["id"] != null && Request["id"] != "")
        {
            //update
            DynamicInsert di = new DynamicInsert();
            di.id = Convert.ToInt32(Request.QueryString["id"]);
            di.title = title_tb.Text;
            di.Length = Convert.ToInt32(tbLength.Text);
            di.startelement = startelement_tb.Text;
            di.endelement = endelement_tb.Text;
            di.content = content_tb.Text;
            di.PageNumber = Convert.ToInt32(tbPageNumber.Text);
            di.pagecontent = pageContent_tb.Text;
            di.bytime = time_ddl.SelectedValue;
            di.bysort = sort_ddl.SelectedValue;
            di.looptime = Convert.ToInt32(looptime_tb.Text);
            di.Encoding = ddlEncoding.SelectedValue;
            di.ispage = Convert.ToBoolean(ispage_ddl.SelectedIndex);
            di.filelist = filelist_tb.Text;
            DynamicInsertBLL.Update(di);  
        }
        else
        {
            //add
            DynamicInsert di = new DynamicInsert();
            di.title = title_tb.Text;
            di.Length = Convert.ToInt32(tbLength.Text);
            di.startelement = startelement_tb.Text;
            di.endelement = endelement_tb.Text;
            di.content = content_tb.Text;
            di.PageNumber = Convert.ToInt32(tbPageNumber.Text);
            di.pagecontent = pageContent_tb.Text;
            di.bytime = time_ddl.SelectedValue;
            di.bysort = sort_ddl.SelectedValue;
            di.looptime = Convert.ToInt32(looptime_tb.Text);
            di.Encoding = ddlEncoding.SelectedValue;
            di.ispage = Convert.ToBoolean(ispage_ddl.SelectedIndex);
            di.filelist = filelist_tb.Text;
            DynamicInsertBLL.Add(di);         
        }
        Response.Redirect("DynamicInsert_list.aspx?page=" + Request["page"]);
    }
    protected void lbDel_Click(object sender, EventArgs e)
    {        
        int id=Convert.ToInt32(Request.QueryString["id"]);
        DynamicInsertBLL.Delete(id);
        Response.Redirect("DynamicInsert_list.aspx?page=" + Request["page"]);
    }
}
