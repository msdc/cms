using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
using ISS.CMS.IDAL;
using ISS.CMS.ClassFactory;
using System.Data;
namespace ISS.CMS.BLL
{
    public class SpecialityBll
    {
        public static Model.Speciality GetModel(int Id)
        {
            return SpecialityFactory.Create().GetModel(Id);
        }
        public static int Add(Model.Speciality model)
        {
            if (model != null)
            {
                return SpecialityFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        public static bool Update(Model.Speciality model)
        {
            if (model != null)
            {
                return SpecialityFactory.Create().Update(model);
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(int Id)
        {
            return SpecialityFactory.Create().Delete(Id);
        }

        public DataSet GetSpeciality()
        {
            return SpecialityFactory.Create().GetSpeciality();
        }
    }
}
