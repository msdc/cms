using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.IDAL;
using ISS.CMS.Model;
namespace ISS.CMS.DAL
{
    public class NewsViewDaoProxy : INewsView
    {
        private INewsView newsView;
        public NewsViewDaoProxy()
        {
            newsView = new NewsViewDaoImpl();
        }
        public int GetMaxId()
        {
            return newsView.GetMaxId();
        }

        public bool Exists(int Id)
        {
            return newsView.Exists(Id);
        }

        public int Add(NewsView model)
        {
            return newsView.Add(model);
        }

        public bool Update(NewsView model)
        {
            return newsView.Update(model);
        }

        public int UpdateNewsViewIsDelById(int Id, bool isDel)
        {
            return newsView.UpdateNewsViewIsDelById(Id, isDel);
        }

        public int UpdateNewsViewIsDelInScope(string scopeStr)
        {
            return newsView.UpdateNewsViewIsDelInScope(scopeStr);
        }

        public int DeleteInScope(string scopeStr)
        {
            return newsView.DeleteInScope(scopeStr);
        }

        public bool Delete(int Id)
        {
            return newsView.Delete(Id);
        }

        public int ClearNewsView()
        {
            return newsView.ClearNewsView();
        }

        public bool DeleteList(string Idlist)
        {
            return newsView.DeleteList(Idlist);
        }

        public NewsView GetModel(int Id)
        {
            return newsView.GetModel(Id);
        }

        public System.Data.DataSet GetList(string strWhere)
        {
            return newsView.GetList(strWhere);
        }

        public System.Data.DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            throw new NotImplementedException();
        }

        public int GetRecordCount(string strWhere)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }
        public bool Update(string[] fieldNames, string[] fieldValues, string strWhere)
        {
            return newsView.Update(fieldNames, fieldValues, strWhere);
        }


        public System.Data.DataSet GetList(string[] fieldNames, string[] fieldValues, string[] fieldOperator, string[] whereOperator, string orderField, bool isAsc)
        {
            return newsView.GetList(fieldNames, fieldValues, fieldOperator, whereOperator, orderField, isAsc);
        }

        public System.Data.DataSet GetNewsViewById(int Id)
        {
            return this.newsView.GetNewsViewById(Id);
        }

        public System.Data.DataSet GetNewsViewListByAddTimeOrUpTime(string strTmp, string isCheck, string time, string startTime, string endTime, string templateId)
         {
             return this.newsView.GetNewsViewListByAddTimeOrUpTime(strTmp, isCheck, time, startTime, endTime, templateId);
         }

        public System.Data.DataSet GetNewsViewListInTemplateId(string strTmp, string isCheck, string templateID, string ID)
        {
            return this.newsView.GetNewsViewListInTemplateId(strTmp, isCheck, templateID, ID);
        }

        /// <summary>
        /// 新闻发布
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public int PublishNewsView(string speciality)
        {
            return this.newsView.PublishNewsView(speciality);
        }

         /// <summary>
        /// 删除远程服务器数据
        /// </summary>
        /// <param name="speciality">标识GUID</param>
        /// <returns>结果</returns>
        public int DelRemoteNews(string speciality)
        {
            return this.newsView.DelRemoteNews(speciality);
        }
    }
}

