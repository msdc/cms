using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.DAL;
namespace ISS.CMS.ClassFactory
{
    public class FromFactory
    {
        private static FromDaoProxy instance;
        public static FromDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new FromDaoProxy();
            }
            return instance;
        }

        public static ISS.CMS.IDAL.IFrom Create()
        {
            return Instance();
        }
    }
}
