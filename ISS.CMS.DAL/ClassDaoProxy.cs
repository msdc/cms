using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class ClassDaoProxy : IClassDao
    {
        private IClassDao dao;

        public ClassDaoProxy()
        {
            this.dao = new ClassDaoImpl();
        }

        public DataSet GetClassById(string id)
        {
            return this.dao.GetClassById(id);
        }

        public string GetClassMapById(string id)
        {
            return this.dao.GetClassMapById(id);
        }

        public int GetClassCount()
        {
            return this.dao.GetClassCount();
        }

        public DataSet GetClass()
        {
            return this.dao.GetClass();
        }

        public DataSet GetClassInScope(string scopeStr)
        {
            return this.dao.GetClassInScope(scopeStr);
        }

        public int DeleteClass(string id)
        {
            return this.dao.DeleteClass(id);
        }

        public int AddClass(string title, string title2, string directory, string template, string parent, string orderid, string map)
        {
            return this.dao.AddClass(title, title2, directory, template, parent, orderid, map);
        }

        public int UpdateClass(string parent, string title, string title2, string directory, string template, string orderid, string map, string id, bool updateParent)
        {
            return this.dao.UpdateClass(parent, title, title2, directory, template, orderid, map, id, updateParent);
        }


        public int GetMaxId()
        {
            return dao.GetMaxId();
        }

        public bool Exists(int Id)
        {
            return dao.Exists(Id);
        }

        public int Add(Model.ClassModel model)
        {
            return dao.Add(model);
        }

        public bool Update(Model.ClassModel model)
        {
            return dao.Update(model);
        }

        public bool Delete(int Id)
        {
            return dao.Delete(Id);
        }

        public bool DeleteList(string Idlist)
        {
            throw new NotImplementedException();
        }

        public Model.ClassModel GetModel(int Id)
        {
            return dao.GetModel(Id);
        }

        public DataSet GetList(string strWhere)
        {
            throw new NotImplementedException();
        }

        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string strWhere)
        {
            throw new NotImplementedException();
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }


        public DataSet GetList(string[] fieldNames, string[] fieldValues, string[] sqlOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return dao.GetList(fieldNames, fieldValues, sqlOperator, whereOperator, orderField, isAsc);
        }


        public DataSet GetClassId()
        {
            return dao.GetClassId();
        }

        public DataSet GetClassByParent(string parent)
        {
            return dao.GetClassByParent(parent);
        }

        public DataSet GetClassByParentAndIdInClassId(string parent, string classId, string sqlOrder)
        {
            return dao.GetClassByParentAndIdInClassId(parent, classId, sqlOrder);
        }

       

    
    }
}
