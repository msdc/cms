using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class RoleDaoProxy : IRoleDao
    {
        private IRoleDao dao;

        public RoleDaoProxy()
        {
            this.dao = new RoleDaoImpl();
        }

        public DataSet GetRole()
        {
            return this.dao.GetRole();
        }

        public string GetRolePageId(string roldId)
        {
            return this.dao.GetRolePageId(roldId);
        }

        public DataSet GetRolePageIdById(string id)
        {
            return this.dao.GetRolePageIdById(id);
        }

        public DataSet GetRoleClassIdById(string id)
        {
            return this.dao.GetRoleClassIdById(id);
        }

        public string GetRoleClassIdByName(string name)
        {
            return this.dao.GetRoleClassIdByName(name);
        }

        public DataSet GetRoleTemplateById(string id)
        {
            return this.dao.GetRoleTemplateById(id);
        }

        public string GetRoleTemplateIdByName(string name)
        {
            return this.dao.GetRoleTemplateIdByName(name);
        }

        public DataSet GetRoleById(string id)
        {
            return this.dao.GetRoleById(id);
        }

        public int UpdateRole(string name, string pageId, string classId, string description, string id)
        {
            return this.dao.UpdateRole(name, pageId, classId, description, id);
        }

        public int AddRole(string name, string pageId, string classId, string description)
        {
            return this.dao.AddRole(name, pageId, classId, description);
        }

        public int DeleteRole(string id)
        {
            return this.dao.DeleteRole(id);
        }
    }
}
