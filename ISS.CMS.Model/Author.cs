using System;
using System.Data;
namespace ISS.CMS.Model
{
    [Serializable]
    public partial class Author
    {
        public Author()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _content;
        private string _email;
        private string _sex;
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Id", SqlDbType.Int)]
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Title", SqlDbType.VarChar)]
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Content", SqlDbType.VarChar)]
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Email", SqlDbType.VarChar)]
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Sex", SqlDbType.VarChar)]
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        #endregion Model

    }
}

