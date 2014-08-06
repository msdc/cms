using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ISS.CMS.Model
{
    /// <summary>
    /// ClassModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ClassModel
    {
        public ClassModel()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _title2;
        private int? _parent;
        private int? _orderid;
        private int? _template;
        private string _directory;
        private string _map;
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
        [DataFiled("Title2", SqlDbType.VarChar)]
        public string Title2
        {
            set { _title2 = value; }
            get { return _title2; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Parent", SqlDbType.Int)]
        public int? Parent
        {
            set { _parent = value; }
            get { return _parent; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("OrderID", SqlDbType.Int)]
        public int? OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Template", SqlDbType.Int)]
        public int? Template
        {
            set { _template = value; }
            get { return _template; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Directory", SqlDbType.VarChar)]
        public string Directory
        {
            set { _directory = value; }
            get { return _directory; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Map", SqlDbType.VarChar)]
        public string Map
        {
            set { _map = value; }
            get { return _map; }
        }
        #endregion Model

    }
}
