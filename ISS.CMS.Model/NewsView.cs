using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.Model
{
    [Serializable]
    public partial class NewsView
    {
        public NewsView()
        { }
        #region Model
        private int _id;
        private int _templateid;
        private string _template; //模版名称
        private string _title;
        private string _titletab;
        private string _url;
        private string _content;
        private string _author;
        private string _from;
        private int _count = 0;
        private string _keyword;
        private string _editor;
        private bool _iscreate = false;
        private string _smallimg;
        private string _bigimg;
        private string _shortcontent;
        private string _speciality;
        private bool _ischeck = false;
        private bool _isdel = false;
        private bool _iscommend = false;
        private int _pagecount = 1;
        private string _filepath;
        private DateTime? _addtime;// = DateTime.Now;
        private DateTime? _uptime = DateTime.Now;
        private string _field1;
        private string _field2;
        private string _field3;
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("id", System.Data.SqlDbType.Int)]
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("TemplateId", System.Data.SqlDbType.Int)]
        public int TemplateId
        {
            set { _templateid = value; }
            get { return _templateid; }
        }
        /// <summary>
        /// 模版名称
        /// </summary>
        [DataFiled("Template", System.Data.SqlDbType.VarChar)]
        public string Template
        {
            set { _template = value; }
            get { return _template; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Title", System.Data.SqlDbType.VarChar)]
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("TitleTab", System.Data.SqlDbType.VarChar)]
        public string TitleTab
        {
            set { _titletab = value; }
            get { return _titletab; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Url", System.Data.SqlDbType.VarChar)]
        public string Url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Content", System.Data.SqlDbType.VarChar)]
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Author", System.Data.SqlDbType.VarChar)]
        public string Author
        {
            set { _author = value; }
            get { return _author; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("From", System.Data.SqlDbType.VarChar)]
        public string From
        {
            set { _from = value; }
            get { return _from; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Count", System.Data.SqlDbType.VarChar)]
        public int Count
        {
            set { _count = value; }
            get { return _count; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("KeyWord", System.Data.SqlDbType.VarChar)]
        public string KeyWord
        {
            set { _keyword = value; }
            get { return _keyword; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Editor", System.Data.SqlDbType.VarChar)]
        public string Editor
        {
            set { _editor = value; }
            get { return _editor; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("IsCreate", System.Data.SqlDbType.VarChar)]
        public bool IsCreate
        {
            set { _iscreate = value; }
            get { return _iscreate; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("SmallImg", System.Data.SqlDbType.VarChar)]
        public string SmallImg
        {
            set { _smallimg = value; }
            get { return _smallimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("BigImg", System.Data.SqlDbType.VarChar)]
        public string BigImg
        {
            set { _bigimg = value; }
            get { return _bigimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("ShortContent", System.Data.SqlDbType.VarChar)]
        public string ShortContent
        {
            set { _shortcontent = value; }
            get { return _shortcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Speciality", System.Data.SqlDbType.VarChar)]
        public string Speciality
        {
            set { _speciality = value; }
            get { return _speciality; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("IsCheck", System.Data.SqlDbType.Bit)]
        public bool IsCheck
        {
            set { _ischeck = value; }
            get { return _ischeck; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("IsDel", System.Data.SqlDbType.Bit)]
        public bool IsDel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("IsCommend", System.Data.SqlDbType.Bit)]
        public bool IsCommend
        {
            set { _iscommend = value; }
            get { return _iscommend; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("PageCount", System.Data.SqlDbType.Int)]
        public int PageCount
        {
            set { _pagecount = value; }
            get { return _pagecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("FilePath", System.Data.SqlDbType.VarChar)]
        public string FilePath
        {
            set { _filepath = value; }
            get { return _filepath; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("AddTime", System.Data.SqlDbType.DateTime)]
        public DateTime? AddTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("UpTime", System.Data.SqlDbType.DateTime)]
        public DateTime? UpTime
        {
            set { _uptime = value; }
            get { return _uptime; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Field1", System.Data.SqlDbType.VarChar)]
        public string Field1
        {
            set { _field1 = value; }
            get { return _field1; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Field2", System.Data.SqlDbType.VarChar)]
        public string Field2
        {
            set { _field2 = value; }
            get { return _field2; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Field3", System.Data.SqlDbType.VarChar)]
        public string Field3
        {
            set { _field3 = value; }
            get { return _field3; }
        }
        #endregion Model

    }
}
