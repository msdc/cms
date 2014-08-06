using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.DAL;

namespace ISS.CMS.ClassFactory
{
    public class DynamicInsertDaoFactory
    {
        private static DynamicInsertProxy instance;
        public static DynamicInsertProxy Instance()
        {
            if (instance == null)
            {
                instance = new DynamicInsertProxy();
            }
            return instance;
        }

        public static ISS.CMS.IDAL.IDynamicInsertDao Create()
        {
            return Instance();
        }
    }
}
