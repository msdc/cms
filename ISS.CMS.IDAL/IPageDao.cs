using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.CMS.Model;

namespace ISS.CMS.IDAL
{
    public interface IPageDao
    {
        PageView GetPageView(string tablename_p, string column_p, string primarykey_p, int pagesize_p, int pageindex_p, string where_p, string order_p);
    }
}
