using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.IDAL
{
    public interface IRoleDao
    {
        DataSet GetRole();

        string GetRolePageId(string roldId);

        DataSet GetRolePageIdById(string id);

        DataSet GetRoleClassIdById(string id);

        string GetRoleClassIdByName(string name);

        DataSet GetRoleTemplateById(string id);

        string GetRoleTemplateIdByName(string name);

        DataSet GetRoleById(string id);

        int UpdateRole(string name, string pageId, string classId, string description, string id);

        int AddRole(string name, string pageId, string classId, string description);

        int DeleteRole(string id);
    }
}
