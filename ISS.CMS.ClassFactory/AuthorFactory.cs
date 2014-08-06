using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.DAL;
using ISS.CMS.IDAL;
namespace ISS.CMS.ClassFactory
{
    public class AuthorFactory
    {
        private static AuthorDaoProxy instance;
        public static AuthorDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new AuthorDaoProxy();
            }
            return instance;
        }

        public static IAuthor Create()
        {
            return Instance();
        }

    }
}
