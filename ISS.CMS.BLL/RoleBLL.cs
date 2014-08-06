using ISS.CMS.ClassFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class RoleBLL
    {
        public static DataSet GetRolePageIdById(string id)
        {
            return RoleDaoFactory.Create().GetRolePageIdById(id);
        }

        public static DataSet GetRoleClassIdById(string id)
        {
            return RoleDaoFactory.Create().GetRoleClassIdById(id);
        }

        public static string GetRoleClassIdByName(string name)
        {
            return RoleDaoFactory.Create().GetRoleClassIdByName(name);
        }

        public static DataSet GetRoleTemplateById(string id)
        {
            return RoleDaoFactory.Create().GetRoleTemplateById(id);
        }

        public static string GetRoleTemplateIdByName(string name)
        {
            return RoleDaoFactory.Create().GetRoleTemplateIdByName(name);
        }

        public static DataSet GetRoleById(string id)
        {
            return RoleDaoFactory.Create().GetRoleById(id);
        }

        public static int RoleEdit(string name, string pageId, string classId, string description, string id)
        {
            if (id != null)
            {
                return RoleDaoFactory.Create().UpdateRole(name, pageId, classId, description, id);
            }
            else
            {
                return RoleDaoFactory.Create().AddRole(name, pageId, classId, description);
            }
        }

        public static int DeleteRole(string id)
        {
            return RoleDaoFactory.Create().DeleteRole(id);
        }
    }
}
