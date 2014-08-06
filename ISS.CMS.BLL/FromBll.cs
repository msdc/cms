using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.ClassFactory;
namespace ISS.CMS.BLL
{
    public class FromBll
    {
        public static Model.From GetModel(int Id)
        {
            return FromFactory.Create().GetModel(Id);
        }
        public static int Add(Model.From model)
        {
            if (model != null)
            {
                return FromFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        public static bool Update(Model.From model)
        {
            if (model != null)
            {
                return FromFactory.Create().Update(model);
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(int Id)
        {
            return FromFactory.Create().Delete(Id);
        }

        public System.Data.DataSet GetFrom()
        {
            return FromFactory.Create().GetFrom();
        }
    }
}
