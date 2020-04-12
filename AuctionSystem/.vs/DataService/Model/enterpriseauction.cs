﻿/**  版本信息模板在安装目录下，可自行修改。
* enterpriseauction.cs
*
* 功 能： N/A
* 类 名： enterpriseauction
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2020/4/12 8:37:54   N/A    初版
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
	/// enterpriseauction:实体类(属性说明自动提取数据库字段的描述信息)
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
		public string AID
		{
			set{ _aid=value;}
			get{return _aid;}
		}
		#endregion Model

	}
}

