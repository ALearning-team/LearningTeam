
using System;
namespace DataService.Model
{
	/// <summary>
	/// enterpriseauction:企业拍卖关联实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class enterpriseauction
	{
		public enterpriseauction()
		{}
		#region Model
		private string _eid;
		private string _aid;
		/// <summary>
		/// 企业ID
		/// </summary>
		public string EID
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 拍卖会ID
		/// </summary>
		public string AID
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		#endregion Model

	}
}

