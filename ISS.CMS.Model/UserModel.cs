using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISS.CMS.Model
{
    public class UserModel
    {
        //private int id;
        //public int ID
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //private String userName;
        //public String UserName
        //{
        //    get { return userName; }
        //    set { userName = value; }
        //}

        //private String password;
        //public String Password
        //{
        //    get { return password; }
        //    set { password = value; }
        //}
        public UserModel()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _nickname;
        private string _password;
        private int _roleid;
        private bool _islock = false;
        private DateTime _logtime = DateTime.Now;
        private DateTime _lastlogtime = DateTime.Now;
        private int _logcount = 1;
        private DateTime _addtime = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("id", System.Data.SqlDbType.Int)]
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Name", System.Data.SqlDbType.VarChar)]
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("NickName", System.Data.SqlDbType.VarChar)]
        public string NickName
        {
            set { _nickname = value; }
            get { return _nickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("Password", System.Data.SqlDbType.VarChar)]
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("RoleID", System.Data.SqlDbType.Int)]
        public int RoleID
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("IsLock", System.Data.SqlDbType.Bit)]
        public bool IsLock
        {
            set { _islock = value; }
            get { return _islock; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("LogTime", System.Data.SqlDbType.DateTime)]
        public DateTime LogTime
        {
            set { _logtime = value; }
            get { return _logtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("LastLogTime", System.Data.SqlDbType.DateTime)]
        public DateTime LastLogTime
        {
            set { _lastlogtime = value; }
            get { return _lastlogtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("LogCount", System.Data.SqlDbType.Int)]
        public int LogCount
        {
            set { _logcount = value; }
            get { return _logcount; }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataFiled("AddTime", System.Data.SqlDbType.DateTime)]
        public DateTime AddTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model
    }


}
