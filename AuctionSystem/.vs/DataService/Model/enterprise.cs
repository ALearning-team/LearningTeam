
using System;
namespace DataService.Model
{
	/// <summary>
	/// enterprise:企业实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class enterprise
	{
		public enterprise()
		{}
		#region Model
		private string _eid;
		private string _username;
		private string _ename;
		private string _creditcode;
		private string _logo;
		private string _phone;
		private string _address;
		private string _abstract;
		/// <summary>
		/// 企业ID
		/// </summary>
		public string EID
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 企业名称
		/// </summary>
		public string EName
		{
			set{ _ename=value;}
			get{return _ename;}
		}
		/// <summary>
		/// 统一社会信用代码
		/// </summary>
		public string CreditCode
		{
			set{ _creditcode=value;}
			get{return _creditcode;}
		}
		/// <summary>
		/// Logo图片地址
		/// </summary>
		public string Logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		/// 企业简介
		/// </summary>
		public string Abstract
		{
			set{ _abstract=value;}
			get{return _abstract;}
		}
		#endregion Model

	}
}

