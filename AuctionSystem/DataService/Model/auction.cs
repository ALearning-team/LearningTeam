/**  版本信息模板在安装目录下，可自行修改。
* auction.cs
*
* 功 能： N/A
* 类 名： auction
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:51   N/A    初版
*
* Copyright (c) 2012 DataService Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace DataService.Model
{
	/// <summary>
	/// auction:实体类(属性说明自动提取数据库字段的描述信息)
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
		/// 
		/// </summary>
		public string AID
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PrivateLaw
		{
			set{ _privatelaw=value;}
			get{return _privatelaw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CourtName
		{
			set{ _courtname=value;}
			get{return _courtname;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime? ShowTime
		{
			set{ _showtime=value;}
			get{return _showtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Announcement
		{
			set{ _announcement=value;}
			get{return _announcement;}
		}
		#endregion Model

	}
}

