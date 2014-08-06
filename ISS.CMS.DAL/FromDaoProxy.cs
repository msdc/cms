using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
namespace ISS.CMS.DAL
{
    public class FromDaoProxy : IFrom
    {
        private IFrom from;
        public FromDaoProxy()
        {
            from = new FromDaoImpl();
        }
        public int GetMaxId()
        {
            throw new NotImplementedException();
        }

        public bool Exists(int Id)
        {
            return from.Exists(Id);
        }

        public int Add(From model)
        {
            return from.Add(model);
        }

        public bool Update(From model)
        {
            return from.Update(model);
        }

        public bool Delete(int Id)
        {
            return from.Delete(Id);
        }

        public bool DeleteList(string Idlist)
        {
            return from.DeleteList(Idlist);
        }

        public From GetModel(int Id)
        {
            return from.GetModel(Id);
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            return from.GetList(strWhere);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return from.GetList(Top, strWhere, filedOrder);
        }

        public int GetRecordCount(string strWhere)
        {
            return from.GetRecordCount(strWhere);
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return from.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        public System.Data.DataSet GetFrom()
        {
            return from.GetFrom();
        }
    }
}
