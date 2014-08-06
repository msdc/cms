using System;
namespace ISS.CMS.Model
{
    /// <summary>
    /// From:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class From
    {
        public From()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _content;
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
        [DataFiled("Title", System.Data.SqlDbType.VarChar)]
        public string Title
        {
            set { _title = value; }
            get { return _title; }
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
        #endregion Model

    }
}


