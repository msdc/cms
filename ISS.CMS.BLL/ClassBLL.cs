using ISS.CMS.ClassFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class ClassBLL
    {
        public static DataSet GetClassById(string id)
        {
            return ClassDaoFactory.Create().GetClassById(id);
        }

        public static string GetClassMapById(string id)
        {
            return ClassDaoFactory.Create().GetClassMapById(id);
        }

        public static int GetClassCount()
        {
            return ClassDaoFactory.Create().GetClassCount();
        }

        public static DataSet GetClassId()
        {
            return ClassDaoFactory.Create().GetClassId();
        }

        public static DataSet GetClassByParent(string parent)
        {
            return ClassDaoFactory.Create().GetClassByParent(parent);
        }

        public static DataSet GetClassByParentAndIdInClassId(string parent, string classId, string sqlOrder)
        {
            return ClassDaoFactory.Create().GetClassByParentAndIdInClassId(parent, classId, sqlOrder);
        }

        public static DataSet GetSubCategory(string parent, string classIdStr)
        {
            if (string.IsNullOrEmpty(parent))
            {
                parent = "-1";
            }
            return GetClassByParentAndIdInClassId(parent, classIdStr, "OrderID desc");
        }

        public static string GetClassString(string id, string classId, string classStr)
        {
            DataTable dt, dt2;
            dt = GetClassByParentAndIdInClassId(id, classId, "addtime").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                classStr += dt.Rows[i]["id"].ToString() + ",";

                //sql = "select * from [tsys_class] where parent =" + dt.Rows[i]["id"].ToString() + " order by addtime";
                dt2 = GetClassByParent(dt.Rows[i]["id"].ToString()).Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    GetClassString(dt.Rows[i]["id"].ToString(), classId, classId);
                }
            }
            return classStr;
        }

        public static int DeleteClass(string id)
        {
            return ClassDaoFactory.Create().DeleteClass(id);
        }

        public static int AddClass(string title, string title2, string directory, string template, string parent, string orderid, string map)
        {
            return ClassDaoFactory.Create().AddClass(title, title2, directory, template, parent, orderid, map);
        }

        public static int UpdateClass(string parent, string title, string title2, string directory, string template, string orderid, string map, string id, bool updateParent)
        {
            return ClassDaoFactory.Create().UpdateClass(parent, title, title2, directory, template, orderid, map, id, updateParent);
        }

        public static int EditClass(string title, string title2, string directory, string template, string orderid, string map, string parent, string id, bool updateParent)
        {
            if (id != null)
            {
                return UpdateClass(parent, title, title2, directory, template, orderid, map, id, updateParent);
            }
            else
            {
                return AddClass(title, title2, directory, template, parent, orderid, map);
            }
        }

        public static Model.ClassModel GetModel(int Id)
        {
            return ClassDaoFactory.Create().GetModel(Id);
        }
        public static int Add(Model.ClassModel model)
        {
            if (model != null)
            {
                return ClassDaoFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        public static bool Update(Model.ClassModel model)
        {
            if (model != null)
            {
                return ClassDaoFactory.Create().Update(model);
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

        public static string GetClassIdByRoleName(string roleName)
        {
            string classid = "0";
            if (roleName == "admin")
            {
                DataTable dt = ClassBLL.GetClassId().Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    classid += dt.Rows[i]["id"] + ",";
                }
                return classid.TrimEnd(',');
            }
            else
            {
                return RoleBLL.GetRoleClassIdByName(roleName);
                //return null;
            }
        }

        public static System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] sqlOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return ClassDaoFactory.Create().GetList(fieldNames, fieldValues, sqlOperator, whereOperator, orderField, isAsc);
        }



        public static DataSet GetClass(string roleName)
        {
            if (roleName != "admin")
            {
                return ClassDaoFactory.Create().GetClassInScope(GetClassIdByRoleName(roleName));
            }
            else
            {
                return ClassDaoFactory.Create().GetClass();
            }
        }
    }
}
