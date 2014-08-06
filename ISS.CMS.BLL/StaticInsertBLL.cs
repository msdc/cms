using ISS.CMS.ClassFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.BLL
{
    public class StaticInsertBLL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int Add(Model.StaticInsert model)
        {
            if (model != null)
            {
                return StaticInsertDaoFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(Model.StaticInsert model)
        {
            if (model != null)
            {
                return StaticInsertDaoFactory.Create().Update(model);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int Id)
        {
            return StaticInsertDaoFactory.Create().Delete(Id);
        }

        public static DataSet GetStaticInsert(int Id)
        {
            return StaticInsertDaoFactory.Create().GetStaticInsert(Id);
        }

        public static DataSet GetStaticInsertList()
        {
            return StaticInsertDaoFactory.Create().GetStaticInsertList();
        }

        public static bool EditStaticInsert(Model.StaticInsert model, string id)
        {
            if (id != null)
            {
                return Update(model);
            }
            else
            {
                return Add(model) > 0;
            }
        }

        public static DataSet GetStaticInsertInScope(string scope)
        {
            return StaticInsertDaoFactory.Create().GetStaticInsertInScope(scope);
        }
    }
}
