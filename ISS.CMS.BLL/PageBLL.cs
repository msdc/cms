using ISS.CMS.ClassFactory;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class PageBLL
    {
        public static PageView GetNewsPageView(string page, string sqlwhere)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }

            PageView pageView = PageDaoFactory.Create().GetPageView("[V_NewsView]", "*", "id", 10, pageIndex, sqlwhere, "addtime desc");
            return pageView;
        }
        public static PageView GetSpecialityPageView(string page, string sqlwhere)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
          
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_Speciality", "*", "id", 10, pageIndex, sqlwhere, "ID asc");
            return pageView;
        }
        public static PageView GetFromPageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_from", "*", "id", 10, pageIndex, "", "ID asc");
            return pageView;
        }
        public static PageView GetAuthorPageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_author", "*", "id", 10, pageIndex, "", "ID asc");
            return pageView;
        }
        public static PageView GetRolePageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_role", "*", "id", 10, pageIndex, "", "ID asc");
            return pageView;
        }
        public static PageView GetUserPageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_user", "*", "id", 10, pageIndex, "", "addtime asc");
            return pageView;
        }
        public static PageView GetTemplatePageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_template", "*", "id", 10, pageIndex, "", "ID asc");
            return pageView;
        }
        public static PageView GetClassPageView(string page, int pageSize, string sqlWhere)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("[tsys_class]", "*", "id", pageSize, pageIndex, sqlWhere, "OrderID ASC");
            return pageView;
        }

        public static PageView GetStaticinsertPageView(string page)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(page);
            }
            catch
            {
                pageIndex = 1;
            }
            PageView pageView = PageDaoFactory.Create().GetPageView("tsys_Staticinsert", "*", "id", 10, pageIndex, "", "ID asc");
            return pageView;
        }

        public static System.Web.UI.WebControls.PagedDataSource GetPageDataSoureView(DataTable dt, int pageSize, int pageIndex)
        {
            if (dt == null) return null;
            if (pageIndex < 0) pageIndex = 1;
            System.Web.UI.WebControls.PagedDataSource ps = new System.Web.UI.WebControls.PagedDataSource();
            ps.DataSource = dt.DefaultView;
            ps.AllowPaging = true;
            ps.PageSize = pageSize;
            ps.CurrentPageIndex = pageIndex;
            return ps;
        }
    }
}
