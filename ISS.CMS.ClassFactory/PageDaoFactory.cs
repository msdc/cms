using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.DAL;

namespace ISS.CMS.ClassFactory
{
    public class PageDaoFactory
    {
        private static PageDaoProxy instance;
        public static PageDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new PageDaoProxy();
            }
            return instance;
        }

        public static IPageDao Create()
        {
            return Instance();
        }
    }
}
