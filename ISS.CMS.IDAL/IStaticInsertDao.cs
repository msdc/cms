using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.IDAL
{
    /// <summary>
    /// 接口层StaticInsert
    /// </summary>
    public interface IStaticInsertDao
    {
        #region  成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(ISS.CMS.Model.StaticInsert model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(ISS.CMS.Model.StaticInsert model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Id);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        DataSet GetStaticInsert(int Id);

        DataSet GetStaticInsertInScope(string scope);

        DataSet GetStaticInsertList();
        
        #endregion  成员方法
    } 
}
