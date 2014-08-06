using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ISS.CMS.BLL;
using ISS.CMS.Model;
public partial class Manage_speciality_mdy : System.Web.UI.Page
{
    string content;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            validate.init();
            dsbind();
            td();
        }
    }
    #region 页面初始
    private void dsbind()
    {
        if (Request["id"] != null)
        {
            //SpecialityBll speciality = new SpecialityBll();
            Speciality model = SpecialityBll.GetModel(Convert.ToInt32(Request["id"]));
            title_tb.Text = model.Title;
            explain_tb.Text = model.Explain;
            state_lbl.Text = "修改特性";
        }
        else
        {
            state_lbl.Text = "添加特性";
            lbDel.Visible = false;
        }
    }
    #endregion

    #region 详细位子递规
    protected void node(int id)
    {
        //SpecialityBll speciality = new SpecialityBll();
        Speciality model = SpecialityBll.GetModel(id);
        content = " ＞ <a href='Speciality_list.aspx?parent=" + model.Id.ToString() + "'>" + model.Title + "</a>" + content;
        if (model.Parent.ToString() != "-1")
        {
            node(Convert.ToInt32(model.Parent));
        }
    }
    #endregion
    #region 详细位子数据绑定
    protected void td()
    {
        if (Request["parent"] != null && Request["parent"] != "")
        {
            if (Request["parent"] != "-1")
                node(Convert.ToInt32(Request["parent"]));
        }
        TD1.InnerHtml = "<a href='Speciality_list.aspx'>根类别</a>" + content + " 的子分类列表";

    }
    #endregion
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        bool isOk = false;
        //SpecialityBll speciality = new SpecialityBll();
        Speciality model = new Speciality();
        if (Request["id"] != null)
        {
            model.Id = Convert.ToInt32(Request["id"]);
            model.Title = title_tb.Text;
            model.Explain = explain_tb.Text;
            model.Parent = Request["parent"] != "" && Request["parent"] != null ? Convert.ToInt32(Request["parent"]) : -1;
            isOk = SpecialityBll.Update(model);
        }
        else
        {
            model.Title = title_tb.Text;
            model.Explain = explain_tb.Text;
            model.Parent = Request["parent"] != "" && Request["parent"] != null ? Convert.ToInt32(Request["parent"]) : -1;
            isOk = SpecialityBll.Add(model) > 0 ? true : false;
        }
        if (isOk)
        {
            self.alert("执行成功");
            self.href("Speciality_list.aspx?page=" + Request["page"] + "&parent=" + Request["parent"]);
        }
        else
        {
            self.alert("执行失败");
        }


    }
    protected void lbDel_Click(object sender, EventArgs e)
    {
       
        if (SpecialityBll.Delete(Convert.ToInt32(Request["id"])))
        {
            self.alert("删除成功");
            self.href("from_list.aspx");
        }
        else
        {
            self.alert("数据有关联无法删除!");
        }

    }
}