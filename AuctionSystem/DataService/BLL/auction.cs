﻿/**  版本信息模板在安装目录下，可自行修改。
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
using System.Data;
using System.Collections.Generic;

using DataService.Model;
namespace DataService.BLL
{
	/// <summary>
	/// auction
	/// </summary>
	public partial class auction
	{
		private readonly DataService.DAL.auction dal=new DataService.DAL.auction();
		public auction()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string AID)
		{
			return dal.Exists(AID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(DataService.Model.auction model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(DataService.Model.auction model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string AID)
		{
			
			return dal.Delete(AID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AIDlist )
		{
			return dal.DeleteList(AIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataService.Model.auction GetModel(string AID)
		{
			
			return dal.GetModel(AID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		//public DataService.Model.auction GetModelByCache(string AID)
		//{
			
		//	string CacheKey = "auctionModel-" + AID;
		//	object objModel = DataService.Common.DataCache.GetCache(CacheKey);
		//	if (objModel == null)
		//	{
		//		try
		//		{
		//			objModel = dal.GetModel(AID);
		//			if (objModel != null)
		//			{
		//				int ModelCache = DataService.Common.ConfigHelper.GetConfigInt("ModelCache");
		//				DataService.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
		//			}
		//		}
		//		catch{}
		//	}
		//	return (DataService.Model.auction)objModel;
		//}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataService.Model.auction> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DataService.Model.auction> DataTableToList(DataTable dt)
		{
			List<DataService.Model.auction> modelList = new List<DataService.Model.auction>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DataService.Model.auction model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

