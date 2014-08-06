using System;
using System.Data;
namespace ISS.CMS.Model
{
	/// <summary>
	/// tsys_DynamicInsert:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DynamicInsert
	{
		public DynamicInsert()
		{}
		#region Model
		private int _id;
        private string _title = "";
		private int? _length=0;
		private int? _shortcontentlen=0;
		private string _titleout="";
        private string _titleouttype = "";
        private string _startelement = "";
        private string _endelement = "";
        private string _content = "";
        private string _pagecontent = "";
		private int? _pagenumber=0;
        private string _bytime = "";
        private string _bysort = "";
		private bool _iscommend= false;
		private int? _looptime=0;
		private bool _ispage=false;
        private string _class = "";
        private string _speciality = "";
        private string _encoding = "";
        private string _filelist = "";
		private bool _needupdate= false;
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("Id", SqlDbType.Int)]
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 标题
		/// </summary>
        [DataFiled("title", SqlDbType.VarChar)]
        public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
        /// 标题截取长度
		/// </summary>
        [DataFiled("Length", SqlDbType.Int)]
        public int? Length
		{
			set{ _length=value;}
			get{return _length;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("ShortContentLen", SqlDbType.Int)]
        public int? ShortContentLen
		{
			set{ _shortcontentlen=value;}
			get{return _shortcontentlen;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("TitleOut", SqlDbType.VarChar)]
        public string TitleOut
		{
			set{ _titleout=value;}
			get{return _titleout;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("TitleOutType", SqlDbType.VarChar)]
        public string TitleOutType
		{
			set{ _titleouttype=value;}
			get{return _titleouttype;}
		}
		/// <summary>
        /// 起始标签
		/// </summary>
        [DataFiled("startelement", SqlDbType.VarChar)]
        public string startelement
		{
			set{ _startelement=value;}
			get{return _startelement;}
		}
		/// <summary>
        /// 结束标签
		/// </summary>
        [DataFiled("endelement", SqlDbType.VarChar)]
        public string endelement
		{
			set{ _endelement=value;}
			get{return _endelement;}
		}
		/// <summary>
		/// 内容
		/// </summary>
        [DataFiled("content", SqlDbType.VarChar)]
        public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
        /// 分页模版
		/// </summary>
        [DataFiled("pagecontent", SqlDbType.VarChar)]
        public string pagecontent
		{
			set{ _pagecontent=value;}
			get{return _pagecontent;}
		}
		/// <summary>
        /// 页码数量
		/// </summary>
        [DataFiled("PageNumber", SqlDbType.Int)]
        public int? PageNumber
		{
			set{ _pagenumber=value;}
			get{return _pagenumber;}
		}
		/// <summary>
        /// 时间
		/// </summary>
        [DataFiled("bytime", SqlDbType.VarChar)]
        public string bytime
		{
			set{ _bytime=value;}
			get{return _bytime;}
		}
		/// <summary>
        /// 排序方式
		/// </summary>
        [DataFiled("bysort", SqlDbType.VarChar)]
        public string bysort
		{
			set{ _bysort=value;}
			get{return _bysort;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("isCommend", SqlDbType.VarChar)]
        public bool isCommend
		{
			set{ _iscommend=value;}
			get{return _iscommend;}
		}
		/// <summary>
        /// 循环次数
		/// </summary>
        [DataFiled("looptime", SqlDbType.Int)]
        public int? looptime
		{
			set{ _looptime=value;}
			get{return _looptime;}
		}
		/// <summary>
        /// 是否分页
		/// </summary>
        [DataFiled("ispage", SqlDbType.VarChar)]
        public bool ispage
		{
			set{ _ispage=value;}
			get{return _ispage;}
		}
		/// <summary>
        /// 资源类别
		/// </summary>
        [DataFiled("classw", SqlDbType.VarChar)]
        public string classw
		{
			set{ _class=value;}
			get{return _class;}
		}
		/// <summary>
        /// 资源特性
		/// </summary>
        [DataFiled("speciality", SqlDbType.VarChar)]
        public string speciality
		{
			set{ _speciality=value;}
			get{return _speciality;}
		}
		/// <summary>
        /// 编码格式
		/// </summary>
        [DataFiled("Encoding", SqlDbType.VarChar)]
        public string Encoding
		{
			set{ _encoding=value;}
			get{return _encoding;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("filelist", SqlDbType.VarChar)]
        public string filelist
		{
			set{ _filelist=value;}
			get{return _filelist;}
		}
		/// <summary>
		/// 
		/// </summary>
        [DataFiled("NeedUpDate", SqlDbType.VarChar)]
        public bool NeedUpDate
		{
			set{ _needupdate=value;}
			get{return _needupdate;}
		}
		#endregion Model

	}
}

