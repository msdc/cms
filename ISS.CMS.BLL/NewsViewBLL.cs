using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.ClassFactory;
namespace ISS.CMS.BLL
{
    public class NewsViewBLL
    {
        /// <summary>
        /// 获取最大id
        /// </summary>
        /// <returns></returns>
        public static int GetMaxId()
        {
            return NewsViewFactory.Create().GetMaxId();
        }
        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="Id">实体的Id</param>
        /// <returns>返回ISS.CMS.Model.NewsView对像</returns>
        public static Model.NewsView GetModelById(int Id)
        {
            return NewsViewFactory.Create().GetModel(Id);
        }


        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>返回</returns>
        public static int Add(Model.NewsView model)
        {
            if (model != null)
            {
                return NewsViewFactory.Create().Add(model);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 根据实体ID更新实体
        /// </summary>
        /// <param name="model">要更新的实体</param>
        /// <returns>返回bool值</returns>
        public static bool Update(Model.NewsView model)
        {
            if (model != null)
            {
                return NewsViewFactory.Create().Update(model);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 物理删除一条数据
        /// </summary>
        /// <param name="Id">要删除数据的Id</param>
        /// <returns>返回bool值</returns>
        public static bool Delete(int Id)
        {
            return NewsViewFactory.Create().Delete(Id);
        }

        public bool EditNewsView(Model.NewsView model, bool addMode)
        {
            if (addMode)
            {
                return Add(model) > 0;
            }
            else
            {
                return Update(model);
            }
        }

        public int EditNewsViewGetId(Model.NewsView model, bool addMode)
        {
            if (addMode)
            {
                return Add(model);
            }
            else
            {
                Update(model);
                return 0;
            }
        }

        public int UpdateNewsViewIsDelById(int Id, bool isDel)
        {
            return NewsViewFactory.Create().UpdateNewsViewIsDelById(Id, isDel);
        }

        public int UpdateNewsViewIsDelInScope(string scopeStr)
        {
            return NewsViewFactory.Create().UpdateNewsViewIsDelInScope(scopeStr);
        }

        public int DeleteInScope(string scopeStr)
        {
            return NewsViewFactory.Create().DeleteInScope(scopeStr);
        }

        /// <summary>
        /// 物理删除指定的数据
        /// </summary>
        /// <param name="idList">删除数据的Id列表</param>
        /// <returns>返回bool值</returns>
        public static bool DeleteList(string idList)
        {
            if (string.IsNullOrEmpty(idList))
            {
                return false;
            }
            return NewsViewFactory.Create().DeleteList(idList);
        }
        /// <summary>
        /// 根据指定的条件，获取数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public static System.Data.DataSet GetList(string strWhere)
        {
            return NewsViewFactory.Create().GetList(strWhere);
        }

        public static System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return NewsViewFactory.Create().GetList(fieldNames, fieldValues, fieldOperator, whereOperator, orderField, isAsc);
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name="idList">id列表</param>
        /// <returns></returns>
        public static bool LogicalDeleteById(string idList)
        {
            return Update(new string[] { "isDel" }, new string[] { "1" }, "id in (" + idList + ")");
        }
        /// <summary>
        /// 还原逻辑删除的数据
        /// </summary>
        /// <param name="idList">id列表</param>
        /// <returns></returns>
        public static bool RestoreById(string idList)
        {
            return Update(new string[] { "isDel" }, new string[] { "0" }, "id in (" + idList + ")");
        }
        /// <summary>
        /// 更改审核状态
        /// </summary>
        /// <param name="idList"></param>
        /// <param name="isCheck"></param>
        /// <returns></returns>
        public static bool PassCheckedById(string idList, bool isCheck)
        {
            string isC = "0";
            if (isCheck)
            {
                isC = "1";
            }
            return Update(new string[] { "IsCheck" }, new string[] { isC }, "id in (" + idList + ")");
        }
        /// <summary>
        /// 更新指定的字段
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="strWhere">更新条件</param>
        /// <returns></returns>
        public static bool Update(string[] fieldNames, string[] fieldValues, string strWhere)
        {
            return NewsViewFactory.Create().Update(fieldNames, fieldValues, strWhere);
        }
        /// <summary>
        ///  根据id列表获取数据
        /// </summary>
        /// <param name="id">id列表，例 1，2，3</param>
        /// <returns></returns>
        public static System.Data.DataSet GetListById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            //string strWhere = "[IsDel] =" + (isDel ? "1" : "0") + " and [template] in (" + templateid + ")";
            return GetListByCustomQuery(new string[] { "id" }, new string[] { id }, new string[] { "in" }, new string[] { }, "id", true);
        }
        /// <summary>
        ///  根据Templateid列表获取数据
        /// </summary>
        /// <param name="templateid">templateid列表，例 1，2，3</param>
        /// <param name="isDel">数据的状态，1：为逻辑删除，0：正常数据</param>
        /// <param name="orderField">排序的字段名</param>
        /// <param name="isAsc">是否按升序</param>
        /// <returns></returns>
        public static System.Data.DataSet GetListByTemplateId(string templateid, bool isDel, string orderField, bool isAsc)
        {

            if (string.IsNullOrEmpty(templateid))
            {
                return null;
            }
            //string strWhere = "[IsDel] =" + (isDel ? "1" : "0") + " and [templateid] in (" + templateid + ")";
            return GetListByCustomQuery(new string[] { "IsDel", "templateid" }, new string[] { isDel ? "1" : "0", templateid }, new string[] { "=", "in" }, new string[] { "and" }, orderField, isAsc);

        }
        /// <summary>
        /// 根据templateid列表和资源类型获取数据
        /// </summary>
        /// <param name="templateid">templateid列表，例 1，2，3</param>
        /// <param name="typeFieldName"></param>
        /// <param name="typeFieldValue"></param>
        /// <param name="isDel">数据的状态，1：为逻辑删除，0：正常数据</param>
        /// <param name="orderField">排序的字段名</param>
        /// <param name="isAsc">是否按升序</param>
        /// <returns></returns>
        public static System.Data.DataSet GetListByTemplateIdAndType(string templateid, string typeFieldName, string typeFieldValue, bool isDel, string orderField, bool isAsc)
        {
            return GetListByCustomQuery(new string[] { "IsDel", "templateid", typeFieldName }, new string[] { isDel ? "1" : "0", templateid, typeFieldValue }, new string[] { "=", "in", "like" }, new string[] { "and", "and" }, orderField, isAsc);
        }
        /// <summary>
        /// 自定义查询条件获取数据
        /// </summary>
        /// <param name="fieldNames">字段名列表</param>
        /// <param name="fieldValues">字段值列表</param>
        /// <param name="sqlOperator">sql逻辑运算符(<,>,=,!=,>=,<=,in,like) </param>
        /// <param name="whereOperator"></param>
        /// <param name="orderField"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public static System.Data.DataSet GetListByCustomQuery(string[] fieldNames, string[] fieldValues, string[] sqlOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return NewsViewFactory.Create().GetList(fieldNames, fieldValues, sqlOperator, whereOperator, orderField, isAsc);
        }
        /// <summary>
        /// 根据指定的范围获取数据
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <param name="orderby">排序字段</param>
        /// <param name="startIndex">数据库中数据的开始位置</param>
        /// <param name="endIndex">数据库中数据的结束位置</param>
        /// <returns></returns>
        public static System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return NewsViewFactory.Create().GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 根据指定条件获取数据的数量
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public static int GetRecordCount(string strWhere)
        {
            return NewsViewFactory.Create().GetRecordCount(strWhere);
        }
        /// <summary>
        /// 根据id判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Exists(string id)
        {
            return NewsViewFactory.Create().Exists(Int32.Parse(id));
        }

        public int ClearNewsView()
        {
            return NewsViewFactory.Create().ClearNewsView();
        }

        public System.Data.DataSet GetNewsViewById(int id)
        {
            return NewsViewFactory.Create().GetNewsViewById(id);
        }

        public int DeleteNewsView(bool completelyDel, int Id)
        {
            if (completelyDel)
            {
                return Delete(Id) ? 1 : 0;
            }
            else
            {
                return UpdateNewsViewIsDelById(Id, true);
            }
        }

        public static System.Data.DataSet GetNewsViewListByAddTimeOrUpTime(string strTmp, string isCheck, string time, string startTime, string endTime, string templateId)
        {
            return NewsViewFactory.Create().GetNewsViewListByAddTimeOrUpTime(strTmp, isCheck, time, startTime, endTime, templateId);
        }

        public static System.Data.DataSet GetNewsViewListInTemplateId(string strTmp, string isCheck, string templateID, string ID)
        {
            return NewsViewFactory.Create().GetNewsViewListInTemplateId(strTmp, isCheck, templateID, ID);
        }

        /// <summary>
        /// 新闻发布
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public static int PublishNewsView(string speciality)
        {
            return NewsViewFactory.Create().PublishNewsView(speciality);
        }

         /// <summary>
        /// 删除远程服务器数据
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public static int DelRemoteNews(string speciality)
        {
            return NewsViewFactory.Create().DelRemoteNews(speciality);
        }
    }

}
