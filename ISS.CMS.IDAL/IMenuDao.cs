using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.IDAL
{
    public interface IMenuDao
    {
        DataSet GetMenuByParentId(string parentId);

        DataSet GetMenuById(string id);

        DataSet GetMenu();

        DataSet GetClass();

        DataSet GetClassByParentId(string parentId);

        DataSet GetAdminPermission();

        int DeleteMenu(string id);

        int UpdateMenuCorrespondingPage(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string haspage, string description, string id);

        int UpdateMenu(string pagename, string haspage, string description, string id);

        int AddMenu(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string parentid, string haspage, string description, string orderid);

        int GetMenuMaxOrderIdByParentId(string parentid);

        int GetCountOfMenuIdByPageTitle(string filename);

        string GetMenuIdByPageTite(string filename);

        string GetMenuIdBySubPageTite(string filename);
    }
}
