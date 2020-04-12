/**  版本信息模板在安装目录下，可自行修改。
* enterprise.cs
*
* 功 能： N/A
* 类 名： enterprise
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:53   N/A    初版
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
	/// enterprise:实体类(属性说明自动提取数据库字段的描述信息)
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
		/// 
		/// </summary>
		public string EID
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EName
		{
			set{ _ename=value;}
			get{return _ename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreditCode
		{
			set{ _creditcode=value;}
			get{return _creditcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
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
		public string Abstract
		{
			set{ _abstract=value;}
			get{return _abstract;}
		}
		#endregion Model

	}
}

