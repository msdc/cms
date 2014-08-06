using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public partial class StaticInsertProxy : IStaticInsertDao
    {
        private IStaticInsertDao staticInsert;
        public StaticInsertProxy()
        {
            staticInsert = new StaticInsertImpl();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ISS.CMS.Model.StaticInsert model)
        {
            return staticInsert.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ISS.CMS.Model.StaticInsert model)
        {
            return staticInsert.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return staticInsert.Delete(id);
        }

        public DataSet GetStaticInsert(int Id)
        {
            return staticInsert.GetStaticInsert(Id);
        }

        public DataSet GetStaticInsertList()
        {
            return staticInsert.GetStaticInsertList();
        }

        public DataSet GetStaticInsertInScope(string scope)
        {
            return staticInsert.GetStaticInsertInScope(scope);
        }
    }
}
