using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.Model
{
    /// <summary>
    /// tsys_Speciality:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Speciality
    {
        public Speciality()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _explain;
        private int? _parent;
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
        [DataFiled("Explain", System.Data.SqlDbType.VarChar)]
        public string Explain
        {
            set { _explain = value; }
            get { return _explain; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Parent", System.Data.SqlDbType.Int)]
        public int? Parent
        {
            set { _parent = value; }
            get { return _parent; }
        }
        #endregion Model

    }
}
