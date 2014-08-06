using ISS.CMS.DAL;
using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class RoleDaoFactory
    {
        private static RoleDaoProxy instance;
        public static RoleDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new RoleDaoProxy();
            }
            return instance;
        }

        public static IRoleDao Create()
        {
            return Instance();
        }
    }
}
