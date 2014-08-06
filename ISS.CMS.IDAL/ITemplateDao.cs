using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.IDAL
{
    public interface ITemplateDao
    {
        DataSet GetTemplateById(string id);

        DataSet GetTemplateId();

        DataSet GetTemplate();

        int DeleteTemplate(string id);

        int UpdateTemplate(string title, string content, string id);

        int AddTemplate(string title, string content);

        DataSet GetTemplateOrderById();

        DataSet GetTemplateInScope(string scopeStr);
    }
}
