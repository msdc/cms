using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ISS.CMS.BLL;
using ISS.CMS.Model;
public partial class Manage_author_mdy : System.Web.UI.Page
{
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

        if (Request["id"] != null)
        {
            Author model = AuthorBll.GetModel(Convert.ToInt32(Request["id"]));            
          
            id_tb.Text = model.Id.ToString();
            title_tb.Text = model.Title;
            sex_rbl.SelectedValue = model.Sex;
            email_tb.Text = model.Email;
            content_tb.Text = model.Content;
            state_lbl.Text = "修改作者";
        }
        else
        {
            state_lbl.Text = "添加作者";
            id_tr.Visible = false;
            lbDel.Visible = false;
        }

    }
    #endregion
    protected void lbOk_Click(object sender, EventArgs e)
    {
        bool isOk = false;

        Author model = new Author();
        if (Request["id"] != null)
        {
            model.Id = Convert.ToInt32(Request["id"]);
            model.Title = title_tb.Text;
            model.Content = content_tb.Text;
            model.Email = email_tb.Text;
            model.Sex = sex_rbl.SelectedValue;
            isOk = AuthorBll.Update(model);
        }
        else
        {
            model.Title = title_tb.Text;
            model.Content = content_tb.Text;
            model.Email = email_tb.Text;
            model.Sex = sex_rbl.SelectedValue;
            isOk = AuthorBll.Add(model) > 0 ? true : false;
        }
        if (isOk)
        {
            self.alert("执行成功");
            self.href("author_list.aspx?page=" + Request["page"]);
        }
        else
        {
            self.alert("执行失败");
        }
    }
    protected void lbDel_Click(object sender, EventArgs e)
    {

        if (AuthorBll.Delete(Convert.ToInt32(id_tb.Text)))
        {
            self.alert("删除成功");
            self.href("author_list.aspx");
        }
        else
        {
            self.alert("数据有关联无法删除!");
        }
    }
}