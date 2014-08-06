using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.DAL;

namespace ISS.CMS.ClassFactory
{
    public class UserDaoFactory
    {
        private static UserDaoProxy instance;
        public static UserDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new UserDaoProxy();
            }
            return instance;
        }

        public static IUserDao Create()
        {
            return Instance();
        }

    }
}
