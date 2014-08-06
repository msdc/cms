using ISS.CMS.ClassFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class TemplateBLL
    {
        public static DataSet GetTemplateById(string id)
        {
            return TemplateDaoFactory.Create().GetTemplateById(id);
        }

        public static DataSet GetTemplateOrderById()
        {
            return TemplateDaoFactory.Create().GetTemplateOrderById();
        }

        public static int DeleteTemplate(string id)
        {
            return TemplateDaoFactory.Create().DeleteTemplate(id);
        }

        public static int TemplateEdit(string title, string content, string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return TemplateDaoFactory.Create().UpdateTemplate(title, content, id);
            }
            else
            {
                return TemplateDaoFactory.Create().AddTemplate(title, content);
            }
        }

        public static DataSet GetTemplateId()
        {
            return TemplateDaoFactory.Create().GetTemplateId();
        }

        public static DataSet GetTemplate()
        {
            return TemplateDaoFactory.Create().GetTemplate();
        }

        public static string GetTemplateIdByRoleName(string roleName)
        {
            string templateid = "0";
            if (roleName == "admin")
            {
                DataTable dt = TemplateBLL.GetTemplateId().Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    templateid += dt.Rows[i]["id"] + ",";
                }
                return templateid.TrimEnd(',');
            }
            else
            {
                return RoleBLL.GetRoleTemplateIdByName(roleName);
                //return null;
            }
        }

        public static DataSet GetTemplate(string roleName)
        {
            if (roleName != "admin")
            {
                return TemplateDaoFactory.Create().GetTemplateInScope(GetTemplateIdByRoleName(roleName));
            }
            else
            {
                return TemplateDaoFactory.Create().GetTemplate();
            }
        }
    }
}
