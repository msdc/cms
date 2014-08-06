using ISS.CMS.IDAL;
using ISS.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class PageDaoProxy : IPageDao
    {
        private IPageDao dao;

        public PageDaoProxy()
        {
            this.dao = new PageDaoImpl();
        }

        public PageView GetPageView(string tablename_p, string column_p, string primarykey_p, int pagesize_p, int pageindex_p, string where_p, string order_p)
        {
            return this.dao.GetPageView(tablename_p, column_p, primarykey_p, pagesize_p, pageindex_p, where_p, order_p);
        }
    }
}
