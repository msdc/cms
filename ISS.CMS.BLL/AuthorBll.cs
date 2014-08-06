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
    public class AuthorBll
    {
        public static Model.Author GetModel(int Id)
        {
            return AuthorFactory.Create().GetModel(Id);
        }
        public static int Add(Model.Author model)
        {
            if (model != null)
            {
                return AuthorFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        public static bool Update(Model.Author model)
        {
            if (model != null)
            {
                return AuthorFactory.Create().Update(model);
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(int Id)
        {
            return AuthorFactory.Create().Delete(Id);
        }

        public DataSet GetAuthor()
        {
            return AuthorFactory.Create().GetAuthor();
        }
    }
}
