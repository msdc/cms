﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;
using System.Data;
namespace ISS.CMS.IDAL
{
    public interface IFrom
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
        int Add(From model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(From model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        From GetModel(int Id);
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
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);

        DataSet GetFrom();
        #endregion  成员方法
    }
}
