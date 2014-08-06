using ISS.CMS.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ISS.CMS.DAL
{
    public class TemplateDaoProxy : ITemplateDao
    {
        private ITemplateDao dao;

        public TemplateDaoProxy()
        {
            this.dao = new TemplateDaoImpl();
        }

        public DataSet GetTemplateById(string id)
        {
            return this.dao.GetTemplateById(id);
        }

        public DataSet GetTemplateOrderById()
        {
            return this.dao.GetTemplateOrderById();
        }

        public DataSet GetTemplateId()
        {
            return this.dao.GetTemplateId();
        }

        public DataSet GetTemplate()
        {
            return this.dao.GetTemplate();
        }

        public int DeleteTemplate(string id)
        {
            return this.dao.DeleteTemplate(id);
        }

        public int UpdateTemplate(string title, string content, string id)
        {
            return this.dao.UpdateTemplate(title, content, id);
        }

        public int AddTemplate(string title, string content)
        {
            return this.dao.AddTemplate(title, content);
        }

        public DataSet GetTemplateInScope(string scopeStr)
        {
            return this.dao.GetTemplateInScope(scopeStr);
        }
    }
}
