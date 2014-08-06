using ISS.CMS.DAL;
using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class TemplateDaoFactory
    {
        private static TemplateDaoProxy instance;
        public static TemplateDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new TemplateDaoProxy();
            }
            return instance;
        }

        public static ITemplateDao Create()
        {
            return Instance();
        }
    }
}
