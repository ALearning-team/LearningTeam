
using System;
namespace DataService.Model
{
	/// <summary>
	/// business:商务部门实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class business
	{
		public business()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _abstract;
		private string _permissions;
		/// <summary>
		/// 部门ID
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		/// 单位简介
		/// </summary>
		public string Abstract
		{
			set{ _abstract=value;}
			get{return _abstract;}
		}
		/// <summary>
		/// 权限
		/// </summary>
		public string Permissions
		{
			set{ _permissions=value;}
			get{return _permissions;}
		}
		#endregion Model

	}
}

