using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.DAL;
using ISS.CMS.IDAL;
namespace ISS.CMS.ClassFactory
{
    public class NewsViewFactory
    {
        private static NewsViewDaoProxy instance;
        public static NewsViewDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new NewsViewDaoProxy();
            }
            return instance;
        }

        public static INewsView Create()
        {
            return Instance();
        }

    }
}
