using ISS.CMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class StaticInsertDaoFactory
    {
        private static StaticInsertProxy instance;
        public static StaticInsertProxy Instance()
        {
            if (instance == null)
            {
                instance = new StaticInsertProxy();
            }
            return instance;
        }

        public static ISS.CMS.IDAL.IStaticInsertDao Create()
        {
            return Instance();
        }
    }
}
