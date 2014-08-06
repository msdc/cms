using ISS.CMS.DAL;
using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class MenuDaoFactory
    {
        private static MenuDaoProxy instance;
        public static MenuDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new MenuDaoProxy();
            }
            return instance;
        }

        public static IMenuDao Create()
        {
            return Instance();
        }
    }
}
