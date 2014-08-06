using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
using ISS.CMS.IDAL;
using ISS.CMS.ClassFactory;
using System.Data;


namespace ISS.CMS.BLL
{
    public class DynamicInsertBLL
    {
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static Model.DynamicInsert GetModel(int Id)
        {
            return DynamicInsertDaoFactory.Create().GetModel(Id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            return DynamicInsertDaoFactory.Create().GetList(strWhere);
        }

        /// <summary>
        /// 自定义条件获取数据
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="fieldOperator">字段运算符</param>
        /// <param name="whereOperator">where条件运算符</param>
        /// <returns></returns>
        public static System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return DynamicInsertDaoFactory.Create().GetList(fieldNames, fieldValues, fieldOperator, whereOperator, orderField, isAsc);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int Add(Model.DynamicInsert model)
        {
            if (model != null)
            {
                return DynamicInsertDaoFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(Model.DynamicInsert model)
        {
            if (model != null)
            {
                return DynamicInsertDaoFactory.Create().Update(model);
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
            return DynamicInsertDaoFactory.Create().Delete(Id);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DynamicInsertDaoFactory.Create().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
		/// 获取记录总数
		/// </summary>
        public static int GetRecordCount(string strWhere)
        {
            return DynamicInsertDaoFactory.Create().GetRecordCount(strWhere);
        }
        /// <summary>
		/// 获得前几行数据
		/// </summary>
        public static DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return DynamicInsertDaoFactory.Create().GetList(Top, strWhere, filedOrder);
        }

        public static DataSet GetDynamicInsertList()
        {
            return DynamicInsertDaoFactory.Create().GetDynamicInsertList();
        }
    }
}
