using ISS.CMS.ClassFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class MenuBLL
    {
        public static DataSet GetMenuByParentId(string parentId)
        {
            if (parentId != null && parentId != "")
            {
                return MenuDaoFactory.Create().GetMenuByParentId(parentId);
            }
            return MenuDaoFactory.Create().GetMenuByParentId("-1");            
        }

        public static DataSet GetClassByParentId(string parentId)
        {
            return MenuDaoFactory.Create().GetClassByParentId(parentId);
        }

        public static DataSet GetMenuById(string id)
        {
            return MenuDaoFactory.Create().GetMenuById(id);
        }

        public static DataSet GetMenu()
        {
            return MenuDaoFactory.Create().GetMenu();
        }

        public static DataSet GetClass()
        {
            return MenuDaoFactory.Create().GetClass();
        }               

        public static int DeleteMenu(string id)
        {
            return MenuDaoFactory.Create().DeleteMenu(id);
        }

        public static int EditMenu(string pagename, string pagefiledir, string pagetitle, string subpagetitle, string parentid, string haspage, string description, string id, bool CorrespondingPage)
        {
            if (id != null)
            {
                if (CorrespondingPage)
                {
                    return MenuDaoFactory.Create().UpdateMenuCorrespondingPage(pagename, pagefiledir, pagetitle, subpagetitle, haspage, description, id);
                }
                else
                {
                    return MenuDaoFactory.Create().UpdateMenu(pagename, haspage, description, id);
                }
            }
            else
            {
                string orderid = Convert.ToString(MenuDaoFactory.Create().GetMenuMaxOrderIdByParentId(parentid) + 1);
                if (!CorrespondingPage)
                {
                    pagefiledir = pagetitle = subpagetitle = "";
                }
                return MenuDaoFactory.Create().AddMenu(pagename, pagefiledir, pagetitle, subpagetitle, parentid, haspage, description, orderid);
            }
        }
    }
}
