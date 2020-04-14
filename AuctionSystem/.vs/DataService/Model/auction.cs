
using System;
namespace DataService.Model
{
	/// <summary>
	/// auction:拍卖实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class auction
	{
		public auction()
		{}
		#region Model
		private string _aid;
		private string _name;
		private string _type;
		private DateTime? _time;
		private string _address;
		private bool _privatelaw;
		private string _courtname;
		private DateTime? _showtime;
		private string _announcement;
		/// <summary>
		/// 拍卖表ID
		/// </summary>
		public string AID
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 拍卖会名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 拍卖类型
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 拍卖时间
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 是否司法拍卖
		/// </summary>
		public bool PrivateLaw
		{
			set{ _privatelaw=value;}
			get{return _privatelaw;}
		}
		/// <summary>
		/// 如果是司法拍卖，委托的法院名称
		/// </summary>
		public string CourtName
		{
			set{ _courtname=value;}
			get{return _courtname;}
		}
		/// <summary>
		/// 展示时间
		/// </summary>
		public DateTime? ShowTime
		{
			set{ _showtime=value;}
			get{return _showtime;}
		}
		/// <summary>
		/// 拍卖会公告正文
		/// </summary>
		public string Announcement
		{
			set{ _announcement=value;}
			get{return _announcement;}
		}
		#endregion Model

	}
}

