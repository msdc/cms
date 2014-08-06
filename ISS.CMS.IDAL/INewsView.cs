using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ISS.CMS.IDAL
{
    public interface INewsView
    {
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
        int Add(ISS.CMS.Model.NewsView model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(ISS.CMS.Model.NewsView model);
        bool Update(string[] fieldNames, string[] fieldValues, string strWhere);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        ISS.CMS.Model.NewsView GetModel(int Id);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        int UpdateNewsViewIsDelById(int id, bool isDel);

        int UpdateNewsViewIsDelInScope(string scopeStr);

        int DeleteInScope(string scopeStr);

        int ClearNewsView();

        DataSet GetNewsViewById(int Id);

        /// <summary>
        /// 根据创建修改时间获得数据列表
        /// </summary>
        DataSet GetNewsViewListByAddTimeOrUpTime(string strTmp, string isCheck, string time, string startTime, string endTime, string templateId);
        /// <summary>
        /// 根据栏目获得数据列表
        /// </summary>
        DataSet GetNewsViewListInTemplateId(string strTmp, string isCheck, string templateId, string ID);

        /// <summary>
        /// 新闻发布
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        int PublishNewsView(string speciality);

        /// <summary>
        /// 删除远程服务器数据
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        int DelRemoteNews(string speciality);
        #endregion  成员方法
    }
}
