using System;
using System.Data;

namespace ISS.CMS.IDAL
{
    /// <summary>
    /// 接口层DynamicInsert
    /// </summary>
    public interface IDynamicInsertDao
    {
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(ISS.CMS.Model.DynamicInsert model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(ISS.CMS.Model.DynamicInsert model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int id);
        bool DeleteList(string idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        ISS.CMS.Model.DynamicInsert GetModel(int id);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 自定义条件获取数据
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="fieldOperator">字段运算符</param>
        /// <param name="whereOperator">where条件运算符</param>
        /// <returns></returns>
        System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc);
   
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);

        DataSet GetDynamicInsertList();
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
    }
}
