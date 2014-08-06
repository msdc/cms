using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
using System.Data;

namespace ISS.CMS.DAL
{

    public partial class DynamicInsertProxy : IDynamicInsertDao
    {
        private IDynamicInsertDao dynamicInsert;
        public DynamicInsertProxy()
        {
            dynamicInsert = new DynamicInsertImpl();
        }

        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dynamicInsert.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dynamicInsert.Exists(id);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ISS.CMS.Model.DynamicInsert model)
        {
            return dynamicInsert.Add(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ISS.CMS.Model.DynamicInsert model)
        {
            return dynamicInsert.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return dynamicInsert.Delete(id);           
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dynamicInsert.DeleteList(idlist);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ISS.CMS.Model.DynamicInsert GetModel(int id)
        {
            return dynamicInsert.GetModel(id);
            
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dynamicInsert.GetList(strWhere);
        }

        /// <summary>
        /// 自定义条件获取数据
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="fieldOperator">字段运算符</param>
        /// <param name="whereOperator">where条件运算符</param>
        /// <returns></returns>
        public System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return dynamicInsert.GetList(fieldNames, fieldValues, fieldOperator, whereOperator, orderField, isAsc);
        }
   
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dynamicInsert.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dynamicInsert.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dynamicInsert.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        public DataSet GetDynamicInsertList()
        {
            return dynamicInsert.GetDynamicInsertList();
        }
      
        #endregion  Method
    }
       
}
