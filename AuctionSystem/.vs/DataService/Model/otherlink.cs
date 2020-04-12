/**  版本信息模板在安装目录下，可自行修改。
* otherlink.cs
*
* 功 能： N/A
* 类 名： otherlink
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:58   N/A    初版
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
	/// otherlink:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class otherlink
	{
		public otherlink()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _url;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		#endregion Model

	}
}

