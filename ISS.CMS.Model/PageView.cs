using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ISS.CMS.Model
{
    public class PageView
    {
        private int pdatacount = 0;
        private int ppagecount = 0;
        private int ppageindex = 0;
        private DataTable dataContent;

        public PageView() { }

        public PageView(DataTable dataContent)
        {
            this.dataContent = dataContent;
        }

        public DataTable DataContent
        {
            set { this.dataContent = value; }
            get
            {
                return dataContent;
            }
        }
        public int DataCount
        {
            set { this.pdatacount = value; }
            get
            {
                return pdatacount;
            }
        }
        public int PageCount
        {
            set { this.ppagecount = value; }
            get
            {
                return ppagecount;
            }
        }
        public int PageIndex
        {
            set { this.ppageindex = value; }
            get
            {
                return ppageindex;
            }
        }
    }
}
