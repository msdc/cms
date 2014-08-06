using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.IDAL
{
    public interface IClassDao
    {
        DataSet GetClassById(string id);

        string GetClassMapById(string id);

        DataSet GetClassId();

        DataSet GetClass();

        DataSet GetClassInScope(string scopeStr);

        DataSet GetClassByParent(string parent);

        DataSet GetClassByParentAndIdInClassId(string parent, string classId, string sqlOrder);

        int GetClassCount();

        int DeleteClass(string id);

        int UpdateClass(string parent, string title, string title2, string directory, string template, string orderid, string map, string id, bool updateParent);

        int AddClass(string title, string title2, string directory, string template, string parent, string orderid, string map);

        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int Id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(ISS.CMS.Model.ClassModel model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(ISS.CMS.Model.ClassModel model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        ISS.CMS.Model.ClassModel GetModel(int Id);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] sqlOperator, string[] whereOperator,string orderField, bool isAsc);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法


    }
}
