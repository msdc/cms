using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class MenuDaoProxy : IMenuDao
    {
        private IMenuDao dao;

        public MenuDaoProxy()
        {
            this.dao = new MenuDaoImpl();
        }

        public DataSet GetMenuByParentId(string parentId)
        {
            return this.dao.GetMenuByParentId(parentId);
        }

        public DataSet GetClassByParentId(string parentId)
        {
            return this.dao.GetClassByParentId(parentId);
        }

        public DataSet GetMenuById(string id)
        {
            return this.dao.GetMenuById(id);
        }

        public DataSet GetMenu()
        {
            return this.dao.GetMenu();
        }

        public DataSet GetClass()
        {
            return this.dao.GetClass();
        }

        public DataSet GetAdminPermission()
        {
            return this.dao.GetAdminPermission();
        }

        public int DeleteMenu(string id)
        {
            return this.dao.DeleteMenu(id);
        }

        public int UpdateMenuCorrespondingPage(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string haspage, string description, string id)
        {
            return this.dao.UpdateMenuCorrespondingPage(pagename, pagefiledir, pagetitle, subpagetitle, haspage, description, id);
        }

        public int UpdateMenu(string pagename, string haspage, string description, string id)
        {
            return this.dao.UpdateMenu(pagename, haspage, description, id);
        }

        public int AddMenu(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string parentid, string haspage, string description, string orderid)
        {
            return this.dao.AddMenu(pagename, pagefiledir, pagetitle, subpagetitle, parentid, haspage, description, orderid);
        }

        public int GetMenuMaxOrderIdByParentId(string parentid)
        {
            return this.dao.GetMenuMaxOrderIdByParentId(parentid);
        }

        public int GetCountOfMenuIdByPageTitle(string filename)
        {
            return this.dao.GetCountOfMenuIdByPageTitle(filename);
        }

        public string GetMenuIdByPageTite(string filename)
        {
            return this.dao.GetMenuIdByPageTite(filename);
        }

        public string GetMenuIdBySubPageTite(string filename)
        {
            return this.dao.GetMenuIdBySubPageTite(filename);
        }
    }
}
