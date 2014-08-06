using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.DAL;
using ISS.CMS.IDAL;
namespace ISS.CMS.ClassFactory
{
    public class SpecialityFactory
    {
        private static SpecialityDaoProxy instance;
        public static SpecialityDaoProxy Instance()
        {
            if (instance == null)
            {
                instance = new SpecialityDaoProxy();
            }
            return instance;
        }

        public static ISpeciality Create()
        {
            return Instance();
        }

    }
}
