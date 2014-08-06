using ISS.CMS.DAL;
using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.ClassFactory
{
    public class ClassDaoFactory
    {
        private static ClassDaoProxy instance;
        public static ClassDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new ClassDaoProxy();
            }
            return instance;
        }

        public static IClassDao Create()
        {
            return Instance();
        }
    }
}
