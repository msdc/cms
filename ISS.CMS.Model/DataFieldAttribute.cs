using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ISS.CMS.Model
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DataFiledAttribute : Attribute
    {
        private string name;
        private SqlDbType paramType;
        private int size;
        /// <summary>
        /// 
        /// </summary>
        public string FieldName
        {
            get { return this.name == null ? string.Empty : this.name; }
            set { this.name = value; }
        }

        public SqlDbType SqlDbType
        {
            get { return this.paramType; }
            set { this.paramType = value; }
        }
        
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public bool IsSizeDefined
        {
            get { return size != 0; }
        }

        public DataFiledAttribute(string strFieldName, SqlDbType sdtSqlDbType, int iSize)
        {
            this.name = strFieldName;
            this.paramType = sdtSqlDbType;
            this.size = iSize;
        }

        public DataFiledAttribute(string strFieldName, SqlDbType sdtSqlDbType) : this(strFieldName, sdtSqlDbType, 0) { }

    }
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class NoDataFiledAttribute : Attribute { }


}
