using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
namespace ISS.CMS.DAL
{
    public class AuthorDaoProxy : IAuthor
    {
        private IAuthor author;
        public AuthorDaoProxy()
        {
            author = new AuthorDaoImpl();
        }
        public int GetMaxId()
        {
            throw new NotImplementedException();
        }

        public bool Exists(int Id)
        {
            throw new NotImplementedException();
        }

        public int Add(Model.Author model)
        {
            return author.Add(model);
        }

        public bool Update(Model.Author model)
        {
            return author.Update(model);
        }

        public bool Delete(int Id)
        {
            return author.Delete(Id);
        }

        public bool DeleteList(string Idlist)
        {
            throw new NotImplementedException();
        }

        public Model.Author GetModel(int Id)
        {
            return author.GetModel(Id);
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string strWhere)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetAuthor()
        {
            return author.GetAuthor();
        }
    }
}
