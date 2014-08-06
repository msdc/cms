using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.Model
{
    /// <summary>
    /// StaticInsert:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StaticInsert
    {
        public StaticInsert()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _content;
        private string _filelist;
        private string _encoding;
        private string _startelement;
        private string _endelement;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileList
        {
            set { _filelist = value; }
            get { return _filelist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Encoding
        {
            set { _encoding = value; }
            get { return _encoding; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StartElement
        {
            set { _startelement = value; }
            get { return _startelement; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EndElement
        {
            set { _endelement = value; }
            get { return _endelement; }
        }
        #endregion Model

    }
}
