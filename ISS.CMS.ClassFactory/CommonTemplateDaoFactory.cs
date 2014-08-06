using ISS.CMS.DAL;
using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class CommonTemplateDaoFactory
    {
        private static CommonTemplateDaoProxy instance;
        public static CommonTemplateDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new CommonTemplateDaoProxy();
            }
            return instance;
        }

        public static ICommonTemplateDao Create()
        {
            return Instance();
        }
    }
}
